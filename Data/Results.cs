using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class BAIResults
    {
        public int InstanceId { get; set; }
        public int BAIId { get; set; }
        public string BAIName { get; set; }
        public int BAIScore { get; set; }
        public DateTime BAIDate { get; set; }

        public List<BAIResults> GetBAIResults()
        {
            var baiResult = new List<BAIResults>();

            baiResult.Add(new BAIResults() { InstanceId = 1, BAIId = 1, BAIName = "BAI1", BAIDate = DateTime.Now, BAIScore = 1 });
            baiResult.Add(new BAIResults() { InstanceId = 1, BAIId = 2, BAIName = "BAI2", BAIDate = DateTime.Now, BAIScore = 2 });
            baiResult.Add(new BAIResults() { InstanceId = 1, BAIId = 3, BAIName = "BAI3", BAIDate = DateTime.Now, BAIScore = 3 });
            baiResult.Add(new BAIResults() { InstanceId = 2, BAIId = 1, BAIName = "BAI1", BAIDate = DateTime.Now, BAIScore = 4 });
            baiResult.Add(new BAIResults() { InstanceId = 2, BAIId = 2, BAIName = "BAI2", BAIDate = DateTime.Now, BAIScore = 5 });
            baiResult.Add(new BAIResults() { InstanceId = 2, BAIId = 3, BAIName = "BAI3", BAIDate = DateTime.Now, BAIScore = 6 });

            return baiResult;
        }
    }
}
