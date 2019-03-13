using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using WorkApp.Events;
using WorkApp.Models;

namespace WorkApp.ViewModels
{
    public class ShellViewModel : Conductor<IScreen>.Collection.OneActive, IHandle<ProjectSaveEvent>
    {
        private readonly IWindowManager _windowManager;
        private readonly IEventAggregator _eventAggregator;

        public ShellViewModel(IWindowManager windowManager, IEventAggregator eventAggregator)
        {
            _windowManager = windowManager;
            _eventAggregator = eventAggregator;
            _eventAggregator.Subscribe(this);
        }

        public void CloseTab(IScreen Item)
        {
            DeactivateItem(Item, true);
        }

        public void ShowProjectListView()
        {
            ActivateItem(new ProjectListViewModel());
        }

        public void ShowProjectDetailView(Project project)
        {           
            ActivateItem(new ProjectDetailViewModel(project));
        }

        public void ShowProjectDiologView()
        {       
            ProjectDiologViewModel diolog = new ProjectDiologViewModel(this._eventAggregator);         
            _windowManager.ShowDialog(diolog);
        }

        public void Handle(ProjectSaveEvent e)
        {
            System.Windows.MessageBox.Show(e.Message);
        }
    }
}
