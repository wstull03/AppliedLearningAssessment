using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedLearningAssessment
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //This is the beginning of Problem 1



            Console.WriteLine("Please enter an integer:");
            int userNum1 = int.Parse(Console.ReadLine());

            if (userNum1 < 10)
            {
                Console.WriteLine("This number is too small");
            }
            else if (userNum1 >= 10)
            {
                Console.WriteLine("This number is big enough");
            }


            
            //This is the end of Problem 1        
            Console.WriteLine();
            //This is the beginning of Problem 2



            float[] myValues1 = { 1.234f, 2.345f, 3.456f, 4.567f, 5.678f };
            Console.WriteLine(myValues1[1]);



            //This is the end of Problem 2        
            Console.WriteLine();
            //This is the beginning of Problem 3



            float[] myValues2 = { 1.234f, 2.345f, 3.456f, 4.567f, 5.678f };

            foreach (float value in myValues2)
            {
                Console.Write(value + " ");
            }


           
            //This is the end of Problem 3        
            Console.WriteLine();
            Console.WriteLine();
            //This is the beginning of Problem 4



            Console.WriteLine("Please enter an integer:");
            int userNum2 = int.Parse(Console.ReadLine());

            switch(userNum2)
            {

                case 1:

                    Console.WriteLine("Only one?");
                    break;

                case 100:

                    Console.WriteLine("100? That's a lot!");
                    break;

                default:

                    Console.WriteLine("Input not recognized.");
                    break;

            }



            //This is the end of Problem 4        
            Console.WriteLine();


        }
    }
}
