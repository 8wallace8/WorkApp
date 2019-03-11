using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkApp.Models
{
    public class Tag
    {
        public int TagID { get; set; }
        public int ProjectID { get; set; }
        public string TagType { get; set; }
        public string Description { get; set; }

        public static Tag CreateTag(
            int tagID,
            int projectID,
            string tagType,
            string description)
        {
            return new Tag
            {
                TagID = tagID,
                ProjectID = projectID,
                TagType = tagType,
                Description = description

            };

        }
    }
}