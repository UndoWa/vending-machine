using System;
using System.Windows.Forms;

namespace Code_3
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.mente = new System.Windows.Forms.Button();
            this.ValueDisplay1 = new System.Windows.Forms.Label();
            this.ProTemp1 = new System.Windows.Forms.Label();
            this.ValueDisplay2 = new System.Windows.Forms.Label();
            this.ProTemp2 = new System.Windows.Forms.Label();
            this.ValueDisplay3 = new System.Windows.Forms.Label();
            this.ProTemp3 = new System.Windows.Forms.Label();
            this.JihankiName = new System.Windows.Forms.Label();
            this.TimeDisplay = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mentePage = new System.Windows.Forms.TabPage();
            this.kaisyu = new System.Windows.Forms.Button();
            this.kousin = new System.Windows.Forms.Button();
            this.hozyu = new System.Windows.Forms.Button();
            this.secretx1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.batu = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tonyu = new System.Windows.Forms.Button();
            this.ProTemp4 = new System.Windows.Forms.Label();
            this.ProTemp5 = new System.Windows.Forms.Label();
            this.ValueDisplay5 = new System.Windows.Forms.Label();
            this.ProTemp6 = new System.Windows.Forms.Label();
            this.ValueDisplay6 = new System.Windows.Forms.Label();
            this.ValueDisplay4 = new System.Windows.Forms.Label();
            this.secret1 = new System.Windows.Forms.Button();
            this.Jiga = new System.Windows.Forms.Label();
            this.oturi = new System.Windows.Forms.Button();
            this.osusume = new System.Windows.Forms.PictureBox();
            this.onpanman = new System.Windows.Forms.Button();
            this.Soldout3 = new System.Windows.Forms.Panel();
            this.soldout6 = new System.Windows.Forms.Panel();
            this.soldout5 = new System.Windows.Forms.Panel();
            this.Soldout4 = new System.Windows.Forms.Panel();
            this.Soldout2 = new System.Windows.Forms.Panel();
            this.Soldout1 = new System.Windows.Forms.Panel();
            this.ProductBut_3 = new System.Windows.Forms.Button();
            this.ProductBut_2 = new System.Windows.Forms.Button();
            this.ProductBut_1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.mentePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osusume)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mente
            // 
            this.mente.Font = new System.Drawing.Font("UD デジタル 教科書体 NK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mente.Location = new System.Drawing.Point(826, 397);
            this.mente.Margin = new System.Windows.Forms.Padding(5);
            this.mente.Name = "mente";
            this.mente.Size = new System.Drawing.Size(125, 64);
            this.mente.TabIndex = 0;
            this.mente.Text = "メンテナンス";
            this.mente.UseVisualStyleBackColor = true;
            this.mente.Click += new System.EventHandler(this.mente_Click);
            // 
            // ValueDisplay1
            // 
            this.ValueDisplay1.BackColor = System.Drawing.Color.Black;
            this.ValueDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValueDisplay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ValueDisplay1.ForeColor = System.Drawing.Color.White;
            this.ValueDisplay1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ValueDisplay1.Location = new System.Drawing.Point(132, 221);
            this.ValueDisplay1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ValueDisplay1.Name = "ValueDisplay1";
            this.ValueDisplay1.Size = new System.Drawing.Size(71, 27);
            this.ValueDisplay1.TabIndex = 3;
            this.ValueDisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProTemp1
            // 
            this.ProTemp1.AutoSize = true;
            this.ProTemp1.BackColor = System.Drawing.Color.DodgerBlue;
            this.ProTemp1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ProTemp1.Location = new System.Drawing.Point(97, 220);
            this.ProTemp1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProTemp1.Name = "ProTemp1";
            this.ProTemp1.Size = new System.Drawing.Size(33, 30);
            this.ProTemp1.TabIndex = 4;
            this.ProTemp1.Text = "冷";
            // 
            // ValueDisplay2
            // 
            this.ValueDisplay2.BackColor = System.Drawing.Color.Black;
            this.ValueDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValueDisplay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ValueDisplay2.ForeColor = System.Drawing.Color.White;
            this.ValueDisplay2.Location = new System.Drawing.Point(387, 220);
            this.ValueDisplay2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ValueDisplay2.Name = "ValueDisplay2";
            this.ValueDisplay2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ValueDisplay2.Size = new System.Drawing.Size(71, 27);
            this.ValueDisplay2.TabIndex = 5;
            this.ValueDisplay2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProTemp2
            // 
            this.ProTemp2.AutoSize = true;
            this.ProTemp2.BackColor = System.Drawing.Color.Firebrick;
            this.ProTemp2.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ProTemp2.Location = new System.Drawing.Point(352, 219);
            this.ProTemp2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProTemp2.Name = "ProTemp2";
            this.ProTemp2.Size = new System.Drawing.Size(33, 30);
            this.ProTemp2.TabIndex = 6;
            this.ProTemp2.Text = "温";
            // 
            // ValueDisplay3
            // 
            this.ValueDisplay3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValueDisplay3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ValueDisplay3.ForeColor = System.Drawing.Color.White;
            this.ValueDisplay3.Location = new System.Drawing.Point(629, 219);
            this.ValueDisplay3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ValueDisplay3.Name = "ValueDisplay3";
            this.ValueDisplay3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ValueDisplay3.Size = new System.Drawing.Size(71, 27);
            this.ValueDisplay3.TabIndex = 7;
            this.ValueDisplay3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProTemp3
            // 
            this.ProTemp3.AutoSize = true;
            this.ProTemp3.BackColor = System.Drawing.Color.Brown;
            this.ProTemp3.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ProTemp3.Location = new System.Drawing.Point(595, 218);
            this.ProTemp3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProTemp3.Name = "ProTemp3";
            this.ProTemp3.Size = new System.Drawing.Size(33, 30);
            this.ProTemp3.TabIndex = 8;
            this.ProTemp3.Text = "温";
            // 
            // JihankiName
            // 
            this.JihankiName.AutoSize = true;
            this.JihankiName.Font = new System.Drawing.Font("NSimSun", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JihankiName.ForeColor = System.Drawing.Color.White;
            this.JihankiName.Location = new System.Drawing.Point(749, 15);
            this.JihankiName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JihankiName.Name = "JihankiName";
            this.JihankiName.Size = new System.Drawing.Size(290, 37);
            this.JihankiName.TabIndex = 9;
            this.JihankiName.Text = "おんちゃ自販機";
            // 
            // TimeDisplay
            // 
            this.TimeDisplay.Font = new System.Drawing.Font("Leelawadee UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeDisplay.ForeColor = System.Drawing.Color.White;
            this.TimeDisplay.Location = new System.Drawing.Point(759, 59);
            this.TimeDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeDisplay.Name = "TimeDisplay";
            this.TimeDisplay.Size = new System.Drawing.Size(288, 56);
            this.TimeDisplay.TabIndex = 10;
            this.TimeDisplay.Text = "TimeDisplay";
            this.TimeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mentePage);
            this.tabControl1.Font = new System.Drawing.Font("UD デジタル 教科書体 NK", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabControl1.Location = new System.Drawing.Point(610, 245);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(384, 259);
            this.tabControl1.TabIndex = 13;
            this.tabControl1.Visible = false;
            // 
            // mentePage
            // 
            this.mentePage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mentePage.Controls.Add(this.kaisyu);
            this.mentePage.Controls.Add(this.kousin);
            this.mentePage.Controls.Add(this.hozyu);
            this.mentePage.Controls.Add(this.label2);
            this.mentePage.Controls.Add(this.batu);
            this.mentePage.Controls.Add(this.richTextBox1);
            this.mentePage.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mentePage.Location = new System.Drawing.Point(4, 26);
            this.mentePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mentePage.Name = "mentePage";
            this.mentePage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mentePage.Size = new System.Drawing.Size(376, 229);
            this.mentePage.TabIndex = 0;
            this.mentePage.Text = "メンテナンスページ";
            this.mentePage.Click += new System.EventHandler(this.mentePage_Click);
            // 
            // kaisyu
            // 
            this.kaisyu.Font = new System.Drawing.Font("UD デジタル 教科書体 NK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.kaisyu.Location = new System.Drawing.Point(148, 41);
            this.kaisyu.Name = "kaisyu";
            this.kaisyu.Size = new System.Drawing.Size(99, 69);
            this.kaisyu.TabIndex = 5;
            this.kaisyu.Text = "売り上げ回収";
            this.kaisyu.UseVisualStyleBackColor = true;
            this.kaisyu.Click += new System.EventHandler(this.kaisyu_Click);
            // 
            // kousin
            // 
            this.kousin.Font = new System.Drawing.Font("UD デジタル 教科書体 NK", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.kousin.Location = new System.Drawing.Point(307, 18);
            this.kousin.Margin = new System.Windows.Forms.Padding(4);
            this.kousin.Name = "kousin";
            this.kousin.Size = new System.Drawing.Size(25, 25);
            this.kousin.TabIndex = 4;
            this.kousin.Text = "↺";
            this.kousin.UseVisualStyleBackColor = true;
            this.kousin.Click += new System.EventHandler(this.kousin_Click);
            // 
            // hozyu
            // 
            this.hozyu.Font = new System.Drawing.Font("UD デジタル 教科書体 NK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hozyu.Location = new System.Drawing.Point(31, 41);
            this.hozyu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hozyu.Name = "hozyu";
            this.hozyu.Size = new System.Drawing.Size(100, 70);
            this.hozyu.TabIndex = 0;
            this.hozyu.Text = "商品補充";
            this.hozyu.UseVisualStyleBackColor = true;
            this.hozyu.Click += new System.EventHandler(this.hozyu_Click);
            // 
            // secretx1
            // 
            this.secretx1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.secretx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.secretx1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secretx1.Font = new System.Drawing.Font("UD デジタル 教科書体 NK", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.secretx1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.secretx1.Location = new System.Drawing.Point(357, 6);
            this.secretx1.Name = "secretx1";
            this.secretx1.Size = new System.Drawing.Size(34, 35);
            this.secretx1.TabIndex = 29;
            this.secretx1.Text = "×";
            this.secretx1.UseVisualStyleBackColor = false;
            this.secretx1.Click += new System.EventHandler(this.secretx1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(57, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // batu
            // 
            this.batu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.batu.Location = new System.Drawing.Point(339, 18);
            this.batu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.batu.Name = "batu";
            this.batu.Size = new System.Drawing.Size(25, 25);
            this.batu.TabIndex = 1;
            this.batu.Text = "×";
            this.batu.UseVisualStyleBackColor = true;
            this.batu.Click += new System.EventHandler(this.batu_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Font = new System.Drawing.Font("UD デジタル 教科書体 NK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox1.Location = new System.Drawing.Point(40, 129);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(311, 89);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "売り上げ";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(820, 306);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(888, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tonyu
            // 
            this.tonyu.Font = new System.Drawing.Font("UD デジタル 教科書体 NK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tonyu.Location = new System.Drawing.Point(820, 348);
            this.tonyu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tonyu.Name = "tonyu";
            this.tonyu.Size = new System.Drawing.Size(77, 30);
            this.tonyu.TabIndex = 16;
            this.tonyu.Text = "投入";
            this.tonyu.UseVisualStyleBackColor = true;
            this.tonyu.Click += new System.EventHandler(this.tonyu_Click);
            // 
            // ProTemp4
            // 
            this.ProTemp4.AutoSize = true;
            this.ProTemp4.BackColor = System.Drawing.Color.DodgerBlue;
            this.ProTemp4.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ProTemp4.Location = new System.Drawing.Point(97, 506);
            this.ProTemp4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ProTemp4.Name = "ProTemp4";
            this.ProTemp4.Size = new System.Drawing.Size(33, 30);
            this.ProTemp4.TabIndex = 19;
            this.ProTemp4.Text = "冷";
            // 
            // ProTemp5
            // 
            this.ProTemp5.AutoSize = true;
            this.ProTemp5.BackColor = System.Drawing.Color.DodgerBlue;
            this.ProTemp5.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ProTemp5.Location = new System.Drawing.Point(352, 506);
            this.ProTemp5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ProTemp5.Name = "ProTemp5";
            this.ProTemp5.Size = new System.Drawing.Size(33, 30);
            this.ProTemp5.TabIndex = 21;
            this.ProTemp5.Text = "冷";
            // 
            // ValueDisplay5
            // 
            this.ValueDisplay5.BackColor = System.Drawing.Color.Black;
            this.ValueDisplay5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValueDisplay5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ValueDisplay5.ForeColor = System.Drawing.Color.White;
            this.ValueDisplay5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ValueDisplay5.Location = new System.Drawing.Point(387, 509);
            this.ValueDisplay5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ValueDisplay5.Name = "ValueDisplay5";
            this.ValueDisplay5.Size = new System.Drawing.Size(71, 27);
            this.ValueDisplay5.TabIndex = 20;
            this.ValueDisplay5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProTemp6
            // 
            this.ProTemp6.AutoSize = true;
            this.ProTemp6.BackColor = System.Drawing.Color.DodgerBlue;
            this.ProTemp6.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ProTemp6.Location = new System.Drawing.Point(595, 506);
            this.ProTemp6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ProTemp6.Name = "ProTemp6";
            this.ProTemp6.Size = new System.Drawing.Size(33, 30);
            this.ProTemp6.TabIndex = 23;
            this.ProTemp6.Text = "冷";
            // 
            // ValueDisplay6
            // 
            this.ValueDisplay6.BackColor = System.Drawing.Color.Black;
            this.ValueDisplay6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValueDisplay6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ValueDisplay6.ForeColor = System.Drawing.Color.White;
            this.ValueDisplay6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ValueDisplay6.Location = new System.Drawing.Point(629, 509);
            this.ValueDisplay6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ValueDisplay6.Name = "ValueDisplay6";
            this.ValueDisplay6.Size = new System.Drawing.Size(71, 27);
            this.ValueDisplay6.TabIndex = 22;
            this.ValueDisplay6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValueDisplay4
            // 
            this.ValueDisplay4.BackColor = System.Drawing.Color.Black;
            this.ValueDisplay4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValueDisplay4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ValueDisplay4.ForeColor = System.Drawing.Color.White;
            this.ValueDisplay4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ValueDisplay4.Location = new System.Drawing.Point(132, 506);
            this.ValueDisplay4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ValueDisplay4.Name = "ValueDisplay4";
            this.ValueDisplay4.Size = new System.Drawing.Size(71, 27);
            this.ValueDisplay4.TabIndex = 24;
            this.ValueDisplay4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secret1
            // 
            this.secret1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.secret1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secret1.Font = new System.Drawing.Font("UD デジタル 教科書体 NK", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.secret1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.secret1.Location = new System.Drawing.Point(320, 7);
            this.secret1.Margin = new System.Windows.Forms.Padding(4);
            this.secret1.Name = "secret1";
            this.secret1.Size = new System.Drawing.Size(33, 34);
            this.secret1.TabIndex = 25;
            this.secret1.Text = "⚠";
            this.secret1.UseVisualStyleBackColor = false;
            this.secret1.Click += new System.EventHandler(this.secret1_Click);
            // 
            // Jiga
            // 
            this.Jiga.BackColor = System.Drawing.Color.Transparent;
            this.Jiga.Font = new System.Drawing.Font("游ゴシック", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Jiga.ForeColor = System.Drawing.Color.White;
            this.Jiga.Location = new System.Drawing.Point(724, 121);
            this.Jiga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Jiga.Name = "Jiga";
            this.Jiga.Size = new System.Drawing.Size(347, 125);
            this.Jiga.TabIndex = 17;
            this.Jiga.Text = "さっさと買え";
            this.Jiga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oturi
            // 
            this.oturi.Font = new System.Drawing.Font("UD デジタル 教科書体 NK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.oturi.Location = new System.Drawing.Point(914, 348);
            this.oturi.Name = "oturi";
            this.oturi.Size = new System.Drawing.Size(80, 30);
            this.oturi.TabIndex = 30;
            this.oturi.Text = "お釣り";
            this.oturi.UseVisualStyleBackColor = true;
            this.oturi.Click += new System.EventHandler(this.oturi_Click);
            // 
            // osusume
            // 
            this.osusume.Image = global::Code_3.Properties.Resources.osusume;
            this.osusume.Location = new System.Drawing.Point(35, 481);
            this.osusume.Margin = new System.Windows.Forms.Padding(2);
            this.osusume.Name = "osusume";
            this.osusume.Size = new System.Drawing.Size(71, 71);
            this.osusume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.osusume.TabIndex = 32;
            this.osusume.TabStop = false;
            this.osusume.Visible = false;
            this.osusume.Click += new System.EventHandler(this.osusume_Click);
            // 
            // onpanman
            // 
            this.onpanman.BackgroundImage = global::Code_3.Properties.Resources.ontyaanpanman;
            this.onpanman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.onpanman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onpanman.Location = new System.Drawing.Point(1043, 540);
            this.onpanman.Margin = new System.Windows.Forms.Padding(2);
            this.onpanman.Name = "onpanman";
            this.onpanman.Size = new System.Drawing.Size(28, 22);
            this.onpanman.TabIndex = 31;
            this.onpanman.UseVisualStyleBackColor = true;
            this.onpanman.Click += new System.EventHandler(this.onpanman_Click);
            // 
            // Soldout3
            // 
            this.Soldout3.BackgroundImage = global::Code_3.Properties.Resources.売り切れ画像1;
            this.Soldout3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Soldout3.Location = new System.Drawing.Point(540, 108);
            this.Soldout3.Margin = new System.Windows.Forms.Padding(4);
            this.Soldout3.Name = "Soldout3";
            this.Soldout3.Size = new System.Drawing.Size(203, 62);
            this.Soldout3.TabIndex = 12;
            this.Soldout3.Visible = false;
            this.Soldout3.Paint += new System.Windows.Forms.PaintEventHandler(this.Soldout3_Paint);
            // 
            // soldout6
            // 
            this.soldout6.BackgroundImage = global::Code_3.Properties.Resources.売り切れ画像1;
            this.soldout6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soldout6.Location = new System.Drawing.Point(543, 372);
            this.soldout6.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.soldout6.Name = "soldout6";
            this.soldout6.Size = new System.Drawing.Size(203, 62);
            this.soldout6.TabIndex = 14;
            this.soldout6.Visible = false;
            // 
            // soldout5
            // 
            this.soldout5.BackgroundImage = global::Code_3.Properties.Resources.売り切れ画像1;
            this.soldout5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soldout5.Location = new System.Drawing.Point(296, 372);
            this.soldout5.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.soldout5.Name = "soldout5";
            this.soldout5.Size = new System.Drawing.Size(203, 62);
            this.soldout5.TabIndex = 13;
            this.soldout5.Visible = false;
            // 
            // Soldout4
            // 
            this.Soldout4.BackgroundImage = global::Code_3.Properties.Resources.売り切れ画像1;
            this.Soldout4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Soldout4.Location = new System.Drawing.Point(52, 372);
            this.Soldout4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Soldout4.Name = "Soldout4";
            this.Soldout4.Size = new System.Drawing.Size(203, 62);
            this.Soldout4.TabIndex = 12;
            this.Soldout4.Visible = false;
            // 
            // Soldout2
            // 
            this.Soldout2.BackgroundImage = global::Code_3.Properties.Resources.売り切れ画像1;
            this.Soldout2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Soldout2.Location = new System.Drawing.Point(296, 108);
            this.Soldout2.Margin = new System.Windows.Forms.Padding(4);
            this.Soldout2.Name = "Soldout2";
            this.Soldout2.Size = new System.Drawing.Size(203, 62);
            this.Soldout2.TabIndex = 12;
            this.Soldout2.Visible = false;
            // 
            // Soldout1
            // 
            this.Soldout1.BackgroundImage = global::Code_3.Properties.Resources.売り切れ画像1;
            this.Soldout1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Soldout1.Location = new System.Drawing.Point(52, 108);
            this.Soldout1.Margin = new System.Windows.Forms.Padding(4);
            this.Soldout1.Name = "Soldout1";
            this.Soldout1.Size = new System.Drawing.Size(203, 62);
            this.Soldout1.TabIndex = 11;
            this.Soldout1.Visible = false;
            // 
            // ProductBut_3
            // 
            this.ProductBut_3.BackColor = System.Drawing.Color.Transparent;
            this.ProductBut_3.BackgroundImage = global::Code_3.Properties.Resources.test_drink_3;
            this.ProductBut_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProductBut_3.FlatAppearance.BorderSize = 0;
            this.ProductBut_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductBut_3.Location = new System.Drawing.Point(565, 15);
            this.ProductBut_3.Margin = new System.Windows.Forms.Padding(4);
            this.ProductBut_3.Name = "ProductBut_3";
            this.ProductBut_3.Size = new System.Drawing.Size(180, 206);
            this.ProductBut_3.TabIndex = 2;
            this.ProductBut_3.UseVisualStyleBackColor = false;
            this.ProductBut_3.Click += new System.EventHandler(this.ProductBut_3_Click);
            // 
            // ProductBut_2
            // 
            this.ProductBut_2.BackColor = System.Drawing.Color.Transparent;
            this.ProductBut_2.BackgroundImage = global::Code_3.Properties.Resources.test_drink_2;
            this.ProductBut_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProductBut_2.FlatAppearance.BorderSize = 0;
            this.ProductBut_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductBut_2.Location = new System.Drawing.Point(324, 10);
            this.ProductBut_2.Margin = new System.Windows.Forms.Padding(4);
            this.ProductBut_2.Name = "ProductBut_2";
            this.ProductBut_2.Size = new System.Drawing.Size(180, 206);
            this.ProductBut_2.TabIndex = 1;
            this.ProductBut_2.TabStop = false;
            this.ProductBut_2.UseVisualStyleBackColor = false;
            this.ProductBut_2.Click += new System.EventHandler(this.ProductBut_2_Click);
            // 
            // ProductBut_1
            // 
            this.ProductBut_1.BackColor = System.Drawing.Color.Transparent;
            this.ProductBut_1.BackgroundImage = global::Code_3.Properties.Resources.test_drink;
            this.ProductBut_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProductBut_1.FlatAppearance.BorderSize = 0;
            this.ProductBut_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductBut_1.ForeColor = System.Drawing.Color.DimGray;
            this.ProductBut_1.Location = new System.Drawing.Point(63, 10);
            this.ProductBut_1.Margin = new System.Windows.Forms.Padding(4);
            this.ProductBut_1.Name = "ProductBut_1";
            this.ProductBut_1.Size = new System.Drawing.Size(180, 206);
            this.ProductBut_1.TabIndex = 0;
            this.ProductBut_1.TabStop = false;
            this.ProductBut_1.UseVisualStyleBackColor = false;
            this.ProductBut_1.Click += new System.EventHandler(this.ProductBut_1_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Code_3.Properties.Resources.ramune;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(63, 288);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 206);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Code_3.Properties.Resources.mikeneko;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(324, 288);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 206);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Code_3.Properties.Resources.yakiimo;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(565, 288);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 206);
            this.button3.TabIndex = 19;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Font = new System.Drawing.Font("UD デジタル 教科書体 NK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabControl2.Location = new System.Drawing.Point(63, 28);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(408, 472);
            this.tabControl2.TabIndex = 33;
            this.tabControl2.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Code_3.Properties.Resources.ontya_maneki;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.secret1);
            this.tabPage2.Controls.Add(this.secretx1);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(400, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ONTYAMUSEUM";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.tonyu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1072, 548);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.onpanman);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Soldout3);
            this.Controls.Add(this.Jiga);
            this.Controls.Add(this.soldout6);
            this.Controls.Add(this.soldout5);
            this.Controls.Add(this.Soldout4);
            this.Controls.Add(this.ValueDisplay4);
            this.Controls.Add(this.ProTemp6);
            this.Controls.Add(this.ValueDisplay6);
            this.Controls.Add(this.ProTemp5);
            this.Controls.Add(this.ValueDisplay5);
            this.Controls.Add(this.ProTemp4);
            this.Controls.Add(this.mente);
            this.Controls.Add(this.Soldout2);
            this.Controls.Add(this.Soldout1);
            this.Controls.Add(this.TimeDisplay);
            this.Controls.Add(this.JihankiName);
            this.Controls.Add(this.ProTemp3);
            this.Controls.Add(this.ValueDisplay3);
            this.Controls.Add(this.ProTemp2);
            this.Controls.Add(this.ValueDisplay2);
            this.Controls.Add(this.ProTemp1);
            this.Controls.Add(this.ValueDisplay1);
            this.Controls.Add(this.ProductBut_3);
            this.Controls.Add(this.ProductBut_2);
            this.Controls.Add(this.ProductBut_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tonyu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.oturi);
            this.Controls.Add(this.osusume);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.mentePage.ResumeLayout(false);
            this.mentePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osusume)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion


        private System.Windows.Forms.Button mente;
        private System.Windows.Forms.Button ProductBut_1;
        private System.Windows.Forms.Button ProductBut_2;
        private System.Windows.Forms.Button ProductBut_3;
        private System.Windows.Forms.Label ValueDisplay1;
        private System.Windows.Forms.Label ProTemp1;
        private System.Windows.Forms.Label ValueDisplay2;
        private System.Windows.Forms.Label ProTemp2;
        private System.Windows.Forms.Label ValueDisplay3;
        private System.Windows.Forms.Label ProTemp3;
        private System.Windows.Forms.Label JihankiName;
        private System.Windows.Forms.Label TimeDisplay;
        private System.Windows.Forms.Panel Soldout1;
        private System.Windows.Forms.Panel Soldout2;
        private System.Windows.Forms.Panel Soldout3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mentePage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tonyu;
        private System.Windows.Forms.Button hozyu;
        private System.Windows.Forms.Button batu;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button kousin;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label ProTemp4;
        private System.Windows.Forms.Label ProTemp5;
        private System.Windows.Forms.Label ValueDisplay5;
        private System.Windows.Forms.Label ProTemp6;
        private System.Windows.Forms.Label ValueDisplay6;
        private System.Windows.Forms.Label ValueDisplay4;
        private System.Windows.Forms.Panel Soldout4;
        private System.Windows.Forms.Panel soldout5;
        private System.Windows.Forms.Panel soldout6;
        private System.Windows.Forms.Button secret1;
        private System.Windows.Forms.Button secretx1;
        private System.Windows.Forms.Label Jiga;
        private Button oturi;
        private Button kaisyu;
        private Button onpanman;
        private PictureBox osusume;
        private TabControl tabControl2;
        private TabPage tabPage2;
    }
}

