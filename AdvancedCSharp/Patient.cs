using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{

    public class Patient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public void Deconstruct(out int id, out string name, out string address)
        {
            id = ID;
            name = Name;
            address = Address;
        }

    }
}
