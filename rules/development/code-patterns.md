# Code Patterns Reference

## 概述

本文档整理了常见的代码模式和最佳实践。

**注意**：本文档只包含通用的、不依赖第三方库的模式。

## 常用模式列表

| 模式名称 | 用途 | 示例代码 |
|----------|------|----------|
| **FSM 相关** | | |
| FSM Injection Pattern | 在现有 FSM 中注入自定义动作 | 见下方详细说明 |
| FSM State Copying | 复制 FSM 状态并添加自定义过渡 | 见下方详细说明 |
| FSM State Modification | 修改现有 FSM 状态 | 见下方详细说明 |
| FSM Custom Action | 创建自定义 FSM 动作 | 见下方详细说明 |
| FSM Event Triggering | 触发 FSM 事件来取消或重定向状态流 | `fsm.SendEvent("CANCEL")` |
| FSM Variable Access | 访问和修改 FSM 浮点变量 | `fsm.GetFloat("variableName")` |
| **对象管理** | | |
| Object Pooling | 使用 Queue<T> 进行对象池管理 | 见下方详细说明 |
| Component Attachment | 添加自定义 MonoBehaviour 组件 | `gameObject.AddComponent<T>()` |
| Component Cleanup | 移除实例化模板中的不必要组件 | `Destroy(template.GetComponent<T>())` |
| GameObject Cleanup | 创建新对象前销毁旧对象 | 见下方详细说明 |
| **伤害计算** | | |
| Charm Damage Multiplier | 根据装备护符计算伤害倍数 | 见下方详细说明 |
| Soul Gain Calculation | 计算灵魂获取，包含护符加成 | 见下方详细说明 |
| **输入与相机** | | |
| Input Axis Reading | 使用 Input.GetAxisRaw 读取玩家输入 | `Input.GetAxisRaw("Horizontal")` |
| Camera Lock Pattern | Boss 战期间锁定相机位置和缩放 | 见下方详细说明 |
| **动画与特效** | | |
| Juice Animation | 对 Boss 部位应用挤压拉伸动画 | 见下方详细说明 |
| Multi-Part Boss Animation | 动画 Boss 分离部位（头、身体等） | 见下方详细说明 |
| Blood Explosion Effect | 生成多个随机速度的血粒子 | 见下方详细说明 |
| **资源加载** | | |
| Sprite Loading from Assembly | 从嵌入程序集资源加载精灵 | 见下方详细说明 |
| Sprite Sheet Loading | 从嵌入资源加载精灵表 | 见下方详细说明 |
| GameObject Preload Extraction | 从预加载对象中提取特定 GameObject | 见下方详细说明 |
| **Hook 模式** | | |
| Hook Injection in Initialize | 在 Mod.Initialize() 中注册 On Hooks | 见下方详细说明 |
| Hook Interception Pattern | 使用 On Hooks 拦截和修改游戏逻辑 | 见下方详细说明 |
| IL Hook Injection | 使用 ILCursor 注入自定义逻辑 | 见下方详细说明 |
| **菜单与设置** | | |
| IMenuMod Implementation | 创建游戏内 Mod 配置菜单 | 见下方详细说明 |
| Mod Settings with IGlobalSettings | 使用 IGlobalSettings 实现设置持久化 | 见下方详细说明 |
| **AI 与行为** | | |
| RandomSelector for Attack Choice | Boss 攻击模式的加权随机选择 | 见下方详细说明 |
| SmoothDamp Movement | 使用 Vector2.SmoothDamp 平滑敌人移动 | 见下方详细说明 |
| Level-based Difficulty Scaling | 技能根据 Boss 血量阈值分级（1-3 级） | 见下方详细说明 |
| **工具类** | | |
| LocateMyFSM | 在 GameObject 上按名称查找 PlayMakerFSM 的扩展方法 | 见下方详细说明 |
| CopyOnto<T> | 扩展方法，将组件属性复制到另一个对象 | 见下方详细说明 |
| Brightness Util | 通过修改材质调整 GameObject 亮度 | 见下方详细说明 |
| Callback System | GameMapHooks.Init 接受回调注册自定义区域 | 见下方详细说明 |
| IHitResponder Interface | 自定义接口处理平台上的命中事件 | 见下方详细说明 |
| Input Manager | 使用 ContinuousInput 和 InputBuffer 的自定义输入管理 | 见下方详细说明 |
| Water Physics Simulation | 基于弹簧的水面模拟，带扩散效果 | 见下方详细说明 |

