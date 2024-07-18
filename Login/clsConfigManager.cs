//// ConfigManager.cs
//using System.IO;
//using System.Xml;
//using Newtonsoft.Json;

//public class clsConfigManager
//{
//    public string ConnectionString { get; set; }

//    private static string configFilePath = "config.json";

//    public static clsConfigManager Load()
//    {
//        if (File.Exists(configFilePath))
//        {
//            var json = File.ReadAllText(configFilePath);
//            return JsonConvert.DeserializeObject<ConfigManager>(json);
//        }
//        return new ConfigManager();
//    }

//    public void Save()
//    {
//        var json = JsonConvert.SerializeObject(this, Formatting.Indented);
//        File.WriteAllText(configFilePath, json);
//    }
//}
