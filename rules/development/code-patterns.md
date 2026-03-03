# Code Patterns Reference

## 概述

本文档整理了常见的代码模式和最佳实践。

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
| **状态机模式** | | |
| EntityStateMachine | 使用 RingLib 的自定义状态机，带 [State] 属性 | 见下方详细说明 |
| Coroutine-based Transitions | 使用 WaitFor, WaitTill, ToState 进行状态过渡 | 见下方详细说明 |
| SkillPhases Pattern | 将技能逻辑封装为 Appear/Loop/Disappear 阶段 | 见下方详细说明 |
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
| Skill Usage Balancing | 追踪技能使用次数，偏好最少使用的技能 | 见下方详细说明 |
| **工具类** | | |
| LocateMyFSM | 在 GameObject 上按名称查找 PlayMakerFSM 的扩展方法 | 见下方详细说明 |
| CopyOnto<T> | 扩展方法，将组件属性复制到另一个对象 | 见下方详细说明 |
| Brightness Util | 通过修改材质调整 GameObject 亮度 | 见下方详细说明 |
| Callback System | GameMapHooks.Init 接受回调注册自定义区域 | 见下方详细说明 |
| IHitResponder Interface | 自定义接口处理平台上的命中事件 | 见下方详细说明 |
| Input Manager | 使用 ContinuousInput 和 InputBuffer 的自定义输入管理 | 见下方详细说明 |
| RingLib State Machine | 带状态集合的自定义状态机库 | 见下方详细说明 |
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

### EntityStateMachine 模式

使用 RingLib 的自定义状态机：

```csharp
internal class CustomStateMachine : EntityStateMachine {
    public CustomStateMachine() : base(
        startState: nameof(Idle),
        globalTransitions: new Dictionary<Type, string>(),
        terrainLayer: "terrain") { }
    
    [State]
    private IEnumerator<Transition> Idle() {
        yield return new WaitTill(() => playerDetected);
        yield return new ToState { State = nameof(Chase) };
    }
}
```

### 协程过渡模式

使用协程进行状态过渡：

```csharp
[State]
private IEnumerator<Transition> Attack() {
    PlayAnimation("attack");
    yield return new WaitFor(0.5f);
    
    if (playerInRange) {
        DealDamage();
    }
    
    yield return new ToState { State = nameof(Idle) };
}
```

### SkillPhases 模式

将技能逻辑封装为三个阶段：

```csharp
private IEnumerator<Transition> Appear() {
    // 出现动画
    yield return new WaitFor(1.0f);
    yield return new ToState { State = nameof(Loop) };
}

[State]
private IEnumerator<Transition> Loop() {
    // 循环行为
    while (true) {
        UseSkill();
        yield return new WaitFor(2.0f);
    }
}

private IEnumerator<Transition> Disappear() {
    // 消失动画
    yield return new WaitFor(1.0f);
    yield return new ToState { State = nameof(Idle) };
}
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

### 加权随机选择

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

### Hook 注入模式

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

### 菜单集成模式

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

### LocateMyFSM 扩展方法

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
```
