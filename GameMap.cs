using SFML.Graphics;
using SFML.System;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class GameMap
    {
        private RectangleShape[,] map;
        public enum MoveDirections { Left, Right, Up, Down }

        private int player_x = 3;
        private int player_y = 3;



        public GameMap()
        {
            map = new RectangleShape[10, 10]; 


            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    map[y, x] = new RectangleShape();
                    map[y, x].Size = new Vector2f(60, 60);
                    map[y, x].Position = new Vector2f(x * 60f, y * 60f);
                    map[y, x].Texture = new Texture("resources/img_floor.jpg");
                }
            }

            map[player_x, player_y].Texture = new Texture("resources/img_player.jpg");
        }

        public void DrawMap(RenderWindow window)
        {
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    window.Draw(map[y, x]);
                }
            }
        }

        public void MovePlayer(MoveDirections direction)
        {
            map[player_y, player_x].Texture = new Texture("resources/img_floor.jpg");

            switch (direction)
            {
                case MoveDirections.Up:
                    player_y--;
                    break;
                case MoveDirections.Down:
                    player_y++;
                    break; 
                case MoveDirections.Left:
                    player_x--;
                    break;
                case MoveDirections.Right:
                    player_x++;
                    break;
            }

            map[player_y, player_x].Texture = new Texture("resources/img_player.jpg");
        }
    }
}
