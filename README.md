# GameProgramming-Team-10
뱀서라이크 장르의 게임입니다.
Vampire survivors의 영향을 크게 받은 게임 장르로 로그라이트 장르의 특징을 가지고 있으며
탑뷰 형태의 시점에서 수많은 적을 공격하는 슈팅게임입니다.
***유투브 골드메탈 - 언데드 서바이벌 에셋 팩을 바탕으로 만든 게임입니다**


# 핵심 기능
  캐릭터
1. 캐릭터 해금 시스템
2. 레벨 업 및 능력 강화 시스템
3. 사망 기능
   몬스터
1. 플레이어 추적 기능
2. 플레이어 공격 기능
3. 피격 시 넉백 및 사망 기능
   스테이지
1. 일반 스테이지(5가지) 구현
2. 스테이지 별 몬스터 스프라이트 적용
   UI 및 오디오
1. 플레이어 체력, 경험치 및 기타 UI
2. BGM 및 몬스터 피격 효과음
   보스
1. 보스 스테이지 구현
2. 몬스터 구현


# 시작화면
<img src = "https://user-images.githubusercontent.com/97091329/247165231-437c5892-f030-40d5-a494-006c944139db.PNG" width="50%"></img>

# 제작자
<img src = "https://user-images.githubusercontent.com/97091329/247166943-83993c2d-93cb-4f2e-b432-888e1c8e871a.PNG" width="50%"></img>

# 맵선택 
<img src = "https://user-images.githubusercontent.com/97091329/247166958-b1907539-c398-4f21-a492-7406a3706f8b.PNG" width="50%"></img>
Ground Snow Cave Lava Swamp 총 5개의 일반맵과 보스맵으로 구성되어 있습니다.

# 캐릭터선택
<img src = "https://user-images.githubusercontent.com/97091329/247166987-2d430b04-1127-4f00-891a-d07e50d8b220.PNG" width="50%"></img>
맵 시작할 때마다 캐릭터를 선택할 수 있으며, 조건 달성시 잠겨있는 캐릭터를 선택할 수 있습니다.

# GroundMap
<img src = "https://user-images.githubusercontent.com/97091329/247167008-d36d035a-d0fa-41af-956f-612f46b68306.PNG" width="50%"></img>
가장 기본적인 맵입니다.

# HellMap
<img src = "https://user-images.githubusercontent.com/97091329/247167039-c70e7d0a-1740-4e43-9d37-36bf3405585b.PNG" width="50%"></img>
용암이 있는 맵입니다.
용암에 닿을시 지속적인 데미지를 얻으며 이동 속도가 감소합니다.

# SwampMap
<img src = "https://user-images.githubusercontent.com/97091329/247167066-e6d6db30-e44e-4fdd-aefb-4c07bb79f92e.PNG" width="50%"></img>
늪지대(파란 구역)을 지날 때 이동 속도가 감소합니다.

# CavaMap(시야 밝을 때)
<img src = "https://user-images.githubusercontent.com/97091329/247167103-c0ae2bd4-e0b9-4622-80f5-c79725c91502.PNG" width="50%"></img>
동굴 맵입니다.
몬스터는 공중 몬스터로 지형 이동에 제약이 없지만 캐릭터는 낭떠러지를 지나지 못합니다.
랜덤한 시간에 시야가 제한됩니다.

# CaveMap(시야 어두울 때)
<img src = "https://user-images.githubusercontent.com/97091329/247167122-f2bd0627-6a40-4da5-8bb6-facc82c9c0ff.PNG" width="50%"></img>

# SnowMap
<img src = "https://user-images.githubusercontent.com/97091329/247167167-735f0d1a-59c5-462f-9cf0-e445c607018b.PNG" width="50%"></img>
스노우 맵입니다.
얼음 위를 지날 때 이동 속도가 빨라지며, 소량의 데미지를 얻습니다.
움직이는 펭귄에 닿을 시 캐릭터를 밀어내고, 데미지를 얻습니다.

# BossMap
<img src = "https://user-images.githubusercontent.com/97091329/247167198-6c47611f-cd88-42c8-a7f8-24b8295aadc1.PNG" width="50%"></img>
보스 맵입니다.
시작과 동시에 15레벨이 되며 레벨업 한 만큼 무기를 업그레이드 한 후 게임을 시작합니다.
