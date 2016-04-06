using System;
using System.Collections.Generic;
using System.Linq;
namespace EnglishProject.Classes
{   public class TranslateClass
    {
        private readonly Data _data;
        private static TranslateClass _transaleclass;
        private TranslateClass()
        {
            _data = Data.Instance;
    }
        public static TranslateClass Instanse => _transaleclass ?? (_transaleclass = new TranslateClass());

       public string Translates(string text)
       {
           bool men = false;
  
           string answer= String.Empty;
           text = text.Replace("\n", " \n ").Replace("?", " ? ");
            var gap1 = text.Split('.');
           foreach (string gap2 in gap1)
           {
            var gap=   gap2.Split('\n');
            foreach (string s in gap)
               {
                   var words = s.Split(' ').ToArray();
                    List<string> gg = words.Where(h => _data.Ikki.FirstOrDefault(x => x.Key == h).Value == null).ToList();
                words = gg.ToArray();
                   gg = null;
                   k:
                   if (words.First().ToLower() == "good")
                   {
                       answer += "Hayrli " + _data.First.FirstOrDefault(m => m.Key == words[1]).Value;
                       words = words.Skip(2).ToArray();
                   }
                   if (_data.First.ContainsKey(words.First().ToLower()))
                   {
                       answer += _data.First.FirstOrDefault(m => m.Key == words.First().ToLower()).Value;
                       words = words.Skip(1).ToArray();
                   }
                   if (words.Count() == 0) continue;

                   if (words.First().ToLower() == "how")
                   {
                       if (_data.Question.ContainsKey(words[1].ToLower()))
                       {
                           answer += _data.Question.FirstOrDefault(x => x.Key == words[1].ToLower());
                           words = words.Skip(2).ToArray();
                       }
                       else
                       {
                           answer += "Qanday" + _data.EngUz[words.First().First().ToString()][words.First()];
                           words = words.Skip(1).ToArray();
                       }

                   }
                   if (_data.Question.ContainsKey(words.First().ToLower()))
                   {
                       answer += _data.Question.FirstOrDefault(x => x.Key == words.First().ToLower()).Value;
                       words = words.Skip(1).ToArray();
                       if (_data.Ikki.ContainsKey(words.First().ToLower()))
                       {
                           words = words.Skip(1).ToArray();

                       }

                   }
                   string wom = words.First().ToLower();
                   if (_data.Uzlik.ContainsKey(words.First().ToLower()))
                   {
                       answer += " " + _data.Uzlik.FirstOrDefault(x => x.Key == words.First().ToLower()).Value;
                       if (words.First() == "I")
                           men = true;
                       words = words.Skip(1).ToArray();
                       if (_data.Will.ContainsKey(words.First().ToLower()))
                       {
                           if (words[1] == "be")
                           {
                               words = words.Skip(2).ToArray();
                               if (men)
                                   answer += " " + _data.EngUz[words.First().First().ToString()][words.First()] +
                                             " bo`laman";
                               else
                                   answer += " " + _data.EngUz[words.First().First().ToString()][words.First()] +
                                             " bo`ladi";
                               words = words.Skip(1).ToArray();
                              }
                           else
                           {
                               if (men)
                                   answer += " " +
                                             _data.Ikki.FirstOrDefault(x => x.Key == words.First().ToLower()).Value +
                                             "man";
                               else
                                   answer += " " +
                                             _data.Ikki.FirstOrDefault(x => x.Key == words.First().ToLower()).Value +
                                             "di";
                               words = words.Skip(1).ToArray();
                           }
                           if (words.Count() == 0) continue;

                       }
                       if (_data.Was.ContainsKey(words.First()))
                       {
                           words = words.Skip(1).ToArray();

                       }

                       if (words.Count() == 0) continue;
                       if (words.First() == "going")
                       {

                           words.Skip(2);
                       }
                   }




                   string str;
                   foreach (string word in words)
                   {

                       if (_data.Uzlik.ContainsKey(word.ToLower()))
                       {
                           goto k;
                       }
                       try
                       {
                           str = _data.EngUz[word.First().ToString()][word.ToLower()].ToString();

                       }
                       catch
                       {
                           str = word;
                       }
                       answer += " " + str;
                       words = words.Skip(1).ToArray();
                   }
                   words = null;

               }
           }

           return answer;
        }

    public string Translate(string text)
    {
        bool men = false;
        string answer = String.Empty;
        text = text.Replace("\n", " \n ").Replace("?", " ? ");
        var gap1 = text.Split('.');
        foreach (string gap2 in gap1)
        {
            var gap = gap2.Split('\n');
            foreach (string s in gap)
            {
                if (s.ToLower().First() == 'i')
                {
                    
                }
            }

        }
        return answer;
    }


    }
}
