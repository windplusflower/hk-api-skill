# Game System Modification Patterns

## 概述

本文档整理了**修改游戏自带系统**的通用模式。不包含 Mod 自定义系统（如 Roguelike 物品工厂、自定义波次逻辑等）。

**适用范围**：任何需要修改游戏原有行为的 Mod。

---

## 1. 商店 FSM 修改模式

### 应用场景

修改游戏自带的商店系统（如 Iselda 商店），而非创建新商店。

### 核心代码

```csharp
// 1. 预加载游戏商店对象
internal const string shop_scene = "Room_shop";
internal const string shop_menu = "Shop Menu";

// 2. 修改商店菜单 FSM
static void AdjustMenuGO(GameObject menu_go)
{
    // 修改 FSM 过渡 - 让商店始终可以打开
    menu_go.LocateMyFSM("shop_control")
        .ChangeTransition("Stock?", "FINISHED", "Open Window");
    
    // 修改 FSM 变量 - 改变商店文本
    menu_go.LocateMyFSM("shop_control")
        .FsmVariables.FindFsmString("No Stock Event").Value = "CUSTOM_TEXT";
    
    // 修改 FSM 动作参数 - 改变对话内容
    menu_go.LocateMyFSM("shop_control")
        .GetAction<SetFsmString>("Iselda", 4).setValue = "custom_intro";
    
    // 修改文本显示 - 自定义物品描述
    var fsm = menu_go.FindGameObjectInChildren("Item List")
        .LocateMyFSM("Item List Control");
    fsm.GetAction<SetTextMeshProText>("Get Details", 3)
        .textString = fsm.FsmVariables.GetFsmString("Item Name Convo");
    
    // 插入自定义动作 - 购买时触发自定义逻辑
    var confirmFsm = menu_go.FindGameObjectInChildren("Confirm")
        .FindGameObjectInChildren("UI List")
        .LocateMyFSM("Confirm Control");
    
    if (confirmFsm.GetState("Special Type?").Actions.Length < 3)
    {
        confirmFsm.InsertCustomAction("Special Type?", (fsm) =>
        {
            // 自定义购买逻辑
            // 例如：给予自定义物品
        }, 1);
    }
}

// 3. 场景加载时初始化
internal static void GameLoadInit()
{
    // 清理旧对象
    if (menu_go != null)
    {
        menu_go.SetActive(false);
        DestroyImmediate(menu_go);
    }
    
    // 创建新对象（从游戏预加载）
    menu_go = Instantiate(PreloadManager.getGO(shop_scene, shop_menu));
    AdjustMenuGO(menu_go);
    DontDestroyOnAdd(menu_go);
}
```

### 关键点

1. **使用游戏预加载对象** - 不创建新对象，修改游戏原有对象
2. **FSM 过渡修改** - 使用 `ChangeTransition` 改变状态流转
3. **FSM 变量修改** - 直接修改 `FsmVariables` 的值
4. **FSM 动作修改** - 使用 `GetAction<T>` 获取并修改动作参数
5. **插入自定义动作** - 使用 `InsertCustomAction` 在指定位置插入逻辑

### 注意事项

- ✅ 检查动作数组长度，避免重复插入
- ✅ 使用 `DontDestroyOnAdd` 保持商店对象
- ✅ 在场景加载时清理旧对象

### 通用性评估

**⭐⭐⭐⭐⭐** - 适用于任何需要修改商店的 Mod
- 修改价格
- 修改商品列表
- 修改商店文本
- 添加自定义购买逻辑

---

## 2. Boss 组件附加模式

### 应用场景

修改游戏自带 Boss 的行为，而非创建新 Boss。

### 核心代码

```csharp
// 1. 监听 Boss FSM 启用
private static void ModifyBoss(On.PlayMakerFSM.orig_OnEnable orig, PlayMakerFSM self)
{
    // 判断是否是目标 Boss
    if (self.gameObject.name == "Absolute Radiance" && self.FsmName == "Control")
    {
        // 附加自定义组件
        self.gameObject.AddComponent<ModBosses.Uradiance>();
    }
    
    // 多阶段 Boss - 为不同阶段添加不同组件
    if (self.gameObject.name == "Dream Mage Lord" && self.FsmName == "Mage Lord")
    {
        self.gameObject.AddComponent<ModBosses.VoidTyrant>();
    }
    if (self.gameObject.name == "Dream Mage Lord Phase2" && self.FsmName == "Mage Lord 2")
    {
        self.gameObject.AddComponent<ModBosses.VoidTyrantPhase2>();
    }
    
    // 调用原始方法（重要！）
    orig(self);
}

// 2. Hook 注册
On.PlayMakerFSM.OnEnable += ModifyBoss;
```

