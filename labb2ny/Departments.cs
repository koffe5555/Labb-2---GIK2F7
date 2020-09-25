using System;
using System.Collections.Generic;

namespace labb2ny
{
    public class Departments
    {
        public int EmployedID;

        public List<Worker> Employed;
        public virtual void Work(List<Worker> Employed, int EmployedID)
        {
            this.Employed = Employed;
            this.EmployedID = EmployedID;
            
        }
        
    }
}
