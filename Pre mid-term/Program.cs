using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Third
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int StudentOfquantity = 1;
            int[] Scoremid, Scorefinal, Scoresum;
            string[] Namestudent;
   
            Console.Write("How many students? : ");
            StudentOfquantity = int.Parse(Console.ReadLine()); 
    
            Namestudent = new string[StudentOfquantity];
            Scoremid = new int[StudentOfquantity];
            Scorefinal = new int[StudentOfquantity];
            Scoresum = new int[StudentOfquantity];
  
            Console.WriteLine(":: Student Information ::");
            for (int Min = 0; Min < StudentOfquantity; Min++)
            {
                Console.Write($"\nPlease key student({Min + 1} of {StudentOfquantity}) name : ");
                Namestudent[Min] = Console.ReadLine();

                Console.Write($"Please key {Namestudent[Min]}'s middle score : ");
                Scoremid[Min] = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Please key {Namestudent[Min]}'s final score : ");
                Scorefinal[Min] = Convert.ToInt32(Console.ReadLine());

                Scoresum[Min] = Scoremid[Min] + Scorefinal[Min];
            }

            Console.WriteLine("\n:: List of students and grades ::");
            int _Min = 0;

            while (_Min < StudentOfquantity)
            {
                float Scoregrades = 0.0f;

                #region Writng an if..else..if code without curly brackets type 1. 

                if (Scoresum[_Min] <= 49) Scoregrades = 0f;
                else if (Scoresum[_Min] <= 54) Scoregrades = 1f;
                else if (Scoresum[_Min] <= 59) Scoregrades = 1.5f;
                else if (Scoresum[_Min] <= 64) Scoregrades = 2f;
                else if (Scoresum[_Min] <= 69) Scoregrades = 2.5f;
                else if (Scoresum[_Min] <= 74) Scoregrades = 3f;
                else if (Scoresum[_Min] <= 79) Scoregrades = 3.5f;
                else if (Scoresum[_Min] >= 80) Scoregrades = 4f;

                #endregion

                #region Writing an if..else..if code with curly brackets.

                #endregion

                Console.WriteLine($"{_Min + 1}. {Namestudent[_Min]} have a" +
                                $" total {Scoresum[_Min]} score or {Scoregrades} grades.");
                _Min++;
            }

            Console.Write("\nPress any key enter....");
            Console.ReadLine();
            //this is my workshop

        }
    }
}