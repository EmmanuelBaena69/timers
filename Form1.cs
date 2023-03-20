using System.Drawing;

namespace timers
{
    public partial class Form1 : Form
    {
        int cont1 = 0, cont2 = 0, cont3 = 0;
        bool flag100 = false;
        bool flag1 = true;
        bool flag20 = false;
        bool flag2_1 = true;
        bool flag50 = false;
        bool flag3_1 = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tmr1.Enabled = true;
            tmr2.Enabled = true;
            tmr3.Enabled = true;
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            if (cont1 == 100)
            {
                flag100 = true;
                flag1 = false;
            }

            if (cont1 == 1)
            {
                flag100 = false;
                flag1 = true;
            }
            if (flag1 == true && flag100 == false)
            {
                cont1 = cont1 + 1;
                lbl1.Text = cont1.ToString();
            }
            if (flag100 == true && flag1 == false)
            {
                cont1 = cont1 - 1;
                lbl1.Text = cont1.ToString();
            }
        }

        private void tmr2_Tick(object sender, EventArgs e)
        {
            if (cont2 == 20)
            {
                flag20 = true;
                flag2_1 = false;
            }

            if (cont2 == 1)
            {
                flag20 = false;
                flag2_1 = true;
            }
            if (flag2_1 == true && flag20 == false)
            {
                cont2 = cont2 + 1;
                lbl2.Text = cont2.ToString();
            }
            if ((flag20 == true && flag2_1 == false) && (flag1 == true && cont1 <= 20))
            {
                cont2 = cont2 - 1;
                lbl2.Text = cont2.ToString();
            }
        }

        private void tmr3_Tick(object sender, EventArgs e)
        {
            if (cont3 == 50)
            {
                flag50 = true;
                flag3_1 = false;
            }

            if (cont3 == 1)
            {
                flag50 = false;
                flag3_1 = true;
            }
            if (flag3_1 == true && flag50 == false)
            {
                cont3 = cont3 + 1;
                lbl3.Text = cont3.ToString();
            }
            if ((flag50 == true && flag3_1 == false) && (flag1 == true && cont1 <= 50))
            {
                cont3 = cont3 - 1;
                lbl3.Text = cont3.ToString();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tmr1.Enabled = false;
            tmr2.Enabled = false;
            tmr3.Enabled = false;
        }
    }
}