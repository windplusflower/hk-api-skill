"""Runtime dependency / environment checks for hk-api scripts.

Each check writes a clear, actionable diagnostic to stderr and raises
SystemExit on failure. Callers (Claude / shell users) see the message
and decide whether to install or reconfigure before retrying.

These checks are intentionally NOT advertised at skill entry — they
fire only when a script that genuinely needs them is invoked.
"""
from __future__ import annotations

import importlib.util
import os
import sys
from pathlib import Path

DEFAULT_HK_DATA = Path(r"D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data")
HK_DATA_ENV = "HK_DATA_DIR"


def _die(msg: str) -> "SystemExit":
    print(msg, file=sys.stderr)
    return SystemExit(2)


def check_unitypy(min_version: str = "1.20") -> None:
    """Verify UnityPy is importable. Exit with install instructions otherwise."""
    if importlib.util.find_spec("UnityPy") is None:
        raise _die(
            "ERROR: UnityPy is not installed.\n\n"
            "This script needs UnityPy to parse Hollow Knight's Unity\n"
            "SerializedFiles (the levelN files under hollow_knight_Data/).\n\n"
            "Install (one-time):\n"
            f"    {sys.executable} -m pip install 'UnityPy>={min_version}'\n\n"
            "Tested with UnityPy 1.25 on Python 3.13. If you cannot or do\n"
            "not want to install it, the static data in fsm-export/ and\n"
            "scene-index/ is still queryable without this script."
        )


def _is_hk_data(path: Path) -> bool:
    return path.is_dir() and (path / "globalgamemanagers").is_file()


def resolve_hk_data() -> Path:
    """Return the Hollow Knight data dir, or exit with guidance.

    Resolution rules:
      1. If ``$HK_DATA_DIR`` is set, that path *must* be a valid HK install
         dir (contains ``globalgamemanagers``). Wrong env values fail loudly
         instead of silently falling back — explicit user intent should not
         be ignored.
      2. Otherwise, use the hard-coded default and require it to be valid.
    """
    env_val = os.environ.get(HK_DATA_ENV, "").strip()
    if env_val:
        path = Path(env_val)
        if _is_hk_data(path):
            return path
        raise _die(
            f"ERROR: ${HK_DATA_ENV} is set but does not point at a Hollow Knight install.\n\n"
            f"  ${HK_DATA_ENV} = {env_val}\n"
            f"  Expected file: {path / 'globalgamemanagers'}\n\n"
            "Either point the env var at a valid hollow_knight_Data/ dir,\n"
            f"or unset it to fall back to the default ({DEFAULT_HK_DATA})."
        )

    if _is_hk_data(DEFAULT_HK_DATA):
        return DEFAULT_HK_DATA

    raise _die(
        "ERROR: Hollow Knight install not found.\n\n"
        "This script reads the local game's Unity SerializedFiles\n"
        "(globalgamemanagers, levelN, ...) under hollow_knight_Data/.\n\n"
        f"Default checked: {DEFAULT_HK_DATA}\n\n"
        f"Fix: set the {HK_DATA_ENV} env var to the absolute path of\n"
        "hollow_knight_Data on this machine, e.g. (PowerShell):\n\n"
        f"    $env:{HK_DATA_ENV} = 'D:/SteamLibrary/steamapps/common/Hollow Knight/hollow_knight_Data'\n\n"
        "or (bash):\n\n"
        f"    export {HK_DATA_ENV}='/path/to/hollow_knight_Data'\n\n"
        "Static data in fsm-export/ and scene-index/scene-objects.tsv\n"
        "remains queryable without this script — only rebuild and\n"
        "single-GO dump operations need a local install."
    )
