using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Resources;
using System.Xml;
using System.Xml.Linq;
using WorkApp.Models;

namespace WorkApp.DataAccess
{
    /// <summary>
    /// Represents a source of projects in the application.
    /// </summary>
    public class ProjectRepository
    {
        #region Fields

        readonly List<Project> _projects;

        #endregion // Fields

        #region Constructor

        /// <summary>
        /// Creates a new repository of projects.
        /// </summary>
        /// <param name="projectDataFile">The relative path to an XML resource file that contains project data.</param>
        public ProjectRepository(string projectDataFile)
        {
            _projects = LoadProjects(projectDataFile);
        }

        #endregion // Constructor

        #region Public Interface

        /// <summary>
        /// Places the specified project into the repository.
        /// If the project is already in the repository, an
        /// exception is not thrown.
        /// </summary>
        public void AddProject(Project project)
        {
            if (project == null)
                throw new ArgumentNullException("project");

            if (!_projects.Contains(project))
            {
                _projects.Add(project);

            }
        }

        /// <summary>
        /// Returns true if the specified project exists in the
        /// repository, or false if it is not.
        /// </summary>
        public bool ContainsProject(Project project)
        {
            if (project == null)
                throw new ArgumentNullException("project");

            return _projects.Contains(project);
        }

        /// <summary>
        /// Returns a shallow-copied list of all projects in the repository.
        /// </summary>
        public List<Project> GetProjects()
        {
            return new List<Project>(_projects);
        }

        #endregion // Public Interface

        #region Private Helpers

        static List<Project> LoadProjects(string projectDataFile)
        {
            // In a real application, the data would come from an external source,
            // but for this demo let's keep things simple and use a resource file.
            using (Stream stream = GetResourceStream(projectDataFile))
            using (XmlReader xmlRdr = new XmlTextReader(stream))
                return
                    (from projectElem in XDocument.Load(xmlRdr).Element("projects").Elements("project")
                     select Project.CreateProject(
                        (int)projectElem.Attribute("projectID"),
                        (string)projectElem.Attribute("projectName"),
                        (string)projectElem.Attribute("developmentType"),
                        (string)projectElem.Attribute("projectType"),
                        (string)projectElem.Attribute("projectStatus")
                         )).ToList();
        }

        static Stream GetResourceStream(string resourceFile)
        {
            Uri uri = new Uri(resourceFile, UriKind.RelativeOrAbsolute);

            StreamResourceInfo info = Application.GetResourceStream(uri);
            if (info == null || info.Stream == null)
                throw new ApplicationException("Missing resource file: " + resourceFile);

            return info.Stream;
        }

        #endregion // Private Helpers
    }
}