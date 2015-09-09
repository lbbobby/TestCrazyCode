using UnityEngine;
using System.Collections;
using System.Xml.Serialization;
using System.IO;

public abstract class BaseConfig
{
    public virtual void Parse()
    {

    }

    public virtual void TestWrite()
    {

    }
}

public class ConfigMgr
{
    static T Deserialize<T>(string xml) where T : BaseConfig
    {
        StringReader reader = new StringReader(xml);
        XmlSerializer xmls = new XmlSerializer(typeof(T));
        T config = (T)xmls.Deserialize(reader);
        config.Parse();
        reader.Dispose();
        return config;
    }

    static void Serialize<T>(T t) where T : BaseConfig
    {
#if UNITY_EDITOR
        XmlSerializer xmls = new XmlSerializer(typeof(T));
        using (Stream s = File.Create("d:\\TestClass.xml"))
        {
            xmls.Serialize(s, t);
        }
#endif
    }

    public static void Load()
    {
        Object[] texts = Resources.LoadAll("config/");
        foreach (TextAsset item in texts)
        {
            ParseXml(item.name, item.text);
        }
    }

    static void ParseXml(string fileName, string xml)
    {
        if (fileName == "armyconfig")
        {
            armyConfig = Deserialize<ArmyConfig>(xml);
            Serialize<ArmyConfig>(armyConfig);
        }
    }

    public static ArmyConfig armyConfig { get; private set; }

}
