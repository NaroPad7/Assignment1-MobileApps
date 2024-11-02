using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    private static readonly FileOutput outFile = new FileOutput("animals.txt");
    private static readonly FileInput inFile = new FileInput("animals.txt");

    static void Main(string[] args)
    {
        List<ITalkable> zoo = new List<ITalkable>();

        // Lines to Replace Begin Here
        zoo.Add(new Dog(true, "Bean"));
        zoo.Add(new Cat(9, "Charlie"));
        zoo.Add(new Teacher(44, "Stacy Read"));
        // End Lines to Replace

        foreach (var thing in zoo)
        {
            PrintOut(thing);
        }

        outFile.FileClose();
        inFile.FileRead();
        inFile.FileClose();

        // Reading from the file again after closing
        FileInput inData = new FileInput("animals.txt");
        string line;
        while ((line = inData.FileReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }

    public static void PrintOut(ITalkable p)
    {
        Console.WriteLine($"{p.GetName()} says: {p.Talk()}");
        outFile.FileWrite($"{p.GetName()} | {p.Talk()}");
    }
}