using System;

namespace Common_Elements
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = { 1, 3 };

            int[] commonElements = CommonElementss(arr1, arr2);
            Console.WriteLine("Common Elements: " + string.Join(", ", commonElements));
        }

        public static int[] CommonElementss(int[] arr1, int[] arr2)
        {
            // Find the maximum possible number of common elements (min(arr1.Length, arr2.Length))
            int maxPossibleCommonElements = arr1.Length < arr2.Length ? arr1.Length : arr2.Length;
            int[] tempCommonElements = new int[maxPossibleCommonElements];
            int commonCount = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        // Check if the element is already in the tempCommonElements array
                        bool alreadyExists = false;
                        for (int k = 0; k < commonCount; k++)
                        {
                            if (tempCommonElements[k] == arr1[i])
                            {
                                alreadyExists = true;
                                break;
                            }
                        }

                        if (!alreadyExists)
                        {
                            tempCommonElements[commonCount] = arr1[i];
                            commonCount++;
                        }
                    }
                }
            }

            // Create the final array with the exact size of common elements
            int[] commonElements = new int[commonCount];
            for (int i = 0; i < commonCount; i++)
            {
                commonElements[i] = tempCommonElements[i];
            }

            return commonElements;
        }
    }
}
