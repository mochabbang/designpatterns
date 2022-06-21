using System;

namespace designpatterns.stratege_pattern 
{
    public abstract class Charater 
    {
        public string charaterName;
        public IWeapon weapon;


        public Charater() {}

        public void SetWeapon(IWeapon weapon)
        {
            this.weapon = weapon; 
        }

        public void Fight()
        {
            Console.WriteLine(this.charaterName + "가 " + weapon.UseWeapon() + "을 장착하였습니다.");
            Console.WriteLine(this.charaterName + "가 " + weapon.ActionWeapon() + "을 실행하였습니다.");
        }

        
    }
}