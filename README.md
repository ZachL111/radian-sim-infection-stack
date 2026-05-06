# radian-sim-infection-stack

`radian-sim-infection-stack` keeps a focused C# implementation around simulations. The project goal is to create a C# reference implementation for infection workflows, centered on incremental indexing, append-only fixtures, and checkpoint recovery checks.

## Why This Exists

This is intentionally local and self-contained so it can be inspected without credentials, services, or seeded history.

## Radian Sim Infection Stack Review Notes

The first comparison I would make is `decision risk` against `state drift` because it shows where the rule is most opinionated.

## Capabilities

- `fixtures/domain_review.csv` adds cases for input pressure and state drift.
- `metadata/domain-review.json` records the same cases in structured form.
- `config/review-profile.json` captures the read order and the two review questions.
- `examples/radian-sim-infection-walkthrough.md` walks through the case spread.
- The C# code includes a review path for `decision risk` and `state drift`.
- `docs/field-notes.md` explains the strongest and weakest cases.

## Implementation Shape

The core code exposes a scoring path and the added review layer uses `signal`, `slack`, `drag`, and `confidence`. The domain terms are `input pressure`, `state drift`, `review cost`, and `decision risk`.

The C# code keeps the review rule close to the tests.

## Local Usage

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

## Verification

The verifier is intentionally local. It should fail if the fixture score math, lane assignment, or language-specific test drifts.

## Roadmap

This remains a local project with deterministic fixtures. It does not depend on credentials, hosted services, or live data. Future work should add richer malformed inputs before widening the public API.
