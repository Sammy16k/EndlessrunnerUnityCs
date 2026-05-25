# EndlessrunnerUnityCs
#Endless Runner lowploy 3d

An action-packed, slow-paced 3D endless runner game built using Unity. Navigate through an ever-changing forest. 

## 🚀 Key Feature 
makes left turn

## 🛠️ Architecture & Core Mechanics

The codebase follows modular, object-oriented design patterns to ensure scalability and ease of extension:
1.  **UI & Canvas Manager:** Responsively handles real-time HUD overlays (score, distance)

---

## 📦 Installation & Setup

Follow these steps to open and run the project locally in Unity:

### Prerequisites
* **Unity Hub** installed.
* **Unity 2022.3 LTS** (or newer) recommended.

### Steps
1.  **Clone the Repository:**
    ```bash
    git clone [https://github.com/YOUR_USERNAME/neon-runner-3d.git](https://github.com/YOUR_USERNAME/neon-runner-3d.git)
    ```
2.  **Open in Unity:**
    * Launch *Unity Hub*.
    * Click **Add** -> **Add project from disk**.
    * Select the cloned `neon-runner-3d` folder.
    * Select the appropriate Unity Editor version.
3.  **Launch the Game:**
    * In the Project window, navigate to `Assets > Scenes`.
    * Open `MainMenu.unity` or `Gameplay.unity`.
    * Press the **Play** button at the top of the editor.

---

## 🕹️ Controls

| Desktop Layout |
| **Move Left** | `A` or `Left Arrow` | Swipe Left |
| **Move Right**| `D` or `Right Arrow`| Swipe Right |

---

## 🎨 Asset Modification & Extension

Want to personalize or expand the game? It's designed to be easily extensible:

* **Adding Track Pieces:** Design a new track segment prefab with obstacles, ensure it includes entry and exit snap-points, and add it to the `TrackSpawner` prefab list array in the Inspector.
* **Adjusting Game Balance:** Locate the `GameSettings` ScriptableObject to instantly tweak base player speed, acceleration multiplier, obstacle spawn rates, and scoring curves without touching code.
## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request or open an issue for bug fixes, performance optimizations, or feature suggestions.


<img width="1155" height="548" alt="image" src="https://github.com/user-attachments/assets/303556f8-0c5e-4f71-8cfd-f70a49056ab7" />
