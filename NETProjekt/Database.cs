using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace NETProjekt
{
    class Database
    {
        
        public void CreateUser(string pName,string pSurname, string pUsername, string pPassword, bool pAdmin)
        {
            using(var db = new BaseContext())
            {
                User u = db.Users.Add(new User
                {
                    Name = pName,
                    Surname = pSurname,
                    Username = pUsername,
                    Password = pPassword,
                    IsAdmin = pAdmin,
                });
                db.SaveChanges();
            }
        }
        public List<User> GetUsers()
        {
            using (var db = new BaseContext())
            {
                var users = db.Users.ToList();
                return users;
            }
            
        }

        public void CreateContact(string pName, string pSurname, string pFixed, string pMobile, string pFax)
        {
            using (var db = new BaseContext())
            {
                Contact c = db.Contacts.Add(new Contact
                {
                    Name = pName,
                    Surname = pSurname,
                    FixNumber=pFixed,
                    MobileNumber=pMobile,
                    FaxNumber=pFax

                });
                db.SaveChanges();
            }

        }

        public List<Contact> GetContacts()
        {
            using (var db = new BaseContext())
            {
                var contacts = db.Contacts.ToList();
                return contacts;
            }

        }

        public void UpdateContact(Contact contact, string oldContactName)
        {
            using (var db = new BaseContext())
            {
                var updateContact = db.Contacts
                    .Where(c => c.Name == oldContactName)
                    .FirstOrDefault<Contact>();
                updateContact.Name = contact.Name;
                updateContact.Surname = contact.Surname;
                updateContact.FixNumber = contact.FixNumber;
                updateContact.MobileNumber = contact.MobileNumber;
                updateContact.FaxNumber = contact.FaxNumber;
                db.SaveChanges();


            }
        }

        public void DeleteContact(string deleteContactName)
        {
            using (var db = new BaseContext())
            {
                
                var deleteContact = db.Contacts
                    .Where(c => c.Name == deleteContactName)
                    .FirstOrDefault<Contact>();
                db.Contacts.Remove(deleteContact);
                db.SaveChanges();
            }
        }
    }
}
