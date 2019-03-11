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
    class InspectionRepository
    {
        readonly List<Inspection> _inspections;

        public InspectionRepository(string inspectionDataFile)
        {
            _inspections = LoadInspections(inspectionDataFile);
            Inspections = _inspections;
        }

        public List<Inspection> Inspections { get; set; }

        static List<Inspection> LoadInspections(string inspectionDataFile)
        {
            using (Stream stream = GetResourceStream(inspectionDataFile))
            using (XmlReader xmlRdr = new XmlTextReader(stream))
                return
                    (from inspectionElem in XDocument.Load(xmlRdr).Element("inspections").Elements("inspection")
                     select Inspection.CreateInspection(
                         (int)inspectionElem.Attribute("inspectionID"),
                         (int)inspectionElem.Attribute("projectID"),
                         (DateTime)inspectionElem.Attribute("date"),
                         (string)inspectionElem.Attribute("inspector"),
                         (string)inspectionElem.Attribute("notes")
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
