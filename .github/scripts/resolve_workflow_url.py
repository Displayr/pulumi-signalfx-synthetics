import json
import os
import re


def main() -> None:
    raw = os.environ.get("RUNS_JSON") or "{}"
    base_ref = os.environ.get("BASE_REF") or ""
    name_re = (
        os.environ.get("WORKFLOW_NAME_REGEX")
        or os.environ.get("PULUMI_WORKFLOW_REGEX")
        or "pulumi|deploy|build"
    )

    try:
        data = json.loads(raw)
    except Exception:
        print("")
        return

    runs = data.get("workflow_runs") or []
    if not runs:
        print("")
        return

    def branch_ok(run):
        branch = (run.get("head_branch") or "")
        return (not base_ref) or (branch == base_ref)

    regex = re.compile(name_re, re.IGNORECASE)

    def run_started(run):
        return (run.get("run_started_at") or run.get("created_at") or "")

    filtered = [r for r in runs if branch_ok(r)]
    preferred = [r for r in filtered if regex.search(r.get("name") or "")]

    candidate = None
    if preferred:
        candidate = sorted(preferred, key=run_started, reverse=True)[0]
    elif filtered:
        candidate = sorted(filtered, key=run_started, reverse=True)[0]

    print((candidate or {}).get("html_url", ""))


if __name__ == "__main__":
    main()
