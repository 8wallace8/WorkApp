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
    class ReviewRepository
    {
        #region Fields
        readonly List<Review> _reviews;
        #endregion

        #region Constructor
        public ReviewRepository(string reviewDataFile)
        {
            _reviews = LoadReviews(reviewDataFile);
            Reviews = _reviews;
        }

        #endregion

        #region Properties

        public List<Review> Reviews { get; set; }

        #endregion

        #region Private Helpers

        static List<Review> LoadReviews(string reviewDataFile)
        {
            using (Stream stream = GetResourceStream(reviewDataFile))
            using (XmlReader xmlRdr = new XmlTextReader(stream))
                return
                    (from reviewElem in XDocument.Load(xmlRdr).Element("reviews").Elements("review")
                    select Review.CreateReview(
                        (int)reviewElem.Attribute("reviewID"),
                        (int)reviewElem.Attribute("projectID"),
                        (string)reviewElem.Attribute("reviewType"),
                        (DateTime)reviewElem.Attribute("submittalDate"),
                        (DateTime)reviewElem.Attribute("commentsSent"),
                        (bool)reviewElem.Attribute("approved"),
                        (string)reviewElem.Attribute("comments")
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

        #endregion
    }
}

