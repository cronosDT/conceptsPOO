using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concepstPOO
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }

        public abstract decimal GetValueToPay   ();
        public override string ToString()
        {
            return $"\n\t{Id} - {FirstName} {LastName} " +
                $"\n\tBirth: {BirthDate:00} " +
                $"\n\tHiring: {HiringDate:00} " +
                $"\n\tIs active: {IsActive}";
        }

    }
}
