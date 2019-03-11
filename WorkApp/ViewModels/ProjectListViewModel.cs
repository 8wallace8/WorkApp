using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using WorkApp.DataAccess;
using WorkApp.Models;

namespace WorkApp.ViewModels
{
    class ProjectListViewModel : Screen
    {
        ProjectRepository _projects;
        string path = "Data/projects.xml";
        public List<Project> Projects { get; private set; }
        public override string DisplayName { get; set; } = "Project List";

        public ProjectListViewModel()
        {
            _projects = new ProjectRepository(path);
            Projects = _projects.GetProjects();
        }



        
    }
}
