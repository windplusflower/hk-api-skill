# Rogue System Patterns

## 概述

本文档整理了从 Rogue Mod（90 个 C# 文件）中提取的通用系统模式。Rogue 是一个大型 Roguelike Mod，包含完整的物品系统、Boss 战管理、敌人波次等系统。

---

## 1. 商店 FSM 修改模式

### 应用场景

需要自定义商店界面，修改现有商店（如 Iselda 商店）而非从头创建。

### 核心代码

```csharp
// 1. 预加载商店对象
internal const string shop_scene = "Room_shop";
internal const string shop_menu = "Shop Menu";
internal const string shop_region = "Basement Closed/Shop Region";

internal static GameObject menu_go;
internal static GameObject shop_go;

internal static void Init()
{
    menu_go = PreloadManager.getGO(shop_scene, shop_menu);
    shop_go = PreloadManager.getGO(shop_scene, shop_region);
    shop_go.SetActive(false);
    Rogue.Instance.rogue_go.AddComponent<ItemManager>();
}

// 2. 修改商店菜单 FSM
static void AdjustMenuGO(GameObject menu_go)
{
    // 修改 FSM 过渡
    menu_go.LocateMyFSM("shop_control")
        .ChangeTransition("Stock?", "FINISHED", "Open Window");
    
    // 修改 FSM 变量
    menu_go.LocateMyFSM("shop_control")
        .FsmVariables.FindFsmString("No Stock Event").Value = "ISELDA";
    
    // 修改 FSM 动作参数
    menu_go.LocateMyFSM("shop_control")
        .GetAction<SetFsmString>("Iselda", 4).setValue = "rouge_introduction";
    
    // 修改文本显示
    var fsm = menu_go.FindGameObjectInChildren("Item List")
        .LocateMyFSM("Item List Control");
    fsm.GetAction<SetTextMeshProText>("Get Details", 3)
        .textString = fsm.FsmVariables.GetFsmString("Item Name Convo");
    
    // 插入自定义动作
    var confirmFsm = menu_go.FindGameObjectInChildren("Confirm")
        .FindGameObjectInChildren("UI List")
        .LocateMyFSM("Confirm Control");
    
    if (confirmFsm.GetState("Special Type?").Actions.Length < 3)
    {
        confirmFsm.InsertCustomAction("Special Type?", (fsm) =>
        {
            Giftname type = (Giftname)(fsm.FsmVariables.GetFsmInt("Special Type").Value - 18);
            if (GiftFactory.all_gifts.ContainsKey(type))
            {
                GiftFactory.all_gifts[type].GetGift();
                GameInfo.got_items.Add(type);
            }
        }, 1);
    }
}

// 3. 修改商店区域 FSM
static void AdjustShopGo(GameObject shop_go)
{
    shop_go.LocateMyFSM("Shop Region")
        .ChangeTransition("Intro Convo?", "YES", "Shop Up");
    
    // 插入自定义动画逻辑
    if (shop_go.LocateMyFSM("Shop Region")
        .GetState("Out Of Range").Actions.Length == 2)
    {
        shop_go.LocateMyFSM("Shop Region")
            .InsertCustomAction("Out Of Range", (fsm) =>
            {
                fsm.gameObject.FindGameObjectInChildren("gou_Bro")
                    .GetComponent<tk2dSpriteAnimator>().Play("Sleep");
            }, 2);
    }
}

// 4. 场景加载时初始化
internal static void GameLoadInit()
{
    if (menu_go != null)
    {
        menu_go.SetActive(false);
        DestroyImmediate(menu_go);
    }
    menu_go = Instantiate(PreloadManager.getGO(shop_scene, shop_menu));
    AdjustMenuGO(menu_go);
    DontDestroyOnAdd(menu_go);
}
```

### 关键点

1. **预加载而非新建** - 使用现有商店对象，避免资源冲突
2. **FSM 过渡修改** - 使用 `ChangeTransition` 改变状态流转
3. **FSM 变量修改** - 直接修改 `FsmVariables` 的值
4. **FSM 动作修改** - 使用 `GetAction<T>` 获取并修改动作参数
5. **插入自定义动作** - 使用 `InsertCustomAction` 在指定位置插入逻辑
6. **场景切换清理** - 在场景加载时销毁并重新创建

