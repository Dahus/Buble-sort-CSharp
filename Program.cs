namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array sort = new BubleSort();

            Console.Write("Введите мин. число: ");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите макс. число: ");
            int maxValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длину массива: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            int[] array = sort.GetRandomArray(minValue, maxValue, arrayLength);

            Console.Write("Сгенерированный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("*Сортировка пузырьком*");
            Console.Write("Отсортированный массив: ");
            array = sort.array(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadKey();
        }
    }

    abstract class Array
    {
        public int[] GetRandomArray(int min, int max, int arrayLength)
        {
            int[] array = new int[arrayLength];
            Random rnd = new Random();
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = rnd.Next(min, max);
            }

            return array;
        }

        public abstract int[] array(int[] array);
    }

    // сортировка пузырьком сделать
    class BubleSort : Array
    {
        public override int[] array(int[] array)
        {
            bool sort = true;

            while (sort)
            {
                sort = false;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int number = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = number;
                        sort = true;
                    }
                }
            }

            return array;
        }
    }
}