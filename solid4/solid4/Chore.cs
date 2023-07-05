using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInv
{
    class Chore : IChore
    {
        private ILogger _logger;
        private ISendMessage _message;
        public string ChoreName { get; set; }

        public int Hours { get; set; }

        public IPerson owner { get; set; }

        public int HoursWorked { get; private set; }

        public bool isCompleted { get; private set; }

        public Chore(string choreName, IPerson owner, ILogger logger, ISendMessage message)
        {
            ChoreName = choreName;
            this.owner = owner;
            _logger = logger;
            _message = message;
        }

        public void PerformedChore(int hours)
        {
            HoursWorked += hours;
            
            _logger.Log($"{owner.Name} performed {ChoreName} for {HoursWorked} hours");
        }

        public void CompleteChore()
        {
            isCompleted = true;
            
            _logger.Log($"Completed {ChoreName} for {owner.Name}");
            _message.Send($" sending mes {ChoreName} ");
        }

    }
}
