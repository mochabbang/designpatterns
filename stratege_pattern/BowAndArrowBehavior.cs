namespace designpatterns.stratege_pattern
{
    public class BowAndArrowBehavior: IWeapon
    {
         public string UseWeapon()
        {
            return "활과 화살";
        } 

        public string ActionWeapon()
        {
            return "불꽃 화살!!!!";
        }
    }
}