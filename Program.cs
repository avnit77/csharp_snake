using System;
using System.Threading;

namespace snake_game
{
    class Snake
    {
        int Height = 20;
        int Width = 30;

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
        static void Main(string[] args)
        {
            Snake snake = new Snake();
            snake.WriteBoard();
            Console.ReadKey();
        }
    }
}
