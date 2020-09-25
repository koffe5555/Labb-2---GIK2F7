using System;
using System.Collections.Generic;

namespace labb2ny
{
    public class Carcompany
    {
        public string CompanyName{get; set;}
        public string Address{get; set;}
        public int OrgNr{get; set;}
        public string Url{get; set;}

        public List<Departments> depart;
        
    }
}
