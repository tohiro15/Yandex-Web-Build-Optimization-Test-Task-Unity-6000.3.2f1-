# A test assignment for the position of Unity Developer (support and optimization of Web projects for Yandex Games).

**Purpose:** porting project with the Google platform on Yandex Game with an emphasis on the optimization of the size of the build, upload speed, and proper integration of the SDK Yandex.

---

## **What has been completed**
**Optimization and Web adaptation**

- Reduced build size from 80 MB to 32.5 MB (optimization of sprites and audio).
- The UI output has been checked and adjusted — the elements do not go beyond the boundaries of the screen.
- Fixed the display of the playing field (eliminated clipping).
- The project has been tested on a mobile device.
- The basic configuration in the Yandex Games console has been configured (description, genres, etc.).

---

## **Working with the Yandex SDK**

- Implemented language switching via the Yandex Games SDK.
- Device type verification is enabled via the YG plugin (determining how to interact with dinosaur parts).

---

## **Code improvement**

- Partially introduced encapsulation in existing scripts.
- Deprecated calls to Object.FindObjectOfType have been replaced with Object.FindFirstObjectByType.
- The project structure has been reorganized (folders, scripts).
- Fixed problems with image stretching in the level selection menu.

---

## **Results**

Size of the final build: 32.5 MB
Platform: Yandex Games (WebGL)
Unity version: 6000.3.2f1

---

## **Additional remarks**

The project has the potential for further optimization.:

- Complete abandonment of Find* methods in favor of DI/reference architecture.
- Improved architecture and separation of responsibilities.
- Additional optimization of assets through Addressables (the possibility of implementation).

---

## 🌐 Community

[![Telegram Channel RU](https://img.shields.io/endpoint?style=for-the-badge&color=0891b2&labelColor=1c1917&url=https%3A%2F%2Ftg.sumanjay.workers.dev%2Fgamedev_my_love&label=Channel%20RU)](https://t.me/gamedev_my_love)
[![Telegram Solyanka Community](https://img.shields.io/endpoint?label=Solyanka%20community&style=for-the-badge&color=0891b2&labelColor=1c1917&url=https%3A%2F%2Ftg.sumanjay.workers.dev%2Fsolycmty)](https://t.me/solycmty)
