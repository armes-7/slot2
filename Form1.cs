using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021
{
    public partial class Form1 : Form
    {


        int JetonAdeti;
        int resim1, resim2, resim3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      
        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int resim1, resim2, resim3;
            resim1 = rnd.Next(0, 5);
            pictureBox1.Image = ımageList1.Images[resim1]
           ; resim2 = rnd.Next(0, 5);
            pictureBox2.Image = ımageList1.Images[resim2]
            ; resim3 = rnd.Next(0, 5);
            pictureBox3.Image = ımageList1.Images[resim3]
        ;
        }

        private void BtnBasla_Click_1(object sender, EventArgs e)
        {
          
            if (JetonAdeti > 0)
            {
                timer1.Start();
                BtnDurdur.Enabled = true;
                Kasadakipara.Text = JetonAdeti + "Jeton".ToString();
            }
            else
            {
                MessageBox.Show("Oynamak içim jeton atmalısınız...!");
            }

        }

        private void BtnDurdur_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            if (resim1 == resim2 && resim2 == resim3)
            {
                JetonAdeti = JetonAdeti + 5;
            }
            else if (resim1 == resim2 || resim1 == resim3 || resim2 == resim3)
            {
                JetonAdeti = JetonAdeti + 3;
            }

            else if (resim1 != resim2 || resim2 != resim3 || resim1 != resim3)
            {
                JetonAdeti = JetonAdeti - 5;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnKapat_Click_1(object sender, EventArgs e)
        {
          
            Close();
        }

        private void BtnJetonAt_Click_1(object sender, EventArgs e)
        {
            JetonAdeti = JetonAdeti + 1;
            Kasadakipara.Text = JetonAdeti + "Jetonunuz Var".ToString();
            lbDurum.Text = "";
        }

      
       
    }
}
