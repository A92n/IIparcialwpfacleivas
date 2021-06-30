using DemoWPF3.Tools.Serialization;
using Entities.Interfaces;
using Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Group : XmlFile<Group>
    {

        public string Name { get; set; }
        public int? Leght { get { return Members?.Count; } }
        public ICollection<Person> Members { get; set; }




      
        public Group FromXml(string Path)
        {
            return XmlSerialization.ReadFromXmlFile<Group>(Path);
        }

     
        public void ToXml(string Path)
        {
            XmlSerialization.WriteToXmlFile(Path, this, false);

        }
    }
}
