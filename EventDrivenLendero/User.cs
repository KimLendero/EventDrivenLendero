using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenLendero
{
    public abstract class User
    {
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public int ContactNumber { get; set; }

        public User(string name, DateTime birthDate, int contactNumber)
        {
            Name = name;
            BirthDate = birthDate;
            ContactNumber = contactNumber;
        }
    }
}
