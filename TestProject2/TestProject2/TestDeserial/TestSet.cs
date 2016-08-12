using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestProject2.TestDeserial
{
    class TestSet
    {
        [XmlAttribute("TestName")]
        public string TestName { get; set; }

        [XmlArray("Parameters")]
        [XmlArrayItem("Parameter")]
        public List<Parameter> Parameters { get; set; }
    }
}

