using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_CS_4
{
    abstract class Human
    {
        private string name;
        private string lastName;
        private string birthDate;
        public Human(string name, string lastName, string birthDate)
        {
            this.name = name;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }

        public Human(string name) 
        {
            this.name = name;
            this.lastName = "";
            this.birthDate = "";
        }

        public Human(string name, string lastName)
        {
            this.name = name;
            this.lastName= lastName;
            this.birthDate = "";
        }

        public Human()
        {
            this.name = "";
            this.lastName = "";
            this.birthDate = "";
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public void SetBirthDate(string birthDate)
        {
            this.birthDate = birthDate;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetLastName()
        {
            return this.lastName;
        }

        public string GetBirthDate()
        {
            return this.birthDate;
        }

        public abstract string toString();
    }
}