### 关键点

1. **使用 On.Enable Hook** - 在 Boss FSM 启用时附加组件
2. **判断 GameObject 名称** - 使用 `self.gameObject.name` 判断 Boss
3. **判断 FSM 名称** - 使用 `self.FsmName` 判断阶段
4. **多阶段处理** - 为不同阶段添加不同组件
5. **调用原始方法** - 必须调用 `orig(self)` 保持游戏正常逻辑

### ⚠️ FSM 使用建议

**修改游戏原有对象** → 使用 PlayMakerFSM
```csharp
// ✅ 正确：修改游戏 Boss 的 FSM
On.PlayMakerFSM.OnEnable += (orig, self) => {
    if (self.gameObject.name == "Radiance") {
        // 修改原有 FSM
    }
    orig(self);
};
```

**从零创建对象** → 使用自定义 MonoBehaviour
```csharp
// ✅ 正确：自己创建的对象用 MonoBehaviour
public class CustomEnemy : MonoBehaviour {
    public int hp = 5;
    void Update() { /* AI logic */ }
}

// ❌ 错误：不要给自己创建的对象添加 PlayMakerFSM
var fsm = enemy.AddPlayMakerFSM(); // 不要这样做
```

### 注意事项

- ✅ 在 `orig(self)` 之前添加自定义逻辑
- ✅ 检查组件是否已存在，避免重复附加
- ✅ 使用 `DontDestroyOnAdd` 保持 Boss 对象

### 通用性评估

**⭐⭐⭐⭐⭐** - 适用于任何需要修改 Boss 行为的 Mod
- 修改 Boss 攻击模式
- 添加新技能
- 修改 Boss HP
- 修改 Boss 阶段转换

---

## 3. Boss 名称修改模式

### 应用场景

修改游戏自带 Boss 的名称显示。

### 核心代码

```csharp
// 1. 使用 LanguageGetHook
private static string ModifyBossName(string key, string sheetTitle, string orig)
{
    // 判断是否是目标 Boss
    if (key == "ABSOLUTE_RADIANCE_MAIN")
    {
        return "自定义名称".Localize();
    }
    
    if (key == "NAME_SOUL_TYRANT")
    {
        return "虚空暴君".Localize();
    }
    
    if (key == "NAME_GHOST_MARKOTH")
    {
        return "无限马科斯".Localize();
    }
    
    // 返回原始名称（重要！）
    return orig;
}

// 2. Hook 注册
ModHooks.LanguageGetHook += ModifyBossName;
```

### 关键点

1. **使用 LanguageGetHook** - 拦截游戏文本本地化
2. **判断 Key** - 使用文本 Key 判断是否是目标 Boss
3. **返回本地化文本** - 使用 `.Localize()` 支持多语言
4. **返回原始值** - 非目标 Boss 返回 `orig`

### 注意事项

- ✅ 只修改目标 Key，其他返回 `orig`
- ✅ 使用 `.Localize()` 支持多语言
- ✅ Boss Key 需要查阅游戏文本文件

### 通用性评估

**⭐⭐⭐⭐⭐** - 适用于任何需要修改文本的 Mod
- 修改 Boss 名称
- 修改 NPC 对话
- 修改物品描述
- 修改菜单文本

---

## 4. 敌人预加载模式

### 应用场景

预加载游戏自带敌人对象，用于生成或替换。

### 核心代码

