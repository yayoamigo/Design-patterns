using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openClose
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }

        public Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public abstract double CalculateBonus(double salary);

        public override string ToString()
        {
            return string.Format($"ID : {this.Id}, Name:{this.Name}");
        }

    }

    public class PermanentEmployee : Employee
    {

        public PermanentEmployee(int id, string name): base(id, name) 
        { }
        public override double CalculateBonus(double salary)
        {
            return salary * 0.10;
        }
    }

    public class TempEmployee : Employee
    {
        public TempEmployee(int id, string name) : base(id, name)
        { }
        public override double CalculateBonus(double salary)
        {
            return salary * 0.05;
        }
    }
}
