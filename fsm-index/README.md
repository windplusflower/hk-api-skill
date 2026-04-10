# FSM Index

这一目录是 `fsm-export/` 的导航层，方便在不全量翻目录的情况下定位 Hollow Knight 的 PlayMaker FSM 导出文件。

## Contents

- [`fsm-manifest.tsv`](./fsm-manifest.tsv): 2743 条 FSM 索引，字段为 `group, scene, gameobject_segment, fsm_name, fsm_id, relative_path`。
- [`scene-summary.md`](./scene-summary.md): 按大区域和场景汇总 FSM 数量，并给出代表性链接。
- [`boss-shortcuts.md`](./boss-shortcuts.md): 常见 Boss / 战斗场景的快速入口。

## Dataset

- Source root: [`../fsm-export/`](../fsm-export/)
- Total FSM files: 2743
- Total groups: 23
- Total scenes: 161

## Manifest Columns

| Column | Meaning |
| --- | --- |
| `group` | 大区域分组，例如 `Greenpath`、`Dreams`、`Godhome`。 |
| `scene` | 场景名，通常对应 Unity scene / assets 导出目录。 |
| `gameobject_segment` | 文件名前半段，对应导出时的 GameObject 路径片段。 |
| `fsm_name` | FSM 名。查 `LocateMyFSM(...)` 时通常先看这一列。 |
| `fsm_id` | PlayMaker FSM PathId，用于唯一定位同名实例。 |
| `relative_path` | 相对 `fsm-export/` 根目录的 Markdown 路径。 |

## Query Workflow

1. 已知 Boss / 战斗场景：先看 [`boss-shortcuts.md`](./boss-shortcuts.md)。
2. 已知场景但不知道文件名：先看 [`scene-summary.md`](./scene-summary.md)，再进入对应导出文件。
3. 已知 GameObject 或 FSM 名：直接在 [`fsm-manifest.tsv`](./fsm-manifest.tsv) 上做文本搜索。
4. 需要动作、变量、状态细节：打开 `../fsm-export/<group>/<scene>/<file>.md`。

## Example Searches

```bash
rg -n $'\tControl\t' /home/windflower/.codex/skills/hk-api/fsm-index/fsm-manifest.tsv
rg -n 'Hornet|Grimm|Radiance' /home/windflower/.codex/skills/hk-api/fsm-index/fsm-manifest.tsv
rg -n '^Godhome\tGG_Hornet_1\t' /home/windflower/.codex/skills/hk-api/fsm-index/fsm-manifest.tsv
```