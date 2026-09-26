# GAME2014 Assignment 2 (Ozcan / Almeida / Asci)

**Educational mobile-development course assignment (GAME2014)** — a small 2D Unity project with menu flow, level select, parallax, and force-based movement. Repository name records the team: **Ozcan, Almeida, Asci**.

---

## What it contains

- Scene flow for **Main Menu**, **Instructions**, **Credits**, **Level Map**, **Gameplay**, and **GameOver**
- `Movement2D` Rigidbody2D force input (horizontal/vertical axes)
- `ParallaxBackground`, level/menu button helpers, and a simple `GameManager` singleton with `GameState` (LEVEL1–3)
- A `PlayerBehaviour` under `TestScript/` (separate from the lighter `Movement2D`)

**Status / limitations:** **course assignment**, not a finished commercial game. Systems are lab-scale (singleton GameManager with minimal logic, basic force movement). Unity **2022.3.45f1**. No automated tests; Editor/Play verification not re-run in this documentation pass.

## Tech stack

| Area | What it uses |
|---|---|
| Engine | **Unity** `2022.3.45f1` |
| Physics | **Rigidbody2D** force movement |
| Structure | Custom `Singleton<>` / static managers |
| UI / scenes | Multiple uGUI-driven menu and gameplay scenes |

## What's in the project

| Area | Key files |
|---|---|
| Gameplay movement / parallax / level select | `Assets/Scripts/Gameplay/Movement2D.cs`, `ParallaxBackground.cs`, `LevelSelector.cs`, `TestScript/PlayerBehaviour.cs` |
| Main menu wiring | `Assets/Scripts/MainMenu/*.cs` |
| Managers | `Assets/Scripts/StaticManagers/GameManager.cs`, `GameController.cs`, `SingletonGeneric.cs` |

Ten authored C# scripts (~9 KB). Art/prefabs accompany the scenes as typical student project content.

### Code / system highlights

- **`Movement2D`:** `FixedUpdate` applies axis-aligned forces (horizontal preferred over vertical when both pressed in the if/else structure).
- **`GameManager`:** singleton holding `GameState`; `ChooseLevel` updates the enum for level selection flow.
- **Menus:** thin button/scene helpers for navigation between the assignment’s screens.

## Scenes

| Scene | Purpose |
|---|---|
| `Assets/Scenes/MainMenuScene.unity` | Entry menu |
| `Assets/Scenes/InstructionsScene.unity` | Instructions |
| `Assets/Scenes/CreditsScene.unity` | Credits |
| `Assets/Scenes/LevelMapScene.unity` | Level select |
| `Assets/Scenes/GameplayScene.unity` | Play |
| `Assets/Scenes/GameOverScene.unity` | Game over |

## Third-party assets

Unity packages plus any sprites/audio imported for the assignment. No separate third-party license inventory is committed; treat art provenance as unverified beyond course use.

## About this repository

**Labeled educational / course work (GAME2014 Assignment 2, team Ozcan–Almeida–Asci).** Public under **PapiChulllo** for portfolio history. Not presented as a shipping title.
