using System;

namespace encapsuation
{
     public class Person
    {
        private DateTime _birthdate;

        //public void SetBirthDate(DateTime birthdate)
        //{
        //    this._birthdate = birthdate;
        //}

        //public DateTime GetBirthDate()
        //{
        //    return _birthdate;
        //}

        public Person(DateTime birthdate)
        {
            BirthDate = birthdate;
        }

        public DateTime BirthDate { get; private set; }

        public int Age
        {
            get 
            { 
                var timespan = DateTime.Today - BirthDate;
                var years = timespan.Days / 365;

                return years;
            }
        }

    }
}