### 注意事项

- ✅ 检查动作数组长度，避免重复插入
- ✅ 使用 `DontDestroyOnAdd` 保持商店对象
- ✅ 在场景加载时清理旧对象

---

## 2. Boss 战管理系统

### 应用场景

需要自定义 Boss 行为、修改 Boss 名称、添加 Boss 战逻辑。

### 核心代码

```csharp
// 1. 敌人预加载与实例化
internal static void Init(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects)
{
    GameObject EnemyInit(string scene, string name, bool on_death = false, bool add_spawn = true)
    {
        var res = GameObject.Instantiate(preloadedObjects[scene][name]);
        res.SetActive(false);
        
        // 订阅 OnDeath 事件
        if (on_death)
        {
            try
            {
                res.GetComponent<HealthManager>().OnDeath += DeathCount;
            }
            catch (Exception)
            {
                Rogue.Instance.Log("No HealthManager");
            }
        }
        
        GameObject.DontDestroyOnAdd(res);
        if (add_spawn)
        {
            spawn_gos.Add(res);
            if (on_death) spawn_health_gos.Add(res);
        }
        return res;
    }
    
    // 预加载 Boss
    big_bee = EnemyInit(PreloadManager.hive_scene, PreloadManager.hive_big_bee, true);
    stringer_bee = EnemyInit(PreloadManager.hive_scene, PreloadManager.hive_bee_stinger, true);
    grimmbear = GameObject.Instantiate(preloadedObjects[PreloadManager.grimm_scene][PreloadManager.grimm_name]
        .LocateMyFSM("Spawn Control")
        .FsmVariables.FindFsmGameObject("Grimmkin Obj").Value);
    grimmbear.SetActive(false);
    GameObject.DontDestroyOnAdd(grimmbear);
    spawn_gos.Add(grimmbear);
}

// 2. 自定义 Boss 组件附加
private static void ModifyBoss(On.PlayMakerFSM.orig_OnEnable orig, PlayMakerFSM self)
{
    if (GameInfo.Branch.radiance)
    {
        if (self.gameObject.name == "Absolute Radiance" && self.FsmName == "Control")
        {
            self.gameObject.AddComponent<ModBosses.Uradiance>();
        }
    }
    
    if (GameInfo.Branch.modboss)
    {
        if (self.gameObject.name == "Dream Mage Lord" && self.FsmName == "Mage Lord")
        {
            self.gameObject.AddComponent<ModBosses.VoidTyrant>();
        }
        if (self.gameObject.name == "Dream Mage Lord Phase2" && self.FsmName == "Mage Lord 2")
        {
            self.gameObject.AddComponent<ModBosses.VoidTyrantPhase2>();
        }
    }
    
    orig(self);
}

// 3. 语言 Hook 修改 Boss 名称
private static string ModifyBossName(string key, string sheetTitle, string orig)
{
    if (GameInfo.Branch.radiance)
    {
        if (key == "ABSOLUTE_RADIANCE_MAIN") return "uradiance".Localize();
    }
    if (GameInfo.Branch.modboss)
    {
        if (key == "NAME_SOUL_TYRANT") return "void_tyrant".Localize();
        if (key == "NAME_GHOST_MARKOTH") return "markoth_infinity".Localize();
    }
    return orig;
}

// 4. Boss 击杀计数
private static void DeathCount()
{
    BossManager.bossleft--;
    if (BossManager.bossleft <= 0)
    {
        // Boss 战结束逻辑
        ProcessManager.NextPhase();
    }
}

// 5. Hook 注册
On.PlayMakerFSM.OnEnable += ModifyBoss;
ModHooks.LanguageGetHook += ModifyBossName;
```

### 关键点

