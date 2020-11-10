using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class Classes
    {
        public List<string> GetClasses()
        {
            List<string> Currentclasses = new List<string>();
            Currentclasses.Add("Efficiency");
            Currentclasses.Add("Proactiveness");
            Currentclasses.Add("Compliance");
            Currentclasses.Add("Risk");
            return Currentclasses;
        }
    }
}
