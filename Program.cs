namespace TwoSum
{
    class Program
    {
        static void Main()
        {
            int x, y;
            int[] arr1, arr2, final;

            Console.WriteLine("Input first number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second number");
            y = int.Parse(Console.ReadLine());

            arr1 = numToArray(x);

            foreach(int a1 in arr1)
                Console.Write($"{a1} ");

            Console.WriteLine();

            arr2 = numToArray(y);

            foreach(int a2 in arr2)
                Console.Write($"{a2} ");

            Console.WriteLine();

            final = twoSum(arr1, arr2);

            foreach(int f in final)
                Console.Write($"{f} ");
        }

        static int[] numToArray(int n)
        {
            int[] r = new int[n.ToString().Length];
            int remainder;

            for(int i = 0; i < r.Length; i++)
            {
                remainder = n % 10;
                r[i] = remainder;
                n /= 10;
            }
            
            return r;
        }

        static int[] twoSum(int[] arr1, int[] arr2)
        {
            int[] r = new int[arr1.Length > arr2.Length ? arr1.Length : arr2.Length];

            if(arr1.Length > arr2.Length)
                Array.Resize(ref arr2, arr1.Length);
            
            else if(arr2.Length > arr1.Length)
                Array.Resize(ref arr1, arr2.Length);
            
            for(int i = 0; i < (arr1.Length < arr2.Length ? arr1.Length : arr2.Length); i++)
            {
                r[i] = r[i] + arr1[i] + arr2[i];

                if(r[i] >= 10)
                {
                    if(i == r.Length - 1)
                        Array.Resize(ref r, r.Length + 1);

                    r[i] -= 10;
                    r[i + 1] = 1;
                }
            }
            
            return r;
        }
    }
}