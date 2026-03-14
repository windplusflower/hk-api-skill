#!/usr/bin/env python3

import argparse
import datetime as dt
import hashlib
import re
from pathlib import Path


def slugify(value: str) -> str:
    slug = re.sub(r"[^a-zA-Z0-9]+", "-", value.strip().lower())
    return slug.strip("-") or "evolution"


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
    write_text(log_path, "# Skill Evolution Log\n\nTracks fallback-to-source learning events and rule updates.\n\n")


def main() -> int:
    parser = argparse.ArgumentParser(description="Record fallback learning and update hk_api rules.")
    parser.add_argument("--question", required=True)
    parser.add_argument("--target", required=True, help="Path under rules/")
    parser.add_argument("--fact", action="append", required=True)
    parser.add_argument("--source", action="append", required=True)
    parser.add_argument("--risk", choices=["low", "high"], default="low")
    args = parser.parse_args()

    repo_root = Path(__file__).resolve().parent.parent
    now = dt.datetime.now()
    target_path = require_rules_target(repo_root, args.target)
    target_rel = target_path.relative_to(repo_root).as_posix()
    marker = make_marker(target_rel, args.question, args.fact, args.source)

    pending_name = f"{now.strftime('%Y%m%d_%H%M%S')}_{slugify(args.question)[:60]}.md"
    pending_path = repo_root / "rules" / "_pending" / pending_name
    pending_rel = pending_path.relative_to(repo_root).as_posix()

    pending_lines = [
        f"# Pending Evolution - {now.strftime('%Y-%m-%d %H:%M:%S')}",
        "",
        f"- Question: {args.question}",
        f"- Target: `{target_rel}`",
        f"- Risk: `{args.risk}`",
        f"- Marker: `{marker}`",
        "",
        "## Learned Facts",
        "",
    ]
    pending_lines.extend([f"- {fact}" for fact in args.fact])
    pending_lines.extend(["", "## Sources", ""])
    pending_lines.extend([f"- `{source}`" for source in args.source])
    pending_lines.append("")
    write_text(pending_path, "\n".join(pending_lines))

    applied = False
    if args.risk == "low":
        current = read_text(target_path)
        if marker not in current:
            block = [
                "",
                f"### Fallback Learning ({now.strftime('%Y-%m-%d')})",
                marker,
                f"- Question: {args.question}",
                "- Facts:",
            ]
            block.extend([f"  - {fact}" for fact in args.fact])
            block.append("- Sources:")
            block.extend([f"  - `{source}`" for source in args.source])
            block.append("")
            if current and not current.endswith("\n"):
                current += "\n"
            write_text(target_path, current + "\n".join(block))
            applied = True

    ensure_log_header(repo_root / "EVOLUTION_LOG.md")
    status = "applied" if applied else "pending"
    append_text(
        repo_root / "EVOLUTION_LOG.md",
        "\n".join(
            [
                f"## {now.strftime('%Y-%m-%d %H:%M:%S')}",
                f"- question: {args.question}",
                f"- target: `{target_rel}`",
                f"- risk: `{args.risk}`",
                f"- pending_note: `{pending_rel}`",
                f"- status: `{status}`",
                "",
            ]
        ),
    )

    print(f"pending note: {pending_rel}")
    print(f"rule updated: {'yes' if applied else 'no'}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
