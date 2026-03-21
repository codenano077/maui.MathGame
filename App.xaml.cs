using MathGame.Maui.Data;

namespace Maui.MathGame
{
    public partial class App : Application
    {
        public static GameRepo? GameRepo { get; private set; }

        public App(GameRepo gameRepo)
        {
            InitializeComponent();

            MainPage = new AppShell();

            GameRepo = gameRepo;
        }

        
        
    }
}