```csharp
// 1. 定义预加载列表
internal static List<(string, string)> GetPreloadNames()
{
    return new()
    {
        // 使用游戏场景名 + 对象路径
        ("Crossroads_03", "Uninfected Parent/Buzzer"),
        ("Crossroads_35", "_Enemies/Hatcher"),
        ("Crossroads_40", "Uninfected Parent/Zombie Runner 2"),
        ("Hive_05", "Big Buzzer"),
        ("Hive_05", "Bee Stinger"),
        // ... 游戏自带敌人
    };
}

// 2. 从预加载字典获取对象
internal static GameObject getGO(string scene, string name)
{
    if (preloadedObjects.ContainsKey(scene) && 
        preloadedObjects[scene].ContainsKey(name))
    {
        return preloadedObjects[scene][name];
    }
    return null;
}

// 3. 实例化敌人
void SpawnEnemy(string scene, string name, Vector3 position)
{
    var prefab = getGO(scene, name);
    if (prefab != null)
    {
        var instance = GameObject.Instantiate(prefab, position, Quaternion.identity);
        // 可以修改 HP 等属性
        instance.GetComponent<HealthManager>().hp = 20;
    }
}
```

### 关键点

1. **使用游戏预加载字典** - `Dictionary<string, Dictionary<string, GameObject>>`
2. **场景 + 路径** - 使用场景名和对象路径定位
3. **实例化而非新建** - 使用游戏预制体
4. **修改属性** - 可以修改 HP 等属性

### 注意事项

- ✅ 检查字典 Key 是否存在
- ✅ 使用 `DontDestroyOnAdd` 管理生成池
- ✅ 检查 HealthManager 是否存在

### 通用性评估

**⭐⭐⭐⭐⭐** - 适用于任何需要生成敌人的 Mod
- 生成游戏自带敌人
- 修改敌人属性
- 敌人替换
- Boss 战生成小怪

---

## 5. 敌人死亡事件订阅模式

### 应用场景

监听游戏自带敌人的死亡事件。

### 核心代码

```csharp
// 1. 订阅 OnDeath 事件
GameObject enemy = preloadedObjects[scene][name];
enemy.GetComponent<HealthManager>().OnDeath += DeathCount;

// 2. 死亡回调
private static void DeathCount()
{
    // 击杀计数
    bossesDefeated++;
    
    // 检查是否所有敌人都被击败
    if (bossesDefeated >= requiredDefeats)
    {
        // 触发下一阶段
        ProcessManager.NextPhase();
    }
}

// 3. 安全检查（重要！）
try
{
    res.GetComponent<HealthManager>().OnDeath += DeathCount;
}
catch (Exception)
{
    // 没有 HealthManager 时的处理
    Rogue.Instance.Log("No HealthManager");
}
```

### 关键点

1. **订阅 OnDeath** - 使用 `HealthManager.OnDeath` 事件
2. **计数逻辑** - 在回调中更新计数
3. **阶段转换** - 根据计数触发下一阶段
4. **异常处理** - 使用 try-catch 检查 HealthManager

### 注意事项

- ✅ 使用 try-catch 检查 HealthManager
- ✅ 在对象销毁前取消订阅（避免内存泄漏）
- ✅ 使用 `DontDestroyOnAdd` 保持对象

### 通用性评估

**⭐⭐⭐⭐⭐** - 适用于任何需要监听敌人死亡的 Mod
- Boss 战击杀计数
- 成就解锁
- 掉落物品
- 任务完成判断

---

## 6. 场景状态管理模式

### 应用场景

管理游戏场景状态和分支剧情。

### 核心代码

```csharp
// 1. 场景状态字典
public class GameInfo
{
    // 场景物品状态
    public static Dictionary<string, bool> now_scene_items = new();
    
    // 分支剧情标志
    public static BranchFlags Branch = new();
    
    public class BranchFlags
    {
        public bool radiance = false;      // 辐光分支
        public bool collector = false;     // 收藏家分支
        public bool meet_collector = false;// 已遇见收藏家
    }
}

// 2. 场景加载初始化
internal static void GameLoadInit()
{
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
    return false;
}

// 4. 禁止列表
internal static List<string> nobossscene = new List<string> {
    "GG_Spa",
    "GG_Engine",
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
3. **场景名判断** - 使用 `ProcessManager.scene_name` 获取当前场景
4. **首次遇见逻辑** - 使用标志位记录首次遇见

### 注意事项

- ✅ 检查字典 Key 是否存在
- ✅ 使用 `ProcessManager.scene_name` 获取场景名
- ✅ 禁止列表使用 `Contains` 快速检查

### 通用性评估

**⭐⭐⭐⭐** - 适用于需要多场景流程的 Mod
- 场景状态管理
- 分支剧情
- 任务进度
- 禁止列表

---

## 7. 文本本地化模式

### 应用场景

使用游戏自带本地化系统支持多语言。

### 核心代码

```csharp
// 1. 扩展方法
public static class LanguageExtensions
{
    public static string Localize(this string key)
    {
        return Language.Language.Get(key, "UI");
    }
}

