import json
import os


def main() -> None:
    raw = os.environ.get("PIPELINES_JSON") or "{}"
    slug = os.environ.get("CIRCLECI_SLUG") or ""
    merge_sha = os.environ.get("MERGE_SHA") or ""

    try:
        data = json.loads(raw)
    except Exception:
        print("")
        return

    for item in data.get("items") or []:
        vcs = item.get("vcs") or {}
        if (vcs.get("revision") or "") == merge_sha:
            number = item.get("number")
            if number is not None:
                print(f"https://app.circleci.com/pipelines/github/{slug}/{number}")
                return

    print("")


if __name__ == "__main__":
    main()
