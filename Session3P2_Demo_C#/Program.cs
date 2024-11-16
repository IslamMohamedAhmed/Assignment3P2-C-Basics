using System.Globalization;
using System.Text;

namespace Session4_Demo_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region StringVsStringBuilder
            //string name01 = new string("islam");
            //string name02 = "Mohamed";


            //string message = "Hello";
            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());
            //message += " Islam";
            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());

            //StringBuilder sb1 = new StringBuilder();
            //sb1.Append("Hello ");
            //Console.WriteLine(sb1);
            //Console.WriteLine(sb1.GetHashCode());
            //sb1.Append("Islam !");
            //Console.WriteLine(sb1);
            //Console.WriteLine(sb1.GetHashCode());


            #endregion

            #region 1DArray
            //int[] number;
            //number = new int[5];
            //Console.WriteLine(++number[1]);
            //int[] number2 = new int[4] { 1, 2, 3, 4 };
            //int[] number3 = new int[] { 1, 2, 3, 4 };
            //int[] number4 = { 1, 2, 3, 4 };

            //Console.WriteLine(number4.Length);
            //Console.WriteLine(number4.Rank); // dimensions of the array
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);

            //}


            #endregion

            #region 2DArray

            //int[,] marks = new int[3, 5] { { 10, 20, 30, 40, 50 }, { 10, 20, 30, 40, 50 }, { 10, 20, 30, 40, 50 } };
            //Console.WriteLine($"size of array = {marks.Length} and dimension of the array = {marks.Rank}");
            //Console.WriteLine($"No of Rows = {marks.GetLength(0)}");
            //Console.WriteLine($"No of Columns = {marks.GetLength(1)}");
            //for (int i = 0; i < marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter Marks for student No. {i + 1}");
            //    for (int j = 0; j < marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter Subject No. {j + 1} mark");
            //        marks[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Marks for student No. {i + 1}");
            //    for (int j = 0; j < marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Subject No. {j + 1} mark");
            //        Console.WriteLine(marks[i, j]);
            //    }
            //}

            #endregion

            #region jaggedArray
            //string[][] jaggedArray = new string[3][]; // Declares a jagged array with 3 rows (null by default)
            //jaggedArray[0] = new string[] { "Apple", "Banana" }; // Assigns an array of 2 strings to the first row
            //jaggedArray[1] = new string[] { "Cherry" };        // Assigns an array of 1 string to the second row
            //jaggedArray[2] = new string[] { "Guava","Mango","Tangerine" };        // Assigns an array of 1 string to the third row

            //for(int i = 0; i < jaggedArray.GetLength(0); i++)
            //{
            //    for(int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write(jaggedArray[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region BoxingAndUnBoxingInC#
            // The process of converting a value type to a reference type.
            // The process of converting a reference type that holds a boxed value back to its original value type.
            //Imporatance of Boxing And Unboxing
            //Enables a unified type system: Since all types ultimately derive from object, any type can be treated as an object reference.
            //Allows storing value types in collections designed for reference types.
            //Potential performance overhead: Boxing and unboxing can introduce some overhead due to memory allocation and copying.

            //int num = 10; // Value type variable

            //object boxedNum = num; // Boxing: convert int to object (reference type)
            //Console.WriteLine(boxedNum);
            //int unboxedNum = (int)boxedNum; // Unboxing: convert object back to int (explicit cast)
            //Console.WriteLine(unboxedNum);

            #endregion

        }
    }
}
