using System.Xml.Serialization;

// XmlSerializer serializer = new XmlSerializer(typeof(Root));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (Root)serializer.Deserialize(reader);
// }

[XmlRoot(ElementName = "root")]
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

	[XmlElement(ElementName = "forceHttps")]
	public bool ForceHttps { get; set; }


	[XmlElement(ElementName = "auth")]
	public bool Auth { get; set; }

	[XmlElement(ElementName = "b64")]
	public bool B64 { get; set; }

	[XmlElement(ElementName = "username")]
	public string Username { get; set; }

	[XmlElement(ElementName = "password")]
	public string Password { get; set; }
}
