using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETProjekt
{
    class Phonebook
    {
        public int PhonebookID { get; set; }
        public virtual List<Contact> Contacts { get; set; }
    }
}
