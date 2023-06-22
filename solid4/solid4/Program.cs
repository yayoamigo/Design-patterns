using DependencyInv;
using System;

namespace solid4
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson David = Factory.CreatePerson("David", 31, "david@gmail.com");

            IChore chore1 = Factory.CreateChore("Take out the trash", David);

            chore1.PerformedChore(3);
            chore1.PerformedChore(1);
            chore1.CompleteChore();

            int hoursWorked = chore1.HoursWorked;

            Console.Write(hoursWorked);
        }
    }
}