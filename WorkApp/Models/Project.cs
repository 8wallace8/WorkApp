using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using WorkApp.Properties;

namespace WorkApp.Models
{
    /// <summary>
    /// Represents a customer of a company.  This class
    /// has built-in validation logic. It is wrapped
    /// by the CustomerViewModel class, which enables it to
    /// be easily displayed and edited by a WPF user interface.
    /// </summary>
    public class Project : IDataErrorInfo
    {
        #region Creation

        public static Project CreateNewProject()
        {
            return new Project();
        }


        public static Project CreateProject(
            int    projectID,
            string projectName,
            string developmentType,
            string projectType,
            string projectStatus)
        {
            return new Project
            {
                ProjectID = projectID,
                ProjectName = projectName,
                DevelopmentType = developmentType,
                ProjectType = projectType,
                ProjectStatus = projectStatus
            };
        }

        protected Project()
        {
        }

        #endregion // Creation

        #region State Properties

        /// <summary>
        /// Gets/sets the ProjectID.
        /// </summary>
        public int ProjectID { get; set; }

        /// <summary>
        /// Gets/sets the project's first name.
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// Gets/sets the development type
        /// The default value is false.
        /// </summary>
        public string DevelopmentType { get; set; }

        /// <summary>
        /// Gets/sets the project type
        /// </summary>
        public string ProjectType { get; set; }

        /// <summary>
        /// Gets/sets the project status
        /// </summary>
        public string ProjectStatus { get; set; }

        #endregion // State Properties

        #region IDataErrorInfo Members

        string IDataErrorInfo.Error { get { return null; } }

        string IDataErrorInfo.this[string propertyName]
        {
            get { return this.GetValidationError(propertyName); }
        }

        #endregion // IDataErrorInfo Members

        #region Validation

        /// <summary>
        /// Returns true if this object has no validation errors.
        /// </summary>
        public bool IsValid
        {
            get
            {
                foreach (string property in ValidatedProperties)
                    if (GetValidationError(property) != null)
                        return false;

                return true;
            }
        }

        static readonly string[] ValidatedProperties = 
        { 
            "ProjectName", 
        };

        string GetValidationError(string propertyName)
        {
            if (Array.IndexOf(ValidatedProperties, propertyName) < 0)
                return null;

            string error = null;

            switch (propertyName)
            {
                case "ProjectName":
                    error = this.ValidateProjectName();
                    break;

                default:
                    Debug.Fail("Unexpected property being validated on Project: " + propertyName);
                    break;
            }

            return error;
        }



        string ValidateProjectName()
        {
            if (IsStringMissing(this.ProjectName))
            {
                return Resources.Customer_Error_MissingFirstName;
            }
            return null;
        }


        static bool IsStringMissing(string value)
        {
            return
                String.IsNullOrEmpty(value) ||
                value.Trim() == String.Empty;
        }

        #endregion // Validation
    }
}