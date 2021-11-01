using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Generated;
using XSDParserConsole.Models;

namespace XMLParserClientNet
{
    class Program
    {
        private static string SchemaUri = "planes.xsd";
        private static string XmlPath="planesxml.xml";
        private const string TargetNamespace = "http://www.mydomain/planes";

        static void Main(string[] args)
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add(TargetNamespace, SchemaUri);
            
            var settings = new XmlReaderSettings
            {
                Schemas = schemas,
                ValidationType = ValidationType.Schema,
                ValidationFlags =
                    XmlSchemaValidationFlags.ProcessIdentityConstraints |
                    XmlSchemaValidationFlags.ReportValidationWarnings
            };
            settings.ValidationEventHandler += new ValidationEventHandler(SchemaValidationEventHandler);
            using var input = new StreamReader(XmlPath);
            using XmlReader reader = XmlReader.Create(input, settings);
            XmlSerializer serializer = new XmlSerializer(typeof(Planes));
            Planes planes = (Planes) serializer.Deserialize(reader);
            if (planes != null && planes.Plane.Any())
            {
                var planesList = planes.Plane.ToList(); 
                planesList.Sort();
                PrintPlanes(planesList);
                SerializePlanes(planesList);
            }
        }

        private static  void PrintPlanes(List<Plane> planes)
        {
            for (int i =0; i<planes.Count ;i++)
            {
                Console.WriteLine($"Plane {i}: {planes[i]}");
            }
        }


        private static void SerializePlanes(List<Plane> planes)
        {
            string jsonString = JsonSerializer.Serialize(planes);

            Console.WriteLine(jsonString);
        }
        
        static void SchemaValidationEventHandler(object sender, ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    Console.WriteLine("\nError: {0}", e.Message,Color.Aqua);
                    throw new Exception(e.Message);
                case XmlSeverityType.Warning:
                    Console.WriteLine("\nWarning: {0}", e.Message, Color.Brown);
                    throw new Exception(e.Message);
            }
        }
    }
}