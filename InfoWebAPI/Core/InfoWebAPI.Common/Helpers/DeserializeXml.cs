using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace InfoWebAPI.Application.Common.Helpers
{
    public abstract class DeserializeXml : SerializeXml
    {
        protected List<T> GetDeserializedResponse<T>(List<XElement> elements)
        {
            return DeserializeJson<T>(ConvertXmlToJson(elements[1]));
        }

        protected List<T> GetDeserializedResponse<T>(XmlElement element)
        {
            return DeserializeJson<T>(ConvertXmlToJson(XElement.Parse(element.OuterXml)));
        }

        private string ConvertXmlToJson(XElement element)
        {
            var newDataSetElement = element.Element("NewDataSet");
            if (newDataSetElement == null || newDataSetElement.Element("Table1") == null)
            {
                return string.Empty;
            }
            if (element.Element("NewDataSet").Elements("Table1").Count() == 1)
            {
                XNamespace ns = "http://james.newtonking.com/projects/json";
                AddAttribute(element.Element("NewDataSet"), XNamespace.Xmlns + "json", "http://james.newtonking.com/projects/json");
                AddAttribute(element.Element("NewDataSet").Element("Table1"), ns + "Array", "true");
            }
            var node = new XmlDocument().ReadNode(element.CreateReader()) as XmlNode;
            return JsonConvert.SerializeXmlNode(node);
        }

        private void AddAttribute(XElement element, XName key, string value)
        {
            var attributes = element.Attributes().ToList();
            attributes.Insert(1, new XAttribute(key, value));
            element.Attributes().Remove();
            element.Add(attributes);
        }

        private List<T> DeserializeJson<T>(string jsonString)
        {
            List<JToken> responseList;
            var returnList = new List<T>();
            if (string.IsNullOrEmpty(jsonString))
            {
                return returnList;
            }
            JObject parsedJson = JObject.Parse(jsonString);
            responseList = parsedJson["diffgr:diffgram"]["NewDataSet"]["Table1"].Children().ToList();
            foreach (JToken result in responseList)
            {
                var returnVal = result.ToObject<T>();
                returnList.Add(returnVal);
            }
            return returnList;
        }
    }
}