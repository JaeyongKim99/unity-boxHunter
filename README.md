# **BoxHunter**

**게임설명**

플레이어가 필드에 생성된 몬스터들을 전부 무찌르고 최종라운드까지 클리어 하는 게임입니다.

**프로젝트 시나리오**
TPS 게임의 기본요소인 맵과 플레이어, 몬스터로 구성
맵은 평평한 평지 등으로 슈팅게임 초보자도 쉽게 할 수 있게 맵을 구성
몰입감을 주기 위한 배경음악과 총소리 몬스터 히트 사운드 구성
플레이어가 맞았을 때 색의 변화와 몬스터가 맞았을 때 색의 변화로 게임의 몰입 극대화

**주요기능**
라운드가 넘어갈 때마다 몬스터 스피드 증가
라운드가 넘어갈 때마다 몬스터 수 증가
적 HP바 표시
적이 사망할 때와 피격받았을 때 색 변경
모든 몬스터를 잡아야 다음 라운드 진행

🗓️ **작업기간** : 2021.6.1 ~ 2021.6.14

👨‍💻 **투입인원** : 1명

📒 **주요업무** 

- 게임 시나리오 및 UI 구현 - 게임 시나리오 및 게임 시작한 시간, 점수, 몬스터 남은 수, 씬화면 UI 구현
- 게임 로직 구현 - 라운드별 몬스터 스피드, 수 증가 로직, HP바 구현 로직, 피격 효과 로직 구현
- 게임 구조물 배치

🌱 **스킬 및 사용툴**

`Unity` `VisualStudioCode`

✉️ **아쉬운 점 및 발전 방안**

다른 강의 시험 준비를 하며 게임을 만들기엔 시간이 적어서 결과물이 만족스럽지 않았고 가져온 에셋을 별로 변화시키지 못했던 것이 아쉽습니다.

모든 몬스터를 잡아야 다음 라운드로 진행되기 떄문에 클리어 타임도 점수에 반영하는 것이 좋았을 것 같습니다.

몬스터가 나오는 곳을 랜덤으로 했으면 더 재밌었을 것 같습니다.

🖌️ **UI 및 로직**
---
![타이틀](https://user-images.githubusercontent.com/111633448/191529751-e13e6829-ac86-459d-a85b-b3de9ab83899.jpg)  
**타이틀 화면**  
![게임플레이](https://user-images.githubusercontent.com/111633448/191529771-d037d27a-d05b-450b-8b70-e12eaf3af63e.jpg)  
**게임플레이 화면**  
![게임클리어](https://user-images.githubusercontent.com/111633448/191529789-90e0edef-a09a-4d72-8f5e-3c0934be542e.jpg)  
**게임클리어 화면**  
![게임오버](https://user-images.githubusercontent.com/111633448/191529798-10c1f5c3-2764-4c18-a172-db27c261b296.jpg)  
**게임오버 화면**  
![UI](https://user-images.githubusercontent.com/111633448/191529811-90422d8b-f0e6-4960-aa60-038959435cf1.png)  
**인게임 UI 화면**  
![전체 맵구성](https://user-images.githubusercontent.com/111633448/191529838-55fa18ff-b108-4c15-8afc-65f837d26318.png)  
**전체 맵구성(빨간 상자 부분에서 적이 스폰됩니다.)**  
![적 HP 바 카메라 고정](https://user-images.githubusercontent.com/111633448/191530468-d286a407-c0a8-441a-8fc9-1020d07bbe97.jpg)  
**적 HP바 카메라 고정 로직입니다.**  
**- 항상 HP바가 화면 정면을 바라보도록 로테이션 값이 조정되게 하였습니다.**  
![적 HP 바 감소](https://user-images.githubusercontent.com/111633448/191530485-39857f57-4e71-4be3-97bf-f32168ce4de3.jpg)  
**HP 값 변수를 만들어 HP바와 연동시켜 적이 데미지를 입을 때마다 HP바를 줄이는 로직입니다.**  
![스테이지별 몬스터 수 증가](https://user-images.githubusercontent.com/111633448/191530510-927d7aae-45e8-43b9-9228-418f33ebd2a1.jpg)  
**라운드마다 라운드의 *2만큼 몬스터가 증가하게 만들었습니다.**  
![스테이지별 몬스터 스피드 증가](https://user-images.githubusercontent.com/111633448/191530513-3cf1c428-93a5-4f29-9039-25463f6e5f31.jpg)  
**라운드마다 라운드의 *2만큼 몬스터의 스피드가 증가하며 최고속도는 10으로 제한했습니다.**  
![플레이어 피격효과](https://user-images.githubusercontent.com/111633448/191530540-d5c1f861-9a4e-4789-9769-708626d889e1.png)  
**플레이어가 데미지를 입을 때마다 노란색으로 피격효과가 발생하게 했습니다.**  
![적 사망효과](https://user-images.githubusercontent.com/111633448/191530576-0326db72-ffa7-42be-b4b9-7f376897915c.png)  
**몬스터의 HP가 0보다 아래로 내려가면 회색으로 변경되게 했습니다.**  

참고
---
[골드메탈 에셋](https://assetstore.unity.com/packages/3d/characters/quarter-view-3d-action-assets-pack-188720#description).
