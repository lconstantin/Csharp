using System.Xml.Serialization;

namespace TestProject2.BasePage.TestDataDeserialization
{
    public class Parameter
    {
    [XmlAttribute("Name")]
    public string Name { get; set; }

    [XmlAttribute("Value")]
    public string Value { get; set; }

    }
}