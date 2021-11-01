namespace Generated {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.mydomain/planes")]
    public partial class planes {
        
        private planesPlane planeField;
        
        /// <remarks/>
        public planesPlane plane {
            get {
                return this.planeField;
            }
            set {
                this.planeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.mydomain/planes")]
    public partial class planesPlane {
        
        private string modelField;
        
        private string originField;
        
        private planesPlaneChars charsField;
        
        private planesPlaneParameters parametersField;
        
        private double priceField;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        /// <remarks/>
        public string model {
            get {
                return this.modelField;
            }
            set {
                this.modelField = value;
            }
        }
        
        /// <remarks/>
        public string origin {
            get {
                return this.originField;
            }
            set {
                this.originField = value;
            }
        }
        
        /// <remarks/>
        public planesPlaneChars chars {
            get {
                return this.charsField;
            }
            set {
                this.charsField = value;
            }
        }
        
        /// <remarks/>
        public planesPlaneParameters parameters {
            get {
                return this.parametersField;
            }
            set {
                this.parametersField = value;
            }
        }
        
        /// <remarks/>
        public double price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.mydomain/planes")]
    public partial class planesPlaneChars {
        
        private string numberOfSeatsField;
        
        private bool hasAmmunitionField;
        
        private bool hasRadarField;
        
        private planesPlaneCharsCharacteristics characteristicsField;
        
        private planesPlaneCharsType typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string numberOfSeats {
            get {
                return this.numberOfSeatsField;
            }
            set {
                this.numberOfSeatsField = value;
            }
        }
        
        /// <remarks/>
        public bool hasAmmunition {
            get {
                return this.hasAmmunitionField;
            }
            set {
                this.hasAmmunitionField = value;
            }
        }
        
        /// <remarks/>
        public bool hasRadar {
            get {
                return this.hasRadarField;
            }
            set {
                this.hasRadarField = value;
            }
        }
        
        /// <remarks/>
        public planesPlaneCharsCharacteristics characteristics {
            get {
                return this.characteristicsField;
            }
            set {
                this.characteristicsField = value;
            }
        }
        
        /// <remarks/>
        public planesPlaneCharsType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.mydomain/planes")]
    public partial class planesPlaneCharsCharacteristics {
        
        private string rocketsCountField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string rocketsCount {
            get {
                return this.rocketsCountField;
            }
            set {
                this.rocketsCountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.mydomain/planes")]
    public enum planesPlaneCharsType {
        
        /// <remarks/>
        support,
        
        /// <remarks/>
        convoy,
        
        /// <remarks/>
        destroyer,
        
        /// <remarks/>
        interceptor,
        
        /// <remarks/>
        scout,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.mydomain/planes")]
    public partial class planesPlaneParameters {
        
        private double lengthField;
        
        private double widthField;
        
        private double heightField;
        
        /// <remarks/>
        public double length {
            get {
                return this.lengthField;
            }
            set {
                this.lengthField = value;
            }
        }
        
        /// <remarks/>
        public double width {
            get {
                return this.widthField;
            }
            set {
                this.widthField = value;
            }
        }
        
        /// <remarks/>
        public double height {
            get {
                return this.heightField;
            }
            set {
                this.heightField = value;
            }
        }
    }
}