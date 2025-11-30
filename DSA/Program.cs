// See https://aka.ms/new-console-template for more information

using System.Collections;
using DSA;

ArrayList();

void RunQuickSort()
{
    int[] arr = { 10, 7, 8, 9, 1, 5 };
    // int[] arr = {4,3,1,2,5,9,7,10,6};
    // int[] arr = {1,2,3,4,5,6,7,8};
    int n = arr.Length;

    MyQuickSort.Run(arr, 0, n - 1, 1);

    foreach (int val in arr)
    {
        Console.Write(val + " ");
    }
}

void ArrayList()
{
    ArrayList list = new ArrayList();
    list.Add(new object());
    list.Add(1);
    

    Console.WriteLine(list.ToArray().Select(o => o.ToString()));
}


