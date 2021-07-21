using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystemTeam
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ParkingSystem.MainParkingSystem()); //메인
            //Application.Run(new Reservation.reservation()); //예약
            //Application.Run(new ParkingSystem.RegisterPark()); //차량 등록
            //Application.Run(new car_project.MemberPark()); //등록차량 입출차
            //Application.Run(new car_project.NonMemberPark()); //미등록차량 입출차
        }
    }
}
