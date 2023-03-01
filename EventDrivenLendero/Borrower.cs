using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenLendero
{
    public class Borrower : User
    {
        public int ID { get; private set; }
        
        public Borrower(string name, DateTime birthDate, int contactNumber, int iD) : base(name, birthDate, contactNumber)
        {
            this.ID = iD;
        }
    }
}
