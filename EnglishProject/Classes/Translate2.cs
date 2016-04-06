using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Configuration;
using System.Windows.Forms;

namespace EnglishProject.Classes
{  class Translate2
    {
        private readonly Data _data;
    private Dictionary<string, string[]> dict; 
        public Translate2()
        {
          _data = Data.Instance;
            dict= new Dictionary<string, string[]>();
        }
        public string Translate(string text)
        {   var g = text.Replace("\n", " \n ").Replace("?", " ? ").Split('.');
            var answer= String.Empty;
            foreach (string s1 in g.Select(s => s.Split('\n')).SelectMany(h => h))
                {
                    bool men = false, biz = false;
                    var words = s1.Split(' ');
                    string fel = String.Empty;
                    k:                  
                    if (words.First().ToLower() == "how")
                    {
                        if (_data.Question.ContainsKey(words[1].ToLower()))
                        {
                            answer += _data.Question.FirstOrDefault(x => x.Key == words[1].ToLower()).Value;
                            words = words.Skip(2).ToArray();
                        }
                        else
                        {
                            words = words.Skip(1).ToArray();
                            answer += "Qanday " + _data.EngUz[words.First().First().ToString()][words.First()];
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
                    words = words.Where(j => _data.Ikki.FirstOrDefault(x => x.Key == j).Value == null).ToArray();
                    if (_data.Uzlik.ContainsKey(words.First().ToLower()) ||
                        _data.Will.ContainsKey(words.First().ToLower()))
                    {
                        answer += " " + _data.Uzlik.FirstOrDefault(x => x.Key == words.First().ToLower()).Value;
                        if (words.First() == "I" || words.First() == "I'll" || words.First() == "I'm") men = true;
                        if (words.First().ToLower() == "we" || words.First().ToLower() == "we're" ||
                            words.First().ToLower() == "we'll") biz = true;
                        if (_data.Will.ContainsKey(words.First().ToLower()) ||
                            _data.Will.ContainsKey(words[1].ToLower()))
                        {
                            words = words.Skip(1).ToArray();
                            if (words[0].ToLower() == "be" || words[1].ToLower() == "be")
                            {
                                words = words[0].ToLower() == "be" ? words.Skip(1).ToArray() : words.Skip(2).ToArray();
                                if (words.First().GetLast(3) == "ing")
                                {
                                    var jkl = words.First().Remove(words.First().Length - 3);
                                    fel = _data.Verbs[jkl.First().ToString()].GetContainsValue(jkl);
                                    if (fel == "")
                                    {
                                    }
                                    else
                                    {
                                        words = words.Skip(1).ToArray();
                                        var h5 = " ";
                                        foreach (var word in words)
                                        {
                                            h5 = _data.EngUz[word.First().ToString()][word].ToString() ?? word;
                                        }
                                        answer += " " + h5 + " " + fel;
                                        words = words.Skip(1).ToArray();
                                    }


                                    if (words[1] != null)
                                    {

                                    }
                                }
                            }
                        }
                        if (words.First().ToLower() == "my")
                        {
                            answer += " " + _data.EngUz[words[1].First().ToString()][words[1].ToLower()] + "im";
                            words = words.Skip(1).ToArray();
                        }
                        if (words.First().ToLower() == "our")
                        {
                            answer += " " + _data.EngUz[words[1].First().ToString()][words[1].ToLower()] + "imiz";
                            words = words.Skip(1).ToArray();
                        }
                        string[] hht = new[] { "his", "her", "him", "your" };
                        if (hht.Contains(words.First().ToLower()))
                        {
                            answer += " " + _data.EngUz[words[1].First().ToString()][words[1].ToLower()] + "ing";
                            words = words.Skip(1).ToArray();
                        }
                        words = words.Skip(1).ToArray();
                        dict = Was(words, men, biz);
                        words = dict.Values.First();
                        answer = dict.Keys.First();
                        dict = null;
                   foreach (string word in words)
                        {

                            if (_data.Uzlik.ContainsKey(word.ToLower()))
                            {
                                goto k;
                            }
                            if (_data.Was.ContainsKey(word))
                            {
                            dict = Was(words, men, biz);
                            words = dict.Values.First();
                            answer = dict.Keys.First();
                            dict = null;
                        }
                            string str;
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
                    }
                  }
                  
            return answer;
        }

    Dictionary<string, string[]> Was(string[] words, bool men,bool biz)
    {       string answer= "";
           if (_data.Was.ContainsKey(words.First().ToLower()))
            {

                if (men)
                {
                    if (!_data.Advice[words[1].ToLower().First().ToString()].ToObject<Dictionary<string, string>>().ContainsKey(words[1].ToLower()))
                    { answer += " " + _data.EngUz[words[1].First().ToString()][words[1].ToLower()] + " bo`lgandim"; }
                    else
                    {
                        if (words.Count() >= 3)
                        {
                            answer += " " + _data.Advice[words[1].First().ToString()][words[1].ToLower()] + " " + _data.EngUz[words?[2]?.First().ToString()][words?[2]?.ToLower()]?.Values<string>() ?? "hello" + " bo`lgandim";
                            words = words.Skip(1).ToArray();
                        }
                        else
                        {
                            answer += " " + _data.Advice[words[1].First().ToString()][words[1].ToLower()] + " " + " bo`lgandim";
                        }
                    }
                    words = words.Skip(2).ToArray();
                }
                if (biz)
                {
                    answer += " " + _data.EngUz[words[1].First().ToString()][words[1].ToLower()] + " edik";
                    words = words.Skip(2).ToArray();
                }

            }
           return  new Dictionary<string, string[]> { { answer, words}};
              

    }
    } 

  
        
    }

