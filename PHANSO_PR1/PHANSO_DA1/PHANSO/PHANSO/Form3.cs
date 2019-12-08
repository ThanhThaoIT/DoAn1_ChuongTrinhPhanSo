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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

      
        public class Phanso
        {

            public double ituso;
            public double imauso;
            public double ipnguyen;
            public double PNguyen 
            {
                get { return this.ipnguyen; }
                set { this.ipnguyen = value; }
            }
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
                        throw new Exception("Mau so khac 0:");
                    this.imauso = value;
                }
            }
            public Phanso() { }
            public Phanso(double tuso,double mauso)
            {
                this.ituso = tuso;
                this.imauso = mauso; 
            }
            public Phanso (double nguyen,double tuso,double mauso)
            {
                this.ipnguyen = nguyen;
                this.ituso = tuso;
                this.imauso = mauso;
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
            public double ToiGianTuSo(double a,double b)
            {
                return a / UCLN(a, b);
            }
            public double ToiGianMauSo(double a,double b)
            {
                return b / UCLN(a, b);
            }
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
        Phanso ps1, ps2;
        Phanso ans;

        private void btntoigianphanso_Click(object sender, EventArgs e)
        {

            ps1 = new Phanso(Convert.ToDouble(NumMini_Tu.Text), Convert.ToDouble(NumMini_Mau.Text));
            ps2 = ps1;
                
            if (ps2.Tuso * ps2.Mauso > 0)//neu ca 2 cung la so am hoac duong
            {
                ps2.Tuso= Math.Abs(ps2.Tuso);
                ps2.Mauso=Math.Abs(ps2.Mauso);
            }
            else if (ps2.Mauso < 0 && ps2.Tuso > 0)//neu 1 trong 2 la so am 
            {
                ps2.Mauso = ps2.Mauso * (-1);
                ps2.Tuso = ps2.Tuso * (-1);
            }
            ps2 = Doi(ps2.Tuso) / Doi(ps2.Mauso);

            ans = new Phanso(ps2.Tuso, ps2.Mauso);
            if (ps2.Tuso - (int)ps2.Tuso == 0 && ps2.Mauso - (int)ps2.Mauso == 0)
            {
                double a = ps2.UCLN(Math.Abs(ps2.Tuso), Math.Abs(ps2.Mauso));
                ans = new Phanso(ps2.Tuso / a, ps2.Mauso / a);

            }
            NumRMini_Tu.Text = ans.Tuso.ToString();
            NumRMini_Mau.Text = ans.Mauso.ToString();
        }

        private void btnhonso_Click(object sender, EventArgs e)
        {
            ps1 = new Phanso(Convert.ToDouble(Num_int.Text), Convert.ToDouble(Num_tu.Text), Convert.ToDouble(Num_mau.Text));
            ps2 = ps1;

            if (ps2.Tuso * ps2.Mauso > 0)//neu ca 2 cung la so am hoac duong
            {
               ps2.Tuso=  Math.Abs(ps2.Tuso);
                ps2.Mauso= Math.Abs(ps2.Mauso);
            }
            else if (ps2.Mauso < 0 && ps2.Tuso > 0)//neu 1 trong 2 la so am 
            {
                ps2.Mauso = ps2.Mauso * (-1);
                ps2.Tuso = ps2.Tuso * (-1);
            }
            ps2 = (Doi(ps2.PNguyen) * Doi(ps2.Mauso)+Doi(ps2.Tuso))/Doi(ps2.Mauso);

            ans = new Phanso(ps2.Tuso, ps2.Mauso);
            if (ps2.Tuso - (int)ps2.Tuso == 0 && ps2.Mauso - (int)ps2.Mauso == 0)
            {
                double a = ps2.UCLN(Math.Abs(ps2.Tuso), Math.Abs(ps2.Mauso));
                ans = new Phanso(ps2.Tuso / a, ps2.Mauso / a);

            }
            NumR_Tu.Text = ans.Tuso.ToString();
            NumR_Mau.Text = ans.Mauso.ToString();
        }

        private void NumMini_Mau_Leave(object sender, EventArgs e)
        {
            if(NumMini_Mau.Text.Trim()!=null)
            {

                if(NumMini_Mau.Text=="0")
                {
                    MessageBox.Show("Mẫu không được bằng 0");
                    NumMini_Mau.Clear();
                    NumMini_Mau.Focus();
                }
            }
        }

        private void NumMini_Mau_TextChanged(object sender, EventArgs e)
        {
            if(NumMini_Mau.Text.Trim()!=null)
            {
                btntoigianphanso.Enabled = true;
               
            }
        }

        private void Num_mau_Leave(object sender, EventArgs e)
        {
            if(NumMini_Mau.Text.Trim()!=null)
            {
                if(NumMini_Mau.Text.Trim()=="0")
                {
                    MessageBox.Show("không được bằng 0");
                    NumMini_Mau.Clear();
                    NumMini_Mau.Focus();
                }
            }
        }

        private void Num_mau_TextChanged(object sender, EventArgs e)
        {
            if(NumMini_Mau.Text.Trim()!=null)
            {
                btnhonso.Enabled = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
