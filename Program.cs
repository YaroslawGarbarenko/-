using System;

namespace ConsoleApp1._3
{
    public delegate void MyDelegat();

    class Program
    {

        public static void M1()
        {
            int[] array1 = new int[] { 1, 2, 3, 4 };
            int array1Sum = 0;

            for (int i = 0; i < array1.Length; i++)
                array1Sum += array1[i];
            Console.WriteLine("первый делегат");
            Console.WriteLine("сумма: {0}", array1Sum);
            Console.WriteLine("среднее арефмитическое: {0}", array1Sum / array1.Length);
        }

        public static void M2()
        {
            int[] array2 = new int[] { 5, 6, 7, 8 };
            int array2Sum = 0;

            for (int i = 0; i < array2.Length; i++)
                array2Sum += array2[i];

            Console.WriteLine("второй делегат");
            Console.WriteLine("сумма: {0}", array2Sum);
            Console.WriteLine("среднее арефмитическое: {0}", array2Sum / array2.Length);
        }

        //public static void M3()
        //{
        //}


        static void Main(string[] args)
        {
            MyDelegat delMain = null;
            MyDelegat del1 = new MyDelegat(M1);
            MyDelegat del2 = new MyDelegat(M2);
          //  MyDelegat del3 = new MyDelegat(M3);

            delMain = del1 + del2;
            delMain();

            Console.ReadKey();
        }
    }
}
