using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_YieldTest
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var score in GetAllScores())
            {
                Console.WriteLine(score);
            }
            foreach (var score in GetScores())
            {
                Console.WriteLine(score);
            }
            foreach (var score in 누적합계())
            {
                Console.WriteLine(score);
            }
        }
        static int[] GetAllScores()
        {
            int[] scores = new int[] { 10, 20, 30 };
            return scores;
        }
        static IEnumerable<int> GetScores()
        {
            int[] scores = new int[] { 10, 20, 30 };
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == 30)
                {
                    yield break;
                }
                yield return scores[i];
                Debug.WriteLine(i + " : Done");
            }
        }
        static IEnumerable<int> 누적합계()
        {
            int[] scores = new int[] { 10, 20, 30 };

            int total = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                total += scores[i];
                yield return total;
            }
        }
    }
}