1. **预加载敌人** - 从预加载字典中实例化，避免重复加载
2. **OnDeath 事件** - 订阅 `HealthManager.OnDeath` 统计击杀
3. **组件附加** - 使用 `AddComponent` 添加自定义 Boss 逻辑
4. **多阶段 Boss** - 为不同阶段添加不同组件（Phase1, Phase2）
5. **语言 Hook** - 修改 Boss 名称显示
6. **条件判断** - 使用 `GameInfo.Branch` 判断是否启用自定义 Boss

### 注意事项

- ✅ 检查 HealthManager 是否存在（try-catch）
- ✅ 使用 `DontDestroyOnAdd` 保持 Boss 对象
- ✅ 在 `orig(self)` 之前添加自定义逻辑

---

## 3. 敌人波次系统

### 应用场景

需要实现波次防御、随机敌人组合、加权波次选择。

### 核心代码

```csharp
// 1. 数据结构定义
[Serializable]
public class Enemy
{
    public string name;      // 敌人预加载名称
    public int hp;           // 自定义 HP
    public int num;          // 生成数量
}

[Serializable]
public class EnemyWave
{
    public List<Enemy> enemies = new List<Enemy>();
}

[Serializable]
public class EnemyWaveCollection
{
    public class OnePossibleWave
    {
        public float weight;         // 权重
        public EnemyWave enemyWave;  // 波次数据
    }
    
    public Dictionary<int, List<OnePossibleWave>> whole_wave = new();
}

// 2. JSON 配置文件示例
/*
{
  "enemies": [
    {"name": "Buzzer", "hp": 10, "num": 5},
    {"name": "Crawler", "hp": 15, "num": 3},
    {"name": "Spitter", "hp": 20, "num": 2}
  ]
}
*/

// 3. 加权随机波次选择
EnemyWave SelectWave(List<OnePossibleWave> waves)
{
    float totalWeight = waves.Sum(w => w.weight);
    float random = UnityEngine.Random.Range(0f, totalWeight);
    float current = 0f;
    
    foreach (var wave in waves)
    {
        current += wave.weight;
        if (random <= current)
        {
            return wave.enemyWave;
        }
    }
    
    return waves[0].enemyWave;
}

// 4. 敌人生成
void SpawnWave(EnemyWave wave)
{
    foreach (var enemy in wave.enemies)
    {
        var prefab = PreloadManager.getGO(scene, enemy.name);
        for (int i = 0; i < enemy.num; i++)
        {
            var instance = GameObject.Instantiate(prefab, position, Quaternion.identity);
            if (enemy.hp > 0)
            {
                instance.GetComponent<HealthManager>().hp = enemy.hp;
            }
        }
    }
}

// 5. 预加载敌人列表
internal static List<(string, string)> GetPreloadNames()
{
    return new()
    {
        (fly_scene, fly_name),           // ("Crossroads_03", "Uninfected Parent/Buzzer")
        (hatcher_scene, hatcher_name),   // ("Crossroads_35", "_Enemies/Hatcher")
        (zombie_scene, zombie_name),     // ("Crossroads_40", "Uninfected Parent/Zombie Runner 2")
        // ... 50+ 种敌人
    };
}
```

### 关键点

1. **JSON 配置** - 使用 Serializable 类定义波次数据结构
2. **加权随机** - 根据权重选择波次，实现难度曲线
3. **敌人 HP 自定义** - 覆盖默认 HP 实现难度调整
4. **批量预加载** - 预加载 50+ 种敌人对象
5. **波次字典** - 使用 `Dictionary<int, List>` 按难度分级

### 注意事项

- ✅ 预加载所有可能用到的敌人
- ✅ 检查 HealthManager 是否存在
- ✅ 使用 `DontDestroyOnAdd` 管理生成池

---

## 4. 物品工厂系统

### 应用场景

需要实现 Roguelike 物品系统、随机奖励、物品权重控制。

### 核心代码

