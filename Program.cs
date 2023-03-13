using System;
using System.Collections.Generic;
using Lab3.SortingAlgorithms;
using System.Diagnostics;
using System.Collections;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {


            //List<double> doubleList = GenerateRandomDoubleList(100, 500);

            //Console.WriteLine("[{0}]", string.Join(", ", intList.ToArray()));
            //Console.WriteLine("[{0}]", string.Join(", ", doubleList.ToArray()));





            //Random

            //Console.WriteLine("[{0}]", string.Join(", ", intList.ToArray()));
            //BubbleSort<int> bubbleSort = new BubbleSort<int>();
            //Console.WriteLine("BUBBLE SORT");



            //for (int i = 0; i < 11; i++)
            //{
            //    List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array

            //    totalTime += TimeSort<int>(bubbleSort, intListCopy);
            //}



            //Console.WriteLine($"{averageTime}");



            List<int> intList = GenerateRandomIntList(1000, 5000);
            double totalTime = 0;
            double averageTime = totalTime / 11;

            //InsertionSort<int> insertionSort = new InsertionSort<int>();
            //Console.WriteLine("INSERTION SORT");
            //totalTime = 0;

            //for (int i = 0; i < 11; i++)
            //{
            //    List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array

            //    totalTime += TimeSort<int>(insertionSort, intListCopy);
            //}

            //averageTime = totalTime / 11;
            //Console.WriteLine($"{averageTime}");


            //MergeSort<int> mergeSort = new MergeSort<int>();
            //Console.WriteLine("MERGE SORT");
            //totalTime = 0;
            //for (int i = 0; i < 11; i++)
            //{
            //    List<int> intListCopy = new List<int>(intList);

            //    totalTime += TimeSort<int>(mergeSort, intListCopy);
            //}
            //averageTime = totalTime / 11;
            //Console.WriteLine($"{averageTime}");

            TreeSort<int> treeSort = new TreeSort<int>();
            Console.WriteLine("TREE SORT");
            totalTime = 0;
            for (int i = 0; i < 11; i++)
            {
                List<int> intListCopy = new List<int>(intList);

                totalTime += TimeSort<int>(treeSort, intListCopy);
            }
            averageTime = totalTime / 11;
            Console.WriteLine($"{averageTime}");

            //MergeSort<int> bucketSort = new MergeSort<int>();
            //Console.WriteLine("BUCKET SORT");
            //totalTime = 0;
            //for (int i = 0; i < 11; i++)
            //{
            //    List<int> intListCopy = new List<int>(intList);

            //    totalTime += TimeSort<int>(bucketSort, intListCopy);
            //}
            //averageTime = totalTime / 11;
            //Console.WriteLine($"{averageTime}");

            //MergeSort<int> countingSort = new MergeSort<int>();
            //Console.WriteLine("COUNTING SORT");
            //totalTime = 0;
            //for (int i = 0; i < 11; i++)
            //{
            //    List<int> intListCopy = new List<int>(intList);

            //    totalTime += TimeSort<int>(countingSort, intListCopy);
            //}
            //averageTime = totalTime / 11;
            //Console.WriteLine($"{averageTime}");




            //REVERSED
            //List<int> intList = GenerateRandomIntList(1000000, 5000000);


            //BubbleSort<int> bubbleSort = new BubbleSort<int>();
            //Console.WriteLine("BUBBLE SORT");
            //Console.WriteLine("[{0}]", string.Join(", ", intList.ToArray()));
            //double totalTime = 0;
            //List<int> revList = new List<int>(intList);
            //revList.Reverse();
            //Console.WriteLine("[{0}]", string.Join(", ", revList.ToArray()));
            //for (int i = 0; i < 11; i++) 
            //{
            //    List<int> intListCopy = new List<int>(revList);   // make a copy of the original unsorted array

            //    totalTime += TimeSort<int>(bubbleSort, intListCopy);
            //}
            //double averageTime = totalTime / 11;
            //Console.WriteLine($"{averageTime}");



            //InsertionSort<int> insertionSort = new InsertionSort<int>();
            //Console.WriteLine("INSERTION SORT");
            //Console.WriteLine("[{0}]", string.Join(", ", intList.ToArray()));
            //totalTime = 0;
            //revList = new List<int>(intList);
            //revList.Reverse();
            //Console.WriteLine("[{0}]", string.Join(", ", revList.ToArray()));
            //for (int i = 0; i < 11; i++)
            //{
            //    List<int> intListCopy = new List<int>(revList);   // make a copy of the original unsorted array

            //    totalTime += TimeSort<int>(insertionSort, intListCopy);
            //}
            //averageTime = totalTime / 11;
            //Console.WriteLine($"{averageTime}");


            //MergeSort<int> mergeSort = new MergeSort<int>();
            //Console.WriteLine("MERGE SORT");
            //Console.WriteLine("[{0}]", string.Join(", ", intList.ToArray()));
            //totalTime = 0;
            //revList = new List<int>(intList);
            //revList.Reverse();
            //Console.WriteLine("[{0}]", string.Join(", ", revList.ToArray()));
            //for (int i = 0; i < 11; i++)
            //{
            //    List<int> intListCopy = new List<int>(revList);

            //    totalTime += TimeSort<int>(mergeSort, intListCopy);
            //}
            //averageTime = totalTime / 11;
            //Console.WriteLine($"{averageTime}");



            //MergeSort<int> treeSort = new MergeSort<int>();
            //Console.WriteLine("TREE SORT");
            //Console.WriteLine("[{0}]", string.Join(", ", intList.ToArray()));
            //totalTime = 0;
            //revList = new List<int>(intList);
            //revList.Reverse();
            //Console.WriteLine("[{0}]", string.Join(", ", revList.ToArray()));
            //for (int i = 0; i < 11; i++)
            //{
            //    List<int> intListCopy = new List<int>(revList);

            //    totalTime += TimeSort<int>(treeSort, intListCopy);
            //}
            //averageTime = totalTime / 11;
            //Console.WriteLine($"{averageTime}");


            //MergeSort<int> bucketSort = new MergeSort<int>();
            //Console.WriteLine("BUCKET SORT");
            //Console.WriteLine("[{0}]", string.Join(", ", intList.ToArray()));
            //totalTime = 0;
            //revList = new List<int>(intList);
            //revList.Reverse();
            //Console.WriteLine("[{0}]", string.Join(", ", revList.ToArray()));
            //for (int i = 0; i < 11; i++)
            //{
            //    List<int> intListCopy = new List<int>(revList);

            //    totalTime += TimeSort<int>(bucketSort, intListCopy);
            //}
            //averageTime = totalTime / 11;
            //Console.WriteLine($"{averageTime}");


            //MergeSort<int> countingSort = new MergeSort<int>();
            //Console.WriteLine("COUNTING SORT");
            //Console.WriteLine("[{0}]", string.Join(", ", intList.ToArray()));
            //totalTime = 0;
            //revList = new List<int>(intList);
            //revList.Reverse();
            //Console.WriteLine("[{0}]", string.Join(", ", revList.ToArray()));
            //for (int i = 0; i < 11; i++)
            //{
            //    List<int> intListCopy = new List<int>(revList);

            //    totalTime += TimeSort<int>(countingSort, intListCopy);
            //}
            //averageTime = totalTime / 11;
            //Console.WriteLine($"{averageTime}");



            //2.5
            //List<int> intList = GenerateNearlySortedIntList(1000000, 5000000);
            //Console.WriteLine("[{0}]", string.Join(", ", intList.ToArray()));

            //BubbleSort<int> bubbleSort = new BubbleSort<int>();
            //Console.WriteLine("BUBBLE SORT");

            //double totalTime = 0;

            //for (int i = 0; i < 11; i++)
            //{
            //    List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array

            //    totalTime += TimeSort<int>(bubbleSort, intListCopy);
            //}
            //double averageTime = totalTime / 11;
            //Console.WriteLine($"{averageTime}");



            //InsertionSort<int> insertionSort = new InsertionSort<int>();
            //Console.WriteLine("INSERTION SORT");
            //totalTime = 0;

            //for (int i = 0; i < 11; i++)
            //{
            //    List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array

            //    totalTime += TimeSort<int>(insertionSort, intListCopy);
            //}

            //averageTime = totalTime / 11;
            //Console.WriteLine($"{averageTime}");


            //MergeSort<int> mergeSort = new MergeSort<int>();
            //Console.WriteLine("MERGE SORT");
            //totalTime = 0;
            //for (int i = 0; i < 11; i++)
            //{
            //    List<int> intListCopy = new List<int>(intList);

            //    totalTime += TimeSort<int>(mergeSort, intListCopy);
            //}
            //averageTime = totalTime / 11;
            //Console.WriteLine($"{averageTime}");

            //TreeSort<int> treeSort = new TreeSort<int>();
            //Console.WriteLine("TREE SORT");
            //totalTime = 0;
            //for (int i = 0; i < 11; i++)
            //{
            //    List<int> intListCopy = new List<int>(intList);

            //    totalTime += TimeSort<int>(treeSort, intListCopy);
            //}
            //averageTime = totalTime / 11;
            //Console.WriteLine($"{averageTime}");

            //BucketSort<int> bucketSort = new BucketSort<int>();
            //Console.WriteLine("BUCKET SORT");
            //totalTime = 0;
            //for (int i = 0; i < 11; i++)
            //{
            //    List<int> intListCopy = new List<int>(intList);

            //    totalTime += TimeSort<int>(bucketSort, intListCopy);
            //}
            //averageTime = totalTime / 11;
            //Console.WriteLine($"{averageTime}");

            //CountingSort<int> countingSort = new CountingSort<int>();
            //Console.WriteLine("COUNTING SORT");
            //totalTime = 0;
            //for (int i = 0; i < 11; i++)
            //{
            //    List<int> intListCopy = new List<int>(intList);

            //    totalTime += TimeSort<int>(countingSort, intListCopy);
            //}
            //averageTime = totalTime / 11;
            //Console.WriteLine($"{averageTime}");












            //Console.WriteLine("[{0}]", string.Join(", ", intList.ToArray()));


            //bubbleSort.Sort(ref intListCopy);

            //BucketSort<int> bucketSort = new BucketSort<int>();
            //bucketSort.Sort(ref intListCopy);

            //HeapSort<int> heapSort = new HeapSort<int>();
            //heapSort.Sort(ref intList);


            //InsertionSort<int> insertionSort = new InsertionSort<int>();
            //insertionSort.Sort(ref intList);

            //SelectionSort<int> selectionSort = new SelectionSort<int>();
            //selectionSort.Sort(ref intList);

            //quickSort.Sort(ref intList);
            //QuickSort<double> quickSortDouble = new QuickSort<double>();
            //quickSortDouble.Sort(ref doubleList);

            //TreeSort<int> treeSort = new TreeSort<int>();
            //treeSort.Sort(ref intList);

            //Console.WriteLine("[{0}]", string.Join(", ", intList.ToArray()));
            //Console.WriteLine("[{0}]", string.Join(", ", doubleList.ToArray()));

            //Console.WriteLine("QUICKSORT");
            //QuickSort<int> quickSort = new QuickSort<int>();
            //for( int i = 0; i < 11; i++)
            //{
            //    List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
            //    TimeSort(quickSort, intListCopy);
            //}

            //MergeSort<int> mergeSort = new MergeSort<int>();
            //for (int i = 0; i < 11; i++)
            //{
            //    List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
            //    TimeSort(mergeSort, intListCopy);
            //}

            //MergeSort<int> mergeSort = new MergeSort<int>();
            //intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
            //TimeSort(mergeSort, intListCopy);

            //InsertionSort<int> insertionSort = new InsertionSort<int>();
            //intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
            //TimeSort(insertionSort, intListCopy);

            //BubbleSort<int> bubbleSort = new BubbleSort<int>();
            //intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
            //TimeSort(bubbleSort, intListCopy);





        }

        private static List<int> GenerateNearlySortedIntList(int length, int maxValue)
        {
            List<int> list = new List<int>();
            list = GenerateRandomIntList(length, maxValue);
            list.Sort();
            var random = new Random();
            for (int i = 0; i < list.Count * 0.025; i++)
            {
                
                int index1 = random.Next(list.Count);
                int index2 = random.Next(list.Count);

                int temp = list[index1];
                list[index1] = list[index2];
                list[index2] = temp;

                
            }
            return list;
            

        }

        public static double TimeSort<T>(ISortable<T> sortable, List<T> items) where T : IComparable<T>
        {
            // start timer
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            sortable.Sort(ref items);

            // end timer
            stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // print info
            //Console.WriteLine(sortable.GetType().ToString());

            // print elapsed time data
            Console.WriteLine(ts.TotalSeconds);

            return ts.TotalSeconds;

        }

        public static double TimeSort(ISortableInt sortable, List<int> items)
        {
            int[] array = items.ToArray();

            // start timer
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var sorted = sortable.Sort(array);

            // end timer
            stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // print info
            //Console.WriteLine(sortable.GetType().ToString());

            // print elapsed time data
            Console.WriteLine(ts.TotalSeconds);

            return ts.TotalSeconds;
        }


        public static List<int> GenerateRandomIntList(int length, int maxValue)
        {
            List<int> list = new List<int>();

            Random random = new Random();

            for(int i=0; i < length; i++)
            {
                list.Add(random.Next(maxValue));               
            }
            list.Sort();
            return list;
        }

        public static List<double> GenerateRandomDoubleList(int length, double maxValue)
        {
            List<double> list = new List<double>();

            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                list.Add(random.NextDouble()* maxValue);
            }

            return list;
        }
    }
}
