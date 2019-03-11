using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using WorkApp.Models;

namespace WorkApp.ViewModels
{
    public class ShellViewModel : Conductor<IScreen>.Collection.OneActive
    {
  
        public void CloseTab(IScreen Item)
        {
            DeactivateItem(Item, true);
        }

        public void ShowProjectListView()
        {
            ActivateItem(new ProjectListViewModel());
        }

        public void ShowProjectView(Project project)
        {           
            ActivateItem(new ProjectViewModel(project));
        }

    }
}
