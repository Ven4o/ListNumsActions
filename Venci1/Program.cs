using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {

        List<int> myList = new List<int> { 1, 2, 3, 4, 5 };


        myList = Venci.InsertElement(myList, 2, 10);
        Venci.PrintList(myList);


        myList = Venci.DeleteElement(myList, 3);
        Venci.PrintList(myList);
    }
}