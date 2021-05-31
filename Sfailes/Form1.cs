using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sfailes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pathto = @"D:\\FINAL.txt";
            string[] rel = new string[] { };
            int[,] arrg = new int[3, 2];
            int z = 0;
            rel = File.ReadAllLines(pathto);
            int ad = 0;
            foreach (string h in rel)
            {


                string[] s = h.Split(' ');


                arrg[ad, 0] = Convert.ToInt32(s[0]);
                arrg[ad, 1] = Convert.ToInt32(s[1]);
                //  MessageBox.Show(Convert.ToString(arrg[i, 0]) + " and " + Convert.ToString(arrg[i, 1]));

                ad++;
                //d=sqrt((x2-x1)^2+(y2-y1)^2)
            }


            for (int i = 0; i < 3; i++)
            {
         //       MessageBox.Show(Convert.ToString(arrg[i, 0]) + " and " + Convert.ToString(arrg[i, 1]));
            }

            double[] dbl = new double[2];
            double min = 0,max=0,max1=0;

            for (int i = 0; i < 2; i++)
            {
                max = Math.Sqrt(((arrg[i+1, 0] - arrg[i, 0])* (arrg[i + 1, 0] - arrg[i, 0])) + ((arrg[i+1, 1] - arrg[i, 1])* +(arrg[i + 1, 1] - arrg[i, 1])));
               


                dbl[i] = max;
                MessageBox.Show(Convert.ToString(dbl[i]));
            //    MessageBox.Show(Convert.ToString(max * 10));



            }

            double maxValue = dbl.Max();
            double minValue = dbl.Min();

            MessageBox.Show("Максимальное: "+Convert.ToString(maxValue) + " Минимальное "+Convert.ToString(minValue));
















            //28

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string pathto = @"D:\\FINAL1.txt";
            string[] rel = new string[] { };

            string g = "";
            int[,] a = new int[3, 3];
            int z = 0;
            rel = File.ReadAllLines(pathto);
            int ad = 0;
            foreach (string h in rel)
            {
                string[] s = h.Split(' ');
                    a[ad, 0] = Convert.ToInt32(s[0]);
                    a[ad, 1] = Convert.ToInt32(s[1]);
                    a[ad, 2] = Convert.ToInt32(s[2]);
                ad++;
              
            }

            string g21 = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    g21 += Convert.ToString(a[i, j]);
                }
                g21 += "\n";
            }
            MessageBox.Show(g21);




            int tmp = 0;
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    tmp = a[i,j];
                    a[i,j] = a[j,i];
                    a[j,i] = tmp;
                }
            }

            string g2 = "";
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    g2+=Convert.ToString(a[i, j]);
                }
                g2 += "\n";
            }
            MessageBox.Show(g2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string pathto = @"D:\\bus.txt";
            string[] rel = new string[] { };

            string g = "";
            int[] arrg = new int[] { };
            rel = File.ReadAllLines(pathto);
            int i = 0; 
            int summ = 0;
            foreach (string h in rel)
            {
                string[] s = h.Split(' ');
                summ += Convert.ToInt32(s[4]);
                i++;
            }
           

            MessageBox.Show(Convert.ToString(summ));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string pathto = @"D:\\bus.txt";
            string[] rel = new string[] { };
            string jj = textBox1.Text;
            rel = File.ReadAllLines(pathto);
            foreach (string h in rel)
            {
                string[] s = h.Split(' ');

                if (s[0] == jj)
                {
                    MessageBox.Show("Маршрут: "+s[1] + "-" + s[2]);
                }
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            string pathto = @"D:\\bus.txt";
            string[] rel = new string[] { };

            string jj = textBox2.Text;
            int[] arrg = new int[] { };
            rel = File.ReadAllLines(pathto);

            foreach (string h in rel)
            {
                string[] s = h.Split(' ');

                if ((s[1] == jj)||(s[2] == jj))
                {
                    MessageBox.Show("Номер маршрута: "+s[0]);
                }
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            string pathto = @"D:\\bus.txt";
            string[] rel = new string[] { };

            string jj = textBox3.Text;
            int[] arrg = new int[] { };
            rel = File.ReadAllLines(pathto);
            string sroks="";
            foreach (string h in rel)
            {
                string[] s = h.Split(' ');

                if (s[5] == jj )
                {
                    sroks += s[1] + "-" + s[2] + "\n";
                }
            }
            MessageBox.Show(sroks);
        }
    }
}
    
