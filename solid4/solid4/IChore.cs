namespace DependencyInv
{
    internal interface IChore
    {
        string ChoreName { get; set; }
        int Hours { get; set; }
        int HoursWorked { get; }
        bool isCompleted { get; }
        IPerson owner { get; set; }

        void CompleteChore();
        void PerformedChore(int hours);
    }
}