using System;
namespace designpatterns.facade_pattern
{
    public class Fecade
    {
        
    }

    public class HomeTeaterFacede {
        Light light;
        Projector projector;
        Screen screen;
        DvdPlayer dvdPlayer;

        public HomeTeaterFacede(
            Light light
            , Projector projector
            , Screen screen
            , DvdPlayer dvdPlayer
        ) {
            this.light = light;
            this.projector = projector;
            this.screen = screen;
            this.dvdPlayer = dvdPlayer;
        }

        public void WathMovie(string movieName) {
            Console.WriteLine("==== 영화 시청 ====");
            light.MovieMode();
            screen.Down();
            projector.On();
            projector.MovieMode();
            dvdPlayer.On();
            dvdPlayer.Play(movieName);
        }
        public void EndMovie() {
            Console.WriteLine("==== 영화 시청 끝 ====");
            light.On();
            screen.Up();
            projector.Off();
            dvdPlayer.Off();
        }
    }
}