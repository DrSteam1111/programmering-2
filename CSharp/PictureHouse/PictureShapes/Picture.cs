namespace PictureShapes
{
    class Picture
    {
        private Square wall;
        private Square window;
        private Triangle roof;
        private Circle sun;
        public Picture()
        {
            DrawImage();
        }
        public void DrawImage()
        {
            wall = new Square();
            wall.MakeVisible();
            wall.ChangeColor("red");
            wall.ChangeSize(250);
            wall.MoveHorizontal(20);
            wall.MoveVertical(-20);

            // Write your code here
            window = new Square();
            window.MakeVisible();
            window.ChangeColor("black");
            window.ChangeSize(90);
            window.MoveHorizontal(60);
            window.MoveVertical(20);

            roof = new Triangle();
            roof.MakeVisible();
            roof.ChangeColor("black");
            roof.ChangeSize(300);
            roof.MoveHorizontal(-50);
            roof.MoveVertical(-60);

            sun = new Circle();
            sun.MakeVisible();
            sun.ChangeColor("yellow");
            sun.ChangeSize(80);
            sun.MoveHorizontal(550);
            sun.MoveVertical(-20);
            sun.MoveVertical(0);
        }
    }
}
