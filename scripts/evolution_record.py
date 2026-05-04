#!/usr/bin/env python3

import argparse
import datetime as dt
import hashlib
import re
from pathlib import Path


def slugify(value: str) -> str:
    slug = re.sub(r"[^a-zA-Z0-9]+", "-", value.strip().lower())
    slug = slug.strip("-")
    return slug or "evolution"


def require_rules_target(repo_root: Path, target_rel: str) -> Path:
    target = (repo_root / target_rel).resolve()
    rules_root = (repo_root / "rules").resolve()
    if rules_root != target and rules_root not in target.parents:
        raise ValueError("--target must be inside rules/")
    return target


def read_text(path: Path) -> str:
    return path.read_text(encoding="utf-8") if path.exists() else ""


def write_text(path: Path, content: str) -> None:
    path.parent.mkdir(parents=True, exist_ok=True)
    path.write_text(content, encoding="utf-8")


def append_text(path: Path, content: str) -> None:
    path.parent.mkdir(parents=True, exist_ok=True)
    with path.open("a", encoding="utf-8") as f:
        f.write(content)


def make_marker(target_rel: str, question: str, facts: list[str], sources: list[str]) -> str:
    raw = "\n".join([target_rel, question, *facts, *sources])
    digest = hashlib.sha1(raw.encode("utf-8")).hexdigest()[:12]
    return f"<!-- evolution:{digest} -->"


def ensure_log_header(log_path: Path) -> None:
    if log_path.exists() and log_path.stat().st_size > 0:
        return
    write_text(
        log_path,
        "# Skill Evolution Log\n\nTracks fallback-to-source learning events and rule updates.\n\n",
    )


def build_note_doc(
    now: dt.datetime,
    question: str,
    target_rel: str,
    risk: str,
    facts: list[str],
    sources: list[str],
    marker: str,
) -> str:
    heading = "Pending Evolution" if risk == "high" else "Evolution Note"
    status = "pending review" if risk == "high" else "applied to target rule"
    lines = [
        f"# {heading} - {now.strftime('%Y-%m-%d %H:%M:%S')}",
        "",
        f"- Question: {question}",
        f"- Target: `{target_rel}`",
        f"- Risk: `{risk}`",
        f"- Status: `{status}`",
        f"- Marker: `{marker}`",
        "",
        "## Learned Facts",
        "",
    ]
    lines.extend([f"- {fact}" for fact in facts])
    lines.extend(["", "## Sources", ""])
    lines.extend([f"- `{source}`" for source in sources])
    lines.append("")
    return "\n".join(lines)


def append_rule_block(
    target_path: Path,
    now: dt.datetime,
    question: str,
    facts: list[str],
    sources: list[str],
    marker: str,
) -> bool:
    current = read_text(target_path)
    if marker in current:
        return False

    block_lines = [
        "",
        f"### Fallback Learning ({now.strftime('%Y-%m-%d')})",
        marker,
        f"- Question: {question}",
        "- Facts:",
    ]
    block_lines.extend([f"  - {fact}" for fact in facts])
    block_lines.append("- Sources:")
    block_lines.extend([f"  - `{source}`" for source in sources])
    block_lines.append("")

    if current and not current.endswith("\n"):
        current += "\n"
    new_content = current + "\n".join(block_lines)
    write_text(target_path, new_content)
    return True


def append_log(
    log_path: Path,
    now: dt.datetime,
    question: str,
    target_rel: str,
    risk: str,
    note_rel: str,
    applied: bool,
) -> None:
    status = "applied" if applied else "pending"
    entry = [
        f"## {now.strftime('%Y-%m-%d %H:%M:%S')}",
        f"- question: {question}",
        f"- target: `{target_rel}`",
        f"- risk: `{risk}`",
        f"- note: `{note_rel}`",
        f"- status: `{status}`",
        "",
    ]
    append_text(log_path, "\n".join(entry))


def main() -> int:
    parser = argparse.ArgumentParser(
        description="Record fallback learning and update hk_api rules."
    )
    parser.add_argument("--question", required=True)
    parser.add_argument("--target", required=True, help="Path under rules/")
    parser.add_argument("--fact", action="append", required=True)
    parser.add_argument("--source", action="append", required=True)
    parser.add_argument("--risk", choices=["low", "high"], default="low")
    args = parser.parse_args()

    script_path = Path(__file__).resolve()
    repo_root = script_path.parent.parent
    now = dt.datetime.now()

    target_path = require_rules_target(repo_root, args.target)
    target_rel = target_path.relative_to(repo_root).as_posix()

    marker = make_marker(target_rel, args.question, args.fact, args.source)

    note_dir_name = "_pending" if args.risk == "high" else "evolution-notes"
    note_dir = repo_root / "rules" / note_dir_name
    note_name = f"{now.strftime('%Y%m%d_%H%M%S')}_{slugify(args.question)[:60]}.md"
    note_path = note_dir / note_name
    note_rel = note_path.relative_to(repo_root).as_posix()

    note_doc = build_note_doc(
        now,
        args.question,
        target_rel,
        args.risk,
        args.fact,
        args.source,
        marker,
    )
    write_text(note_path, note_doc)

    applied = False
    if args.risk == "low":
        applied = append_rule_block(
            target_path,
            now,
            args.question,
            args.fact,
            args.source,
            marker,
        )

    log_path = repo_root / "EVOLUTION_LOG.md"
    ensure_log_header(log_path)
    append_log(
        log_path,
        now,
        args.question,
        target_rel,
        args.risk,
        note_rel,
        applied,
    )

    print(f"note: {note_rel}")
    print(f"rule updated: {'yes' if applied else 'no'}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