## 详细模式说明

### FSM 注入模式

在现有 FSM 中注入自定义动作：

```csharp
private void InjectCustomAction(PlayMakerFSM fsm, string stateName) {
    var state = fsm.Fsm.GetState(stateName);
    if (state == null) return;
    
    // 在状态动作列表开头插入自定义动作
    var newActions = new FsmStateAction[state.Actions.Length + 1];
    newActions[0] = new CustomAction();
    Array.Copy(state.Actions, 0, newActions, 1, state.Actions.Length);
    state.Actions = newActions;
}
```

### FSM 状态复制

复制 FSM 状态并添加自定义过渡：

```csharp
fsm.CopyState("Source State", "Target State");
fsm.AddTransition("Source State", "CUSTOM_EVENT", "Target State");
```

### 自定义 FSM 动作

创建自定义 FSM 动作：

```csharp
public class CustomAction : FsmStateAction {
    public override void OnEnter() {
        // 自定义逻辑
        Finish();
    }
}
```

### FSM 事件触发

触发 FSM 事件来取消或重定向状态流：

```csharp
// 取消当前状态
fsm.SendEvent("CANCEL");

// 重定向到另一个状态
fsm.SendEvent("FSM CANCEL");
```

### FSM 变量访问

访问和修改 FSM 浮点变量：

```csharp
// 获取 FSM 变量
var variable = fsm.FsmVariables.GetFsmFloat("VariableName");

// 设置 FSM 变量
fsm.FsmVariables.GetFsmFloat("VariableName").Value = 10f;
```

### 对象池模式

使用 Queue<T> 进行对象池管理：

```csharp
private Queue<GameObject> pool = new Queue<GameObject>();

GameObject GetFromPool() {
    if (pool.Count > 0) {
        var obj = pool.Dequeue();
        obj.SetActive(true);
        return obj;
    }
    return Instantiate(prefab);
}

void ReturnToPool(GameObject obj) {
    obj.SetActive(false);
    pool.Enqueue(obj);
}
```

### 组件附加模式

添加自定义 MonoBehaviour 组件：

```csharp
// 检查并添加组件
if (gameObject.GetComponent<CustomComponent>() == null) {
    gameObject.AddComponent<CustomComponent>();
}
```

### 组件清理模式

移除实例化模板中的不必要组件：

```csharp
var template = preloadedObjects["Scene"]["Object"];

// 清理不需要的组件
Destroy(template.GetComponent<PersistentBoolItem>());
Destroy(template.GetComponent<ConstrainPosition>());
```

### 游戏对象清理

创建新对象前销毁旧对象：

```csharp
// 销毁场景中所有同名对象
var oldObjects = GameObject.FindGameObjectsWithTag("Enemy");
foreach (var obj in oldObjects) {
    Destroy(obj);
}

// 创建新对象
var newObject = Instantiate(prefab, position, Quaternion.identity);
```

### 伤害计算模式

考虑护符加成的伤害计算：

```csharp
float CalculateDamageMultiplier() {
    float multiplier = 1f;
    var pd = PlayerData.instance;
    
    // 力量护符
    if (pd.GetBool("equippedCharm_25")) {
        multiplier *= 1.5f;
    }
    
    // 亡者之怒（残血）
    if (pd.GetBool("equippedCharm_6") && pd.GetInt("health") == 1) {
        multiplier *= 1.75f;
    }
    
    // 萨满之石
    if (pd.GetBool("equippedCharm_19")) {
        multiplier *= 1.5f;  // 法术伤害
    }
    
    return multiplier;
}
```

### 灵魂获取计算

```csharp
int CalculateSoulGain(bool isMainSoulFull) {
    int baseSoul = isMainSoulFull ? 6 : 11;
    var pd = PlayerData.instance;
    
    if (pd.GetBool("equippedCharm_20")) {
        baseSoul += isMainSoulFull ? 2 : 3;  // 灵魂捕手
    }
    
    if (pd.GetBool("equippedCharm_21")) {
        baseSoul += isMainSoulFull ? 6 : 8;  // 噬魂者
    }
    
    return baseSoul;
}
```

### 相机锁定模式

Boss 战期间锁定相机位置和缩放：

