using System;

/**
 * The while loop represents the game.
 * Each iteration represents a turn of the game
 * where you are given inputs (the heights of the mountains)
 * and where you have to print an output (the index of the mountain to fire on)
 * The inputs you are given are automatically updated according to your last actions.
 **/
class Player
{
    static void Main(String[] args)
    {
        // game loop
        while (true)
        {
            var highestMountainIndex = 0;
            var maxHeight = 0;
            for (var i = 0; i < 8; i++)
            {
                var currentHeight = Int32.Parse(Console.ReadLine());
                if (currentHeight > maxHeight)
                {
                    maxHeight = currentHeight;
                    highestMountainIndex = i;
                }
            }

            Console.WriteLine($"{highestMountainIndex}"); // The index of the mountain to fire on.
        }
    }
}