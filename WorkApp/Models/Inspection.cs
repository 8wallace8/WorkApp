using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkApp.Models
{
    public class Inspection
    {
        public int InsectionID { get; set; }
        public int ProjectID { get; set; }
        public DateTime Date { get; set; }
        public string Inspector { get; set; }
        public string Notes { get; set; }

        public static Inspection CreateInspection(
            int inspectionID,
            int projectID,
            DateTime date,
            string inspector,
            string notes)
        {
            return new Inspection
            {
                InsectionID = inspectionID,
                ProjectID = projectID,
                Date = date,
                Inspector = inspector,
                Notes = notes

            };
        }
    }
}
