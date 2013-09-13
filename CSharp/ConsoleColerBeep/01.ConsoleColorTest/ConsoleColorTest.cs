using System;
class ConsoleColorTest
{
    static void Main()
    {
        int size = 5;
        DrawSquare(0, size + 0, size, ConsoleColor.Red);
        DrawSquare(0, size + 2, size, ConsoleColor.Green);
        DrawSquare(0, size + 4, size, ConsoleColor.Black);
        DrawSquare(0, size + 6, size, ConsoleColor.Blue);
    }

    public static void DrawSquare(int x, int y, int size, ConsoleColor color)
    {
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.SetCursorPosition(x + row, y + col);
                Console.BackgroundColor = color;
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.ResetColor();
    }
}

