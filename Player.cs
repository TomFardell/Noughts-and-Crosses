namespace NoughtsAndCrosses
{
    using System;

    class Player
    {
        private char usedCharacter;

        internal Player(char character)
        {
            usedCharacter = character;
        }

        internal int GetPosition(char axis)
        {
            Console.Write("Please enter the {0} co-ordinate of your position > ", axis);
            string posInput = Console.ReadLine();

            return int.Parse(posInput);
        }

        internal char GetMove()
        {
            return usedCharacter;
        }
    }
}