```csharp
private static readonly FieldInfo xLockField = typeof(CameraController)
    .GetField("xLockPos", BindingFlags.Instance | BindingFlags.NonPublic);
private static readonly FieldInfo yLockField = typeof(CameraController)
    .GetField("yLockPos", BindingFlags.Instance | BindingFlags.NonPublic);

void LockCamera(float x, float y, float zoom = 1.0f) {
    var camCtrl = GameCameras.instance.cameraController;
    camCtrl.mode = CameraController.CameraMode.FROZEN;
    camCtrl.transform.position = new Vector3(x, y, camCtrl.transform.position.z);
    
    xLockField?.SetValue(camCtrl, x);
    yLockField?.SetValue(camCtrl, y);
    
    if (GameCameras.instance.tk2dCam != null) {
        GameCameras.instance.tk2dCam.ZoomFactor = zoom;
    }
}
```

### 输入轴读取

使用 Input.GetAxisRaw 读取玩家输入：

```csharp
float horizontal = Input.GetAxisRaw("Horizontal");
float vertical = Input.GetAxisRaw("Vertical");

// 用于 Boss 攻击方向判断
if (horizontal > 0.5f) {
    // 玩家向右移动
}
```

### 加权随机选择

Boss 攻击模式的加权随机选择：

```csharp
public class RandomSelector<T> {
    private List<(T item, float weight)> options = new();
    
    public void Add(T item, float weight) {
        options.Add((item, weight));
    }
    
    public T Select() {
        float totalWeight = options.Sum(o => o.weight);
        float random = UnityEngine.Random.Range(0f, totalWeight);
        float current = 0f;
        
        foreach (var (item, weight) in options) {
            current += weight;
            if (random <= current) return item;
        }
        
        return options[0].item;
    }
}

// 使用示例
var attackSelector = new RandomSelector<string>();
attackSelector.Add("ChargeAttack", 30f);
attackSelector.Add("GroundAttack", 25f);
attackSelector.Add("Shots", 25f);
attackSelector.Add("Suck", 20f);

var selectedAttack = attackSelector.Select();
```

### 平滑移动模式

使用 Vector2.SmoothDamp 平滑敌人移动：

```csharp
Vector2 velocity = Vector2.zero;
float smoothTime = 0.3f;

void Update() {
    Vector2 targetPosition = GetTargetPosition();
    transform.position = Vector2.SmoothDamp(
        transform.position, 
        targetPosition, 
        ref velocity, 
        smoothTime
    );
}
```

### 难度分级模式

技能根据 Boss 血量阈值分级（1-3 级）：

```csharp
int GetSkillLevel(float currentHP, float maxHP) {
    float hpPercent = currentHP / maxHP;
    
    if (hpPercent <= 0.33f) return 3;  // 狂暴阶段
    if (hpPercent <= 0.66f) return 2;  // 中期阶段
    return 1;  // 初期阶段
}

// 使用示例
int skillLevel = GetSkillLevel(bossHP, maxBossHP);
switch (skillLevel) {
    case 1:
        // 使用基础技能
        break;
    case 2:
        // 使用进阶技能
        break;
    case 3:
        // 使用狂暴技能
        break;
}
```

### 精灵加载模式

从嵌入资源加载精灵：

```csharp
Sprite LoadSpriteFromAssembly(string resourceName, float pixelsPerUnit = 100f) {
    var assembly = Assembly.GetExecutingAssembly();
    using var stream = assembly.GetManifestResourceStream(resourceName);
    using var memoryStream = new MemoryStream();
    stream.CopyTo(memoryStream);
    
    Texture2D texture = new Texture2D(2, 2);
    texture.LoadImage(memoryStream.ToArray());
    
    return Sprite.Create(texture, 
        new Rect(0, 0, texture.width, texture.height), 
        new Vector2(0.5f, 0.5f), 
        pixelsPerUnit);
}
```

### 精灵表加载

从嵌入资源加载精灵表：

```csharp
Sprite[] LoadSpriteSheet(string resourceName, int frameWidth, int frameHeight) {
    var texture = LoadTextureFromAssembly(resourceName);
    
    int cols = texture.width / frameWidth;
    int rows = texture.height / frameHeight;
    int totalFrames = cols * rows;
    
    Sprite[] sprites = new Sprite[totalFrames];
    for (int i = 0; i < totalFrames; i++) {
        int col = i % cols;
        int row = i / cols;
        
        sprites[i] = Sprite.Create(texture,
            new Rect(col * frameWidth, row * frameHeight, frameWidth, frameHeight),
            new Vector2(0.5f, 0.5f));
    }
    
    return sprites;
}
```

