/*using System;

public interface IWorker
{
    bool IsDone { get; }
    void Print();
}

public struct FirstWorker : IWorker
{
    public bool IsDone { get; private set; }

    public void Work()
    {
        IsDone = true;
    }

    public void Print()
    {
        Console.WriteLine($"FW{IsDone}");
    }
}

static void Main()
{
    FirstWorker FW1 = new FirstWorker(); // taza fw1 
    FW1.Print(); //
    IWorker worker = FW1;
    FW1.Work();
    worker.Print();
    FW1.Print();
}
*/