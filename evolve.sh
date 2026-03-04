#!/bin/bash

# Skill 自动进化脚本
# 当检测到知识不足时，自动查阅源码并更新 skill 文档

set -e

SKILL_DIR="/home/windflower/.openclaw/workspace/HollowKnight/hk-api-skill"
HKAPI_DIR="$SKILL_DIR/hkapi"
RULES_DIR="$SKILL_DIR/rules"
EVOLUTION_LOG="$SKILL_DIR/EVOLUTION_LOG.md"

echo "=== Skill 自动进化脚本 ==="
echo "执行时间：$(date)"

# 1. 读取需要查询的关键词（从参数或输入）
SEARCH_TERM="${1:-$2}"

if [ -z "$SEARCH_TERM" ]; then
    echo "用法：$0 <搜索关键词>"
    exit 1
fi

echo "搜索关键词：$SEARCH_TERM"

# 2. 检查 skill 文档中是否已有相关知识
echo "检查现有文档..."
EXISTING_INFO=$(grep -r "$SEARCH_TERM" "$RULES_DIR" --include="*.md" 2>/dev/null | head -20 || echo "")

if [ -n "$EXISTING_INFO" ]; then
    echo "✓ 找到相关信息："
    echo "$EXISTING_INFO" | head -5
else
    echo "⚠ 文档中没有相关信息，需要查阅源码"
fi

# 3. 查阅 hkapi 源码
echo "查阅 hkapi 源码..."
SOURCE_FILES=$(find "$HKAPI_DIR" -name "*.cs" -exec grep -l "class $SEARCH_TERM\|public.*$SEARCH_TERM" {} \; 2>/dev/null | head -10)

if [ -z "$SOURCE_FILES" ]; then
    echo "❌ 源码中未找到相关信息"
    exit 1
fi

echo "找到以下文件："
echo "$SOURCE_FILES"

# 4. 提取关键信息
echo "提取关键信息..."
EXTRACTED_INFO=""

for file in $SOURCE_FILES; do
    echo "分析：$file"
    
    # 提取类定义
    CLASS_DEF=$(grep -A 20 "class $SEARCH_TERM" "$file" 2>/dev/null || echo "")
    if [ -n "$CLASS_DEF" ]; then
        EXTRACTED_INFO="$EXTRACTED_INFO\n\n### 类定义 ($(basename $file))\n\`\`\`csharp\n$CLASS_DEF\n\`\`\`"
    fi
    
    # 提取公共方法
    PUBLIC_METHODS=$(grep "public.*(" "$file" 2>/dev/null | grep -v "override\|interface" | head -10 || echo "")
    if [ -n "$PUBLIC_METHODS" ]; then
        EXTRACTED_INFO="$EXTRACTED_INFO\n\n### 公共方法\n\`\`\`csharp\n$PUBLIC_METHODS\n\`\`\`"
    fi
    
    # 提取公共属性
    PUBLIC_PROPS=$(grep "public.*{.*get" "$file" 2>/dev/null | head -10 || echo "")
    if [ -n "$PUBLIC_PROPS" ]; then
        EXTRACTED_INFO="$EXTRACTED_INFO\n\n### 公共属性\n\`\`\`csharp\n$PUBLIC_PROPS\n\`\`\`"
    fi
done

# 5. 生成更新建议
UPDATE_FILE="$SKILL_DIR/pending_updates/${SEARCH_TERM}_$(date +%Y%m%d).md"
mkdir -p "$(dirname "$UPDATE_FILE")"

cat > "$UPDATE_FILE" << EOF
# $SEARCH_TERM - 知识更新建议

**生成时间**: $(date)
**源码文件**: $SOURCE_FILES

## 现有文档内容

$EXISTING_INFO

## 从源码提取的新知识

$EXTRACTED_INFO

## 建议更新

请确认是否需要将上述内容添加到 skill 文档中。

**确认命令**:
\`\`\`bash
# 接受更新
cp "$UPDATE_FILE" "$RULES_DIR/core/${SEARCH_TERM}.md"

# 或手动编辑后添加
\`\`\`
EOF

echo ""
echo "=== 知识提取完成 ==="
echo "更新建议已保存到：$UPDATE_FILE"
echo ""

# 6. 记录进化日志
cat >> "$EVOLUTION_LOG" << EOF

## $(date +%Y-%m-%d) - $SEARCH_TERM

- **搜索关键词**: $SEARCH_TERM
- **源码文件**: $SOURCE_FILES
- **状态**: ⏳ 待确认
- **更新文件**: $UPDATE_FILE

EOF

echo "进化日志已更新：$EVOLUTION_LOG"
