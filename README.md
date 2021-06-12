# Lost in Space

![KakaoTalk_20210607_094650083](https://user-images.githubusercontent.com/84438387/120945820-713f3180-c775-11eb-9adb-8ff4eff154a8.jpg)

**제작멤버**  
20190252 성채림, 20190265 차현진

**제작프로그램**  
Unity   
   

# 스토리
은하수를 관찰하며 우주를 탐험하던 우주비행사 J,
탐험 도중 우주선 내부 시스템에 문제가 생겨 우주선이 고장나고 알 수 없는 위치에 고립되게 된다. 탐험을 계속하기 위해서는 
우주선을 고치고 동료에게 위치를 알려야 하는 상황 ! 

어디로 쓸려 온 건지 우주선 밖에는 로봇들이 돌아다니고 있다.
J는 로봇에게서 우주선 부품을 얻을 수 있다는 것을 알고 우주선 밖으로 나선다. 산소통도 고장이 난 바람에 우주에서 부품을 수집할 수 있는 시간은 단 30초 .. J는 과연 우주선을 고치고 이 위기를 벗어날 수 있을까?


# 제작의도
폭파된 인공위성의 잔해와 부딪혀 우주에 고립된 이야기를 담겨 있는 영화  <그래비티>와  SF 드라마 <로스트 인 스페이스>를 모티브로 하여 생존 게임을 만들게 되었다. 

평지에서 이루어지는 게임이 아닌 우주라는 새로운 환경에서의 게임을 구현해보고자 하였으며, 평소 즐기던 게임에서 볼 수 있었던 HP 기능, 총 기능, 
1인칭 시점 카메라 등 3d fps 게임 기능과 방탈출 게임 요소를 결합시켜 
구현하고자 하였다. 


# 게임 진행 화면 및 기능
## Spaceship (우주선 내부)
- 창문을 통해 우주선 바깥이 보인다. 
- 우주선 내부 곳곳에 숨겨져 있는 회복 아이템을 찾아 인벤토리에 저장해야 한다.
- 아이템을 수집하려면 아이템을 화면 정중에 위치시키고, 화면에 표시되는 안내를 따라 e키를 누르면 아이템이 인벤토리에 들어가게 된다. 
- 인벤토리에서 회복 아이템과 우주선 부품 등 아이템들을 확인하고 정리할 수 있다.
- 왼쪽 하단의 HP 바를 통해 남은 체력을 확인할 수 있다. 

![KakaoTalk_20210607_105127996](https://user-images.githubusercontent.com/84438387/120949014-7785db80-c77e-11eb-8953-bb749e85c2a5.png)

## Space (우주)
- 로봇을 제거하고 부품을 획득할 수 있는 곳으로, 사방이 우주로 보이도록 구현했다. 
- 산소가 부족한 환경이기 때문에 사용자의 산소가 계속해서 줄어들게 구현하였으며, 인벤토리에 저장해놓은 회복 아이템을 먹으면 체력을 회복시킬 수 있다. 
- 왼쪽 하단의 산소 상태 바와 HP 바, 총알 상태바를 통해 남은 산소 양과 체력, 남은 총알의 양을 확인할 수 있다.
- 총알을 모두 소진하면 R 키를 사용하여 재장전한다.
- 로봇은 총을 두 번 맞으면 제거되도록 하였고 제거된 로봇으로부터 우주선 부품을 얻을 수 있게 된다.  

![KakaoTalk_20210611_140830656](https://user-images.githubusercontent.com/84438387/121636466-ee92db00-cac2-11eb-8c32-5e3341d17376.png)


