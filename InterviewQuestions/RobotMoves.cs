using System;
using System.Collections.Generic;

namespace InterviewQuestions
{
    public class RobotMoves
    {
        public static char[,] Grid { get; set; }

        public static void StartMap()
        {
            Grid = new char[10,10];
            for(int i = 0; i < 10; i++)
            {
                for(int j=0;j<10; j++)
                {
                    Grid[i, j] = ' ';
                }
            }
            Grid[5,5] = '_';
            for(int i=0;i<10; i++)
                for(int j=0;j<10;j++)
                    Console.WriteLine(Grid[i,j]);
        }
    }
}
