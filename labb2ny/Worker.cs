using System;
using System.Collections.Generic;


namespace labb2ny
{
    public class Worker
    {
        public string Name{get; set;}
        public string Surname{get; set;}
        public string Titel{get; set;}

        public void Employed(string Name, string Surname, string Titel)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Titel = Titel;
        }
        public Boolean Hire(string Name, string Surname, string Titel)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Titel = Titel;
            return false;
        }

        public Boolean Fire(string Name, string Surname, string Titel)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Titel = Titel;
            return true;
        }

    }
}
