  using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace EnglishProject.Classes
{   public static class Extenstion
    { public static string GetLast(this string soursem, int tail_lenght)
        {  if (tail_lenght >= soursem.Length)
            { return soursem;}
            return soursem.Substring(soursem.Length - tail_lenght);
        }

        public static string GetContainsValue(this JToken value, string text)
        {
            return value.ToObject<Dictionary<string, string>>().FirstOrDefault(x => x.Key.Contains(text)).Value?? ""; 
        }
    }

    public  class Data
 {
     private static Data _instanse;

        private Data()
     {
         Uzlik = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("Data/uzlik.json")).ToDictionary(x => x.Key, y => y.Value);
         Question = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("Data/Question.json"))
                 .ToDictionary(x => x.Key, y => y.Value);
         Ikki = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("Data/ikki.json"))
                 .ToDictionary(x => x.Key, y => y.Value);
         First = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("Data/first.json"))
                 .ToDictionary(x => x.Key, y => y.Value);
            var g =new  StreamReader("Data/rusuz.json",  Encoding.GetEncoding(1251));
           string h= String.Empty;
          h=g.ReadToEnd();
            g = null;
         EngUz = JObject.Parse(File.ReadAllText("Data/enguz.json"));
         Engrus = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("Data/engrus.json")).ToDictionary(x => x.Key, y => y.Value);
            Rusuz = JsonConvert.DeserializeObject<Dictionary<string, string>>(h).ToDictionary(x => x.Key, y => y.Value);
            g= new StreamReader("Data/uzrus.json");
            h = g.ReadToEnd();
            Uzrus = JsonConvert.DeserializeObject<Dictionary<string, string>>(h).ToDictionary(x => x.Key, y => y.Value);
         Uzeng = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("Data/uzeng.json")).ToDictionary(x => x.Key, y => y.Value);
        
         Will = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("Data/kelajak.json"))
                .ToDictionary(x => x.Key, y => y.Value);
         Was = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("Data/utgan.json"))
             .ToDictionary(x => x.Key, y => y.Value);
                   Enguz1 = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("Data/enguz1.json"))
             .ToDictionary(x => x.Key, y => y.Value);
            Advice = JObject.Parse(File.ReadAllText("Data/adjective.json"));
            Noun = JObject.Parse(File.ReadAllText("Data/noun.json"));
            Verbs = JObject.Parse(File.ReadAllText("Data/verbs.json"));

     }
         public Dictionary<string, string> Enguz1 { get; set; }
        public Dictionary<string, string> Will { get; set; }
        public Dictionary<string, string> Was { get; set; }
        public Dictionary<string, string> Engrus { get; set; }
        public Dictionary<string, string> Uzrus { get; set; }
        public Dictionary<string, string> Uzeng { get; set; }
        public Dictionary<string, string> Rusuz { get; set; }
        public Dictionary<string, string> Uzlik { get; set; }
        public Dictionary<string, string> Ikki { get; set; }
        public Dictionary<string, string> Question { get; set; }
        public Dictionary<string, string> First { get; set; }
        public JToken EngUz { get; set; }
        public JToken Advice { get; set; }
        public  JToken Noun { get; set; }
        public JObject Verbs { get; set; }
        public static Data Instance
     {
         get
         {
             if(_instanse== null)_instanse= new Data();
             return _instanse;
         }
     }

 }
}
