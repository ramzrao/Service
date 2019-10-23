using InfoWebAX;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Linq;

namespace InfoWebAPI.Application.Common.Helpers
{
    public abstract class SerializeXml
    {
        protected ArrayOfXElement Serialize(object obj)
        {
            return SerializedXml(ConvertObjectToJson(new NewDataSet { Table1 = new Table { Table1 = obj } }));
        }

        private string ConvertObjectToJson(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        private XmlDocument AddRoot(XmlDocument document, string name)
        {
            var xDocument = DocumentToXDocumentReader(document);
            var newDocument = new XDocument();
            newDocument.Add(new XElement(name));
            newDocument.Root.Add(xDocument.Root);
            var doc = new XmlDocument();
            doc.LoadXml(newDocument.Root.ToString());
            return doc;
        }

        private XDocument DocumentToXDocumentReader(XmlDocument doc)
        {
            return XDocument.Load(new XmlNodeReader(doc));
        }

        private ArrayOfXElement SerializedXml(string jsonString)
        {
            XmlDocument doc = JsonConvert.DeserializeXmlNode(jsonString);
            doc = AddRoot(doc, "Table1");
            doc = AddRoot(doc, "NewDataSet");
            ArrayOfXElement elements = new ArrayOfXElement();
            elements.Nodes.Add(XmlElementToXelement(doc.DocumentElement));
            return elements;
        }

        private XElement XmlElementToXelement(XmlElement e)
        {
            return XElement.Parse(e.OuterXml);
        }
    }
}