```csharp
// 1. 物品枚举定义（150+ 种物品）
public enum Giftname
{
    // 护符类 (1-40)
    charm_fengqun,      // 蜂群
    charm_compass,      // 指南针
    charm_wangnu,       // 亡者之怒
    charm_jiaoao,       // 骄傲印记
    // ...
    
    // 角色类
    role_nail_master,   // 骨钉大师
    role_shaman,        // 萨满
    role_hunter,        // 猎人
    // ...
    
    // 商店类
    shop_keeper_key,    // 商店钥匙
    shop_add_1_notch,   // 凹槽 +1
    shop_nail_upgrade,  // 骨钉升级
    // ...
    
    // 自定义类
    custom_refresh_dash,// 刷新冲刺
    custom_always_parry,// 永远格挡
    // ...
}

// 2. 物品抽象类
public class Gift
{
    [NonSerialized] public int id;
    [NonSerialized] public int price;
    [NonSerialized] public float weight;
    [NonSerialized] public float now_weight;
    
    public int level { get; private set; }
    public bool active = true;
    public bool showConvo = true;
    public bool force_active = true;
    
    internal Action<Giftname> reward;
    internal Giftname giftname;
    internal Func<Sprite> getSprite = null;
    
    internal virtual string GetName() {
        return name.Localize();
    }
    
    internal virtual string GetDesc() {
        return desc.Localize();
    }
    
    internal virtual void GetGift() {
        reward?.Invoke(giftname);
    }
    
    internal virtual Sprite GetSprite() {
        return getSprite?.Invoke();
    }
}

// 3. 工厂类
internal static class GiftFactory
{
    public static Dictionary<Giftname, Gift> all_gifts = new();
    public static Dictionary<GiftVariety, List<Gift>> all_kind_of_gifts = new();
    public static Action after_update_weight = null;
    
    // 物品种类
    public enum GiftVariety {
        item,      // 普通物品
        huge,      // 巨大物品
        role,      // 角色
        shop,      // 商店
        charm,     // 护符
        custom     // 自定义
    }
    
    // 初始化所有物品
    private static void Init()
    {
        CharmInit();   // 护符初始化
        RoleInit();    // 角色初始化
        ShopInit();    // 商店初始化
        ItemInit();    // 物品初始化
        CustomInit();  // 自定义初始化
    }
    
    // 护符初始化示例
    private static void CharmInit()
    {
        for (int i = 1; i <= 40; i++)
        {
            if (i == 36) continue;
            all_gifts.Add((Giftname)i, new CharmGift((Giftname)i));
        }
    }
    
    // 角色初始化示例
    private static void RoleInit()
    {
        all_gifts.Add(Giftname.role_nail_master, 
            new RoleGift<NailMaster>(Giftname.role_nail_master));
        all_gifts.Add(Giftname.role_shaman, 
            new RoleGift<Shaman>(Giftname.role_shaman));
        all_gifts.Add(Giftname.role_hunter, 
            new RoleGift<Hunter>(Giftname.role_hunter));
    }
    
    // 权重更新
    public static void UpdateWeight()
    {
        foreach (var gift in all_gifts.Values)
        {
            if (gift.active && gift.force_active)
            {
                gift.now_weight = gift.weight;
            }
            else
            {
                gift.now_weight = 0;
            }
        }
        after_update_weight?.Invoke();
    }
    
    // 随机选择物品
    public static Gift SelectGift(List<Gift> gifts)
    {
        float totalWeight = gifts.Sum(g => g.now_weight);
        float random = UnityEngine.Random.Range(0f, totalWeight);
        float current = 0f;
        
        foreach (var gift in gifts)
        {
            current += gift.now_weight;
            if (random <= current)
            {
                return gift;
            }
        }
        
        return gifts[0];
    }
}

// 4. 护符物品实现
public class CharmGift : Gift
{
    public CharmGift(Giftname name)
    {
        this.giftname = name;
        this.level = 1;
        this.price = 100;
        this.weight = 10f;
        this.reward = (giftname) => {
            // 给予护符逻辑
            PlayerData.instance.SetBool("equippedCharm_" + (int)giftname, true);
        };
    }
}

// 5. 角色物品实现
public class RoleGift<T> : Gift where T : MonoBehaviour
{
    public RoleGift(Giftname name)
    {
        this.giftname = name;
        this.level = 2;
        this.price = 200;
        this.weight = 5f;
        this.reward = (giftname) => {
            // 添加角色组件
            HeroController.instance.gameObject.AddComponent<T>();
        };
    }
}
```

