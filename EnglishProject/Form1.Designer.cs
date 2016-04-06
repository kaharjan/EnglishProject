using MaterialSkin.Controls;

namespace EnglishProject
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroScrollBar1 = new MetroFramework.Controls.MetroScrollBar();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.metroTile12 = new MetroFramework.Controls.MetroTile();
            this.metroTile11 = new MetroFramework.Controls.MetroTile();
            this.metroTile10 = new MetroFramework.Controls.MetroTile();
            this.metroTile9 = new MetroFramework.Controls.MetroTile();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.ItemSize = new System.Drawing.Size(58, 18);
            this.materialTabControl1.Location = new System.Drawing.Point(0, 98);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(714, 391);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.metroButton2);
            this.tabPage1.Controls.Add(this.metroButton1);
            this.tabPage1.Controls.Add(this.richTextBox2);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.materialRaisedButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(706, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Translate";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(603, 6);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(87, 51);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Save As";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(19, 6);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(87, 51);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Open File";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.Location = new System.Drawing.Point(369, 63);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(337, 302);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(360, 302);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(300, 6);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(120, 51);
            this.materialRaisedButton1.TabIndex = 1;
            this.materialRaisedButton1.Text = "Translater";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.metroComboBox3);
            this.tabPage2.Controls.Add(this.metroComboBox2);
            this.tabPage2.Controls.Add(this.materialRaisedButton3);
            this.tabPage2.Controls.Add(this.materialRaisedButton2);
            this.tabPage2.Controls.Add(this.metroButton3);
            this.tabPage2.Controls.Add(this.richTextBox4);
            this.tabPage2.Controls.Add(this.richTextBox3);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(706, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Online Translate";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.metroComboBox3.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroComboBox3.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 29;
            this.metroComboBox3.Location = new System.Drawing.Point(140, 13);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(138, 35);
            this.metroComboBox3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroComboBox3.TabIndex = 9;
            this.metroComboBox3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.metroComboBox2.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroComboBox2.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 29;
            this.metroComboBox2.Location = new System.Drawing.Point(410, 13);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(138, 35);
            this.metroComboBox2.Style = MetroFramework.MetroColorStyle.White;
            this.metroComboBox2.TabIndex = 8;
            this.metroComboBox2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(570, 6);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(120, 51);
            this.materialRaisedButton3.TabIndex = 7;
            this.materialRaisedButton3.Text = "Save File";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(14, 6);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(120, 51);
            this.materialRaisedButton2.TabIndex = 6;
            this.materialRaisedButton2.Text = "Open File";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(284, 6);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(120, 51);
            this.metroButton3.TabIndex = 5;
            this.metroButton3.Text = "Translate";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(350, 63);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(360, 302);
            this.richTextBox4.TabIndex = 4;
            this.richTextBox4.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(0, 63);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(344, 302);
            this.richTextBox3.TabIndex = 3;
            this.richTextBox3.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.metroTextBox1);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Controls.Add(this.materialSingleLineTextField1);
            this.tabPage3.Controls.Add(this.metroScrollBar1);
            this.tabPage3.Controls.Add(this.metroComboBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(706, 365);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dictionary";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Enabled = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox1.Location = new System.Drawing.Point(340, 61);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(366, 290);
            this.metroTextBox1.TabIndex = 5;
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(315, 290);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(3, 19);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(315, 23);
            this.materialSingleLineTextField1.TabIndex = 3;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            this.materialSingleLineTextField1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialSingleLineTextField1_KeyPress);
            // 
            // metroScrollBar1
            // 
            this.metroScrollBar1.Location = new System.Drawing.Point(324, 3);
            this.metroScrollBar1.Name = "metroScrollBar1";
            this.metroScrollBar1.Orientation = MetroFramework.Controls.MetroScrollOrientation.Vertical;
            this.metroScrollBar1.Size = new System.Drawing.Size(10, 359);
            this.metroScrollBar1.TabIndex = 1;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "English -> Uzbek",
            "English -> Russian",
            "Uzbek->English ",
            "Uzbek->Russian",
            "Russian->English  ",
            "Russian->Uzbek"});
            this.metroComboBox1.Location = new System.Drawing.Point(340, 3);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(274, 29);
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.metroTile12);
            this.tabPage4.Controls.Add(this.metroTile11);
            this.tabPage4.Controls.Add(this.metroTile10);
            this.tabPage4.Controls.Add(this.metroTile9);
            this.tabPage4.Controls.Add(this.metroTile8);
            this.tabPage4.Controls.Add(this.metroTile7);
            this.tabPage4.Controls.Add(this.metroTile5);
            this.tabPage4.Controls.Add(this.metroTile6);
            this.tabPage4.Controls.Add(this.metroTile4);
            this.tabPage4.Controls.Add(this.metroTile3);
            this.tabPage4.Controls.Add(this.metroTile2);
            this.tabPage4.Controls.Add(this.metroTile1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(706, 365);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "English Grammar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // metroTile12
            // 
            this.metroTile12.Location = new System.Drawing.Point(513, 248);
            this.metroTile12.Name = "metroTile12";
            this.metroTile12.Size = new System.Drawing.Size(177, 112);
            this.metroTile12.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile12.TabIndex = 11;
            this.metroTile12.Text = "Past Perfect Continuous";
            this.metroTile12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile12.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile12.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile12.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // metroTile11
            // 
            this.metroTile11.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroTile11.Location = new System.Drawing.Point(513, 128);
            this.metroTile11.Name = "metroTile11";
            this.metroTile11.Size = new System.Drawing.Size(177, 114);
            this.metroTile11.TabIndex = 10;
            this.metroTile11.Text = "Present Perfect Continuous";
            this.metroTile11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile11.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile11.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile11.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // metroTile10
            // 
            this.metroTile10.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.metroTile10.Location = new System.Drawing.Point(513, 3);
            this.metroTile10.Name = "metroTile10";
            this.metroTile10.Size = new System.Drawing.Size(177, 119);
            this.metroTile10.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile10.TabIndex = 9;
            this.metroTile10.Text = "Future Prefect Continuous";
            this.metroTile10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile10.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile10.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile10.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // metroTile9
            // 
            this.metroTile9.Location = new System.Drawing.Point(173, 248);
            this.metroTile9.Name = "metroTile9";
            this.metroTile9.Size = new System.Drawing.Size(164, 112);
            this.metroTile9.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile9.TabIndex = 8;
            this.metroTile9.Text = "Past Continuous";
            this.metroTile9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile9.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile9.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile9.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // metroTile8
            // 
            this.metroTile8.Location = new System.Drawing.Point(173, 128);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(164, 114);
            this.metroTile8.TabIndex = 7;
            this.metroTile8.Text = "Present Continuous";
            this.metroTile8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile8.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile8.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile8.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // metroTile7
            // 
            this.metroTile7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.metroTile7.Location = new System.Drawing.Point(343, 3);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(164, 119);
            this.metroTile7.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile7.TabIndex = 6;
            this.metroTile7.Text = "Future Prefect";
            this.metroTile7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile7.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile7.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile7.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // metroTile5
            // 
            this.metroTile5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroTile5.CustomBackground = true;
            this.metroTile5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroTile5.Location = new System.Drawing.Point(3, 128);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(164, 114);
            this.metroTile5.TabIndex = 5;
            this.metroTile5.Text = "Present Simple";
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile5.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // metroTile6
            // 
            this.metroTile6.BackColor = System.Drawing.Color.OrangeRed;
            this.metroTile6.CustomBackground = true;
            this.metroTile6.Location = new System.Drawing.Point(3, 248);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(164, 112);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile6.TabIndex = 4;
            this.metroTile6.Text = "Past Simple";
            this.metroTile6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile6.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile6.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile6.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // metroTile4
            // 
            this.metroTile4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.metroTile4.BackColor = System.Drawing.Color.Teal;
            this.metroTile4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroTile4.Location = new System.Drawing.Point(173, 3);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(164, 119);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile4.TabIndex = 0;
            this.metroTile4.Text = "Future Continuous";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // metroTile3
            // 
            this.metroTile3.Location = new System.Drawing.Point(343, 248);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(164, 112);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "Past Perfect";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(343, 128);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(164, 114);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Present Perfect";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // metroTile1
            // 
            this.metroTile1.BackColor = System.Drawing.Color.Teal;
            this.metroTile1.CustomBackground = true;
            this.metroTile1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroTile1.Location = new System.Drawing.Point(3, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(164, 119);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Future Simple";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialTabSelector2.Location = new System.Drawing.Point(0, 47);
            this.materialTabSelector2.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Padding = new System.Windows.Forms.Padding(2);
            this.materialTabSelector2.Size = new System.Drawing.Size(714, 45);
            this.materialTabSelector2.TabIndex = 0;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 488);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Form1";
            this.Text = ".NEXT";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
       
        private MaterialTabSelector materialTabSelector2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialRaisedButton materialRaisedButton3;
        private MaterialRaisedButton materialRaisedButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private MaterialSingleLineTextField materialSingleLineTextField1;
        private MetroFramework.Controls.MetroScrollBar metroScrollBar1;
        private MetroFramework.Controls.MetroTile metroTile12;
        private MetroFramework.Controls.MetroTile metroTile11;
        private MetroFramework.Controls.MetroTile metroTile10;
        private MetroFramework.Controls.MetroTile metroTile9;
        private MetroFramework.Controls.MetroTile metroTile8;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
    }
}

