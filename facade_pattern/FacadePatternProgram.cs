namespace designpatterns.facade_pattern
{
    public class FacadePatternProgram: IProgram
    {    
        public void Execute() 
        {
            Light light = new Light();
            Projector projector = new Projector();
            Screen screen = new Screen();
            DvdPlayer dvdPlayer = new DvdPlayer();

            HomeTeaterFacede homeTeaterFacede = new HomeTeaterFacede(
                light
                , projector
                , screen
                , dvdPlayer
            );

            homeTeaterFacede.WathMovie("어벤저스");
            homeTeaterFacede.EndMovie();

        }
    }
}