namespace designpatterns.iterator_pattern
{
    public class MenuTestDrive: IProgram
    {
        public void Execute()
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinnerMenu = new DinerMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu, dinnerMenu);

            waitress.PrintMenu();
        }
    }
}