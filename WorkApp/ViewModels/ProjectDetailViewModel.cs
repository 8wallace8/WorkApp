using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using WorkApp.DataAccess;
using WorkApp.Models;

namespace WorkApp.ViewModels
{
    class ProjectDetailViewModel : Screen
    {
        string reviewData = "Data/reviews.xml";
        string tagData = "Data/tags.xml";
        string inspectionData = "Data/inspections.xml";


        public ProjectDetailViewModel(Project project)
        {
            Project = project;
            DisplayName = project.ProjectName;
            Reviews = new ReviewRepository(reviewData).Reviews;
            Tags = new TagRepository(tagData).Tags;
            Inspections = new InspectionRepository(inspectionData).Inspections;


        }

        public override string DisplayName { get; set; }
        public Project Project { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Inspection> Inspections { get; set; }
    }
}
