using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using WorkApp.Events;

namespace WorkApp.ViewModels
{
    class ProjectDiologViewModel : Screen
    {
        private readonly IEventAggregator _eventAggregator;

        public ProjectDiologViewModel()
        {
            
        }

        public StringCollection ListOfProjectTypes
        {
            get
            {
                return Properties.Settings.Default.PROJECT_TYPES;
            }
        }

        public StringCollection ListOfDevelopmentTypes
        {
            get
            {
                return Properties.Settings.Default.DEVELOPMENT_TYPES;
            }
        }

        public StringCollection ListOfProjectStatuses
        {
            get
            {
                return Properties.Settings.Default.PROJECT_STATUS;
            }
        }

        public StringCollection ListOfZonings
        {
            get
            {
                return Properties.Settings.Default.ZONINGS;
            }
        }

        public ProjectDiologViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public void OnSave()
        {
            Properties.Settings.Default.PROJECT_TYPES.Add("I Saved");
            _eventAggregator.PublishOnUIThread(new ProjectSaveEvent("You Just Saved!!"));
        }

        public void OnExit()
        {
            this.TryClose();
        }
    }
}
