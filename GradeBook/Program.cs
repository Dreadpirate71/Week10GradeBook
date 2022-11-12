using System;
using System.Collections.Generic;

namespace GradeBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal classAverage = 0;
            string studentLetterGrade = null;

            IDictionary<string, Dictionary<string, List<decimal>>> Students = new Dictionary<string, Dictionary<string, List<decimal>>>
            {
                {
                    "Morty",
                    new Dictionary<string, List<decimal>>
                    {
                        { "Homework", new List<decimal> { 15, 20, 18, 19 } },
                        { "Quizzes", new List<decimal> { 45, 48, 42 } },
                        { "Tests", new List<decimal> { 92, 98 } }
                    }
                },
                {
                    "Charlie",
                    new Dictionary<string, List<decimal>>
                    {
                        { "Homework", new List<decimal> { 14, 16, 18, 17 } },
                        { "Quizzes", new List<decimal> { 42, 39, 36 } },
                        { "Tests", new List<decimal> { 86, 78 } }
                    }
                },
                {
                    "Opie",
                    new Dictionary<string, List<decimal>>
                    {
                        { "Homework", new List<decimal> { 19, 20, 18, 17 } },
                        { "Quizzes", new List<decimal> { 47, 47, 50 } },
                        { "Tests", new List<decimal> { 97, 95 }
                        }
                    }
                }
            };
            void PrintStudentInfo(IDictionary<string, Dictionary<string, List<decimal>>> students)
            {
                foreach (var student in students)
                {
                    List<decimal> studentAverageScores = new List<decimal>();
                    decimal studentClassTotal = 0;
                    foreach (var item in student.Value)
                    {
                        
                        decimal scoreAverage = 0;
                        Console.WriteLine("{0} ->> {1}", student.Key, item.Key);
                        foreach (var grade in item.Value)
                        {
                            Console.Write("{0} ", grade);
                            studentClassTotal += grade;
                        }
                        scoreAverage = CalculateAssignmentAverage(item.Value);
                        studentAverageScores.Add(scoreAverage);
                        Console.WriteLine("\n{0}'s average of the {1} is {2}.", student.Key, item.Key, scoreAverage);
                        Console.WriteLine();
                    }
                    
                    classAverage = CalculateClassAverage(studentClassTotal);
                    classAverage = Decimal.Round(classAverage, 2);
                    studentLetterGrade = GetLetterGrade(classAverage*100);
                    Console.WriteLine("{0}'s class average is {1}%.", student.Key, classAverage*100);
                    Console.WriteLine("{0}'s grade in the class is {1}.\n", student.Key, studentLetterGrade);
                };
            }
            PrintStudentInfo(Students);

            decimal CalculateAssignmentAverage (List<decimal> scores)
            {
                decimal sumScores = 0;
                foreach (var score in scores)
                {
                   sumScores = sumScores + score;
                }
                decimal averageScores = sumScores / scores.Count;
                return averageScores; 
            }
            decimal CalculateClassAverage (decimal studentTotalScores)
            {
                decimal studentClassAverage = studentTotalScores / 430;
                return studentClassAverage;
            }
            string GetLetterGrade(decimal studentClassAverage)
            {
                if (studentClassAverage >= 90)
                {
                    studentLetterGrade = "A";
                }
                else if (studentClassAverage >= 80 && studentClassAverage < 90)
                {
                    studentLetterGrade = "B";
                }
                else if (studentClassAverage >= 70 && studentClassAverage < 80)
                {
                    studentLetterGrade = "C";
                }
                else if (studentClassAverage >= 60 && studentClassAverage < 70)
                {
                    studentLetterGrade = "D";
                }
                else
                {
                    studentLetterGrade = "F";
                }
                return studentLetterGrade;
            }
        }
    }
}
