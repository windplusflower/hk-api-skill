# Skill 自动进化机制

## 概述

当 skill 文档中的知识不足以回答问题时，自动查阅 hkapi 源码并将新知识整合到 skill 文档中。

## 触发条件

以下情况触发自动进化：

1. **无法回答的问题** - skill 文档中没有相关信息
2. **知识不完整** - 文档中有提及但缺少关键细节
3. **发现错误** - 文档中的信息与源码不符

## 进化流程

```
1. 检测知识不足
   ↓
2. 查阅 hkapi 源码
   ↓
3. 提取新知识
   ↓
4. 对比现有文档
   ↓
5. 生成更新内容
   ↓
6. 用户确认（可选）
   ↓
7. 更新 skill 文档
   ↓
8. 记录进化日志
```

## 实现脚本

### 1. 自动进化脚本

**位置**: `evolve.sh`

**用法**:
```bash
# 搜索并提取新知识
./evolve.sh HealthManager

# 查看生成的更新建议
cat pending_updates/HealthManager_20260304.md

# 确认并应用更新
cp pending_updates/HealthManager_20260304.md rules/core/HealthManager.md
```

**功能**:
- 检查 skill 文档中是否已有相关知识
- 从 hkapi 源码中提取类定义、方法、属性
- 生成更新建议文档
- 记录进化日志

### 2. 知识检测脚本

```bash
#!/bin/bash
# 检测问题是否能从当前 skill 文档中找到答案

QUESTION="$1"
SKILL_DIR="/home/windflower/.openclaw/workspace/HollowKnight/hk-api-skill/rules"

# 搜索 skill 文档
if grep -r "$QUESTION" "$SKILL_DIR" --include="*.md" > /dev/null; then
    echo "知识已存在"
    exit 0
else
    echo "知识缺失，需要进化"
    exit 1
fi
```

### 3. 源码查阅脚本

```bash
#!/bin/bash
# 从 hkapi 源码中查找相关信息

SEARCH_TERM="$1"
HKAPI_DIR="/home/windflower/.openclaw/workspace/HollowKnight/hk-api-skill/hkapi"

# 搜索相关的类和方法
grep -r "class $SEARCH_TERM" "$HKAPI_DIR" --include="*.cs"
grep -r "public.*$SEARCH_TERM" "$HKAPI_DIR" --include="*.cs"

# 提取关键信息
# - 类定义
# - 公共方法
# - 公共属性
# - 事件
```

### 4. 知识整合脚本

```bash
#!/bin/bash
# 将新知识整合到 skill 文档

NEW KNOWLEDGE="$1"
TARGET_DOC="$2"

# 检查文档是否存在
if [ ! -f "$TARGET_DOC" ]; then
    # 创建新文档
    cat > "$TARGET_DOC" << EOF
# $NEW KNOWLEDGE

## 概述

## 使用方法

## 示例代码

## 注意事项
EOF
else
    # 追加到现有文档
    cat >> "$TARGET_DOC" << EOF

## 新增内容 - $(date +%Y-%m-%d)

$NEW KNOWLEDGE
EOF
fi
```

## 自动化配置

### OpenClaw Cron 配置

```yaml
name: skill-evolution
trigger: on_knowledge_gap
action: run_evolution_script
notify: true
```

## 进化日志

记录每次进化的详细信息：

```markdown
# Skill 进化日志

## 2026-03-04

### 进化 #1
- **触发问题**: HealthManager 需要哪些必要组件
- **查阅源码**: hkapi/HealthManager.cs
- **新增内容**: 必要组件列表、正确的添加顺序
- **更新文档**: rules/core/core-classes.md
- **状态**: ✅ 已完成
```

## 用户确认机制

### 自动确认（小改动）

- 添加代码示例
- 补充参数说明
- 修正拼写错误

### 需要确认（大改动）

- 新增整个章节
- 修改核心概念
- 删除过时内容

## 示例流程

### 场景：用户询问 HealthManager 的必要组件

1. **检测**: skill 文档中没有提到必要组件
2. **查阅**: 读取 HealthManager.cs 源码
3. **提取**: 发现需要 SpriteRenderer、tk2dSpriteAnimator 等
4. **对比**: 现有文档缺少这些信息
5. **生成**: 创建更新内容
6. **更新**: 添加到 core-classes.md
7. **记录**: 记录到进化日志

## 注意事项

1. **只添加验证过的知识** - 确保从源码中提取的信息准确
2. **保持文档结构** - 遵循现有文档格式
3. **避免重复** - 检查是否已有相同内容
4. **记录来源** - 标注知识来自哪个源码文件