### 关键点

1. **枚举定义** - 使用 enum 定义 150+ 种物品 ID
2. **抽象类设计** - Gift 基类定义通用属性和方法
3. **工厂模式** - GiftFactory 统一管理所有物品
4. **物品分类** - 使用 GiftVariety 枚举分类管理
5. **权重系统** - 支持动态调整物品出现概率
6. **泛型实现** - RoleGift<T> 支持泛型角色组件

### 注意事项

- ✅ 使用 `[NonSerialized]` 避免序列化临时数据
- ✅ 权重更新后调用回调 `after_update_weight`
- ✅ 检查物品 `active` 状态再选择

---

## 5. 场景管理系统

### 应用场景

需要管理多场景流程、场景状态、分支剧情。

### 核心代码

```csharp
// 1. 场景状态管理
public class GameInfo
{
    // 场景物品状态
    public static Dictionary<string, bool> now_scene_items = new();
    
    // 分支剧情标志
    public static BranchFlags Branch = new();
    
    public class BranchFlags
    {
        public bool radiance = false;      // 辐光分支
        public bool modboss = false;       // Mod Boss 分支
        public bool collector = false;     // 收藏家分支
        public bool lost_kin = false;      // 失落近亲分支
        public bool meet_collector = false;// 已遇见收藏家
        public bool meet_lost_kin = false; // 已遇见失落近亲
    }
}

// 2. 场景加载流程
internal static void GameLoadInit()
{
    // 清理旧对象
    if (menu_go != null)
    {
        menu_go.SetActive(false);
        DestroyImmediate(menu_go);
    }
    
    // 创建新对象
    menu_go = Instantiate(PreloadManager.getGO(shop_scene, shop_menu));
    AdjustMenuGO(menu_go);
    DontDestroyOnAdd(menu_go);
    
    // 初始化场景状态
    if (!GameInfo.now_scene_items.ContainsKey(ProcessManager.scene_name))
    {
        GameInfo.now_scene_items[ProcessManager.scene_name] = false;
    }
}

// 3. 分支剧情判断
internal static bool BranchBoss()
{
    if (ProcessManager.scene_name == "GG_Collector_V")
    {
        if (GameInfo.Branch.collector)
        {
            if (GameInfo.Branch.meet_collector)
            {
                return true;  // 进入 Boss 战
            }
            else
            {
                GameInfo.Branch.meet_collector = true;  // 首次遇见
            }
        }
    }
    
    if (ProcessManager.scene_name == "GG_Lost_Kin")
    {
        if (GameInfo.Branch.lost_kin)
        {
            if (GameInfo.Branch.meet_lost_kin)
            {
                return true;
            }
            else
            {
                GameInfo.Branch.meet_lost_kin = true;
            }
        }
    }
    
    return false;
}

// 4. 禁止 Boss 战场景列表
internal static List<string> nobossscene = new List<string> {
    "GG_Spa",
    "GG_Engine",
    "GG_Unn",
    "GG_Wyrm",
    "GG_Atrium_Roof",
    "GG_End_Sequence"
};

// 5. 场景检查
bool CanSpawnBoss(string scene_name)
{
    return !nobossscene.Contains(scene_name);
}
```

### 关键点

1. **字典管理状态** - 使用 `Dictionary<string, bool>` 管理场景状态
2. **分支标志类** - 使用嵌套类管理分支剧情标志
3. **场景加载清理** - 在场景加载时清理旧对象
4. **首次遇见逻辑** - 使用标志位记录首次遇见 Boss
5. **禁止列表** - 使用 List 定义禁止 Boss 战的场景

### 注意事项

- ✅ 使用 `ProcessManager.scene_name` 获取当前场景名
- ✅ 场景状态字典需要检查 Key 是否存在
- ✅ 禁止列表使用 `Contains` 快速检查

---

## 6. UI 显示管理系统

### 应用场景

需要自定义 UI 显示、文本本地化、状态更新。

### 核心代码

