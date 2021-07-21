using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class MainParkingSystem : Form
    { //parksanwon
        public MainParkingSystem()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RedBox.BackColor = Color.Red;
            RedBox.Text = YellowBox.Text.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RedBox.BackColor = Color.Yellow;
            RedBox.Text = t.Text.ToString();
        }

        private void t_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;

            if (RedBox.BackColor == Color.Red)
            {
                t.Text = txtCarNumber.Text;
            }
            else
            {
                MessageBox.Show("자리가 있습니다.");
            }
        }

        private void t_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = false;
            
            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t.Text = "1";
            if (pictureBox1.Visible == true)
            {
                MessageBox.Show("자리가 없습니다");
            }
            else
            {
                MessageBox.Show("자리가 있습니다");
            }
        }

        private void t_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox1.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox1.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
            
                         
        }

        private void t1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox2.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t1.Text = txtCarNumber.Text;
        }

        private void t1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox2.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t1.Text = "2";
            if (pictureBox2.Visible == true)
            {
                MessageBox.Show("자리가 없습니다");
            }
            else
            {
                MessageBox.Show("자리가 있습니다");
            }
        }

        private void t2_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox3.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t2.Text = txtCarNumber.Text;
        }

        private void t2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox3.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t2.Text = "3";
            if (pictureBox3.Visible == true)
            {
                MessageBox.Show("자리가 없습니다");
            }
            else
            {
                MessageBox.Show("자리가 있습니다");
            }
        }

        private void t3_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox4.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t3.Text = txtCarNumber.Text;
        }

        private void t3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox4.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t3.Text = "4";
            if (pictureBox4.Visible == true)
            {
                MessageBox.Show("자리가 없습니다");
            }
            else
            {
                MessageBox.Show("자리가 있습니다");
            }
        }

        private void t4_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox5.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t4.Text = txtCarNumber.Text;
        }

        private void t4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox5.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t4.Text = "5";
            if (pictureBox5.Visible == true)
            {
                MessageBox.Show("자리가 없습니다");
            }
            else
            {
                MessageBox.Show("자리가 있습니다");
            }
        }

        private void t5_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox6.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t5.Text = txtCarNumber.Text;
        }

        private void t5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox6.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t5.Text = "6";
            if (pictureBox6.Visible == true)
            {
                MessageBox.Show("자리가 없습니다");
            }
            else
            {
                MessageBox.Show("자리가 있습니다");
            }
        }

        private void t6_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox7.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t6.Text = txtCarNumber.Text;
        }

        private void t6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox7.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t6.Text = "7";
        }

        private void t7_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox8.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t7.Text = txtCarNumber.Text;
        }

        private void t7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox8.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t7.Text = "8";
        }

        private void t8_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox9.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t8.Text = txtCarNumber.Text;
        }

        private void t8_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox9.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t8.Text = "9";
        }

        private void t9_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox10.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t9.Text = txtCarNumber.Text;
        }

        private void t9_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox10.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t9.Text = "10";
        }

        private void t10_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox11.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t10.Text = txtCarNumber.Text;
        }

        private void t10_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox11.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t10.Text = "11";
        }

        private void t11_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox12.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t11.Text = txtCarNumber.Text;
        }

        private void t11_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox12.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t11.Text = "12";
        }

        private void t12_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox13.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t12.Text = txtCarNumber.Text;
        }

        private void t12_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox13.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t12.Text = "13";
        }

        private void t13_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox14.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t13.Text = txtCarNumber.Text;
        }

        private void t13_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox14.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t13.Text = "14";
        }

        private void t14_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox15.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t14.Text = txtCarNumber.Text;
        }

        private void t14_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox15.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t14.Text = "15";
        }

        private void t15_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox16.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t15.Text = txtCarNumber.Text;
        }

        private void t15_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox16.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t15.Text = "16";
        }

        private void t16_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox17.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t16.Text = txtCarNumber.Text;
        }

        private void t16_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox17.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t16.Text = "17";
        }

        private void t17_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox18.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t17.Text = txtCarNumber.Text;
        }

        private void t17_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox18.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t17.Text = "18";
        }

        private void t18_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox19.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t18.Text = txtCarNumber.Text;
        }

        private void t18_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox19.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t18.Text = "19";
        }

        private void t19_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox20.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t19.Text = txtCarNumber.Text;
        }

        private void t19_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox20.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t19.Text = "20";
        }

        private void t20_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox21.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t20.Text = txtCarNumber.Text;
        }

        private void t20_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox21.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t20.Text = "21";
        }

        private void t21_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox22.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t21.Text = txtCarNumber.Text;
        }

        private void t21_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox22.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t21.Text = "22";
        }

        private void t22_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox23.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t22.Text = txtCarNumber.Text;
        }

        private void t22_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox23.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t22.Text = "23";
        }

        private void t23_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox24.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t23.Text = txtCarNumber.Text;
        }

        private void t23_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox24.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t23.Text = "24";
        }

        private void t24_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox25.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t24.Text = txtCarNumber.Text;
        }

        private void t24_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox25.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t24.Text = "25";
        }

        private void t25_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox26.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t25.Text = txtCarNumber.Text;
        }

        private void t25_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox26.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t25.Text = "26";
        }

        private void t26_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox27.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t26.Text = txtCarNumber.Text;
        }

        private void t26_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox27.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t26.Text = "27";
        }

        private void t27_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox28.Visible = true;
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.White;
            t27.Text = txtCarNumber.Text;
        }

        private void t27_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox28.Visible = false;

            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.White;
            t27.Text = "28";
        }

        private void t1_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox2.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox2.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t2_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox3.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox3.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t3_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox4.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox4.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t4_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox5.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox5.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t5_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox6.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox6.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t6_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox7.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox7.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t7_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox8.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox8.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t8_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox9.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox9.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t9_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox10.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox10.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t10_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox11.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox11.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t11_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox12.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox12.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t12_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox13.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox13.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t13_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox14.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox14.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t14_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox15.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox15.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t15_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox16.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox16.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t16_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox17.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox17.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t17_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox18.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox18.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t18_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox19.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox19.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t19_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox20.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox20.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t20_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox21.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox21.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t21_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox22.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox22.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t22_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox23.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox23.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t23_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox24.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox24.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t24_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox25.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox25.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t25_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox26.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox26.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t26_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox27.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox27.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void t27_MouseHover(object sender, EventArgs e)
        {
            BlueBox.BackColor = Color.White;
            RedBox.BackColor = Color.White;

            if (pictureBox28.Visible == true)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (pictureBox28.Visible == false)
            {
                BlueBox.BackColor = Color.Blue;
            }
        }

        private void ParkingLine_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RedBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BlueBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void YellowBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void t2_TextChanged(object sender, EventArgs e)
        {

        }

        private void t3_TextChanged(object sender, EventArgs e)
        {

        }

        private void t4_TextChanged(object sender, EventArgs e)
        {

        }

        private void t5_TextChanged(object sender, EventArgs e)
        {

        }

        private void t6_TextChanged(object sender, EventArgs e)
        {

        }

        private void t7_TextChanged(object sender, EventArgs e)
        {

        }

        private void t8_TextChanged(object sender, EventArgs e)
        {

        }

        private void t9_TextChanged(object sender, EventArgs e)
        {

        }

        private void t10_TextChanged(object sender, EventArgs e)
        {

        }

        private void t11_TextChanged(object sender, EventArgs e)
        {

        }

        private void t12_TextChanged(object sender, EventArgs e)
        {

        }

        private void t13_TextChanged(object sender, EventArgs e)
        {

        }

        private void t14_TextChanged(object sender, EventArgs e)
        {

        }

        private void t15_TextChanged(object sender, EventArgs e)
        {

        }

        private void t16_TextChanged(object sender, EventArgs e)
        {

        }

        private void t17_TextChanged(object sender, EventArgs e)
        {

        }

        private void t18_TextChanged(object sender, EventArgs e)
        {

        }

        private void t19_TextChanged(object sender, EventArgs e)
        {

        }

        private void t20_TextChanged(object sender, EventArgs e)
        {

        }

        private void t21_TextChanged(object sender, EventArgs e)
        {

        }

        private void t22_TextChanged(object sender, EventArgs e)
        {

        }

        private void t23_TextChanged(object sender, EventArgs e)
        {

        }

        private void t24_TextChanged(object sender, EventArgs e)
        {

        }

        private void t25_TextChanged(object sender, EventArgs e)
        {

        }

        private void t26_TextChanged(object sender, EventArgs e)
        {

        }

        private void t27_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {

        }

        private void txtCarNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
