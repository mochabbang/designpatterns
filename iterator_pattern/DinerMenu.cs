using System.Collections;
using System.Collections.Generic;
using System;
namespace designpatterns.iterator_pattern
{
    public class DinerMenu: IMenu
    {
        private static int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuItem[] menuItems;

        public DinerMenu() 
        {
            menuItems = new MenuItem[MAX_ITEMS];

            AddItems(
                "채식주의자용 BLT"
                , "통밀 위에 콩고기 베이컨, 상추, 토마토를 얹은 메뉴"
                , true
                , 2.99
            );

            AddItems(
                "BLT"
                , "통밀 위에 베이컨, 상추, 토마토를 얹은 메뉴"
                , false
                , 2.99
            );

            AddItems(
                "오늘의 스프y"
                , "감자 샐러드를 곁들인 오늘의 스프"
                , false
                , 3.29
            );

            AddItems(
                "핫도그"
                , "샤워크라우트, 갖은 양념, 양파, 치즈가 곁들여진 핫도그"
                , false
                , 3.05
            );
        } 

        public void AddItems(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);

            if (numberOfItems >= MAX_ITEMS) {
                Console.WriteLine("죄송합니다, 메뉴가 꽉 찼습니다. 더이상 추가할 수 없습니다.");
            }
            else {
                menuItems[numberOfItems] = menuItem;
                numberOfItems = numberOfItems + 1;
            }
        }

        // 내부 구조를 다 드러내는 단점!!
        // public MenuItem[] GetMenuItems()
        // {
        //     return menuItems;
        // }

        public Iterator createIterator() {
            return new DinerMenuIterator(menuItems);
        }
    }
}