### 预加载对象提取

从预加载对象中提取特定 GameObject：

```csharp
public override List<(string, string)> GetPreloadNames() {
    return new List<(string, string)> {
        ("GG_Radiance", "Boss Control/Absolute Radiance"),
        ("Tutorial_01", "_Enemies/Buzzer"),
    };
}

public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects) {
    // 提取预加载对象
    var radiance = preloadedObjects["GG_Radiance"]["Boss Control/Absolute Radiance"];
    var fsm = radiance.LocateMyFSM("Attack Commands");
    
    // 从 FSM 中提取预制体
    var prefab = fsm.GetAction<SpawnObjectFromGlobalPool>("Comb Top", 0).gameObject.Value;
}
```

### Hook 注入模式

在 Mod.Initialize() 中注册 On Hooks：

```csharp
public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects) {
    // On Hooks
    On.HeroController.Attack += HeroController_Attack;
    On.PlayMakerFSM.OnEnable += PlayMakerFSM_OnEnable;
    
    // ModHooks
    ModHooks.LanguageGetHook += LanguageGet_Hook;
    ModHooks.HeroUpdateHook += HeroUpdate_Hook;
}
```

### Hook 拦截模式

使用 On Hooks 拦截和修改游戏逻辑：

```csharp
// 拦截攻击输入
private void HeroController_Attack(On.HeroController.orig_Attack orig, 
    HeroController self, AttackDirection dir) {
    
    // 修改攻击行为
    if (customAttackMode) {
        FireCustomProjectile(self, dir);
        return;  // 不调用原始方法
    }
    
    orig(self, dir);  // 调用原始方法
}

// 拦截 FSM 启用
private void PlayMakerFSM_OnEnable(On.PlayMakerFSM.orig_OnEnable orig, 
    PlayMakerFSM self) {
    
    if (self.gameObject.name == "Boss" && self.FsmName == "Control") {
        // 注入自定义逻辑
        InjectCustomAction(self, "Idle");
    }
    
    orig(self);
}
```

### IL Hook 注入

使用 ILCursor 注入自定义逻辑：

```csharp
private void IL_Hook(ILContext il) {
    var cursor = new ILCursor(il);
    
    // 查找目标指令
    if (cursor.TryGotoNext(MoveType.After,
        x => x.MatchLdarg(0),
        x => x.MatchCall<PlayerData>("GetInt"))) {
        
        // 注入自定义逻辑
        cursor.Emit(OpCodes.Ldarg_0);
        cursor.EmitDelegate<Func<int, int>>(ModifyValue);
    }
}

private int ModifyValue(int original) {
    return original * 2;  // 自定义修改逻辑
}
```

### 菜单集成模式

创建游戏内 Mod 配置菜单：

```csharp
public class ModClass : Mod, IGlobalSettings<Settings>, IMenuMod {
    public bool ToggleButtonInsideMenu => true;
    
    public MenuScreen GetMenuScreen(MenuScreen modListScreen, Func<MenuScreen> navigation) {
        var builder = new ScreenBuilder("ModName");
        
        builder.BindOptionToggle("Enable Feature", 
            (cfg) => cfg.Enabled, 
            (cfg, val) => cfg.Enabled = val);
        
        return builder.Build(navigation, modListScreen);
    }
}
```

### 设置持久化模式

使用 IGlobalSettings 实现设置持久化：

```csharp
public class ModClass : Mod, IGlobalSettings<Settings> {
    private Settings settings = new();
    
    public Settings GetGlobalSettings() => settings;
    
    public void SetGlobalSettings(Settings s) => settings = s;
}

[Serializable]
public class Settings {
    public bool Enabled { get; set; } = true;
    public float Difficulty { get; set; } = 1.0f;
}
```

### LocateMyFSM 扩展方法

在 GameObject 上按名称查找 PlayMakerFSM：

