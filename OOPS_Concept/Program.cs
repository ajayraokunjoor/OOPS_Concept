using encapsuation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Encapsulation - means hiding the unnecessasry information like implementation detIls from outside world.
            objects should hide their implementation details and reveal what they can do rather than how they do what
            they are suppores to do */
                var person = new Person(new DateTime(1985, 10, 17));
            //person.SetBirthDate(new DateTime(1985, 10, 17));
            //Console.WriteLine(person.GetBirthDate());
            var BirthDate = person.BirthDate;
            Console.WriteLine("BirthDate : " + BirthDate);          

        }
    }
}
