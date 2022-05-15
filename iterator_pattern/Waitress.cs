using System;
namespace designpatterns.iterator_pattern
{
    public class Waitress
    {
        PancakeHouseMenu pancakeHouseMenu;
        DinerMenu dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            Iterator pancakeIterator = pancakeHouseMenu.createIterator();
            Iterator dinerIterator = dinerMenu.createIterator();

            Console.WriteLine("메뉴\n----\n아침 메뉴");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\n점심 메뉴");
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(Iterator iterator) 
        {
            while(iterator.HasNext()) 
            {
                MenuItem menuItem = iterator.Next();
                Console.WriteLine(menuItem.GetName() + ", ");
                Console.WriteLine(menuItem.GetPrice() + " -- ");
                Console.WriteLine(menuItem.GetDescription());
            }
        }
    }
}