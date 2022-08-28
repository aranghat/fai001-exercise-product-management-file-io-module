using System;
using System.Xml.Serialization;

namespace Repositories
{
    internal class XmlSeriallizer : XmlSerializer
    {
        public XmlSeriallizer(Type type) : base(type)
        {
        }
    }
}