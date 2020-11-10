using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class Instance
    {
        public int id { get; set; }
        public int assessmentId { get; set; }
        public DateTime Date { get; set; }
        public List<BAIResults> Results { get; set; }

        public List<Instance> GetInstances()
        {
            var Instances = new List<Instance>();

            Instances.Add(new Instance() { id = 1, assessmentId = 1, Date = DateTime.Now, Results = new List<BAIResults>()});
            Instances.Add(new Instance() { id = 2, assessmentId = 2, Date = DateTime.Now, Results = new List<BAIResults>()});

            return Instances;
        }

        public List<BAIResults> GetResults()
        //Get all the results from this instance
        {
            var Results = new List<BAIResults>();

            var Res = new BAIResults();
            var Listedresults = Res.GetBAIResults();

            foreach(BAIResults x in Listedresults)
            {
                if(x.InstanceId == id)
                {
                    Results.Add(x);
                }
            } 
            return Results;
        }
    }
}
