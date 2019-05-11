namespace NoughtsAndCrosses
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application();
            app.Start();
        }
    }

    class Application
    {
        internal void Start()
        {
            char[] boardPlaces = new char[9];
            boardPlaces[0] = 'X'; boardPlaces[1] = 'O'; boardPlaces[2] = ' ';
            boardPlaces[3] = 'X'; boardPlaces[4] = 'O'; boardPlaces[5] = 'X';
            boardPlaces[6] = 'O'; boardPlaces[7] = ' '; boardPlaces[8] = ' ';


            Console.WriteLine(string.Format("|{0}|{1}|{2}|\n" +
                                            "|{3}|{4}|{5}|\n" +
                                            "|{6}|{7}|{8}|",
                                            boardPlaces[0], boardPlaces[1], boardPlaces[2],
                                            boardPlaces[3], boardPlaces[4], boardPlaces[5],
                                            boardPlaces[6], boardPlaces[7], boardPlaces[8]));

            Console.ReadKey();
        }
    }
}
