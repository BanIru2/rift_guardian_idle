# 프로젝트 에셋 출처 및 라이선스 정보 (Asset Credits & Licenses)

본 문서는 **균열 수호자 · Rift Guardian Idle** 프로젝트에서 사용하는 모든 외부 스프라이트, 그래픽, VFX, 아이콘 에셋의 출처, 제작자, 라이선스 및 프로젝트 내 적용 규격을 기록한 문서입니다.

모든 에셋은 **상업적 이용 및 포트폴리오 공개가 허용**되는 무료/퍼블릭 도메인 라이선스(CC0, CC-BY 또는 제작자 명시 허용 라이선스)에 부합함을 확인하고 채택했습니다.

---

## 1. 에셋 요약표 (Asset Overview)

| 분류 | 에셋 명칭 | 제작자 | 출처 (URL) | 라이선스 | 프로젝트 내 저장 경로 |
| :--- | :--- | :--- | :--- | :--- | :--- |
| **플레이어** | Hero Knight | **LuizMelo** | [Itch.io](https://luizmelo.itch.io/hero-knight) | **CC0 (Public Domain)** | `Assets/Art/Sprites/Player/HeroKnight/` |
| **일반 적 & 보스** | Monsters Creatures Fantasy | **LuizMelo** | [Itch.io](https://luizmelo.itch.io/monsters-creatures-fantasy) | **CC0 (Public Domain)** | `Assets/Art/Sprites/Enemies/Skeleton/`<br>`Assets/Art/Sprites/Enemies/Goblin/` |
| **환경 & 배경** | Tiny Platformer - Forest | **LuizMelo** | [Itch.io](https://luizmelo.itch.io/tiny-platformer-forest-asset-pack) | **CC0 (Public Domain)** | `Assets/Art/Sprites/Environment/Forest/` |
| **전투 이펙트** | Effect and Bullet 16x16 | **BDragon1727** | [Itch.io](https://bdragon1727.itch.io/free-effect-and-bullet-16x16) | **Free (상업/개인 무료)** | `Assets/Art/Sprites/VFX/` |
| **아이콘** | Kyrise's 16x16 RPG Icon Pack | **Kyrise** | [Itch.io](https://kyrise.itch.io/kyrises-free-16x16-rpg-icon-pack) | **Free (상업/개인 무료 / CC-BY)** | `Assets/Art/Sprites/Icons/` |

---

## 2. 에셋별 상세 정보 및 프로젝트 적용 규격

### 2.1. 플레이어: Hero Knight
* **제작자:** LuizMelo
* **웹페이지:** https://luizmelo.itch.io/hero-knight
* **라이선스:** Creative Commons Zero (CC0 1.0 Universal) - 상업적 이용 가능, 포트폴리오 공개 가능, 수정 자유, 출처 표기 의무 없음
* **프로젝트 내 위치:** `Assets/Art/Sprites/Player/HeroKnight/`
* **사용 파일 및 모션:**
  * `Idle.png`: 대기 모션 (11 프레임)
  * `Run.png`: 달리기/추적 모션 (8 프레임)
  * `Attack1.png`: 기본 공격 1타 (7 프레임)
  * `Attack2.png`: 기본 공격 2타 (7 프레임)
  * `Take Hit.png`: 피격 모션 (4 프레임)
  * `Death.png`: 사망 모션 (11 프레임)
* **임포트 및 슬라이스 규격:**
  * **Frame Size:** 180 × 180 고정 그리드 박스
  * **Pivot:** `Custom (X: 0.5, Y: 0.361)` — 픽셀 기준 `(90, 65)` 접지선에 발바닥 위치 고정
  * **PPU:** `32` (실제 캐릭터 신체 약 50px이 1.56 World Unit이 됨)
  * **Filter Mode:** `Point (no filter)`
  * **Compression:** `None (Uncompressed)`

---

### 2.2. 적 & 보스: Monsters Creatures Fantasy
* **제작자:** LuizMelo
* **웹페이지:** https://luizmelo.itch.io/monsters-creatures-fantasy
* **라이선스:** Creative Commons Zero (CC0 1.0 Universal) - 상업적 이용 가능, 포트폴리오 공개 가능, 수정 자유, 출처 표기 의무 없음
* **프로젝트 내 위치:** `Assets/Art/Sprites/Enemies/Skeleton/`, `Assets/Art/Sprites/Enemies/Goblin/`
* **사용 파일 및 모션:**
  * **Skeleton (스켈레톤):**
    * `Idle.png` (4 프레임), `Walk.png` (4 프레임), `Attack.png` (8 프레임), `Take Hit.png` (4 프레임), `Death.png` (4 프레임)
  * **Goblin (고블린):**
    * `Idle.png` (4 프레임), `Run.png` (8 프레임), `Attack.png` (8 프레임), `Take Hit.png` (4 프레임), `Death.png` (4 프레임)
  * **보스 대체:**
    * 1차 프로토타입 단계에서는 Skeleton 프리팹의 `Transform.localScale`을 1.8~2.0배 확대하고, `SpriteRenderer.color`를 붉은색 계열로 틴트하여 10단계 보스로 임시 재활용.
* **임포트 및 슬라이스 규격:**
  * **Frame Size:** 150 × 150 고정 그리드 박스
  * **Pivot:** `Custom (X: 0.5, Y: 0.320)` — 픽셀 기준 `(75, 48)` 접지선에 발바닥 위치 고정
  * **PPU:** `32`
  * **Filter Mode:** `Point (no filter)`
  * **Compression:** `None (Uncompressed)`

---

### 2.3. 환경 및 지면: Tiny Platformer - Forest Asset Pack
* **제작자:** LuizMelo
* **웹페이지:** https://luizmelo.itch.io/tiny-platformer-forest-asset-pack
* **라이선스:** Creative Commons Zero (CC0 1.0 Universal)
* **프로젝트 내 위치:** `Assets/Art/Sprites/Environment/Forest/`
* **사용 파일:**
  * `Layer_01.png`, `Layer_02.png`, `Layer_03.png`: 3단 패럴랙스 숲 배경 이미지 (Single Sprite)
  * `Tileset.png`: 전투 공간 바닥 및 지면 타일셋 (16×16 단위 총 48개 타일로 슬라이스)
  * `props.png`: 숲 배경 소품
* **임포트 규격:**
  * **PPU:** `16` (타일 1블록 16px이 Unity World 1.0 Unit을 형성하여 캐릭터와 적절한 스케일 매칭)
  * **Filter Mode:** `Point (no filter)`
  * **Compression:** `None (Uncompressed)`

---

### 2.4. 전투 이펙트: Effect and Bullet 16x16
* **제작자:** BDragon1727
* **웹페이지:** https://bdragon1727.itch.io/free-effect-and-bullet-16x16
* **라이선스:** Free for personal and commercial game development (단독 재배포 및 재판매 금지)
* **프로젝트 내 위치:** `Assets/Art/Sprites/VFX/`
* **사용 파일:**
  * `Fire Effect and Bullet 16x16.png`: 참격 궤적 및 파이어볼/폭발 이펙트 프레임
  * `Purple Effect and Bullet 16x16.png`: 암흑/피격 임팩트 스파크 프레임
* **임포트 규격:**
  * **Slice:** 16 × 16 그리드 슬라이스
  * **PPU:** `16`
  * **Filter Mode:** `Point (no filter)`
  * **Compression:** `None (Uncompressed)`

---

### 2.5. 아이콘: Kyrise's 16x16 RPG Icon Pack
* **제작자:** Kyrise
* **웹페이지:** https://kyrise.itch.io/kyrises-free-16x16-rpg-icon-pack
* **라이선스:** Free for non-commercial and commercial projects (Attribution appreciated / CC-BY)
* **프로젝트 내 위치:** `Assets/Art/Sprites/Icons/`
* **사용 파일:**
  * `coin_gold.png`: 골드 획득 및 인게임 재화 UI 아이콘
  * `sword_upgrade.png`: 공격력 강화 버튼 아이콘
  * `icons_spritesheet_16x16.png`: Sprite Atlas 묶기 및 드로우 콜 비교 실습용 전체 16×16 시트
* **임포트 규격:**
  * **PPU:** `16`
  * **Filter Mode:** `Point (no filter)`
  * **Compression:** `None (Uncompressed)`

---

## 3. 라이선스 준수 및 포트폴리오 공개 시 주의사항

1. **상업적 이용 및 포트폴리오 공개:**
   * 수록된 모든 에셋은 상업용 게임 출시 및 GitHub / 웹 포트폴리오 영상/코드 공개에 법적 제약이 없습니다.
2. **크레딧 표기 (선택/권장):**
   * LuizMelo 작가의 에셋(Hero Knight, Monsters, Forest)은 CC0로 출처 표기 의무가 없으나 오픈소스 관례상 크레딧을 명시합니다.
   * BDragon1727 및 Kyrise 작가의 에셋 역시 인게임 '정보/설정' 창 또는 본 `Docs/ASSETS.md` 문서에 크레딧을 명시하여 라이선스 조건을 준수합니다.
