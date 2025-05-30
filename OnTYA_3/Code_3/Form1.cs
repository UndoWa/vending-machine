using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using static Code_3.Form1;


namespace Code_3
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private Timer Atime;
        bool tenmetu = false;
        bool jiga = false;
        bool jiga_er = false;
        int total = 0;

        int sagaku = 0;

        int count = 0; //セリフ変更用カウンタ
        int sw_jiga = 0; //セリフ変更用変数


        static Product Product1 = new Product() { name = "焼酎", value = 500, stock = 10, temp = false };
        static Product Product2 = new Product() { name = "ジャスミン茶", value = 100, stock = 5, temp = true };
        static Product Product3 = new Product() { name = "ビール", value = 200, stock = 12, temp = false };
        static Product Product4 = new Product() { name = "ramune", value = 160, stock = 15, temp = false };
        static Product Product5 = new Product() { name = "mikeneko", value = 200, stock = 6, temp = false };
        static Product Product6 = new Product() { name = "yakiimo", value = 130, stock = 10, temp = true };


        public struct Product
        {
            public string name;
            public int value;
            public int stock;
            public bool temp;
        }

        private void SetTempValue(Product product, Label temp, Label value)
        {
            value.Text = "￥" + product.value.ToString();

            if (product.temp)
            {
                temp.BackColor = Color.Firebrick;
                temp.Text = "温";
            }
            else
            {
                temp.BackColor = Color.DodgerBlue;
                temp.Text = "冷";
            }
        }

        private void SetTime1()
        {
            TimeDisplay.Text = DateTime.Now.ToString("HH : mm");
        }

        private void SetTime2()
        {
            TimeDisplay.Text = DateTime.Now.ToString("HH   mm");
        }

        public Form1()
        {
            InitializeComponent();

            timer = new Timer(); //時計用タイマ
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            Atime = new Timer(); //常時実行用タイマ
            Atime.Interval = 100;
            Atime.Tick += Atime_Tick;
        }


        private void mente_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            this.label2.Text = total.ToString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!tenmetu) { SetTime1(); tenmetu = true; }
            else { SetTime2(); tenmetu = false; }
        }

        private void Atime_Tick(object sender, EventArgs e)
        {
            if (Product1.stock == 0) Soldout1.Visible = true;
            else Soldout1.Visible = false;
            if (Product2.stock == 0) Soldout2.Visible = true;
            else Soldout2.Visible = false;
            if (Product3.stock == 0) Soldout3.Visible = true;
            else Soldout3.Visible = false;
            if (Product4.stock == 0) Soldout4.Visible = true;
            else Soldout4.Visible = false;
            if (Product5.stock == 0) soldout5.Visible = true;
            else soldout5.Visible = false;
            if (Product6.stock == 0) soldout6.Visible = true;
            else soldout6.Visible = false;


            if (jiga)
            {
                Jiga_Change();
                count = 0;
                jiga = false;
            }
            if (count == 80)
            {
                Jiga_Change();
                count = 0;
            }
            if (jiga_er)
            {
                switch (sw_jiga)
                {
                    case 1:
                        count = 0;
                        Jiga.Text = "悪いな。この自販機1000円までなんだ。";
                        jiga_er = false;
                        break;
                    case 2:
                        count = 0;
                        Jiga.Text = "文字入れてどうすんだよ？";
                        jiga_er = false;
                        break;
                    case 3:
                        count = 0;
                        Jiga.Text = "金だよ。\n金入れろや。";
                        jiga_er = false;
                        break;
                    default:
                        break;
                }
            }
            count++;
        }

        private void Jiga_Change()
        {
            Random random = new Random();
            int Rnum;

            if (jiga) Jiga.Text = "っざす！\nアゲアゲでいけよ！";
            else
            {
                Rnum = random.Next(5);

                switch (Rnum)
                {
                    case 0:
                        Jiga.Text = "あくしろよ～";
                        break;
                    case 1:
                        Jiga.Text = "金持ってんのか？";
                        break;
                    case 2:
                        Jiga.Text = "オススメ？\n全部さ...";
                        break;
                    case 3:
                        Jiga.Text = "買ってくれないの？\n(´;ω;`)";
                        break;
                    case 4:
                        Jiga.Text = "遅ぇヤツは\nモテないぜ？";
                        break;
                    default:
                        break;
                }
            }
        }

        private void ProductBut_1_Click(object sender, EventArgs e)
        {
            if (Product1.stock > 0 && sagaku >= Product1.value)
            {
                Product1.stock -= 1;
                total += Product1.value;

                sagaku -= Product1.value;

                count = 0;
                jiga = true;

            }
            this.label1.Text = sagaku.ToString();
        }

        private void ProductBut_2_Click(object sender, EventArgs e)
        {
            if (Product2.stock > 0 && sagaku >= Product2.value)
            {
                Product2.stock -= 1;
                total += Product2.value;

                sagaku -= Product2.value;

                count = 0;
                jiga = true;

            }
            this.label1.Text = sagaku.ToString();
        }

        private void ProductBut_3_Click(object sender, EventArgs e)
        {

            if (Product3.stock > 0 && sagaku >= Product3.value)
            {
                Product3.stock -= 1;
                total += Product3.value;

                sagaku -= Product3.value;
                count = 0;
                jiga = true;

            }
            this.label1.Text = sagaku.ToString();

           // label -= Product3.value;

        }

        //this.label1.Text = label.ToString();

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Product4.stock > 0 && sagaku >= Product4.value)
            {
                Product4.stock -= 1;
                total += Product4.value;
                                        
                sagaku -= Product4.value;
                count = 0;
                jiga = true;

            }
            this.label1.Text = sagaku.ToString();



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Product5.stock > 0 && sagaku >= Product5.value)
            {
                Product5.stock -= 1;
                total += Product5.value;

                sagaku -= Product5.value;
                count = 0;
                jiga = true;

            }
            this.label1.Text = sagaku.ToString();


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (Product6.stock > 0 && sagaku >= Product6.value)
            {
                Product6.stock -= 1;
                total += Product6.value;

                sagaku -= Product6.value;
                count = 0;
                jiga = true;

            }
            this.label1.Text = sagaku.ToString();


        }




        private void Form1_Load_1(object sender, EventArgs e)
        {

            SetTempValue(Product1, ProTemp1, ValueDisplay1);
            SetTempValue(Product2, ProTemp2, ValueDisplay2);
            SetTempValue(Product3, ProTemp3, ValueDisplay3);
            SetTempValue(Product4, ProTemp4, ValueDisplay4);
            SetTempValue(Product5, ProTemp5, ValueDisplay5);
            SetTempValue(Product6, ProTemp6, ValueDisplay6);

            SetTime1();
            timer.Start();
            Atime.Start();
        }

        private void mentePage_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tonyu_Click(object sender, EventArgs e)
        {
            this.CancelButton = this.tonyu;
            string inputValue = label1.Text;
            string convertedlabelValue = ConvertFullWidthToHalfWidth(textBox1.Text);



            string ConvertFullWidthToHalfWidth(string input)
            {
                char[] result = new char[input.Length];

                for (int i = 0; i < input.Length; i++)
                {
                    char c = input[i];
                    if (c >= '０' && c <= '９') // 全角数字の範囲
                    {
                        result[i] = (char)(c - '０' + '0'); // 半角数字に変換
                    }
                    else
                    {
                        result[i] = c; // その他の文字はそのまま
                    }
                }

                return new string(result);
            }



            if (int.TryParse(convertedlabelValue, out _))
            {
                int label = int.Parse(inputValue);
                int box = int.Parse(convertedlabelValue);


                if (box <= 1000 && box >= 0)
                {
                    sagaku += box;
                    label += box;
                    this.label1.Text = label.ToString();
                }
                else if (box >= 1001)
                {
                    sw_jiga = 1;
                    jiga_er = true;
                }
            }
            else if(textBox1.Text == "")
            {
                sw_jiga = 3;
                jiga_er = true;
            }
            else
            {
                sw_jiga = 2;
                jiga_er = true;
            }
            textBox1.Text = "";
        }
        private void reset1_Click(object sender, EventArgs e)
        {
            label2.Text = total.ToString();
            tabControl1.Visible = true;

        }

        private void hozyu_Click(object sender, EventArgs e)
        {
            Product1.stock = 10;
            Product2.stock = 5;
            Product3.stock = 12;
            Product4.stock = 15;
            Product5.stock = 6;
            Product6.stock = 10;


        }

        private void batu_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void Soldout3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kousin_Click(object sender, EventArgs e)
        {
            this.label2.Text = total.ToString();
        }
        private void secret1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void secretx1_Click_1(object sender, EventArgs e)
        {
            tabControl2.Visible = false;

        }

        private void oturi_Click(object sender, EventArgs e)
        {
            this.label1.Text = "0";
        }

        private void kaisyu_Click(object sender, EventArgs e)
        {
            total = 0;
            this.label2.Text = "0";
        }

        private void onpanman_Click(object sender, EventArgs e)
        {
            try
            {
                
                osusume.Visible = true; // PictureBoxを表示
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("画像を読み込めませんでした。\n" + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void osusume_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = true;
        }
    }
    }
    


