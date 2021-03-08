using System.Collections.Generic;
using System;

namespace AddressBookProgram
{
    public class AddressBook
    {
        public Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>();

        public void AddContact(Contact contact)
        {
            try
            {
                Contacts.Add($"{contact.Email}", contact);
            }
            catch
            {
                Console.WriteLine($"Exception: {contact.Email} already exists, cannot add to contacts");
                Console.WriteLine();
            }

        }
        public Contact GetByEmail(string email)
        {
            try
            {
                return Contacts[email];
            }
            catch
            {
                return null;
            }
        }

    }
}