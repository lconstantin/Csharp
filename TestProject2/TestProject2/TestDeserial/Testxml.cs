using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestProject2.TestDeserial
{
    [Serializable()]
    [XmlRoot("Testxml")]
    class Testxml
    
    {
        XmlElement("TestSet")]
        public List<TestSet> Tests { get; set; }
    }
}
