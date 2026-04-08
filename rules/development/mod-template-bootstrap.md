# Hollow Knight Mod Template Bootstrap

用于指导 AI 在空目录中创建一个可编译、可安装的 Hollow Knight Mod 模板。

## 最小目录结构

```text
MyMod/
├── MyMod.csproj
├── MyMod.cs
├── README.md
└── assets/
```

## 必需步骤

1. 创建 `net472` SDK 风格项目
2. 添加 HK 引用（`Assembly-CSharp`、`UnityEngine.*`、`PlayMaker`、`MMHOOK_*`）
3. 实现 `Mod` 主类（含 settings + menu）
4. 配置构建后安装到 `Managed/Mods/<ModName>`
5. 写明重命名点与构建说明

## GameDir 路径策略

当已确认用户机器的 `Managed` 路径时，优先将绝对路径直接写入 `.csproj` 的 `GameDir`。

- 单人本地模板开发优先固定 `GameDir`
- 仅在路径未知时再使用 `HK_GAME_DIR` 或 `-p:GameDir=...` 作为备用

## 常见特化清理

1. 清理命名残留（项目名、类名、命名空间）
2. 将特定场景/FSM 示例改为通用占位
3. 将 Satchel/RingLib 标注为可选依赖
