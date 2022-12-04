using System.Xml.Serialization;

// XmlSerializer serializer = new XmlSerializer(typeof(Root));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (Root)serializer.Deserialize(reader);
// }

namespace rascal_controller.configTemplate
{
	[XmlRoot(ElementName = "Root")]
	public class Root
	{
		[XmlElement(ElementName = "remoteURl")]
		public string RemoteURl { get; set; }

		[XmlElement(ElementName = "administratorUrl")]
		public string AdministratorUrl { get; set; }

		[XmlElement(ElementName = "clientUrl")]
		public string ClientUrl { get; set; }

		[XmlElement(ElementName = "disconnectUrl")]
		public string DisconnectUrl { get; set; }
	}

}
