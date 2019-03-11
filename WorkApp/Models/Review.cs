using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkApp.Models
{
    public class Review
    {

        public int ReviewID { get; set; }
        public int ProjectID { get; set; }
        public string ReviewType { get; set; }
        public DateTime SubmittalDate { get; set; }
        public DateTime CommentsSent { get; set; }
        public bool Approved { get; set; }
        public string Comments { get; set; }

        public static Review CreateReview(
            int reviewID,
            int projectID,
            string reviewType,
            DateTime submittalDate,
            DateTime commentsSent,
            bool approved,
            string comments)
        {
            return new Review
            {
                ReviewID = reviewID,
                ProjectID = projectID,
                ReviewType = reviewType,
                SubmittalDate = submittalDate,
                CommentsSent = commentsSent,
                Approved = approved,
                Comments = comments

            };
        }

    }
}