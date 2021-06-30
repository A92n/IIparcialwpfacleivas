using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoWPF3.Tools.Serialization;
using Entities.Interfaces;
using Lib.Serialization;

namespace Entities.Models
{
    [Serializable]
    public class Person:XmlFile<Person>
    {
        public string Names { get; set; }
        public string ItemNames { get; set; }
        
      

        public Person FromXml(string Path)
        {
            return XmlSerialization.ReadFromXmlFile<Person>(Path);
        }

        public void ToXml(string Path)
        {
           XmlSerialization.WriteToXmlFile(Path, this, false);
        }
    }
}
