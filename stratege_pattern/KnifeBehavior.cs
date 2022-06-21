namespace designpatterns.stratege_pattern
{
    public class KnifeBehavior: IWeapon
    {
        public string UseWeapon()
        {
            return "단검";
        } 

        public string ActionWeapon()
        {
            return "찌르기!!!";
        }
    }
}