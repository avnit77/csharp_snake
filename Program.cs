using System;
using System.Threading;

namespace snake_game
{
    class Snake
    {
        int Height = 20;
        int Width = 30;

        int[] X = new int[50];
        int[] Y = new int[50];

        int pointX;
        int pointY;

        int parts = 3;
        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 'W';

        Random rnd = new Random();

        public void WriteBoard()
        {
           Console.Clear();
           for(int i = 1; i <= (Width + 2);i++)
           {
               Console.SetCursorPosition(i, 1);
               Console.Write("-");

           }
            for(int i = 1; i <= (Width + 2);i++)
           {
               Console.SetCursorPosition(i, (Height+2));
               Console.Write("_");

           }
            for(int i = 1; i <= (Height + 2);i++)
           {
               Console.SetCursorPosition(1, i);
               Console.Write("|");

           }
            for(int i = 1; i <= (Height + 2);i++)
           {
               Console.SetCursorPosition((Width+2), i);
               Console.Write("|");

           }
        }

        public void Input()
        {
            if(Console.KeyAvailable)
            {
                Console.ReadKey(true);
                key = keyInfo.KeyChar;
            }
        }
        public void WritePoint(int x, int y)
        {
            Console.SetCursorPosition(x,y);
            Console.Write("#");
        }

        public void Logic()
        {
            if(X[0]==pointX)
            {
                if(Y[0]==pointY)
                {
                    parts++;
                    pointX = rnd.Next(2, (Width - 2));
                    pointY = rnd.Next(2, (Height - 2));

                }
            }
            for(int i = parts; i > 1; i--)
            {
                X[i - 1] = X [i - 2];
                Y[i - 1] = Y [i - 2];
            }

            switch(key)
            {
                case 'w':
                Y[0]--;
                break;

                case 's':
                Y[0]++;
                break;

                case 'a':
                X[0]--;
                break;

                case 'd':
                X[0]++;
                break;
            }
        }
        static void Main(string[] args)
        {
            Snake snake = new Snake();
            snake.WriteBoard();
            snake.Input();
            snake.WritePoint(1, 1);
            Console.ReadKey();
        }
    }
}
