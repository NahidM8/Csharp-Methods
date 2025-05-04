namespace C__Methods_Default_Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Task 1
            //Console.WriteLine(Power(5));


            ////Task 2
            //int[] array = ArrPower(2, 3, 4, 5, 11, 15, 20);
            //foreach (int i in array) 
            //{
            //    Console.Write(i + " ");
            //}


            ////Task 3
            //Console.WriteLine(RemoveSpace(" Na hid Mehdi li "));


            ////Task 4
            //int[] array = {1,5,7};
            //int[] newArray = AddingElement(array,3);
            //foreach (int i in newArray)
            //{
            //    Console.WriteLine(i);
            //}

            ////Extra Tasks
            CheckingDivision(42);

            Console.WriteLine(CountOddNumbers(5, 20));

            Console.WriteLine(SumOfOddNumbers(7, 14));

            PrimeOrComposite(67);

            Console.WriteLine(SumOfEvenNumbers(12, 56, 3, 55, 6, 22, 78));
        }

        //Task 1
        public static int Power (int n) 
        {
            return n *= n;
        }

        //Task 2
        public static int[] ArrPower(params int[] arr) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= arr[i];
            }

            return arr;
        }

        //Task 3
        public static string RemoveSpace(string word)
        {
            string result = string.Empty;
            foreach (var letter in word)
            {
                if (letter != ' ')
                {
                    result += letter;
                }
            }

            return result;
        }

        //Task 4
        public static int[] AddingElement(int[] arr,int a)
        {
            int[] result = new int[arr.Length+1];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[i];
            }
            result[arr.Length] = a;

            return result;
        }



        //Extra tasks
        public static void CheckingDivision(int n)
        {
            if (n % 3 == 0 && n % 7 == 0 && n != 0)
                Console.WriteLine("eded 3 ve 7-e bolunur");
            else
                Console.WriteLine("eded 3 ve ya 7-e bolunmur");
        }

        public static int CountOddNumbers(int n,int m)
        {
            int count = 0;
            if (n<m)
            {
                for (int i = n+1; i < m; i++)
                {
                    if (i % 2 == 1)
                    {
                        count++;
                    }
                }
            }
            else Console.WriteLine("Araliqi duzgun daxil edin");
            return count;
        }

        public static int SumOfOddNumbers (int n, int m)
        {
            int sum = 0;
            if (n < m)
            {
                for (int i = n + 1; i < m; i++)
                {
                    if (i % 2 == 1)
                    {
                        sum += i;
                    }
                }
            }
            else Console.WriteLine("Araliqi duzgun daxil edin");
            return sum;
        }

        public static void PrimeOrComposite(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count > 2)
                Console.WriteLine("Murekkeb ededdir");
            else
                Console.WriteLine("Sade ededdir");
        }

        public static int SumOfEvenNumbers(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }


    }
}
