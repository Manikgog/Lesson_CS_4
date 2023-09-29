using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_CS_4
{
    internal class Pilot : Human
    {
        private string profession;
        private int salary;

        public Pilot(string profession, int salary) : base()
        {
            this.profession = profession;
            this.salary = salary;   
        }

        public Pilot(string name, string lastName, string birthDate, string profession, int salary) 
            : base(name, lastName, birthDate)
        {
            this.profession = profession;
            this.salary = salary;
        }

        public override string toString()
        {
            return this.GetName() + " " + this.GetLastName() + " " + this.GetBirthDate() + " " + profession + " " + salary;
        }

        public int GetSalary() {
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

        public static Pilot operator +(Pilot p, int dobavkaToSalary)
        {
            Pilot newPilot = new Pilot(p.GetName(), p.GetLastName(), p.GetBirthDate(), p.GetProfession(), p.GetSalary());
            newPilot.SetSalary(newPilot.GetSalary() + dobavkaToSalary);
            return newPilot;
        }

        public static Pilot operator -(Pilot p, int dobavkaToSalary)
        {
            Pilot newPilot = new Pilot(p.GetName(), p.GetLastName(), p.GetBirthDate(), p.GetProfession(), p.GetSalary());
            newPilot.SetSalary(newPilot.GetSalary() - dobavkaToSalary);
            return newPilot;
        }

        public static bool operator ==(Pilot p1, Pilot p2)
        {
            if(p1.GetSalary() == p2.GetSalary())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Pilot p1, Pilot p2)
        {
            if (p1.GetSalary() == p2.GetSalary())
            {
                return false; 
            }
            return true;
        }

        public static bool operator >(Pilot p1, Pilot p2)
        {
            if(p1.GetSalary() > p2.GetSalary())
            {
                return true;
            }
            return false;
        }

        public static bool operator <(Pilot p1, Pilot p2)
        {
            if (p1.GetSalary() > p2.GetSalary())
            {
                return false; 
            }
            return true;
        }



    }
}
