using System.Xml.Serialization;

namespace XSDParserConsole.Models
{
    public class ParametersCharacteristics
    {
        [XmlElement("length")]
        public System.Double Length { get; set; }

        [XmlElement("length")]
        public System.Double Width { get; set; }

        [XmlElement("height")]
        public System.Double Height { get; set; }
    }
}