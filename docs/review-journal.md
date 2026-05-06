# Review Journal

The repository goal stays the same: create a C# reference implementation for infection workflows, centered on incremental indexing, append-only fixtures, and checkpoint recovery checks. This note explains the added review angle.

The local checks classify each case as `ship`, `watch`, or `hold`. That gives the project a small review vocabulary that matches its simulations focus without claiming live deployment or external usage.

## Cases

- `baseline`: `input pressure`, score 172, lane `ship`
- `stress`: `state drift`, score 134, lane `watch`
- `edge`: `review cost`, score 155, lane `ship`
- `recovery`: `decision risk`, score 242, lane `ship`
- `stale`: `input pressure`, score 193, lane `ship`

## Note

The useful failure mode here is a wrong decision on a named case, not a vague style disagreement.
