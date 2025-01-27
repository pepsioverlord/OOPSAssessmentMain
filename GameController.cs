using SFML.Graphics;
using SFML.Window;

namespace ConsoleApp1
{
    internal class GameController
    {
        private RenderWindow gameWindow;
        private GameMap gameMap;
        public GameController()
        {
            gameWindow = new RenderWindow(new SFML.Window.VideoMode(800, 600), "Assessment Game", SFML.Window.Styles.Close);
            gameWindow.Closed += OnClosed;
            gameWindow.KeyReleased += OnKeyReleased;

            gameMap = new GameMap();
        }

        private void OnClosed(object? sender, EventArgs e)
        {
            gameWindow.Close();
        }

        private void OnKeyReleased(object? sender, KeyEventArgs e)
        {
            switch (e.Code)
            {
                case Keyboard.Key.W:
                    gameMap.MovePlayer(GameMap.MoveDirections.Up);
                    break;
                case Keyboard.Key.A:
                    gameMap.MovePlayer(GameMap.MoveDirections.Left);
                    break;
                case Keyboard.Key.S:
                    gameMap.MovePlayer(GameMap.MoveDirections.Down);
                    break;
                case Keyboard.Key.D:
                    gameMap.MovePlayer(GameMap.MoveDirections.Right);
                    break;
            }
        }

        public void Run() 
        {
            while (gameWindow.IsOpen)
            {
                // Gather user input
                gameWindow.DispatchEvents();

                // update game
                UpdateGame();

                // render game
                RenderGame();
            }

            gameWindow.Close();
        }

        private void UpdateGame()
        {
            // We can update our game here
        }

        private void RenderGame()
        {
            // Draw everything here


            // Clear
            gameWindow.Clear(new Color(200, 100, 150));

            gameMap.DrawMap(gameWindow);

            // Display
            gameWindow.Display();
        }
    }
}
