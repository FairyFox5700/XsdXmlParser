using System.Xml.Serialization;

namespace XSDParserConsole.Models
{
    [XmlRoot("planes", Namespace = "http://www.mydomain/planes",IsNullable = false)]
    public partial class Planes
    {
        [XmlElementAttribute("plane")]
        public Plane[] Plane { get; set; }
    }
}