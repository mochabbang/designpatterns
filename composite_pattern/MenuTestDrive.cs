using designpatterns.composite_pattern;

namespace designpatterns.composite_pattern
{
    public class MenuTestDrive: IProgram
    {
        public void Execute()
        {
            MenuComponent pancakeHouseMenus = new Menu("팬케이크 하우스 메뉴", "아침메뉴");
            MenuComponent dinnerMenus = new Menu("객체마을 식당 메뉴", "점심 메뉴");
            MenuComponent cafeMenus = new Menu("카페 메뉴", "저녁 메뉴");
            MenuComponent dessertMenus = new Menu("디저트 메뉴", "디저트를 즐겨 보세요.");

            MenuComponent allMenus = new Menu("전체 메뉴", "전체 메뉴");            

            pancakeHouseMenus.Add(new MenuItem("K&B 팬케이크 세트", "스크램블 에그와 토스트가 곁들여진 팬케이크", true, 2.99));
            pancakeHouseMenus.Add(new MenuItem("레귤러 팬케이크 세트", "달걀 프라이와 소시지가 곁들여진 팬케이크", false, 3.49));
            pancakeHouseMenus.Add(new MenuItem("블루베리 팬케이크", "신선한 블루베리와 블루베리 시럽으로 만든 팬케이크", true, 3.49));
            pancakeHouseMenus.Add(new MenuItem( "아플", "취향에 따라 블루베리나 딸기를 얹을 수 있는 와플", true, 3.59));

            allMenus.Add(pancakeHouseMenus);
            allMenus.Add(dinnerMenus);
            allMenus.Add(cafeMenus);

            // 메뉴 항목(MenuItem 추가)
            // pancakeHouseMenus.Add();            
            dinnerMenus.Add(new MenuItem("파스타", "마리나라 소스 스파게티, 효모빵도 드립니다.", true, 3.89));

            dinnerMenus.Add(dessertMenus);
            dessertMenus.Add(new MenuItem("애플 파이", "바삭바삭한 크러스트에 바닐라 아이스크림이 얹혀 있는 애플 파이", true, 1.59));

            Waitress waitress = new Waitress(allMenus);

            waitress.PrintMenu();
        }
    }
}