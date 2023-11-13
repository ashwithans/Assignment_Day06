using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppDay6Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a jagged array for student scores
            int[][] studentScores = new int[3][];

            // Initialize the jagged array with scores for each student
            studentScores[0] = new int[] { 85, 92, 78 };
            studentScores[1] = new int[] { 90, 87, 93, 89 };
            studentScores[2] = new int[] { 76, 88 };

            // Iterate through the jagged array to print scores for each student and calculate their average scores
            for (int student = 0; student < studentScores.Length; student++)
            {
                int[] scores = studentScores[student];
                Console.WriteLine("Student " + (student + 1) + " scores:");
                int totalScore = 0;

                foreach (int score in scores)
                {
                    Console.Write(score + " ");
                    totalScore += score;
                }

                double averageScore = (double)totalScore / scores.Length;
                Console.WriteLine("\nAverage score for Student " + (student + 1) + ": " + averageScore);
            }

            // Calculate the average score for all students combined
            int totalAllScores = 0;
            int totalAllStudents = 0;

            foreach (int[] scores in studentScores)
            {
                totalAllScores += scores.Length;
                totalAllStudents += scores.Sum();
            }

            double averageAllStudents = (double)totalAllStudents / totalAllScores;
            Console.WriteLine("Average score for all students combined: " + averageAllStudents);
            Console.ReadKey();
        }
    }
}
