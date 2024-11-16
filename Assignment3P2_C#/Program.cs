namespace Assignment3P2_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment3.17
            //int[,] points = new int[3, 2];
            //for(int i = 0; i < points.GetLength(0); i++)
            //{
            //    Console.WriteLine($"insert point number {i+1}");
            //    Console.WriteLine($"x{i+1} y{i+1}");
            //    string str = Console.ReadLine();
            //    var arr = str.Split(" ");
            //    for (int j = 0; j < points.GetLength(1); j++)
            //    {
            //        points[i,j] = int.Parse(arr[j]);



            //    }
            //}

            //if ((points[0, 0] - points[1,0])/ (points[0, 1] - points[1, 1]) == (points[0, 0] - points[2, 0]) / (points[0, 1] - points[2, 1]))
            //{
            //    Console.WriteLine("Collinear Points!");
            //}
            //else
            //{
            //    Console.WriteLine("Non-Collinear Points!");
            //}
            #endregion

            #region Assignment3.18
            //Console.WriteLine("Enter your Working Hours!");
            //float hours = Single.Parse(Console.ReadLine());
            //if (hours < 3)
            //{
            //    Console.WriteLine("Highly Efficient!");
            //}
            //else if (hours >= 3 && hours < 4)
            //{
            //    Console.WriteLine("Increase your Speed!");
            //}
            //else if(hours >= 4 && hours < 5)
            //{
            //    Console.WriteLine("You need training to enhance your speed!");
            //}
            //else
            //{
            //    Console.WriteLine("You are fired!");
            //}
            #endregion

            #region Assignment3.19
            //Console.WriteLine("Enter the size of the unary matrix you want!");
            //int sz = int.Parse(Console.ReadLine());
            //for(int i = 0; i < sz; i++)
            //{
            //    for(int j = 0; j < sz; j++)
            //    {
            //        if(j == i)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }

            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Assignment3.20With3.23
            //Console.WriteLine("Enter the range of the numbers you want!");
            //int range = int.Parse(Console.ReadLine());
            //int[] arr = new int[range];
            //Console.WriteLine("Enter your desired numbers now!");
            //for (int i = 0; i < range; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine($"Sum of the numbers you entered =  {arr.Sum()}");
            //Console.WriteLine($"Max num in arr you entered =  {arr.Max()}"); //q 3.23
            //Console.WriteLine($"min num in arr you entered =  {arr.Min()}"); //q 3.23


            #endregion



            #region Assignment3.21
            //int[] arr1 = { 2, 33, 65, 21, -12 };
            //int[] arr2 = { 342, -3, 5, 21, -14 };
            //int[] arr3 = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i <= 4)
            //    {
            //        arr3[i] = arr1[i];

            //    }
            //    else
            //    {
            //        arr3[i] = arr2[i - 5];
            //    }
            //}
            //Array.Sort(arr3);
            //Array.Reverse(arr3);
            //for(int i = 0; i < arr3.Length; i++)
            //{
            //    Console.Write(arr3[i] + " ");
            //}
            //Console.WriteLine();

            #endregion

            #region Assignment3.22
            //Console.WriteLine("Enter number of the elements of the array!");
            //int n = int.Parse(Console.ReadLine());
            //int[] freqArr = new int[int.MaxValue/2];
            //int[] mainArr = new int[n];
            //string str = Console.ReadLine();
            //var arr = str.Split(" ");
            //for(int i = 0; i < n; i++)
            //{
            //    mainArr[i] = int.Parse(arr[i]);
            //    freqArr[mainArr[i]]++;
            //}
            //for(int i = mainArr.Min(); i <= mainArr.Max(); i++)
            //{
            //    if (freqArr[i] == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine($"{i} was repeated in array {freqArr[i]} times!");
            //    
            //        
            //    
            //}
            #endregion

            #region Assignment3.24
            //Console.WriteLine("Enter number of the elements of the array!");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //int[] arr3 = new int[n];

            //string str = Console.ReadLine();
            //var arr2 = str.Split(" ");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(arr2[i]);
            //}
            //for(int j = 0; j < n; j++)
            //{
            //    if (arr[j] == arr.Max())
            //    {
            //        arr3[j] = 0;
            //    }
            //    else
            //    {
            //        arr3[j] = arr[j];
            //    }
            //}
            //Console.WriteLine($"Second Max Element in the array = {arr3.Max()}");

            // Using Linq
            Console.WriteLine("Enter number of the elements of the array!");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            string str = Console.ReadLine();
            var arr2 = str.Split(" ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(arr2[i]);
            }
            int res = arr.OrderByDescending(p=>p).Skip(1).FirstOrDefault();
            Console.WriteLine(res);
            #endregion

            #region Assignment3.25
            //Console.WriteLine("Enter number of the elements of the array!");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //int MaxDistance = 0;
            //int MaxEnd = 0;

            //string str = Console.ReadLine();
            //var arr2 = str.Split(" ");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(arr2[i]);
            //}
            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = i + 1; j < n; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            MaxEnd = Math.Max(MaxEnd, j);
            //        }
            //    }
            //    MaxDistance = Math.Max(MaxDistance, MaxEnd - i - 1);
            //}

            //Console.WriteLine($"Max distance for a repeated value is {MaxDistance}");

            #endregion

            #region Assignment3.26
            //Console.WriteLine("Enter your string");
            //string str1 = Console.ReadLine();
            //string[] CharArray = str1.Split(" ");
            //Array.Reverse(CharArray);
            //string str2 = string.Join(" ", CharArray);
            //Console.WriteLine(str2);
            #endregion

            #region Assignment3.27
            //int[,] Arr2D1 = new int[2, 3];
            //int[,] Arr2D2 = new int[2, 3];
            //Console.WriteLine("Enter the elements of 1st 2D Array!");
            //for (int i = 0; i < Arr2D1.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter column {i+1}!");
            //    for(int j = 0; j < Arr2D1.GetLength(1); j++)
            //    {
            //        Arr2D1[i, j] = Convert.ToInt32(Console.ReadLine());
            //        Arr2D2[i, j] = Arr2D1[i, j];
            //    }
            //}

            //Console.WriteLine("The second array is");
            //for (int i = 0; i < Arr2D1.GetLength(0); i++)
            //{

            //    for (int j = 0; j < Arr2D1.GetLength(1); j++)
            //    {
            //        Console.Write(string.Format("{0} ", Arr2D2[i, j]));
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Assignment3.28
            //Console.WriteLine("Enter size of the array!");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[n];
            //string str = Console.ReadLine();
            //var arr2 = str.Split(" ");
            //for (int i = 0; i < n; i++)
            //{
            //    arr1[i] = int.Parse(arr2[i]);
            //}
            //Array.Reverse(arr1);
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(arr1[i]+" ");
            //}
            //Console.WriteLine();
            #endregion
        }
    }
}
