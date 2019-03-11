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
    class TagRepository
    {
        readonly List<Tag> _tags;

        public TagRepository(string tagDataFile)
        {
            _tags = LoadTags(tagDataFile);
            Tags = _tags;
        }

        public List<Tag> Tags { get; set; }

        static List<Tag> LoadTags(string tagDataFile)
        {
            using (Stream stream = GetResourceStream(tagDataFile))
            using (XmlReader xmlRdr = new XmlTextReader(stream))
                return
                    (from tagElem in XDocument.Load(xmlRdr).Element("tags").Elements("tag")
                     select Tag.CreateTag(
                         (int)tagElem.Attribute("tagID"),
                         (int)tagElem.Attribute("projectID"),
                         (string)tagElem.Attribute("tagType"),
                         (string)tagElem.Attribute("description")
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
    }
}
