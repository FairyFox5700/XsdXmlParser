using System;
using System.Xml.Serialization;

namespace XSDParserConsole.Models
{
    public class Plane: IComparable<Plane>
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlElementAttribute("model")]
        public System.String Model { get; set; } = "";

        [XmlElementAttribute("origin")]
        public System.String Origin { get; set; } = "";

        [XmlElementAttribute("chars")]
        public Chars Chars { get; set; } = new Chars();

        [XmlElementAttribute("parameters")]
        public Parameters Parameters { get; set; } = new Parameters();
        
        [XmlElementAttribute("price")]
        public double Price { get; set; }

        public int CompareTo(Plane other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return
                $"Plane: Id = {Id}, Model = {Model}, Origin = {Origin}, Price ={Price},{Environment.NewLine}s Chars= {Chars}{Environment.NewLine},Parameters = {Parameters}{Environment.NewLine}";
        }
    }
}