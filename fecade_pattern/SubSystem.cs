using Internal;
using System;
namespace designpatterns.fecade_pattern
{
    public class SubSystem
    {
        
    }

    public class Light {
        public void On() {
            Console.WriteLine("조명을 킵니다.");
        }

        public void MovieMode() {
            Console.WriteLine("조명을 영화관 모드로 변경합니다.");
        }
    }

    public class Screen {
        public void Down() {
            Console.WriteLine("스크린을 내립니다.");
        }

        public void Up() {
            Console.WriteLine("스크린을 올립니다.");
        }
    }

    public class Projector {
        public void On() {
            Console.WriteLine("Projector를 킵니다.");
        }

        public void Off() {
            Console.WriteLine("Projector를 끕니다.");
        }
        
        public void MovieMode() {
            Console.WriteLine("Projector를 영화관 모드로 설정합니다.");
        }
    }

    public class DvdPlayer {
        public void On() {
            Console.WriteLine("DvdPlayer를 킵니다.");
        }

        public void Off() {
            Console.WriteLine("DvdPlayer를 끕니다.");
        }

        public void Play(string movieName) {
            Console.WriteLine(movieName + "를 시작합니다.");
        }
    }
}