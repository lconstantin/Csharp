using System.Collections.Generic;
using System.Xml.Serialization;
using NUnit.Framework;

namespace TestProject2.BasePage.TestDataDeserialization
{   
    
    internal class TestSet
    {
    [XmlAttribute("TestName")]
    public string TestName { get; set; }

    [XmlArray("Parameters")]
        [XmlArrayItem("Parameter")]
        public List<Parameter> Parameters { get; set; }
    }
}