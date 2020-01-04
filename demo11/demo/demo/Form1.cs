using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class Form1 : Form
    {
        public class Phanso
        {
            public double ituso;
            public double imauso;
            public double Tuso
            {
                get { return this.ituso; }
                set { this.ituso = value; }
            }
            public double Mauso
            {
                get { return this.imauso; }
                set
                {
                    if (this.imauso == 0)
                        throw new Exception("Mau so khac 0 :");
                    this.imauso = value;
                }
            }
            public Phanso() { }
            public Phanso(double tuso, double mauso)
            {
                this.ituso = tuso;
                this.imauso = mauso;
            }
            // cong hai phan so
            public static Phanso operator +(Phanso a, Phanso b)
            {
                Console.WriteLine(a.ituso + "/" + a.Mauso + " + " + b.ituso + "/" + b.imauso);
                if (a.imauso == b.imauso)
                {
                    return new Phanso(a.ituso + b.ituso, a.imauso);
                }
                else
                {
                    double c = a.ituso * b.imauso;
                    double d = b.ituso * a.imauso;
                    return new Phanso(c + d, a.imauso * b.imauso);
                }
            }
            //Trừ hai phân số
            public static Phanso operator -(Phanso a, Phanso b)
            {
                if (a.imauso == b.imauso)
                    return new Phanso(a.ituso - b.ituso, a.imauso);
                else
                {
                    double c = a.ituso * b.imauso;
                    double d = a.imauso * b.ituso;
                    return new Phanso(c - d, a.imauso * b.imauso);
                }
            }
            // nhân  hai phân số
            public static Phanso operator *(Phanso a, Phanso b)
            {
                return new Phanso(a.ituso * b.ituso, a.imauso * b.imauso);
            }
            //Chia hai phân số
            public static Phanso operator /(Phanso a, Phanso b)
            {
                Phanso c = new Phanso();
                c.ituso = b.imauso;
                c.imauso = b.ituso;



                return (a * c);
            }
           
            
            public double PhanSoToiGianTuSo(double a, double b)
            {
                return a / UCLN(a, b);

            }
            public double PhanSoToiGianMauSo(double a, double b)
            {
                return b / UCLN(a, b);

            }
            public static Phanso operator +(Phanso a, int num)
            {
                return new Phanso(a.ituso + a.imauso * num, a.imauso);
            }
            //so sanh
            public static bool operator >(Phanso a, Phanso b)
            {
                double c = (double)a.ituso / a.imauso;
                double d = (double)b.ituso / b.imauso;
                return (c > d);
            }//return true
            public static bool operator <(Phanso a, Phanso b)
            {
                double c = (double)a.ituso / a.imauso;
                double d = (double)b.ituso / b.imauso;
                return c < d;
            }
            public static bool operator ==(Phanso a, Phanso b)
            {
                double c = (double)a.ituso / a.imauso;
                double d = (double)b.ituso / b.imauso;
                return (c == d);
            }
            public static bool operator !=(Phanso a, Phanso b)
            {
                double c = (double)a.ituso / a.imauso;
                double d = (double)b.ituso / b.imauso;
                return (c != d);
            }
            //so sanh voi 1 so

            //ep ve kieu so nguyen

            public static implicit operator Phanso(int num)
            {
                Phanso kq = new Phanso(num, 1);
                return kq;

            }

            // ep ve kieu so thuc
            public static explicit operator double(Phanso a)
            {
                return ((double)a.ituso / a.imauso);
            }
            //xuat
            public void nhap()
            {
                Console.WriteLine("Nhap tu so :");
                this.ituso = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap mau so :");
                this.imauso = Convert.ToInt32(Console.ReadLine());
            }
            public void xuat()
            {
                Console.WriteLine(this.ituso + "/" + this.imauso);
            }
            public double UCLN(double a, double b)
            {
                if (a == 0 || b == 0)
                {
                    return a + b;
                }
                while (a != b)
                {
                    if (a > b)
                        a = a - b;
                    else b = b - a;
                }
                return a;
            }


        }
        int leftcontrol = 1;
        int lefttoright = 1;
        string[] a = new string[100];//toan tu 
        string[] ToanTuNguyengoc = new string[100];
        //1 la cong 
        //2 la tru
        //3 la nhan
        //4 la chia
        Phanso ans = new Phanso();
        bool PS = true;
        Phanso[] phansoNguyengoc = new Phanso[100];

        bool bans = false;//co hieu de tiep tuc phep toan voi ans
        public Form1()
        {
            InitializeComponent();
        }
        int n = 0;//so thu tu phan so
        int m = 0; 
        Phanso[] phansos = new Phanso[100];//so hang
        TextBox[] Tuso = new TextBox[100];
        TextBox[] mauso = new TextBox[100];
        Phanso Phansokq = new Phanso();
        Label[] gachngang = new Label[100];
        private void button1_Click(object sender, EventArgs e)
        {
            if (PS == true)
            {
                n++; m++;

               

                for (int i = n - 1; i < n; i++)
                {
                    Tuso[i] = new TextBox();
                    mauso[i] = new TextBox();
                    gachngang[i] = new Label();
                }
                for (int i = n - 1; i < n; i++)
                {
                    this.Controls.Add(Tuso[i]);
                    this.Controls.Add(gachngang[i]);
                    this.Controls.Add(mauso[i]);

                    Tuso[i].Top = leftcontrol * 25;
                    Tuso[i].Left = lefttoright * (n + 10);
                    Tuso[i].Size = new Size(70, 20);
                    Tuso[i].TextAlign = HorizontalAlignment.Center;
                    Tuso[i].Focus();
                    leftcontrol++;

                    gachngang[i].Text = "--------------------";
                    gachngang[i].Top = leftcontrol * 25;
                    gachngang[i].Left = lefttoright * (n + 10);
                    leftcontrol++;

                    mauso[i].Top = leftcontrol * 25;
                    mauso[i].Left = lefttoright * (n + 10);
                    mauso[i].Size = new Size(70, 20);
                    mauso[i].TextAlign = HorizontalAlignment.Center;
                    leftcontrol = 1;
                    mauso[i].Leave += new EventHandler(textBoxLeave);
                    // lefttoright = lefttoright + 10;
                }
                PS = false;
                button1.Enabled = false;
                btnAdd.Enabled = true;
                btnSub.Enabled = true;
                btnMutipl.Enabled = true;
                btndiv.Enabled = true;
                btnClear.Enabled = false;
            }
            //
           // textBox1.Text = n.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (bans == true)// tiep tuc thuc hien phep tinh moi
            {
                
                Coppy(phansoNguyengoc, phansos, ToanTuNguyengoc, a, n - 1);
                    
                 

                PS = true;
                button1.Enabled = true;
                btnAdd.Enabled = false;
                btnSub.Enabled = false;
                btnMutipl.Enabled = false;
                btndiv.Enabled = false;
                lefttoright = lefttoright + 10;
                TextBox operato = new TextBox();
                this.Controls.Add(operato);
                operato.Size = new Size(30, 30);
                operato.Top = leftcontrol * 50;
                operato.Left = lefttoright * (n + 10);
                operato.Text = "+";
                operato.TextAlign = HorizontalAlignment.Center;
                operato.Font = new Font("Microsoft Sans Serif", 10);
                lefttoright = lefttoright + 5;
                a[n - 1] = "+";//day la phep cong 
                //phansos[n - 1] = new Phanso(Convert.ToDouble(textBox1.Text.Trim()), Convert.ToDouble(textBox2.Text.Trim()));
                phansoNguyengoc[n - 1] = new Phanso(Convert.ToDouble(textBox1.Text.Trim()), Convert.ToDouble(textBox2.Text.Trim()));
                ToanTuNguyengoc[n - 1] = "+";

            }
            else
            {
                

                PS = true;
                button1.Enabled = true;
                btnAdd.Enabled = false;
                btnSub.Enabled = false;
                btnMutipl.Enabled = false;
                btndiv.Enabled = false;
                lefttoright = lefttoright + 10;
                TextBox operato = new TextBox();
                this.Controls.Add(operato);
                operato.Size = new Size(30, 30);
                operato.Top = leftcontrol * 50;
                operato.Left = lefttoright * (n + 10);
                operato.Text = "+";
                operato.TextAlign = HorizontalAlignment.Center;
                operato.Font = new Font("Microsoft Sans Serif", 10);
                lefttoright = lefttoright + 5;

                a[n - 1] = "+";//day la phep cong
                ToanTuNguyengoc[n - 1] = "+";
                double[] b = new double[100];
                string[] tt = new string[100];
                double ts = 0;
                double ms = 0;
                
                if ((ktra(Tuso[n - 1].ToString()) == true) && (ktra(mauso[n - 1].ToString()) == true))//ca 2 cung co toan tu
                {
                    convert(b, tt, Tuso[n - 1].Text.Trim());
                    ts = kqcongtru(b, tt);
                    convert(b, tt, mauso[n - 1].Text.Trim());
                    ms = kqcongtru(b, tt);
                    phansos[n - 1] = new Phanso(ts, ms);
                    phansoNguyengoc[n - 1] = new Phanso(ts, ms);

                }
                else if (ktra(Tuso[n - 1].ToString()) == true)//co toan tu o trong tu so
                {

                    convert(b, tt, Tuso[n - 1].Text.Trim());
                    ts = kqcongtru(b, tt);
                    phansos[n - 1] = new Phanso(ts, Convert.ToDouble(mauso[n - 1].Text.Trim()));
                    phansoNguyengoc[n - 1] = new Phanso(ts, Convert.ToDouble(mauso[n - 1].Text.Trim()));


                }
                else if (ktra(mauso[n - 1].ToString()) == true)//co toan tu o trong mau
                {
                    convert(b, tt, mauso[n - 1].Text.Trim());
                    ms = kqcongtru(b, tt);
                    phansos[n - 1] = new Phanso(Convert.ToDouble(Tuso[n - 1].Text.Trim()), ms);
                    phansoNguyengoc[n - 1] = new Phanso(Convert.ToDouble(Tuso[n - 1].Text.Trim()), ms);

                }

                else //ca 2 khong co toan tu 
                {
                    try {
                        phansoNguyengoc[n - 1] = new Phanso(Convert.ToDouble(Tuso[n - 1].Text.Trim()), Convert.ToDouble(mauso[n - 1].Text.Trim()));

                        phansos[n - 1] = new Phanso(Convert.ToDouble(Tuso[n - 1].Text.Trim()), Convert.ToDouble(mauso[n - 1].Text.Trim()));
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Tuso[n - 1].Focus();
                    }
                }
            }

        }

        //ham sao chep 
        void Coppy(Phanso[] a, Phanso[] b, string[] toantua, string[] toantub,int n)
        {
            //mang a la mang phan so nguyen goc
            //mang b la mang phan so dang thuc hien cac phep tinh
            // n la so luong ky tu thuc te ma mang a co 
            if (n >= 1)
            {
                for (int i = 0; i <= n; i++)
                {
                    b[i] = a[i];
                }
                for (int i = 0; i < n; i++)
                {
                    toantub[i] = toantua[i];
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    b[i] = a[i];
                }
                for (int i = 0; i < n-1; i++)
                {
                    toantub[i] = toantua[i];
                }
            }
        }
        //ham ktra ki tu dac biet
        bool ktra(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '+' || a[i] == '-' || a[i] == '*' || a[i] == '/')
                    return true;//neu la so 
            }
            return false;
        }
        void KquaNhanChia(Phanso[] phanso,string[] ToanTu,int k)
        {
            
            int n = k;
            for (int i = 0; i <= n; i++)
             {
                if (ToanTu[i] == "*")
                {
                    phanso[i] = phanso[i + 1] * phanso[i];
                    // kq =kq+ so[i];
                    // xoa vi tri so[i+1]
                    for (int j = i + 1; j < n; j++)
                    {
                        phanso[j] = phanso[j + 1];
                    }
                    //xoa dau i
                    for (int j = i; j < n; j++)
                    {
                        ToanTu[j] = ToanTu[j + 1];
                    }
                    i--;
                    n--;

                }
                else if (ToanTu[i] == "/")
                {
                    phanso[i] = phanso[i] / phanso[i + 1];
                    //kq = kq+so[i];
                    // xoa vi tri so[i+1]
                    for (int j = i + 1; j < n; j++)
                    {
                        phanso[j] = phanso[j + 1];
                    }
                    //xoa dau i
                    for (int j = i; j < n; j++)
                    {
                        ToanTu[j] = ToanTu[j + 1];
                    }
                    i--;
                    n--;

                }

            }
        }
        Phanso KquaCongTru(Phanso[] phanso,string[]ToanTu,int k)
        {
            Phanso kq = new Phanso();
              KquaNhanChia(phanso, ToanTu,k);
            kq = phanso[0];
           
            int n = k;
            for (int i = 0; i <= n; i++)
            {
                if (ToanTu[i] == "+")
                {
                    phanso[i] = phanso[i + 1] + phanso[i];
                    kq = phanso[i];
                    // xoa vi tri so[i+1]
                    for (int j = i + 1; j < n; j++)
                    {
                        phanso[j] = phanso[j + 1];
                    }
                    //xoa dau i
                    for (int j = i; j < n; j++)
                    {
                        ToanTu[j] = ToanTu[j + 1];
                    }
                    i--;
                    n--;

                }
                else if (ToanTu[i] == "-")
                {
                    phanso[i] = phanso[i] - phanso[i + 1];
                    kq = phanso[i];
                    // xoa vi tri so[i+1]
                    for (int j = i + 1; j < n; j++)
                    {
                        phanso[j] = phanso[j + 1];
                    }
                    //xoa dau i
                    for (int j = i; j < n; j++)
                    {
                        ToanTu[j] = ToanTu[j + 1];
                    }
                    i--;
                    n--;

                }

            }
            return kq;

        }
        
       
        private void btnSub_Click(object sender, EventArgs e)
        {
            if (bans == true)// tiep tuc thuc hien phep tinh moi
            {

                Coppy(phansoNguyengoc, phansos, ToanTuNguyengoc, a, n - 1);



                PS = true;
                button1.Enabled = true;
                btnAdd.Enabled = false;
                btnSub.Enabled = false;
                btnMutipl.Enabled = false;
                btndiv.Enabled = false;
                lefttoright = lefttoright + 10;
                TextBox operato = new TextBox();
                this.Controls.Add(operato);
                operato.Size = new Size(30, 30);
                operato.Top = leftcontrol * 50;
                operato.Left = lefttoright * (n + 10);
                operato.Text = "-";
                operato.TextAlign = HorizontalAlignment.Center;
                operato.Font = new Font("Microsoft Sans Serif", 10);
                lefttoright = lefttoright + 5;
                a[n - 1] = "-";//day la phep tru 
               // phansos[n - 1] = new Phanso(Convert.ToDouble(textBox1.Text.Trim()), Convert.ToDouble(textBox2.Text.Trim()));
                phansoNguyengoc[n - 1] = new Phanso(Convert.ToDouble(textBox1.Text.Trim()), Convert.ToDouble(textBox2.Text.Trim()));
                ToanTuNguyengoc[n - 1] = "-";

            }
            else
            {


                PS = true;
                button1.Enabled = true;
                btnAdd.Enabled = false;
                btnSub.Enabled = false;
                btnMutipl.Enabled = false;
                btndiv.Enabled = false;
                lefttoright = lefttoright + 10;
                TextBox operato = new TextBox();
                this.Controls.Add(operato);
                operato.Size = new Size(30, 30);
                operato.Top = leftcontrol * 50;
                operato.Left = lefttoright * (n + 10);
                operato.Text = "-";
                operato.TextAlign = HorizontalAlignment.Center;
                operato.Font = new Font("Microsoft Sans Serif", 10);
                lefttoright = lefttoright + 5;

                a[n - 1] = "+";//day la phep tru
                ToanTuNguyengoc[n - 1] = "-";
                double[] b = new double[100];
                string[] tt = new string[100];
                double ts = 0;
                double ms = 0;

                if ((ktra(Tuso[n - 1].ToString()) == true) && (ktra(mauso[n - 1].ToString()) == true))//ca 2 cung co toan tu
                {
                    convert(b, tt, Tuso[n - 1].Text.Trim());
                    ts = kqcongtru(b, tt);
                    convert(b, tt, mauso[n - 1].Text.Trim());
                    ms = kqcongtru(b, tt);
                    phansos[n - 1] = new Phanso(ts, ms);
                    phansoNguyengoc[n - 1] = new Phanso(ts, ms);

                }
                else if (ktra(Tuso[n - 1].ToString()) == true)//co toan tu o trong tu so
                {

                    convert(b, tt, Tuso[n - 1].Text.Trim());
                    ts = kqcongtru(b, tt);
                    phansos[n - 1] = new Phanso(ts, Convert.ToDouble(mauso[n - 1].Text.Trim()));
                    phansoNguyengoc[n - 1] = new Phanso(ts, Convert.ToDouble(mauso[n - 1].Text.Trim()));


                }
                else if (ktra(mauso[n - 1].ToString()) == true)//co toan tu o trong mau
                {
                    convert(b, tt, mauso[n - 1].Text.Trim());
                    ms = kqcongtru(b, tt);
                    phansos[n - 1] = new Phanso(Convert.ToDouble(Tuso[n - 1].Text.Trim()), ms);
                    phansoNguyengoc[n - 1] = new Phanso(Convert.ToDouble(Tuso[n - 1].Text.Trim()), ms);

                }

                else //ca 2 khong co toan tu 
                {
                    try
                    {
                        phansoNguyengoc[n - 1] = new Phanso(Convert.ToDouble(Tuso[n - 1].Text.Trim()), Convert.ToDouble(mauso[n - 1].Text.Trim()));

                        phansos[n - 1] = new Phanso(Convert.ToDouble(Tuso[n - 1].Text.Trim()), Convert.ToDouble(mauso[n - 1].Text.Trim()));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Tuso[n - 1].Focus();
                    }
                }
            }
        }

        private void btnMutipl_Click(object sender, EventArgs e)
        {
            if (bans == true)// tiep tuc thuc hien phep tinh moi
            {
                Coppy(phansoNguyengoc, phansos, ToanTuNguyengoc, a, n - 1);

                //phansoNguyengoc[n - 1] = new Phanso(Convert.ToDouble(textBox1.Text.Trim()), Convert.ToDouble(textBox2.Text.Trim()));
                ToanTuNguyengoc[n - 1] = "*";


                PS = true;
                button1.Enabled = true;
                btnAdd.Enabled = false;
                btnSub.Enabled = false;
                btnMutipl.Enabled = false;
                btndiv.Enabled = false;
                lefttoright = lefttoright + 10;
                TextBox operato = new TextBox();
                this.Controls.Add(operato);
                operato.Size = new Size(30, 30);
                operato.Top = leftcontrol * 50;
                operato.Left = lefttoright * (n + 10);
                operato.Text = "*";
                operato.TextAlign = HorizontalAlignment.Center;
                operato.Font = new Font("Microsoft Sans Serif", 10);
                lefttoright = lefttoright + 5;
                a[n - 1] = "*";//day la phep nhan
               // phansos[n - 2] = new Phanso(Convert.ToDouble(textBox1.Text.Trim()), Convert.ToDouble(textBox2.Text.Trim()));
            }
            else
            {


                PS = true;
                button1.Enabled = true;
                btnAdd.Enabled = false;
                btnSub.Enabled = false;
                btnMutipl.Enabled = false;
                btndiv.Enabled = false;
                lefttoright = lefttoright + 10;
                TextBox operato = new TextBox();
                this.Controls.Add(operato);
                operato.Size = new Size(30, 30);
                operato.Top = leftcontrol * 50;
                operato.Left = lefttoright * (n + 10);
                operato.Text = "*";
                operato.TextAlign = HorizontalAlignment.Center;
                operato.Font = new Font("Microsoft Sans Serif", 10);
                lefttoright = lefttoright + 5;

                a[n - 1] = "*";//day la phep nhan
                ToanTuNguyengoc[n - 1] = "*";

                double[] b = new double[100];
                string[] tt = new string[100];
                double ts = 0;
                double ms = 0;
                if ((ktra(Tuso[n - 1].ToString()) == true) && (ktra(mauso[n - 1].ToString()) == true))//ca 2 cung co toan tu
                {
                    convert(b, tt, Tuso[n - 1].Text.Trim());
                    ts = kqcongtru(b, tt);
                    convert(b, tt, mauso[n - 1].Text.Trim());
                    ms = kqcongtru(b, tt);
                    phansos[n - 1] = new Phanso(ts, ms);
                    phansoNguyengoc[n - 1] = new Phanso(ts, ms);


                }
                else if (ktra(Tuso[n - 1].ToString()) == true)//co toan tu o trong tu so
                {

                    convert(b, tt, Tuso[n - 1].Text.Trim());
                    ts = kqcongtru(b, tt);
                    phansos[n - 1] = new Phanso(ts, Convert.ToDouble(mauso[n - 1].Text.Trim()));
                    phansoNguyengoc[n - 1] = new Phanso(ts, Convert.ToDouble(mauso[n - 1].Text.Trim()));


                }
                else if (ktra(mauso[n - 1].ToString()) == true)//co toan tu o trong mau
                {
                    convert(b, tt, mauso[n - 1].Text.Trim());
                    ms = kqcongtru(b, tt);
                    phansos[n - 1] = new Phanso(Convert.ToDouble(Tuso[n - 1].Text.Trim()), ms);
                    phansoNguyengoc[n - 1] = new Phanso(Convert.ToDouble(Tuso[n - 1].Text.Trim()), ms);

                }

                else //ca 2 khong co toan tu 
                {
                    try
                    {
                        phansoNguyengoc[n - 1] = new Phanso(Convert.ToDouble(Tuso[n - 1].Text.Trim()), Convert.ToDouble(mauso[n - 1].Text.Trim()));

                        phansos[n - 1] = new Phanso(Convert.ToDouble(Tuso[n - 1].Text.Trim()), Convert.ToDouble(mauso[n - 1].Text.Trim()));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Tuso[n - 1].Focus();
                    }
                }
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (bans == true)// tiep tuc thuc hien phep tinh moi
            {

                Coppy(phansoNguyengoc, phansos, ToanTuNguyengoc, a, n - 1);



                PS = true;
                button1.Enabled = true;
                btnAdd.Enabled = false;
                btnSub.Enabled = false;
                btnMutipl.Enabled = false;
                btndiv.Enabled = false;
                lefttoright = lefttoright + 10;
                TextBox operato = new TextBox();
                this.Controls.Add(operato);
                operato.Size = new Size(30, 30);
                operato.Top = leftcontrol * 50;
                operato.Left = lefttoright * (n + 10);
                operato.Text = "/";
                operato.TextAlign = HorizontalAlignment.Center;
                operato.Font = new Font("Microsoft Sans Serif", 10);
                lefttoright = lefttoright + 5;
                a[n - 1] = "/";//day la phep chia 
               // phansos[n - 1] = new Phanso(Convert.ToDouble(textBox1.Text.Trim()), Convert.ToDouble(textBox2.Text.Trim()));
                phansoNguyengoc[n - 1] = new Phanso(Convert.ToDouble(textBox1.Text.Trim()), Convert.ToDouble(textBox2.Text.Trim()));
                ToanTuNguyengoc[n - 1] = "/";

            }
            else
            {


                PS = true;
                button1.Enabled = true;
                btnAdd.Enabled = false;
                btnSub.Enabled = false;
                btnMutipl.Enabled = false;
                btndiv.Enabled = false;
                lefttoright = lefttoright + 10;
                TextBox operato = new TextBox();
                this.Controls.Add(operato);
                operato.Size = new Size(30, 30);
                operato.Top = leftcontrol * 50;
                operato.Left = lefttoright * (n + 10);
                operato.Text = "+";
                operato.TextAlign = HorizontalAlignment.Center;
                operato.Font = new Font("Microsoft Sans Serif", 10);
                lefttoright = lefttoright + 5;

                a[n - 1] = "/";//day la phep chia
                ToanTuNguyengoc[n - 1] = "/";
                double[] b = new double[100];
                string[] tt = new string[100];
                double ts = 0;
                double ms = 0;

                if ((ktra(Tuso[n - 1].ToString()) == true) && (ktra(mauso[n - 1].ToString()) == true))//ca 2 cung co toan tu
                {
                    convert(b, tt, Tuso[n - 1].Text.Trim());
                    ts = kqcongtru(b, tt);
                    convert(b, tt, mauso[n - 1].Text.Trim());
                    ms = kqcongtru(b, tt);
                    phansos[n - 1] = new Phanso(ts, ms);
                    phansoNguyengoc[n - 1] = new Phanso(ts, ms);

                }
                else if (ktra(Tuso[n - 1].ToString()) == true)//co toan tu o trong tu so
                {

                    convert(b, tt, Tuso[n - 1].Text.Trim());
                    ts = kqcongtru(b, tt);
                    phansos[n - 1] = new Phanso(ts, Convert.ToDouble(mauso[n - 1].Text.Trim()));
                    phansoNguyengoc[n - 1] = new Phanso(ts, Convert.ToDouble(mauso[n - 1].Text.Trim()));


                }
                else if (ktra(mauso[n - 1].ToString()) == true)//co toan tu o trong mau
                {
                    convert(b, tt, mauso[n - 1].Text.Trim());
                    ms = kqcongtru(b, tt);
                    phansos[n - 1] = new Phanso(Convert.ToDouble(Tuso[n - 1].Text.Trim()), ms);
                    phansoNguyengoc[n - 1] = new Phanso(Convert.ToDouble(Tuso[n - 1].Text.Trim()), ms);

                }

                else //ca 2 khong co toan tu 
                {
                    try
                    {
                        phansoNguyengoc[n - 1] = new Phanso(Convert.ToDouble(Tuso[n - 1].Text.Trim()), Convert.ToDouble(mauso[n - 1].Text.Trim()));

                        phansos[n - 1] = new Phanso(Convert.ToDouble(Tuso[n - 1].Text.Trim()), Convert.ToDouble(mauso[n - 1].Text.Trim()));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Tuso[n - 1].Focus();
                    }
                }
            }
        }
        //Đổi số thập phân về phân số
        Phanso Doi(double a)
        {
            if (a > 0)
            {
                if (a - (int)a == 0)
                {
                    return new Phanso(a, 1);
                }
                else //la so thap phan
                {
                    bool stn = false;
                    int mu = 1;
                    while (stn == false)
                    {
                        if (a - (int)a == 0)
                        {
                            stn = true;
                        }
                        else
                        {
                            mu = mu * 10;
                            a = a * 10;
                        }
                    }
                    return new Phanso(a, mu);
                }
            }
            else if (a < 0)
            {
                if (a + Math.Abs((int)a) == 0)
                {
                    return new Phanso(a, 1);
                }
                else
                {
                    bool stn = false;
                    int mu = 1;
                    while (stn == false)
                    {
                        if (a + Math.Abs((int)a) == 0)
                        {
                            stn = true;
                        }
                        else
                        {
                            mu = mu * 10;
                            a = a * mu;
                        }
                    }
                    return new Phanso(a, mu);
                }
            }
            else return new Phanso(0, 1);
        }

        int KtraMausoBangKhong(Phanso[] a,int n) //n la so luong phan so thuc te de tranh lang phi 
        {
            for(int i=0;i<n-1;i++)
            {
                if (a[i].Mauso == 0)
                    return i;
            }
            return -1;
        }
        private void btnresult_Click(object sender, EventArgs e)
        {
            if (bans == true)
            {
                phansos[n - 1] = new Phanso(Convert.ToDouble(Tuso[n - 1].Text.Trim()), Convert.ToDouble(mauso[n - 1].Text.Trim()));
                phansoNguyengoc[n - 1] = new Phanso(Convert.ToDouble(Tuso[n - 1].Text.Trim()), Convert.ToDouble(mauso[n - 1].Text.Trim()));

            }
            else
            {
                phansos[n - 1] = new Phanso(Convert.ToDouble(Tuso[n - 1].Text.Trim()), Convert.ToDouble(mauso[n - 1].Text.Trim()));
                phansoNguyengoc[n - 1] = new Phanso(Convert.ToDouble(Tuso[n - 1].Text.Trim()), Convert.ToDouble(mauso[n - 1].Text.Trim()));
            }
            int l = KtraMausoBangKhong(phansos, n);
            Phanso kq = KquaCongTru(phansos, a, n);
            if (kq.Mauso != 0)
            {
                if (kq.Tuso * kq.Mauso > 0)//neu ca 2 cung la so am hoac duong
                {
                    Math.Abs(kq.Tuso);
                    Math.Abs(kq.Mauso);
                }
                else if (kq.Mauso < 0 && kq.Tuso > 0)//neu 1 trong 2 la so am 
                {
                    kq.Mauso = kq.Mauso * (-1);
                    kq.Tuso = kq.Tuso * (-1);
                }
                kq = Doi(kq.Tuso) / Doi(kq.Mauso);//vi ham doi se tao ra 1 phan so moi, nen phai chia lai thi moi ra 

                ans = new Phanso(kq.Tuso, kq.Mauso);
                if (kq.Tuso - (int)kq.Tuso == 0 && kq.Mauso - (int)kq.Mauso == 0)
                {
                    double a = kq.UCLN(Math.Abs(kq.Tuso), Math.Abs(kq.Mauso));
                    ans = new Phanso(kq.Tuso / a, kq.Mauso / a);

                }
                textBox1.Text = ans.Tuso.ToString();
                textBox2.Text = ans.Mauso.ToString();
                btnClear.Enabled = true; bans = true;
            }
            else //mau so bang 0
            {
                MessageBox.Show("Có một hoặc nhiều phân số bằng không.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //int l = KtraMausoBangKhong(phansos, n);
                if(l>=0)
                    mauso[l].Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        //day la phan xu ly chuoi 
         void convert(double[] so, string[] dau, string dauvao)
        {
            //chuan hoa chuoi
            dauvao.Trim();
            //xet vong for
            int m = 0, n = 0; //m la thu tu cua chuoi so, n la thu tu cua chuoi toan tu
            string temp = "";

            for (int i = 0; i < dauvao.Length; i++)
            {
                //neu khong la so ma la dau
                if (dauvao[i] == '+' || dauvao[i] == '-' || dauvao[i] == '*' || dauvao[i] == '/')
                {
                    dau[n] = dauvao[i].ToString();
                    n++;
                    so[m] = double.Parse(temp);
                    temp = "";
                    m++;

                }

                else //neu khong la toan tu ma la so 
                {
                    temp = temp + dauvao[i];
                }
                if (i == dauvao.Length - 1)
                {
                    so[m] = double.Parse(temp);
                    temp = "";
                    m++;

                }

            }
            //for (int i = 0; i < m; i++)
            //{
            //    Console.WriteLine(so[i]);
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(dau[i]);
            //}
        }

         void kqnhanchia(double[] so, string[] dau)
        {
            int kq = 1;
            int n = dau.Length - 1;
            for (int i = 0; i <= n; i++)
            {
                if (dau[i] == "*")
                {
                    so[i] = so[i + 1] * so[i];
                    // kq =kq+ so[i];
                    // xoa vi tri so[i+1]
                    for (int j = i + 1; j < so.Length - 1; j++)
                    {
                        so[j] = so[j + 1];
                    }
                    //xoa dau i
                    for (int j = i; j < n; j++)
                    {
                        dau[j] = dau[j + 1];
                    }
                    i--;
                    n--;

                }
                else if (dau[i] == "/")
                {
                    so[i] = so[i] / so[i + 1];
                    //kq = kq+so[i];
                    // xoa vi tri so[i+1]
                    for (int j = i + 1; j < so.Length - 1; j++)
                    {
                        so[j] = so[j + 1];
                    }
                    //xoa dau i
                    for (int j = i; j < n; j++)
                    {
                        dau[j] = dau[j + 1];
                    }
                    i--;
                    n--;

                }

            }


        }
         double kqcongtru(double[] so, string[] dau)
        {
            kqnhanchia(so, dau);
            double kq = 0;
            int n = dau.Length - 1;
            for (int i = 0; i <= n; i++)
            {
                if (dau[i] == "+")
                {
                    so[i] = so[i + 1] + so[i];
                    kq = so[i];
                    // xoa vi tri so[i+1]
                    for (int j = i + 1; j < so.Length - 1; j++)
                    {
                        so[j] = so[j + 1];
                    }
                    //xoa dau i
                    for (int j = i; j < n; j++)
                    {
                        dau[j] = dau[j + 1];
                    }
                    i--;
                    n--;

                }
                else if (dau[i] == "-")
                {
                    so[i] = so[i] - so[i + 1];
                    kq = so[i];
                    // xoa vi tri so[i+1]
                    for (int j = i + 1; j < so.Length - 1; j++)
                    {
                        so[j] = so[j + 1];
                    }
                    //xoa dau i
                    for (int j = i; j < n; j++)
                    {
                        dau[j] = dau[j + 1];
                    }
                    i--;
                    n--;

                }

            }
            return kq;


        }

        private async void btnInputfiles_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog()
                {
                    Filter = "Text Documents|*.txt",
                    Multiselect = false,
                    ValidateNames = true
                }
                    
                )
                {
                    if(ofd.ShowDialog()==DialogResult.OK)
                    {
                        using(StreamReader sr=new StreamReader(ofd.FileName))
                        {
                            txtInputfile.Text = await sr.ReadToEndAsync();
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxLeave(object sender, EventArgs e)
        {
            // put your code here
            TextBox txbmausoPhanSo1 = new TextBox();
            if (txbmausoPhanSo1.Text.Trim() != null)
                if (txbmausoPhanSo1.Text == "0")
                {
                MessageBox.Show("Mẫu không được =0");
                txbmausoPhanSo1.Clear();
                txbmausoPhanSo1.Focus();


                }
        }
    }
}
