using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisKata
{
    class Program
    {



        static void Main(string[] args)
        {
            int[] scores = { -1, -1 };
            scores = GetPlayerScores();
            PrintTennisScores(scores[0], scores[1]);
        }

         static void PrintTennisScores(int p1, int p2)
        {
            
        }


        /// <summary>
        /// Takes an int and gives the tennis score
        /// i.e. 1 = fifteen, 0 = love
        /// </summary>
        /// <param name="playerScore"></param>
        /// <returns></returns>
        static string ScoreToString(int playerScore)
        {
            string stringScore = "";
            switch (playerScore)
            {
                case 0:
                    stringScore = "love";
                    break;
                case 1:
                    stringScore = "fifteen";
                    break;
                case 2:
                    stringScore = "thirty";
                    break;
                case 3:
                    stringScore = "forty";
                    break;
            }
            return stringScore;
        }

        /// <summary>
        /// Returns the two scores in an int Array
        /// </summary>
        /// <returns>int{ score1, score2}</returns>
        static int[] GetPlayerScores()
        {
            int[] result = { -1, -1 };
            result[0] = GetInt("Enter First Score");
            result[1] = GetInt("Enter Second Score");
            return result;
        }

        /// <summary>
        /// returns whether or not a and b are 1 apart
        /// </summary>
        /// <param name="a">integer</param>
        /// <param name="b">integer</param>
        /// <returns>boolean true if ABS(a-b) == 1</returns>
        static bool HasAdvantage(int a, int b)
        {
            return Math.Abs(a - b) == 1;
        }

        /// <summary>
        /// getInt()
        /// grabs a non negative integer from the User through the Console
        /// </summary>
        /// <param name="prompt">Takes a String to display to User before readline</param>
        /// <returns>non Negative integer</returns>
        static int GetInt(string prompt)
        {
            int result = -1;
            string response = "";
            do
            {
                Console.Write(prompt);
                response = Console.ReadLine();

            } while (!int.TryParse(response, out result));
            return result;
        }
    }
}
