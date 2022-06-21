namespace designpatterns.stratege_pattern
{
    public class AxeBehavior: IWeapon
    {
        public string UseWeapon()
        {
            return "도끼";
        } 

        public string ActionWeapon()
        {
            return "찍어버리기!!!";
        }
    }
}