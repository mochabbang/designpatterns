using System;
namespace designpatterns.stratege_pattern
{
    public class King: Charater
    {
        public King()
        {
            this.charaterName = "왕";
            Console.WriteLine(this.charaterName + "은 소지하고 있는 무기가 없습니다.");
        }
    }
}