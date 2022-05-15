using System.Collections.Generic;
namespace designpatterns.iterator_pattern
{
    public class PancakeHouseMenu: IMenu
    {
        List<MenuItem> menuItems;

        public PancakeHouseMenu() {
            menuItems = new List<MenuItem>();

            AddItems(
                "K&B 팬케이크 세트"
                , "스크램블 에그와 토스트가 곁들여진 팬케이크"
                , true
                , 2.99
            );
            
            AddItems(
                "레귤러 팬케이크 세트"
                , "달걀 프라이와 소시지가 곁들여진 팬케이크"
                , false
                , 3.49
            );

            AddItems(
                "블루베리 팬케이크"
                , "신선한 블루베리와 블루베리 시럽으로 만든 팬케이크"
                , true
                , 3.49
            );

            AddItems(
                "아플"
                , "취향에 따라 블루베리나 딸기를 얹을 수 있는 와플"
                , true
                , 3.59
            );
        }

        public void AddItems(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem);
        }


        public Iterator createIterator()
        {
            return new PancakeHouseMenuIterator(menuItems);
        }
    }
}