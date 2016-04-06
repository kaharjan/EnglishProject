using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using EnglishProject.Classes;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using MetroFramework.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Application = Microsoft.Office.Interop.Word.Application;

namespace EnglishProject
{
    public partial class Form1 : MetroForm //MaterialForm
    {
        
        private Dictionary<string, string> bing;
        private JObject _json;
        private Data _d;
        private Dictionary<string, string> enguz;
        private MetroMessageBox g;
        private Translate2 translate2;
        public Form1()
        {
            InitializeComponent();
            translate2 = new Translate2();
            openFileDialog1.Filter = "Text file|*.txt|Word Documents|*.doc;*.docx| Pdf file|*.pdf";
            bing = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("Data/bing.json"))
                .ToDictionary(x => x.Value, y => y.Key);
            foreach (string key in bing.Keys)
            {
                metroComboBox2.Items.Add(key);
                metroComboBox3.Items.Add(key);
            }
            metroComboBox3.SelectedIndex = 0;
            metroComboBox2.SelectedIndex = 59;
            _d=Data.Instance;
            enguz = new Dictionary<string, string>();
                                  g= new MetroMessageBox();
        }

        private void materialSingleLineTextField1_KeyPress(object sender, KeyPressEventArgs e)
        {
            listBox1.Items.Clear();
            if (_eng)
            {
                if (materialSingleLineTextField1.Text.Count() == 1)
                {
                    enguz = _d.EngUz[materialSingleLineTextField1.Text.ToLower().First().ToString()].ToObject<Dictionary<string, string>>();
                    listBox1.Items.AddRange(enguz.Keys.ToArray());
                }
                else
                {
                    foreach (var s in enguz.Keys.Where(key => key.Contains(materialSingleLineTextField1.Text)))

                    {
                        listBox1.Items.Add(s);
                    }
                }

            }
            else if (_rus)
            {
                foreach (string key in _d.Engrus.Keys.Where(key => key.Contains(materialSingleLineTextField1.Text)))
                {
                    listBox1.Items.Add(key);
                }
            }
            else
            {
                foreach (string key in _d.Uzrus.Keys.Where(key => key.Contains(materialSingleLineTextField1.Text)))
                {
                    listBox1.Items.Add(key);
                }
            }
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
          var f=  translate2.Translate(richTextBox1.Text);
            richTextBox2.Text = f;

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName.Contains(".pdf"))
                {
                    PdfReader reader2 = new PdfReader(openFileDialog1.FileName);
                    string strText = String.Empty;
                    for (int page = 1; page <= reader2.NumberOfPages; page++)
                    {
                        ITextExtractionStrategy its = new SimpleTextExtractionStrategy();
                        var reader = new PdfReader(openFileDialog1.FileName);
                        string s = PdfTextExtractor.GetTextFromPage(reader, page, its);
                        s =
                            Encoding.GetEncoding(1251)
                                .GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8,
                                    Encoding.Default.GetBytes(s)));
                        strText += s;
                        reader.Close();
                    }
                    // Regex.Split(strText,@"/r")
                    strText = strText.Replace(System.Environment.NewLine, string.Empty);
                  //  richTextBox2.Text = translate.Translates(strText.Trim());
                }
                if (openFileDialog1.FileName.Contains(".doc") || openFileDialog1.FileName.Contains(".docx"))
                {
                    Application word = new Application();
                    object miss = System.Reflection.Missing.Value;
                    object readOnly = true;
                    object filename = openFileDialog1.FileName;
                    var doc = word.Documents.Open(ref filename, ref miss, ref readOnly, ref miss, ref miss,
                        ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss,
                        ref miss,
                        ref miss);
                    string totaltext = " ";
                    for (int i = 0; i < doc.Paragraphs.Count; i++)
                    {
                        totaltext += doc.Paragraphs[i + 1].Range.Text;

                    }
                    doc.Close();
                    word.Quit();
                  //  richTextBox2.Text = translate.Translates(totaltext);
                }


            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = GetString(richTextBox3.Text);
        }
         private string GetString(string text)
        {
            string urlstr =
                "https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.1.1.20160220T152438Z.367d421febd48a3c.cb774eeaa2f0d6aba3609403a0a6f3734dfcc68d";
            urlstr += "&text=" + text + "&lang=" + bing[metroComboBox3.SelectedItem.ToString()] + "-" +
                      bing[metroComboBox2.SelectedItem.ToString()];

            try
            {
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                _json = JObject.Parse(client.DownloadString(urlstr));
                return _json["text"].ToString().Replace("[", "").Replace("]", "");
            }
            catch
            {
                MessageBox.Show("Internet ne potklyuchon");
            }

            return null;

        }
         private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName.Contains(".pdf"))
                {
                    PdfReader reader2 = new PdfReader(openFileDialog1.FileName);
                    string strText = String.Empty;
                    for (int page = 1; page <= reader2.NumberOfPages; page++)
                    {
                        ITextExtractionStrategy its = new SimpleTextExtractionStrategy();
                        var reader = new PdfReader(openFileDialog1.FileName);
                        string s = PdfTextExtractor.GetTextFromPage(reader, page, its);
                        s =
                            Encoding.GetEncoding(1251)
                                .GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8,
                                    Encoding.Default.GetBytes(s)));
                        strText += s;
                        reader.Close();
                    }
                    // Regex.Split(strText,@"/r")
                    strText = strText.Replace(System.Environment.NewLine, string.Empty);
                    richTextBox4.Text = GetString(strText.Trim());
                }
                if (openFileDialog1.FileName.Contains(".doc") || openFileDialog1.FileName.Contains(".docx"))
                {
                    Application word = new Application();
                    object miss = System.Reflection.Missing.Value;
                    object readOnly = true;
                    object filename = openFileDialog1.FileName;
                    var doc = word.Documents.Open(ref filename, ref miss, ref readOnly, ref miss, ref miss,
                        ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss,
                        ref miss,
                        ref miss);
                    string totaltext = " ";
                    for (int i = 0; i < doc.Paragraphs.Count; i++)
                    {
                        totaltext += doc.Paragraphs[i + 1].Range.Text;

                    }
                    doc.Close();
                    word.Quit();
                    richTextBox4.Text = GetString(totaltext);
                }

            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroComboBox1.SelectedIndex)
            {
                case 0:
                    _eng = true;
                    _iuz = true;
                    _uz = false;
                    _rus = false;
                    _ieng = false;
                    _irus = false;
                    break;
                case 1:
                    _eng = true;
                    _iuz = false;
                    _uz = false;
                    _rus = false;
                    _ieng = false;
                    _irus = true;
                    break;
                case 2:
                    _eng = false;
                    _iuz = false;
                    _uz = true;
                    _rus = false;
                    _ieng = true;
                    _irus = false;
                    break;

                case 3:
                    _eng = false;
                    _iuz = false;
                    _uz = true;
                    _rus = false;
                    _ieng = false;
                    _irus = true;
                    break;
                case 4:
                    _eng = false;
                    _iuz = true;
                    _uz = false;
                    _rus = true;
                    _ieng = false;
                    _irus = false;
                    break;
                case 5:
                    _eng = false;
                    _iuz = false;
                    _uz = false;
                    _rus = true;
                    _ieng = true;
                    _irus = false;
                    break;

            }
            hello();
        }
        private bool _rus, _uz, _eng, _irus, _iuz, _ieng;
        private TileControl ggg;
        private void metroTile1_Click(object sender, EventArgs e)
        {
            ggg= new TileControl("Future Simple", "Oddiy kelasi zamon","Future Simple asosiy felning oldiga birlik va ko`plik da will yordamchi fe`li qo`yish bilan yasaladi ","Ega+will+V");
            ggg.Show();
            // g.Show(new TileController("Future Simple", "Oddiy kelasi Zamon:\n Future Simple asosiy felning oldiga birlik va ko`plik da will yordamchi fe`li qo`yish bilan yasaladi\n  Ega+will+V"));
            //g.Show(new TileController("Future Simple","Oddiy kelasi Zamon:\n Future Simple asosiy felning oldiga birlik va ko`plik da will yordamchi fe`li qo`yish bilan yasaladi\n  Ega+will+V"));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_eng)
            {
                if (_iuz)
                    metroTextBox1.Text =
                        _d.EngUz[listBox1.SelectedItem.ToString().ToLower().First().ToString()][
                            listBox1.SelectedItem.ToString()].ToString();
                if (_irus) metroTextBox1.Text = _d.Engrus[listBox1.SelectedItem.ToString()];
            }
            else if (_rus)
            {
                if (_iuz)
                    metroTextBox1.Text =
                        _d.Rusuz[listBox1.SelectedItem.ToString()];
                if (_ieng)
                    metroTextBox1.Text =
                        _d.Engrus.FirstOrDefault(x => x.Value == listBox1.SelectedItem.ToString()).Key;
            }
            else
            {
                if (_ieng)
                    metroTextBox1.Text = _d.Enguz1.FirstOrDefault(x => x.Value == listBox1.SelectedItem.ToString()).Key;
                else if (_irus) metroTextBox1.Text = _d.Uzrus[listBox1.SelectedItem.ToString()];
                else
                {
                    MessageBox.Show("Neverniy oshibka");
                }
            }
            try
            {
               
            }
            catch
            {


            }
        }

        private void hello()
        {
            listBox1.Items.Clear();

            if (_uz && _irus)
                listBox1.Items.AddRange(_d.Uzrus.Keys.ToArray());
            else if (_eng)
            {
                listBox1.Items.AddRange(_d.Enguz1.Keys.ToArray());
            }
            else if (_rus)
            {
                listBox1.Items.AddRange(_d.Rusuz.Keys.ToArray());
            }

            else
            {
                listBox1.Items.AddRange(_d.Enguz1.Values.ToArray());
            }
        }
    }
}
