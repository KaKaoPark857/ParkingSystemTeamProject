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
namespace car_project
{
    public partial class NonMemberPark : Form
    {
        public string intime, outtime;
        public NonMemberPark()
        {
            InitializeComponent();
        }
                                           

        private void btnInCar_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lblClock.Text = DateTime.Now.ToString("yy년MM월dd일 HH:mm");
            tbIntime.Text = lblClock.Text;

            if (tbCarNumber.Text == ""||tbCarNumber2.Text ==""||tbCarNumber3.Text == "")
            {
                MessageBox.Show("차량번호를 입력해주세요.");
            }
            else
            {
                string carNumber = tbCarNumber.Text + tbCarNumber2.Text + tbCarNumber3.Text;
                nonmemberlist.Items.Add(new ListViewItem(new string[] { carNumber, tbPhone.Text = "None", tbIntime.Text, "" }));
            }
            tbCarNumber.Clear();
            tbCarNumber2.Clear();
            tbCarNumber3.Clear();
            tbIntime.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            string dirPath = @"C:\ParkingSystem";
            Directory.CreateDirectory(dirPath);
            StreamWriter sw = new StreamWriter(new FileStream(dirPath + @"\Nonmember.csv", FileMode.Create)
                , System.Text.Encoding.UTF8);

            string[,] data;
            int nRow = nonmemberlist.Items.Count + 1;
            int nCol = 4;

            data = new string[nRow, nCol]; //리스트 뷰에 있는 column 값 data 행열에 추가
            data[0, 0] = nonmemberlist.Columns[0].Text;
            data[0, 1] = nonmemberlist.Columns[1].Text;
            data[0, 2] = nonmemberlist.Columns[2].Text;
            data[0, 3] = nonmemberlist.Columns[3].Text;
            

            int itemsNumber = 0;
            for (int i = 1; i < nRow; i++) //리스트 뷰에 있는 아이템값 data 행열에 추가
            {
                if (itemsNumber > nRow) break;
                for (int j = 0; j < nCol; j++)
                {
                    data[i, j] = nonmemberlist.Items[itemsNumber].SubItems[j].Text;
                }
                itemsNumber++;
            }

            for (int i = 0; i < nCol; i++) //column 값 엑셀에 추가
            {
                sw.Write(data[0, i] + "\t");


            }
            sw.Write("\n");

            for (int j = 1; j < nRow; j++) //리스트 뷰에 추가된 값들 엑셀에 추가
            {
                for (int i = 0; i < nCol; i++)
                {
                    sw.Write(data[j, i] + "\t");
                }
                sw.Write("\n");
            }
            sw.Close();
        }

        private void btnOutCar_Click(object sender, EventArgs e)
        {

            lblClock.Text = DateTime.Now.ToString("yy년MM월dd일 HH:mm");
            tbOuttime.Text = lblClock.Text;

            try
            {
                nonmemberlist.SelectedItems[0].SubItems[3].Text = tbOuttime.Text;
            }
            catch (Exception exp)
            {
                MessageBox.Show("리스트에서 차량을 선택해주세요.");
            }
            tbOuttime.Clear();
        }
        

    }
}
