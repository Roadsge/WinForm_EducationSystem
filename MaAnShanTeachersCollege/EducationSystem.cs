using MaAnShanTeachersCollege.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaAnShanTeachersCollege
{
    public delegate void MyDelegate(string messgee);
    public partial class EducationSystem : Form
    {
        public EducationSystem()
        {
            InitializeComponent();
       

        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }



        private void menuUC1_LabelClick(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            HomePage homePage = new HomePage();
            panelContent.Controls.Add(homePage);
        }

        private void menuUC2_LabelClick(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            SettingPage settingPage = new SettingPage();
            panelContent.Controls.Add(settingPage);
        }
    }
}
