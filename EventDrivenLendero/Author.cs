using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenLendero
{
    public class Author : User
    {
        public string PenName { get; private set; }

        public Author(string name, int contactNumber, DateTime birthDate, string penName) : base(name, birthDate, contactNumber)
        {
            this.PenName = penName;
        }
    }
}