```csharp
// 1. 显示管理类
public class DisplayManager
{
    // 显示状态
    public static void DisplayStates()
    {
        UpdateBossCount();
        UpdateWaveCount();
        UpdateItemCount();
    }
    
    // 更新 Boss 计数
    private static void UpdateBossCount()
    {
        var text = GameObject.Find("BossCountText")
            .GetComponent<TextMeshProUGUI>();
        text.text = $"Boss: {BossManager.bossleft}";
    }
    
    // 更新波次计数
    private static void UpdateWaveCount()
    {
        var text = GameObject.Find("WaveCountText")
            .GetComponent<TextMeshProUGUI>();
        text.text = $"Wave: {EnemyWaveManager.waveleft}";
    }
    
    // 显示对话文本
    public static void ShowConvo(string text)
    {
        Rogue.Instance.Log(text);
        // 显示到 UI
    }
    
    // 更新权重显示
    public static void UpdateWeight()
    {
        GiftFactory.UpdateWeight();
        DisplayStates();
    }
}

// 2. 文本本地化
public static class Language
{
    public static string Localize(this string key)
    {
        return Language.Language.Get(key, "UI");
    }
}

// 3. UI 初始化
internal static void InitUI()
{
    // 创建 UI 文本对象
    var bossCountText = new GameObject("BossCountText");
    bossCountText.AddComponent<TextMeshProUGUI>();
    
    var waveCountText = new GameObject("WaveCountText");
    waveCountText.AddComponent<TextMeshProUGUI>();
    
    DontDestroyOnAdd(bossCountText);
    DontDestroyOnAdd(waveCountText);
}
```

### 关键点

1. **集中管理** - DisplayManager 统一管理所有 UI 更新
2. **本地化扩展** - 使用扩展方法实现文本本地化
3. **状态同步** - 游戏状态改变时自动更新 UI
4. **对象池** - UI 对象使用 `DontDestroyOnAdd` 保持

### 注意事项

- ✅ 使用 `GameObject.Find` 前检查对象是否存在
- ✅ 本地化 Key 使用统一命名规范
- ✅ UI 更新频率不宜过高（避免每帧更新）

---

## 7. 预加载管理系统

### 应用场景

需要批量预加载资源、管理场景对象、避免卡顿。

### 核心代码

```csharp
// 1. 预加载管理器
internal static class PreloadManager
{
    // 场景常量
    internal const string hive_scene = "Hive_05";
    internal const string mushroom_scene = "Fungus2_25";
    internal const string grimm_scene = "Grimm_Troupe_Tent";
    internal const string collector_scene = "Room_Collector";
    
    // 敌人常量
    internal const string hive_big_bee = "Big Buzzer";
    internal const string hive_bee_stinger = "Bee Stinger";
    internal const string roller_mushroom_name = "Rolling Shroom";
    internal const string grimm_name = "Troupe Master Grimm";
    
    // 预加载字典
    private static Dictionary<string, Dictionary<string, GameObject>> preloadedObjects;
    
    // 获取预加载对象
    internal static GameObject getGO(string scene, string name)
    {
        if (preloadedObjects.ContainsKey(scene) && 
            preloadedObjects[scene].ContainsKey(name))
        {
            return preloadedObjects[scene][name];
        }
        return null;
    }
    
    // 预加载所有资源
    internal static List<(string, string)> GetPreloadNames()
    {
        return new()
        {
            // Boss 相关
            (hive_scene, hive_big_bee),
            (hive_scene, hive_bee_stinger),
            (mushroom_scene, roller_mushroom_name),
            (grimm_scene, grimm_name),
            (collector_scene, collector_name),
            
            // 敌人相关（50+ 种）
            (fly_scene, fly_name),
            (hatcher_scene, hatcher_name),
            (zombie_scene, zombie_name),
            // ...
        };
    }
}

// 2. Mod 初始化时预加载
public override void Initialize(
    Dictionary<string, Dictionary<string, GameObject>> preloadedObjects)
{
    PreloadManager.preloadedObjects = preloadedObjects;
    
    // 初始化 Boss 管理器
    BossManager.Init(preloadedObjects);
    
    // 初始化敌人波次
    EnemyWaveManager.Init(preloadedObjects);
}
```

