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
    }
}
