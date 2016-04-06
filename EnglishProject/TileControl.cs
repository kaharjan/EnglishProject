
using MetroFramework.Forms;

namespace EnglishProject
{
    public partial class TileControl : MetroForm
    {
        public TileControl(string tiletext,string labelText, string text, string label2text)
        {

            InitializeComponent();
            this.Text = tiletext;
            textBox2.Text = string.Format(text);
            metroTile1.Text = labelText;

            metroLabel1.Text = label2text;
        }
    }
}