```csharp
public static class FSMUtility {
    public static PlayMakerFSM LocateMyFSM(this GameObject go, string fsmName) {
        foreach (var fsm in go.GetComponents<PlayMakerFSM>()) {
            if (fsm.FsmName == fsmName) return fsm;
        }
        return null;
    }
    
    public static void SendEventToGameObject(GameObject go, string eventName, bool requireReceiver = false) {
        foreach (var fsm in go.GetComponents<PlayMakerFSM>()) {
            fsm.SendEvent(eventName);
        }
    }
}

// 使用示例
var fsm = bossGameObject.LocateMyFSM("Control");
fsm?.SendEvent("START");
```

### 工具类扩展方法

扩展方法，将组件属性复制到另一个对象：

```csharp
public static class ComponentExtensions {
    public static T CopyOnto<T>(this T source, GameObject target) where T : Component {
        var copy = target.AddComponent<T>();
        
        // 复制属性
        foreach (var prop in typeof(T).GetProperties()) {
            if (prop.CanWrite) {
                prop.SetValue(copy, prop.GetValue(source));
            }
        }
        
        return copy;
    }
}
```

### 亮度调整工具

通过修改材质调整 GameObject 亮度：

```csharp
public static class BrightnessUtil {
    public static void SetBrightness(GameObject go, float brightness) {
        var renderer = go.GetComponent<SpriteRenderer>();
        if (renderer != null) {
            var color = renderer.color;
            color.a = brightness;
            renderer.color = color;
        }
    }
}
```

### 回调注册系统

GameMapHooks.Init 接受回调注册自定义区域：

```csharp
GameMapHooks.Init += () => {
    // 注册自定义区域
    CustomRegions.Register("WHITE_PALACE", new CustomRegion {
        BackgroundMusic = "wp_music",
        AmbientLight = Color.white
    });
};
```

### IHitResponder 接口

自定义接口处理平台上的命中事件：

```csharp
public interface IHitResponder {
    void OnHit(HitInstance hit);
    bool CanBeHit();
}

// 实现示例
public class CustomPlatform : MonoBehaviour, IHitResponder {
    public void OnHit(HitInstance hit) {
        // 处理命中逻辑
        TakeDamage(hit.DamageDealt);
    }
    
    public bool CanBeHit() {
        return !isInvincible;
    }
}
```

### 输入管理器

使用 ContinuousInput 和 InputBuffer 的自定义输入管理：

```csharp
public class InputManager : MonoBehaviour {
    private Queue<InputAction> inputBuffer = new();
    private float inputWindow = 0.2f;  // 输入窗口（秒）
    
    void Update() {
        // 缓冲输入
        if (Input.GetKeyDown(KeyCode.Z)) {
            inputBuffer.Enqueue(new InputAction {
                Type = ActionType.Jump,
                Time = Time.time
            });
        }
        
        // 处理缓冲输入
        ProcessBufferedInputs();
    }
    
    private void ProcessBufferedInputs() {
        while (inputBuffer.Count > 0) {
            var action = inputBuffer.Peek();
            if (Time.time - action.Time > inputWindow) {
                inputBuffer.Dequeue();  // 超时移除
            } else {
                ExecuteAction(action);
                break;
            }
        }
    }
}
```

### 水面物理模拟

基于弹簧的水面模拟，带扩散效果：

```csharp
public class WaterPhysics : MonoBehaviour {
    private float[] springs;
    private float[] velocities;
    private float tension = 0.025f;
    private float dampening = 0.025f;
    private float spread = 0.05f;
    
    void Start() {
        springs = new float[width];
        velocities = new float[width];
    }
    
    void Update() {
        // 弹簧物理
        for (int i = 0; i < width; i++) {
            float x = springs[i];
            velocities[i] = tension * x - velocities[i] * dampening;
            springs[i] -= velocities[i];
        }
        
        // 扩散效果
        float[] leftDeltas = new float[width];
        float[] rightDeltas = new float[width];
        
        for (int j = 0; j < 8; j++) {
            for (int i = 0; i < width; i++) {
                if (i > 0) leftDeltas[i] = spread * (springs[i] - springs[i - 1]);
                if (i < width - 1) rightDeltas[i] = spread * (springs[i] - springs[i + 1]);
            }
            
            for (int i = 0; i < width; i++) {
                if (i > 0) springs[i - 1] += leftDeltas[i];
                if (i < width - 1) springs[i + 1] += rightDeltas[i];
            }
        }
    }
}
```
