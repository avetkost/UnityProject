using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface IWorker2
{
    bool IsDone { get; }
    void Print();
}

public class SecondWorker : IWorker2
{
    public bool IsDone { get; private set; }

    public void Work()
    {
        IsDone = true;
    }

    public void Print()
    {
        Console.WriteLine($"SW{IsDone}");
    }
}

static void Main()
{
    SecondWorker SW1 = new SecondWorker();
    SW1.Print();
    IWorker2 worker = SW1;
    SW1.Work();
    worker.Print();
    SW1.Print();
}
