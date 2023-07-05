using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInv
{
    class Factory
    {
        public static IChore CreateChore(string choreName, IPerson owner)
        {
           
            return new Chore(choreName, owner, CreateLogger(), CreateMessage());
        }
        public static IPerson CreatePerson(string name, int age, string email)
        {
             
            return new Person(name, age, email);
        }
        public static ILogger CreateLogger()
        {
         
            return new Logger();
        }
        public static ISendMessage CreateMessage()
        {

            return new SendMessage();
        }
    }
}
