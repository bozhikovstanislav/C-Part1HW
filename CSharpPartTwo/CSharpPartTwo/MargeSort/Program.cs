using System;


namespace MargeSort
{
    class Program
    {
        static public void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
        static public void MergeSort_Recursive(int[] numbers, int left, int right)
        {
            var mid=0;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort_Recursive(numbers, left, mid);
                MergeSort_Recursive(numbers, (mid + 1), right);

                DoMerge(numbers, left, (mid + 1), right);
            }
        }

        static void Main(string[] args)
        {
            var numberN = Console.ReadLine();
            var nNumber = long.Parse(numberN);

            int[] numberArray = new int[nNumber];

            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
            }
            MergeSort_Recursive(numberArray, 0, numberArray.Length-1);
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }

        }
    }
}
