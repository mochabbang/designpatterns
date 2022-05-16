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

            allMenus.Add(pancakeHouseMenus);
            allMenus.Add(dinnerMenus);
            allMenus.Add(cafeMenus);

            // 메뉴 항목(MenuItem 추가)
            dinnerMenus.Add(new MenuItem("파스타", "마리나라 소스 스파게티, 효모빵도 드립니다.", true, 3.89));

            dinnerMenus.Add(dessertMenus);
            dessertMenus.Add(new MenuItem("애플 파이", "바삭바삭한 크러스트에 바닐라 아이스크림이 얹혀 있는 애플 파이", true, 1.59));

            Waitress waitress = new Waitress(allMenus);

            waitress.PrintMenu();
        }
    }
}