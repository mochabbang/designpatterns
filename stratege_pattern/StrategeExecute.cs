namespace designpatterns.stratege_pattern
{
    public class StrategeExecute: IProgram
    {
         public void Execute()
         {
            Charater charater = new King();
            IWeapon weapon = new KnifeBehavior();
            
            charater.SetWeapon(weapon);
            charater.Fight();

            weapon = new SwordBehavior();            
            charater.SetWeapon(weapon);
            charater.Fight();

         }
    }
}