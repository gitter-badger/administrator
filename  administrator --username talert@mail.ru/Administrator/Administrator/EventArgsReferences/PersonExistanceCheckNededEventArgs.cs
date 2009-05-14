using System;
using Administrator.Data;

namespace Administrator.EventArgsReferences
{
    public class PersonExistanceCheckNededEventArgs : EventArgs
    {
        public Person Person { get; private set; }
        public Person FindedPerson { get; set; }
        public bool Exists { get; set; }

        public PersonExistanceCheckNededEventArgs(Person person)
        {
            Person = person;
        }
    }
}
