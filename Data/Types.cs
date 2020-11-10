using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class Types
    {
        
        public List<string> GetTypes()
        {
            List<string> Currenttypes = new List<string>();
            Currenttypes.Add("Department");
            Currenttypes.Add("Process");
            Currenttypes.Add("Entity");
            Currenttypes.Add("Theme");
            return Currenttypes;
        }
    }

   
}
