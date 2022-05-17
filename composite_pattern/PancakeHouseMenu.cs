using System.Collections;
namespace designpatterns.composite_pattern
{
    public class PancakeHouseMenu
    {
        MenuComponent menus;

        public PancakeHouseMenu()
        {
            menus.Add(new MenuItem("K&B 팬케이크 세트", "스크램블 에그와 토스트가 곁들여진 팬케이크", true, 2.99));
            menus.Add(new MenuItem("레귤러 팬케이크 세트", "달걀 프라이와 소시지가 곁들여진 팬케이크", false, 3.49));
            menus.Add(new MenuItem("블루베리 팬케이크", "신선한 블루베리와 블루베리 시럽으로 만든 팬케이크", true, 3.49));
            menus.Add(new MenuItem( "아플", "취향에 따라 블루베리나 딸기를 얹을 수 있는 와플", true, 3.59));
        }
    }
}