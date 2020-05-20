using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviDrugiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[] { 3, 1, 54, 23,-1, 21.1, 5.7, 3, 6, 42.8, 10, 11};

            NumberSequence numSequence1 = new NumberSequence(array);
            BubbleSort bubSort = new BubbleSort();
            numSequence1.SetSortStrategy(bubSort);
            numSequence1.Sort();
            Console.WriteLine("Bubble sort:");
            Console.WriteLine(numSequence1.ToString());

            NumberSequence numSequence2 = new NumberSequence(array);
            CombSort combSort = new CombSort();
            numSequence2.SetSortStrategy(combSort);
            numSequence2.Sort();
            Console.WriteLine("Comb sort:");
            Console.WriteLine(numSequence2.ToString());

            NumberSequence numSequence3 = new NumberSequence(array);
            SequentialSort sequentialSort = new SequentialSort();
            numSequence3.SetSortStrategy(sequentialSort);
            numSequence3.Sort();
            Console.WriteLine("Sequential sort:");
            Console.WriteLine(numSequence3.ToString());

            NumberSequence numSequence4 = new NumberSequence(array);
            LinearSearch linearSearch = new LinearSearch();
            numSequence4.SetSearchStrategy(linearSearch);
            Console.WriteLine("LinearSearch: ");
            Console.WriteLine(numSequence4.Search(5.7));

        }
    }
}
