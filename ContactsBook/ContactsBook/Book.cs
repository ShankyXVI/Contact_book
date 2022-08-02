using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsBook
{
    internal class Book 
    {
        List<Contact> ContactBook = new List<Contact>();
        
        public void NewContact()
        {
            // wyjątek z pustym imieniem
            ContactBook.Add(new Contact());
            Console.Write("Wprowadź poniższe dane: imię, nazwisko");
            
        }
        public void ShowAll()
        {
            // wyjątek z pustą bazą danych

        }
        /*public void SearchContact()
        {
            // wyjątek z pustą bazą elementów
            Console.WriteLine("Podaj frazę: ");
            var searchingElement = Console.ReadLine();
            if (searchingElement != null)
            {
                searchingElement = searchingElement.Trim();
                if (ContactBook.Contains(searchingElement)
                {
                    
                }
                foreach (var element in ContactBook)
                {
                    Console.WriteLine(element);
                }
            }
        }*/
    }
}
