using System;

namespace Indexers
{
    class Car
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public override string ToString()
        {
            return Name + " " + Number;
        }
    }
}
