//No client should be force to depend on methods it doesn use
using System;

// Bad design violating ISP
interface IWorker
{
    void Work();
    void Eat();
}

class Worker : IWorker
{
    public void Work()
    {
        Console.WriteLine("Working...");
    }

    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

class Manager
{
    private readonly IWorker worker;

    public Manager(IWorker worker)
    {
        this.worker = worker;
    }

    public void Manage()
    {
        worker.Work();
        worker.Eat();
    }
}

// Good design following ISP
interface IWorkable
{
    void Work();
}

interface IEatable
{
    void Eat();
}

class Worker2 : IWorkable, IEatable
{
    public void Work()
    {
        Console.WriteLine("Working...");
    }

    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

class Manager2
{
    private readonly IWorkable worker;

    public Manager2(IWorkable worker)
    {
        this.worker = worker;
    }

    public void Manage()
    {
        worker.Work();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Bad design
        IWorker worker = new Worker();
        Manager manager = new Manager(worker);
        manager.Manage();

        Console.WriteLine();

        // Good design
        IWorkable worker2 = new Worker2();
        Manager2 manager2 = new Manager2(worker2);
        manager2.Manage();
    }
}
