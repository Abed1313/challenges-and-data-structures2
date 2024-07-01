namespace Find_Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindAndPrintDuplicates();
            Console.WriteLine();
        }

        public static void FindAndPrintDuplicates()
        {
            int[] arr = { 1, 2, 3, 1, 2, 3 };
            List<int> duplicates = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && !duplicates.Contains(arr[i]))
                    {
                        duplicates.Add(arr[i]);
                    }
                }
            }
            Console.WriteLine("Duplicates: " + string.Join(", ", duplicates));
        }
    }
}