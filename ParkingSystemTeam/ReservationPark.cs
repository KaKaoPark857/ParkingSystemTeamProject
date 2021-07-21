﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Reservation
{
    public partial class reservation : Form
    {
        int count = 0;
        public reservation()
        {
            InitializeComponent();

            //폼 닫기 이벤트 선언
            this.FormClosed += Form_Closing;
        }
        public void Form_Closing(object sender, FormClosedEventArgs e)
        {
            notifyIcon1.Visible = true; // tray icon 표시
            this.Hide();
        }
        //메인폼에서 예약 버튼을 눌렀을 때
        private void reservation_Load(object sender, EventArgs e)
        {
            CarNum.Text = "aa";
            ReservationSpotNum.Text = "aa";

            timer1.Start();
        }



        private void ResrvationBtn_Click(object sender, EventArgs e)
        {
            //현재 시간 나누기
            string NowMon = NowTime.Text.Substring(0, 2);
            string NowDay = NowTime.Text.Substring(3, 2);
            string NowHour = NowTime.Text.Substring(6, 2);
            string NowMin = NowTime.Text.Substring(9, 2);
            int NowMonNum = int.Parse(NowMon);
            int NowDayNum = int.Parse(NowDay);
            int NowHourNum = int.Parse(NowHour);
            int NowMinNum = int.Parse(NowMin);

            if (ReservationTime.Text == "")
            {
                MessageBox.Show("예약 시간을 입력해주세요");
            }
            else
            {
                //예약 시간 나누기
                string ReMon = ReservationTime.Text.Substring(0, 2);
                string ReDay = ReservationTime.Text.Substring(3, 2);
                string ReHour = ReservationTime.Text.Substring(6, 2);
                string ReMin = ReservationTime.Text.Substring(9, 2);
                int ReMonNum = int.Parse(ReMon);
                int ReDayNum = int.Parse(ReDay);
                int ReHourNum = int.Parse(ReHour);
                int ReMinNum = int.Parse(ReMin);

                if ((ReMonNum * 1000) + (ReDayNum * 100) + (ReHourNum * 10) + ReMinNum >= (NowMonNum * 1000) + (NowDayNum * 100) + (NowHourNum * 10) + NowMinNum)
                {

                    MessageBox.Show("예약이 완료 되었습니다.");

                    if ((ReHourNum + 5) < 24)
                    {
                        ReHourNum = ReHourNum + 5;
                        EndTime.Text = ReMon + "월" + ReDayNum + "일" + ReHourNum + ":" + ReMin;
                    }
                    else if ((ReHourNum + 5) == 24)
                    {
                        ReHourNum = 0;
                        ReHour = "00";
                        ReDayNum = ReDayNum + 1;

                        EndTime.Text = ReMon + "월" + ReDayNum + "일" + ReHour + ":" + ReMin;
                    }
                    else
                    {
                        ReHourNum = ReHourNum - 24;
                        ReHour = "0" + ReHourNum;
                        ReDayNum = ReDayNum + 1;

                        EndTime.Text = ReMon + "월" + ReDayNum + "일" + ReHour + ":" + ReMin;
                    }
                    MessageBox.Show("예약 종료 시간은 " + EndTime.Text + "입니다.");
                   string dirPath = @"C:\ParkingSystem";
                    Directory.CreateDirectory(dirPath);
                    StreamWriter sw = new StreamWriter(new FileStream(dirPath + @"\Reservation.csv", FileMode.Create)
                        , System.Text.Encoding.UTF8);

                    string[,] data;
                    int nRow = 2;
                    int nCol = 5;

                    data = new string[nRow, nCol]; //리스트 뷰에 있는 column 값 data 행열에 추가
                    data[0, 0] = CarNumlb.Text;
                    data[0, 1] = ReservationSpotNumlb.Text;
                    data[0, 2] = NowTimelb.Text;
                    data[0, 3] = ReservationTimelb.Text;
                    data[0, 4] = EndTimelb.Text;

                    sw.Write(data[0, 0] + "\t");
                    sw.Write(data[0, 1] + "\t");
                    sw.Write(data[0, 2] + "\t");
                    sw.Write(data[0, 3] + "\t");
                    sw.Write(data[0, 4]);
                    sw.Write("\n");

                    data[1, 0] = CarNum.Text;
                    data[1, 1] = ReservationSpotNum.Text;
                    data[1, 2] = NowTime.Text;
                    data[1, 3] = ReservationTime.Text;
                    data[1, 4] = EndTime.Text;

                    sw.Write(data[1, 0] + "\t");
                    sw.Write(data[1, 1] + "\t");
                    sw.Write(data[1, 2] + "\t");
                    sw.Write(data[1, 3] + "\t");
                    sw.Write(data[1, 4]);

                    


                    sw.Close();
                    notifyIcon1.Visible = true; // tray icon 표시
                    this.Hide();
                    CarInbtn.Enabled = true;
                    ResrvationBtn.Enabled = false;
                }

                else
                {
                    MessageBox.Show("예약이 불가능한 시간입니다.\n시간을 다시 확인해주세요.");
                }
                

            }
        }

            private void timer1_Tick(object sender, EventArgs e)
            {
                NowTime.Text = DateTime.Now.ToString("MM월dd일HH:mm");

                if (ReservationTime.Text == NowTime.Text && count == 0)
                {
                    timer2.Start();
                }
            }


            private void timer2_Tick(object sender, EventArgs e)
            {
                count++;
            //시연을 위해 1분으로 설정
                if (count == 1)
                {
                    MessageBox.Show("예약 시간이 끝났습니다.\n주차장 자리를 반환합니다.");
                string path = @"C:\ParkingSystem\Reservation.csv";
                bool result = File.Exists(path);
                if (result == true)
                {
                    File.Delete(path);
                }
                else
                {
                    MessageBox.Show("존재 하지 않는 파일입니다.");
                }
                timer1.Stop();
                timer2.Stop();
                Application.ExitThread();
                }
            }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            this.ShowInTaskbar = true; // 작업 표시줄 표시
            this.Show();
        }

        private void CarInbtn_Click(object sender, EventArgs e)
        {
           
            Application.ExitThread();
        
        }

        private void reservation_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true; // tray icon 표시
                this.ShowInTaskbar = false;
                this.Hide();
            }
        }

    }
} 
