

namespace Step_cs.Class
{
    internal class Point
    {
        private int x;
        private int y;

        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        public int MyProperty_X
        {
            get { return x; }
            set { if (x >= 0) { x = value; } }
        }
        public int MyProperty_Y
        {
            get { return y; }
            set { if (y >= 0) { y = value; } }
        }
        public void showData()
        {
            Console.WriteLine($"x->{x}\ny->{y}");
        }


    }
}