### 关键点

1. **场景 + 路径字典** - 使用嵌套字典管理预加载对象
2. **常量定义** - 使用 const 定义场景和对象名称
3. **批量预加载** - 一次性预加载 100+ 个对象
4. **访问工具** - 提供 `getGO` 方法安全访问

### 注意事项

- ✅ 检查字典 Key 是否存在再访问
- ✅ 使用 `DontDestroyOnAdd` 保持预加载对象
- ✅ 预加载对象设置为 `SetActive(false)`

---

## 8. 统计管理系统

### 应用场景

需要统计游戏数据、保存进度、显示成就。

### 核心代码

```csharp
// 1. 统计管理类
public class StatsManager
{
    // 统计数据
    public static int bossesDefeated = 0;
    public static int wavesCleared = 0;
    public static int itemsCollected = 0;
    public static int playTime = 0;
    
    // 保存数据
    public class SaveData
    {
        public int bossesDefeated;
        public int wavesCleared;
        public int itemsCollected;
        public List<Giftname> got_items = new();
    }
    
    // 保存统计
    public static void Save()
    {
        var data = new SaveData
        {
            bossesDefeated = bossesDefeated,
            wavesCleared = wavesCleared,
            itemsCollected = itemsCollected,
            got_items = GameInfo.got_items
        };
        
        var json = JsonConvert.SerializeObject(data);
        File.WriteAllText(GetSavePath(), json);
    }
    
    // 加载统计
    public static void Load()
    {
        if (File.Exists(GetSavePath()))
        {
            var json = File.ReadAllText(GetSavePath());
            var data = JsonConvert.DeserializeObject<SaveData>(json);
            
            bossesDefeated = data.bossesDefeated;
            wavesCleared = data.wavesCleared;
            itemsCollected = data.itemsCollected;
            GameInfo.got_items = data.got_items;
        }
    }
    
    // 获取保存路径
    private static string GetSavePath()
    {
        return Path.Combine(Application.persistentDataPath, "rogue_stats.json");
    }
    
    // 更新统计
    public static void AddBossDefeated()
    {
        bossesDefeated++;
        Save();
    }
    
    public static void AddWaveCleared()
    {
        wavesCleared++;
        Save();
    }
}

// 2. 物品收集记录
public class GameInfo
{
    public static List<Giftname> got_items = new();
    
    public static void AddItem(Giftname item)
    {
        if (!got_items.Contains(item))
        {
            got_items.Add(item);
            StatsManager.Save();
        }
    }
}
```

### 关键点

1. **JSON 序列化** - 使用 Newtonsoft.Json 序列化保存数据
2. **持久化路径** - 使用 `Application.persistentDataPath`
3. **自动保存** - 关键操作后自动保存
4. **列表记录** - 使用 `List<Giftname>` 记录已收集物品

### 注意事项

- ✅ 使用 `JsonConvert` 进行序列化和反序列化
- ✅ 检查文件是否存在再加载
- ✅ 保存前检查数据有效性

---

## 总结

Rogue Mod 提供了 8 个完整的系统实现，每个系统都可以独立应用于其他 Mod 开发：

| 系统 | 复杂度 | 通用性 | 推荐使用场景 |
|------|--------|--------|-------------|
| 商店 FSM 修改 | 中 | ⭐⭐⭐⭐⭐ | 自定义商店 |
| Boss 战管理 | 中 | ⭐⭐⭐⭐⭐ | Boss 战改造 |
| 敌人波次 | 低 | ⭐⭐⭐⭐⭐ | 波次防御 |
| 物品工厂 | 高 | ⭐⭐⭐⭐⭐ | Roguelike 物品 |
| 场景管理 | 中 | ⭐⭐⭐⭐ | 多场景 Mod |
| UI 显示 | 中 | ⭐⭐⭐ | 自定义 UI |
| 预加载管理 | 低 | ⭐⭐⭐⭐ | 大量资源加载 |
| 统计管理 | 低 | ⭐⭐⭐ | 数据统计 |

这些系统共同构成了一个完整的 Roguelike Mod 框架，可以根据需要组合使用。
