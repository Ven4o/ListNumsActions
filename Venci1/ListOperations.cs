using System;
using System.Collections.Generic;

public static class ListOperations
{

    public static List<int> InsertElement(List<int> list, int index, int element)
    {
        list.Insert(index, element);
        return list;
    }

    public static List<int> DeleteElement(List<int> list, int element)
    {
        list.Remove(element);
        return list;
    }


    public static void PrintList(List<int> list)
    {
        Console.WriteLine("Current list: ");
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
