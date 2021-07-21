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
    public partial class MemberPark : Form
    {
        public MemberPark()
        {
            InitializeComponent();
            nonmemberlist.FullRowSelect = true;
        }     
    }
}