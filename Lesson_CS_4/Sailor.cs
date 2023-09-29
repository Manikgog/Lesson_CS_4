using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_CS_4
{
    internal class Sailor : Human
    {
        private string profession;
        private int salary;
        public Sailor(string profession, int salary) : base()
        {
            this.profession = profession;
            this.salary = salary;
        }

        public Sailor(string name, string lastName, string birthDate, string profession, int salary)
           : base(name, lastName, birthDate)
        {
            this.profession = profession;
            this.salary = salary;
        }

        public int GetSalary()
        {
            return this.salary;
        }

        public string GetProfession()
        {
            return this.profession;
        }

        public void SetSalary(int salary)
        {
            this.salary = salary;
        }

        public static Sailor operator +(Sailor p, int dobavkaToSalary)
        {
            Sailor newSailor = new Sailor(p.GetName(), p.GetLastName(), p.GetBirthDate(), p.GetProfession(), p.GetSalary());
            newSailor.SetSalary(newSailor.GetSalary() + dobavkaToSalary);
            return newSailor;
        }

        public static Sailor operator -(Sailor p, int dobavkaToSalary)
        {
            Sailor newSailor = new Sailor(p.GetName(), p.GetLastName(), p.GetBirthDate(), p.GetProfession(), p.GetSalary());
            newSailor.SetSalary(newSailor.GetSalary() - dobavkaToSalary);
            return newSailor;
        }

        public static bool operator ==(Sailor p1, Sailor p2)
        {
            if (p1.GetSalary() == p2.GetSalary())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Sailor p1, Sailor p2)
        {
            if (p1.GetSalary() == p2.GetSalary())
            {
                return false;
            }
            return true;
        }

        public static bool operator >(Sailor p1, Sailor p2)
        {
            if (p1.GetSalary() > p2.GetSalary())
            {
                return true;
            }
            return false;
        }

        public static bool operator <(Sailor p1, Sailor p2)
        {
            if (p1.GetSalary() > p2.GetSalary())
            {
                return false;
            }
            return true;
        }

        public override string toString()
        {
            return this.GetName() + " " + this.GetLastName() + " " + this.GetBirthDate() + " " + profession + " " + salary;
        }
    }
}
