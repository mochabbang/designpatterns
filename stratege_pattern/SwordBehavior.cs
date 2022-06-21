namespace designpatterns.stratege_pattern
{
    public class SwordBehavior: IWeapon
    {
        public string UseWeapon()
        {
            return "칼";
        } 

        public string ActionWeapon()
        {
            return "필살 배어버리기!!!";
        }
    }
}