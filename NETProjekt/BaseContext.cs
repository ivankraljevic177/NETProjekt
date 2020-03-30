using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace NETProjekt
{
    class BaseContext:DbContext
    {
        public BaseContext() : base("Phonebook")
        {


        }

        public DbSet<User> Users { get; set; }
        public DbSet<Phonebook> Phonebooks { get; set; }
        public DbSet<Contact> Contacts { get; set; }

    }
}
