using System;

//IDE - INTEGRATED DEVELOPMENT ENVIRONMENT
//VISUAL STUDIO CODE - TEXT EDITOR
//VISUAL STUDIO - TEXT EDITOR + COMPILE
namespace P318FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DataType

            int firstNumber = 30;
            double secondNumber = 10.5;
            decimal thirdNumber = 10.7M;
            float fourNumber = 10.3F;
            bool isMarried = false;
            string name = "sakfjkasjakgnaogaojgosak124125^%##10.5";
            char symbol = 'a';
            int[] array = {1, 2, 3, 4, 5};
            int[] array1 = new int[10];

            double a = 10.5;
            int d;
            var b = 10;
            dynamic c = 10;
            c = "aaa";
            c = true;
            Console.WriteLine(c);

            //Console.WriteLine(firstNumber);

            #endregion

            #region Condition

            //if (isMarried) // = if (isMarried == true)
            //{
            //    Console.WriteLine("Evlidir.");
            //}
            //else
            //{
            //    Console.WriteLine("Evli deil.");
            //}

            //switch (firstNumber)
            //{
            //    case 10:
            //        Console.WriteLine("Eded 10-dur.");
            //        break;
            //    case 20:
            //        Console.WriteLine("Eded 20-dir.");
            //        break;
            //    default:
            //        Console.WriteLine("Eded bilinmir.");
            //        break;
            //}

            #endregion

            #region Loop

            //foreach (int item in array)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion

            #region Console, Try-catch (runtime error)

            //Console.WriteLine("Yashinizi daxil edin:");
            //string ageString = Console.ReadLine();

            //if (int.TryParse(ageString, out int age))
            //{
            //    if (age >= 18)
            //    {
            //        Console.WriteLine("Xosh geldiniz.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Girish qadagandir.");
            //    }
            //}

            //try
            //{
            //    int age = int.Parse(ageString);

            //    if (age >= 18)
            //    {
            //        Console.WriteLine("Xosh geldiniz.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Girish qadagandir.");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("Daxil etdiyiniz reqem deil.");
            //}
            //finally
            //{
            //    Console.WriteLine("Test");
            //}

            #endregion
        }
    }
}
