using System;
namespace designpatterns.template_method_pattern
{
    public class TemplatePatternProgram: IProgram
    {        
        public void Execute()
        {
            // Coffee coffee = new Coffee();
            // coffee.PrepareRecipe();

            // Tea tea = new Tea();
            // tea.PrepareRecipe();
            CoffeWithHook coffeWithHook = new CoffeWithHook();
            coffeWithHook.PrepareRecipe();
        }
    }
}