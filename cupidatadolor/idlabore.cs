string path = System.IO.Path.Combine(Application.StartupPath, "AppValues.xml");
XmlDocument doc = new XmlDocument();
doc.Load(path);
string xmlcontents = doc.InnerXml;