// 2. 使用示例
string bossName = "custom_boss_name".Localize();
string itemDesc = "custom_item_desc".Localize();

// 3. 在 Hook 中使用
private static string ModifyBossName(string key, string sheetTitle, string orig)
{
    if (key == "ABSOLUTE_RADIANCE_MAIN")
    {
        return "uradiance".Localize();  // 从本地化文件读取
    }
    return orig;
}
```

### 关键点

1. **使用游戏 Language 系统** - `Language.Language.Get(key, sheet)`
2. **扩展方法** - 使用 `.Localize()` 简化调用
3. **多语言支持** - 在本地化文件中添加多语言文本

### 注意事项

- ✅ 使用 `.Localize()` 而非硬编码文本
- ✅ 在本地化文件中添加文本
- ✅ 使用统一 Key 命名规范

### 通用性评估

**⭐⭐⭐⭐** - 适用于任何需要文本显示的 Mod
- Boss 名称
- 物品描述
- 菜单文本
- 对话文本

---

## 8. 预加载管理模式

### 应用场景

批量预加载游戏资源，避免生成时卡顿。

### 核心代码

```csharp
// 1. 定义预加载常量
internal const string hive_scene = "Hive_05";
internal const string hive_big_bee = "Big Buzzer";
internal const string grimm_scene = "Grimm_Troupe_Tent";
internal const string grimm_name = "Troupe Master Grimm";

// 2. 预加载列表
internal static List<(string, string)> GetPreloadNames()
{
    return new()
    {
        (hive_scene, hive_big_bee),
        (hive_scene, "Bee Stinger"),
        (grimm_scene, grimm_name),
        // ... 游戏自带对象
    };
}

// 3. 获取预加载对象
internal static GameObject getGO(string scene, string name)
{
    if (preloadedObjects.ContainsKey(scene) && 
        preloadedObjects[scene].ContainsKey(name))
    {
        return preloadedObjects[scene][name];
    }
    return null;
}

// 4. Mod 初始化时接收预加载字典
public override void Initialize(
    Dictionary<string, Dictionary<string, GameObject>> preloadedObjects)
{
    PreloadManager.preloadedObjects = preloadedObjects;
}
```

### 关键点

1. **嵌套字典** - `Dictionary<string, Dictionary<string, GameObject>>`
2. **场景 + 路径** - 使用场景名和对象路径定位
3. **常量定义** - 使用 const 定义场景和对象名称
4. **安全检查** - 检查 Key 是否存在

### 注意事项

- ✅ 检查字典 Key 是否存在
- ✅ 使用 const 定义常量
- ✅ 预加载对象设置为 `SetActive(false)`

### 通用性评估

**⭐⭐⭐⭐⭐** - 适用于任何需要预加载资源的 Mod
- 敌人生成
- Boss 战
- 特效播放
- 对象池管理

---

## 总结

本文档整理了 8 个**修改游戏自带系统**的通用模式：

| 模式 | 通用性 | 复杂度 | 推荐使用场景 |
|------|--------|--------|-------------|
| 商店 FSM 修改 | ⭐⭐⭐⭐⭐ | 中 | 修改商店 |
| Boss 组件附加 | ⭐⭐⭐⭐⭐ | 中 | Boss 战改造 |
| Boss 名称修改 | ⭐⭐⭐⭐⭐ | 低 | 文本修改 |
| 敌人预加载 | ⭐⭐⭐⭐⭐ | 低 | 敌人生成 |
| 死亡事件订阅 | ⭐⭐⭐⭐⭐ | 低 | 击杀计数 |
| 场景状态管理 | ⭐⭐⭐⭐ | 中 | 多场景流程 |
| 文本本地化 | ⭐⭐⭐⭐ | 低 | 多语言支持 |
| 预加载管理 | ⭐⭐⭐⭐⭐ | 低 | 资源管理 |

**所有模式都基于游戏自带系统**，不依赖 Mod 自定义框架，可直接用于任何 HK Mod 开发。
