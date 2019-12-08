using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            // cong 2 phan so
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
            public static Phanso operator *(Phanso a, Phanso b)
            {
                return new Phanso(a.ituso * b.ituso, a.imauso * b.imauso);
            }
            public static Phanso operator /(Phanso a, Phanso b)
            {
                Phanso c = new Phanso();
                c.ituso = b.imauso;
                c.imauso = b.ituso;



                return (a * c);
            }
            public static Phanso operator ++(Phanso a)
            {
                Phanso b = new Phanso();
                b.imauso = 1;
                b.ituso = 1;

                return (a + b);
            }
            public static Phanso operator --(Phanso a)
            {
                Phanso b = new Phanso();
                b.imauso = 1;
                b.ituso = 1;
                return (a - b);
            }
            //public static implicit operator Phanso (double a)// doi thap phan sang phan so 
            //{
            //    if (a > 0)
            //    {
            //        if (a - (int)a == 0)
            //        {
            //            return new Phanso(a, 1);
            //        }
            //        else //la so thap phan
            //        {
            //            bool stn = false;
            //            int mu = 1;
            //            while (stn == false)
            //            {
            //                if (a - (int)a == 0)
            //                {
            //                    stn = true;
            //                }
            //                else
            //                {
            //                    mu = mu * 10;
            //                    a = mu * mu;
            //                }
            //            }
            //            return new Phanso(a, mu);
            //        }
            //    }
            //    else if (a < 0)
            //    {
            //        if (a + Math.Abs((int)a) == 0)
            //        {
            //            return new Phanso(a, 1);
            //        }
            //        else
            //        {
            //            bool stn = false;
            //            int mu = 1;
            //            while (stn == false)
            //            {
            //                if (a + Math.Abs((int)a) == 0)
            //                {
            //                    stn = true;
            //                }
            //                else
            //                {
            //                    mu = mu * 10;
            //                    a = a * mu;
            //                }
            //            }
            //            return new Phanso(a, mu);
            //        }
            //    }
            //    else return new Phanso(0, 1);
                

            //}
            public  double  PhanSoToiGianTuSo(double a,double b)
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
                if(a==0||b==0)
                {
                    return a + b;
                }
               while (a!=b)
                {
                    if (a > b)
                        a = a - b;
                    else b = b - a;
                }
                return a;
            }


        }

        bool badd=false;//cờ hiệu cho phép add được bật lên
        bool bsub=false,// cờ hiệu cho phép sub được bât
            bmutil=false,// cờ hiệu cho phép multip
            bdiv=false;//cờ hiệu cho phép div được bật
        bool bans = false;
        Phanso ans;
        Phanso Phanso1, Phanso2, Phanso3;
        double tuso1, mauso1, tuso2, mauso2;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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
                            a = a * mu;
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
        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            badd = true;
            if(bans==true)
            {
                txbTusoPhanSo1.Text = ans.Tuso.ToString();
                txbmausoPhanSo1.Text = ans.Mauso.ToString();
                txbTusoPhanSo2.Clear();
                txbmausoPhanSo2.Clear();
                txbmausoPhanSo3.Clear();
                txbTusoPhanSo3.Clear();
            }
            

            bsub = false;
            bmutil = false;
            bdiv = false;
            BtnAdd.Enabled = false;
            Btnsub.Enabled = false;
            BtnMulti.Enabled = false;
            Btndiv.Enabled = false;
            BtnClear.Enabled = true;
            textBox1.Text = "+";
            txbTusoPhanSo2.Enabled = true;
            txbTusoPhanSo2.Focus();

        }

        private void Btnsub_Click(object sender, EventArgs e)
        {
            bsub = true;
            if (bans == true)
            {
                txbTusoPhanSo1.Text = ans.Tuso.ToString();
                txbmausoPhanSo1.Text = ans.Mauso.ToString();
                txbTusoPhanSo2.Clear();
                txbmausoPhanSo2.Clear();
                txbmausoPhanSo3.Clear();
                txbTusoPhanSo3.Clear();
            }

            badd = false;
            bmutil = false;
            bdiv = false;
            BtnAdd.Enabled = false;
            Btnsub.Enabled = false;
            BtnMulti.Enabled = false;
            Btndiv.Enabled = false;
            textBox1.Text = "----";
            txbTusoPhanSo2.Focus();


        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            bsub = false;
            badd = false;
            bmutil = true;
            if (bans == true)
            {
                txbTusoPhanSo1.Text = ans.Tuso.ToString();
                txbmausoPhanSo1.Text = ans.Mauso.ToString();
                txbTusoPhanSo2.Clear();
                txbmausoPhanSo2.Clear();
                txbmausoPhanSo3.Clear();
                txbTusoPhanSo3.Clear();
            }
            bdiv = false;
            BtnAdd.Enabled = false;
            Btnsub.Enabled = false;
            BtnMulti.Enabled = false;
            Btndiv.Enabled = false;
            textBox1.Text = "*";
            txbTusoPhanSo2.Focus();

        }

        private void txbTusoPhanSo1_Leave(object sender, EventArgs e)
        {
            if (txbTusoPhanSo1.Text.Trim() != null)
            {
                tuso1 = Convert.ToDouble(txbTusoPhanSo1.Text);
            }
            else
                tuso1 = 0;



        }

        private void txbmausoPhanSo1_TextChanged(object sender, EventArgs e)
        {
            if(txbmausoPhanSo1.Text.Trim()!=null)
            {
                panel1.Enabled = true;
                BtnClear.Enabled = false;
                BtnShow.Enabled = false;
              


            }
        }

        private void txbmausoPhanSo1_Leave(object sender, EventArgs e)
        {
            if(txbmausoPhanSo1.Text.Trim()!=null)
            {
                if(txbmausoPhanSo1.Text=="0")
                {
                    MessageBox.Show("Mẫu không được =0");
                    txbmausoPhanSo1.Clear();
                    txbmausoPhanSo1.Focus();
                    
                    
                }
                else
                {
                    //mauso1 = Convert.ToDouble(txbmausoPhanSo2.Text.Trim());
                    panel1.Enabled = true;
                    BtnShow.Enabled = false;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giớiThiệuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void txbTusoPhanSo2_TextChanged(object sender, EventArgs e)
        {
            if(txbTusoPhanSo2.Text.Trim()!=null)
            {
                txbmausoPhanSo2.Enabled = true;
                
            }
        }

        private void nângCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btndiv_Click(object sender, EventArgs e)
        {
            bsub = false;
            badd = false;
            bmutil = false;
            bdiv = true;
            if (bans == true)
            {
                txbTusoPhanSo1.Text = ans.Tuso.ToString();
                txbmausoPhanSo1.Text = ans.Mauso.ToString();
                txbTusoPhanSo2.Clear();
                txbmausoPhanSo2.Clear();
                txbmausoPhanSo3.Clear();
                txbTusoPhanSo3.Clear();
            }
            BtnAdd.Enabled = false;
            Btnsub.Enabled = false;
            BtnMulti.Enabled = false;
            Btndiv.Enabled = false;
            textBox1.Text = "/";
            txbTusoPhanSo2.Focus();

        }

        private void txbTusoPhanSo2_Leave(object sender, EventArgs e)
        {
            //if (txbTusoPhanSo2.Text.Trim() != null)
            //{
            //    Phanso1.Tuso = Convert.ToDouble(txbTusoPhanSo1.Text.ToString());
            //}
            //else Phanso2.Tuso = 0;
            if (txbTusoPhanSo2.Text.Trim() != null)
            {
                tuso2= Convert.ToDouble(txbTusoPhanSo2.Text);
            }
            else
                tuso2 = 0;
        }

        private void txbmausoPhanSo2_Leave(object sender, EventArgs e)
        {
            if (txbmausoPhanSo2.Text.Trim() != null)
            {
                if (txbmausoPhanSo2.Text == "0")
                {
                    MessageBox.Show("Mẫu không được =0");
                    txbmausoPhanSo2.Clear();
                    txbmausoPhanSo2.Focus();
                    

                }
                else
                {
                    BtnAdd.Enabled = false;
                    Btnsub.Enabled = false;
                    BtnMulti.Enabled = false;
                    Btndiv.Enabled = false;
                    BtnShow.Enabled = true;
                    BtnClear.Enabled = true;
                    mauso2 = Convert.ToDouble(txbmausoPhanSo2.Text);
                    
                }
            }
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
           if(badd==true)
            {
                try
                {
                    Phanso1 = new Phanso(Convert.ToDouble(txbTusoPhanSo1.Text.Trim()), Convert.ToDouble(txbmausoPhanSo1.Text.Trim()));
                    Phanso1 = Doi(Phanso1.Tuso) / Doi(Phanso1.Mauso);
                    Phanso2 = new Phanso(Convert.ToDouble( txbTusoPhanSo2.Text),Convert.ToDouble( txbmausoPhanSo2.Text));
                    Phanso2 = Doi(Phanso2.Tuso) / Doi(Phanso2.Mauso);

                    Phanso3 = Phanso1 + Phanso2;
                   
                    if (Phanso3.Tuso*Phanso3.Mauso>0)//neu ca 2 cung la so am hoac duong
                    {
                        Math.Abs(Phanso3.Tuso);
                        Math.Abs(Phanso3.Mauso);
                    }
                    else if(Phanso3.Mauso<0 &&Phanso3.Tuso>0)//neu 1 trong 2 la so am 
                    {
                        Phanso3.Mauso = Phanso3.Mauso * (-1);
                        Phanso3.Tuso = Phanso3.Tuso * (-1);
                    }
                    Phanso3 = Doi(Phanso3.Tuso) / Doi(Phanso3.Mauso);

                    ans = new Phanso(Phanso3.Tuso, Phanso3.Mauso);
                    if (Phanso3.Tuso -(int)Phanso3.Tuso==0&& Phanso3.Mauso-(int)Phanso3.Mauso==0)
                    {
                    double a =  Phanso3.UCLN(Math.Abs( Phanso3.Tuso),Math.Abs( Phanso3.Mauso));
                        ans = new Phanso(Phanso3.Tuso / a, Phanso3.Mauso / a);

                    }
                    
                    
                    txbTusoPhanSo3.Text = ans.Tuso.ToString();
                    txbmausoPhanSo3.Text = ans.Mauso.ToString();
                    BtnShow.Enabled = false;
                    BtnClear.Enabled = true;
                    BtnAdd.Enabled = true;
                    Btnsub.Enabled = true;
                    BtnMulti.Enabled = true;
                    Btndiv.Enabled = true;
                    badd = false;
                    bsub = false;
                    bmutil = false;
                    bdiv = false;
                    bans = true;//bat co luu de tie[p tuc thuc hien phep tinh

                }
                catch
                {
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại!");
                    txbmausoPhanSo1.Clear();
                    txbmausoPhanSo2.Clear();
                    txbmausoPhanSo3.Clear();
                    txbTusoPhanSo1.Clear();
                    txbTusoPhanSo2.Clear();
                    txbTusoPhanSo3.Clear();
                    textBox1.Clear();
                    ans = new Phanso();
                    panel1.Enabled = false;
                    BtnClear.Enabled = true;
                }
            }
           else if (bsub == true)
            {
                try
                {
                    Phanso1 = new Phanso(Convert.ToDouble(txbTusoPhanSo1.Text.Trim()), Convert.ToDouble(txbmausoPhanSo1.Text.Trim()));
                    Phanso1 = Doi(Phanso1.Tuso) / Doi(Phanso1.Mauso);
                    Phanso2 = new Phanso(Convert.ToDouble(txbTusoPhanSo2.Text), Convert.ToDouble(txbmausoPhanSo2.Text));
                    Phanso2 = Doi(Phanso2.Tuso) / Doi(Phanso2.Mauso); Phanso3 = Phanso1 - Phanso2;
                    //if (Phanso3.Tuso - (int)Phanso3.Tuso != 0)
                    //{
                    //    if (Phanso3.Mauso - (int)Phanso3.Mauso != 0)
                    //    {
                    //        //ca 2 deu la so thap phan
                    //        //doi tu so sang phan so 
                    //        Phanso phansod = Phanso3.Tuso;
                    //        Phanso phansoe = Phanso3.Mauso;
                    //        Phanso3 = phansod / phansoe;


                    //    }
                    //    //neu b khong la so thap phan
                    //    else
                    //    {
                    //        Phanso phanso = Phanso3.Tuso;
                    //        Phanso3 = phanso / Phanso3.Mauso;
                    //    }

                    //}
                    //else //neu tu so khong la so thap phan
                    //{
                    //    if (Phanso3.Mauso - (int)Phanso3.Mauso != 0)//neu mau la thap phan
                    //    {

                    //        Phanso phansoe = Phanso3.Mauso;
                    //        Phanso3 = Phanso3.Tuso / phansoe;


                    //    }
                    //}
                    if (Phanso3.Tuso * Phanso3.Mauso > 0)
                    {
                        Math.Abs(Phanso3.Tuso);
                        Math.Abs(Phanso3.Mauso);
                    }
                    else if (Phanso3.Mauso < 0 && Phanso3.Tuso > 0)
                    {
                        Phanso3.Mauso = Phanso3.Mauso * (-1);
                        Phanso3.Tuso = Phanso3.Tuso * (-1);
                    }
                    Phanso3 = Doi(Phanso3.Tuso) / Doi(Phanso3.Mauso);
                    ans = new Phanso(Phanso3.Tuso, Phanso3.Mauso);
                    if (Phanso3.Tuso - (int)Phanso3.Tuso == 0 && Phanso3.Mauso - (int)Phanso3.Mauso == 0)
                    {
                        double a = Phanso3.UCLN(Math.Abs(Phanso3.Tuso), Math.Abs(Phanso3.Mauso));
                        ans = new Phanso(Phanso3.Tuso / a, Phanso3.Mauso / a);

                    }
                    txbTusoPhanSo3.Text = ans.Tuso.ToString();
                    txbmausoPhanSo3.Text = ans.Mauso.ToString();
                    BtnShow.Enabled = false;
                    BtnClear.Enabled = true;
                    BtnAdd.Enabled = true;
                    Btnsub.Enabled = true;
                    BtnMulti.Enabled = true;
                    Btndiv.Enabled = true;
                    badd = false;
                    bsub = false;
                    bmutil = false;
                    bdiv = false;
                    bans = true;//bat co luu de tie[p tuc thuc hien phep tinh

                }
                catch
                {
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại!");
                    txbmausoPhanSo1.Clear();
                    txbmausoPhanSo2.Clear();
                    txbmausoPhanSo3.Clear();
                    txbTusoPhanSo1.Clear();
                    txbTusoPhanSo2.Clear();
                    txbTusoPhanSo3.Clear();
                    textBox1.Clear();
                    ans = new Phanso();
                    panel1.Enabled = false;
                    BtnClear.Enabled = true;
                }
            }
            else if (bmutil == true)
            {
                try
                {
                    Phanso1 = new Phanso(Convert.ToDouble(txbTusoPhanSo1.Text.Trim()), Convert.ToDouble(txbmausoPhanSo1.Text.Trim()));
                    Phanso1 = Doi(Phanso1.Tuso) / Doi(Phanso1.Mauso);
                    Phanso2 = new Phanso(Convert.ToDouble(txbTusoPhanSo2.Text), Convert.ToDouble(txbmausoPhanSo2.Text));
                    Phanso2 = Doi(Phanso2.Tuso) / Doi(Phanso2.Mauso);
                    Phanso3 = Phanso1 * Phanso2;
                    //if (Phanso3.Tuso - (int)Phanso3.Tuso != 0)
                    //{
                    //    if (Phanso3.Mauso - (int)Phanso3.Mauso != 0)
                    //    {
                    //        //ca 2 deu la so thap phan
                    //        //doi tu so sang phan so 
                    //        Phanso phansod = Phanso3.Tuso;
                    //        Phanso phansoe = Phanso3.Mauso;
                    //        Phanso3 = phansod / phansoe;


                    //    }
                    //    //neu b khong la so thap phan
                    //    else
                    //    {
                    //        Phanso phanso = Phanso3.Tuso;
                    //        Phanso3 = phanso / Phanso3.Mauso;
                    //    }

                    //}
                    //else //neu tu so khong la so thap phan
                    //{
                    //    if (Phanso3.Mauso - (int)Phanso3.Mauso != 0)//neu mau la thap phan
                    //    {

                    //        Phanso phansoe = Phanso3.Mauso;
                    //        Phanso3 = Phanso3.Tuso / phansoe;


                    //    }
                    //}
                    if (Phanso3.Tuso * Phanso3.Mauso > 0)
                    {
                        Math.Abs(Phanso3.Tuso);
                        Math.Abs(Phanso3.Mauso);
                    }
                    else if (Phanso3.Mauso < 0 && Phanso3.Tuso > 0)
                    {
                        Phanso3.Mauso = Phanso3.Mauso * (-1);
                        Phanso3.Tuso = Phanso3.Tuso * (-1);
                    }
                    Phanso3 = Doi(Phanso3.Tuso) / Doi(Phanso3.Mauso);
                    ans = new Phanso(Phanso3.Tuso, Phanso3.Mauso);
                    if (Phanso3.Tuso - (int)Phanso3.Tuso == 0 && Phanso3.Mauso - (int)Phanso3.Mauso == 0)
                    {
                        double a = Phanso3.UCLN(Math.Abs(Phanso3.Tuso), Math.Abs(Phanso3.Mauso));
                        ans = new Phanso(Phanso3.Tuso / a, Phanso3.Mauso / a);

                    };
                    txbTusoPhanSo3.Text = ans.Tuso.ToString();
                    txbmausoPhanSo3.Text = ans.Mauso.ToString();
                    BtnShow.Enabled = false;
                    BtnClear.Enabled = true;
                    BtnAdd.Enabled = true;
                    Btnsub.Enabled = true;
                    BtnMulti.Enabled = true;
                    Btndiv.Enabled = true;
                    badd = false;
                    bsub = false;
                    bmutil = false;
                    bdiv = false;
                    bans = true;//bat co luu de tie[p tuc thuc hien phep tinh

                }
                catch
                {
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại!");
                    txbmausoPhanSo1.Clear();
                    txbmausoPhanSo2.Clear();
                    txbmausoPhanSo3.Clear();
                    txbTusoPhanSo1.Clear();
                    txbTusoPhanSo2.Clear();
                    txbTusoPhanSo3.Clear();
                    textBox1.Clear();
                    ans = new Phanso();
                    panel1.Enabled = false;
                    BtnClear.Enabled = true;
                }
            }
            else if (bdiv == true)
            {
                try
                {
                    Phanso1 = new Phanso(Convert.ToDouble(txbTusoPhanSo1.Text.Trim()), Convert.ToDouble(txbmausoPhanSo1.Text.Trim()));
                    Phanso1 = Doi(Phanso1.Tuso) / Doi(Phanso1.Mauso);
                    Phanso2 = new Phanso(Convert.ToDouble(txbTusoPhanSo2.Text), Convert.ToDouble(txbmausoPhanSo2.Text));
                    Phanso2 = Doi(Phanso2.Tuso) / Doi(Phanso2.Mauso); Phanso3 = Phanso1 / Phanso2;
                    //if (Phanso3.Tuso - (int)Phanso3.Tuso != 0)
                    //{
                    //    if (Phanso3.Mauso - (int)Phanso3.Mauso != 0)
                    //    {
                    //        //ca 2 deu la so thap phan
                    //        //doi tu so sang phan so 
                    //        Phanso phansod = Phanso3.Tuso;
                    //        Phanso phansoe = Phanso3.Mauso;
                    //        Phanso3 = phansod / phansoe;


                    //    }
                    //    //neu b khong la so thap phan
                    //    else
                    //    {
                    //        Phanso phanso = Phanso3.Tuso;
                    //        Phanso3 = phanso / Phanso3.Mauso;
                    //    }

                    //}
                    //else //neu tu so khong la so thap phan
                    //{
                    //    if (Phanso3.Mauso - (int)Phanso3.Mauso != 0)//neu mau la thap phan
                    //    {

                    //        Phanso phansoe = Phanso3.Mauso;
                    //        Phanso3 = Phanso3.Tuso / phansoe;


                    //    }
                    //}
                    if (Phanso3.Tuso * Phanso3.Mauso > 0)
                    {
                        Math.Abs(Phanso3.Tuso);
                        Math.Abs(Phanso3.Mauso);
                    }
                    else if (Phanso3.Mauso < 0 && Phanso3.Tuso > 0)
                    {
                        Phanso3.Mauso = Phanso3.Mauso * (-1);
                        Phanso3.Tuso = Phanso3.Tuso * (-1);
                    }
                    Phanso3 = Doi(Phanso3.Tuso) / Doi(Phanso3.Mauso);
                    ans = new Phanso(Phanso3.Tuso, Phanso3.Mauso);
                    if (Phanso3.Tuso - (int)Phanso3.Tuso == 0 && Phanso3.Mauso - (int)Phanso3.Mauso == 0)
                    {
                        double a = Phanso3.UCLN(Math.Abs(Phanso3.Tuso), Math.Abs(Phanso3.Mauso));
                        ans = new Phanso(Phanso3.Tuso / a, Phanso3.Mauso / a);

                    }
                    txbTusoPhanSo3.Text = ans.Tuso.ToString();
                    txbmausoPhanSo3.Text = ans.Mauso.ToString();
                    BtnShow.Enabled = false;
                    BtnClear.Enabled = true;
                    BtnAdd.Enabled = true;
                    Btnsub.Enabled = true;
                    BtnMulti.Enabled = true;
                    Btndiv.Enabled = true;
                    badd = false;
                    bsub = false;
                    bmutil = false;
                    bdiv = false;
                    bans = true;//bat co luu de tie[p tuc thuc hien phep tinh

                }
                catch
                {
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại!");
                    txbmausoPhanSo1.Clear();
                    txbmausoPhanSo2.Clear();
                    txbmausoPhanSo3.Clear();
                    txbTusoPhanSo1.Clear();
                    txbTusoPhanSo2.Clear();
                    txbTusoPhanSo3.Clear();
                    textBox1.Clear();
                    ans = new Phanso();
                    panel1.Enabled = false;
                    BtnClear.Enabled = true;
                }
            }
        }

       public void load()
        {
            panel1.Enabled = false;
            textBox1.Enabled = false;
            txbTusoPhanSo2.Enabled = false;
            txbmausoPhanSo2.Enabled = false;
            
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txbmausoPhanSo1.Clear();
            txbmausoPhanSo2.Clear();
            txbmausoPhanSo3.Clear();
            txbTusoPhanSo1.Clear();
            txbTusoPhanSo2.Clear();
            txbTusoPhanSo3.Clear();
            textBox1.Clear();
            ans = new Phanso();
            panel1.Enabled = false;
            bans = false;
            
        }

        private void txbmausoPhanSo2_TextChanged(object sender, EventArgs e)
        {
            if(txbmausoPhanSo2.Text.Trim()!=null)
            {
                BtnShow.Enabled = true;

            }
        }
    }
}
