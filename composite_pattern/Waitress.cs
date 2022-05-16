namespace designpatterns.composite_pattern
{
    public class Waitress
    {
        MenuComponent allMenus;

        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }

        public void PrintMenu() 
        {
            allMenus.Print();
        }
    }
}