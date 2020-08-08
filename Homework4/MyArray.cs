// 3. a Дописать класс для работы с одномерным массивом.
namespace Homework4
{
    public class MyArray
    {
        private int[] arr;

        public int[] Arr => arr;

        private int size;

        public MyArray(int size, int startNum, int step)
        {
            arr = new int[size];
            arr[0] = startNum;
            for (int i = 1; i < size; i++)
            {
                arr[i] = startNum + step;
            }

            this.size = size;
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                foreach (var num in arr)
                {
                    sum += num;
                }
                return sum;
            }
        }

        public int[] Inverse()
        {
            int[] temp = new int[arr.Length];
            int k = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                temp[k++] = arr[i];
            }
            return temp;
        }

        public void Multy(int multiplier)
        {
            int[] temp = new int[arr.Length];
            int i = 0;
            foreach (var num in arr)
            {
                temp[i] = arr[i] * multiplier;
                i++;
            }

            arr = temp;
        }

        public int MaxCount
        {
            get
            {
                return size;
            }
        }
    }
}