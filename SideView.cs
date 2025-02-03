using SFML.Graphics;
using SFML.System;

namespace ConsoleApp1
{
    internal class SideView : RectangleShape
    {

        private Font basic_font;
        private Text title_text;
        public SideView()
        {
            this.Size = new Vector2f(198, 598);
            this.Position = new Vector2f(601, 1);
            this.FillColor = Color.White;
            this.OutlineThickness = 2;
            this.OutlineColor = Color.Green;

            basic_font = new Font("resources/basic_font.ttf");
            title_text = new Text("OOPS GAME", basic_font);
            title_text.Position = this.Position + new Vector2f(20f, 20f);
            title_text.FillColor = Color.Black;
        }

        public void DrawSideView(RenderWindow window)
        {
            window.Draw(this);

            window.Draw(title_text);
        }
    }
}
