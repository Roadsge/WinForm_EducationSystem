using EducationSystem.Pages;
using EducationSystem.Properties;
using EducationSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationSystem
{
    public delegate void MyDelegate(string messgee);
    public partial class WinForm_EducationSystem : Form
    {
        public WinForm_EducationSystem()
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

        private void EducationSystem_Load(object sender, EventArgs e)
        {
            ////加载菜单
            //string path = @"C:用户\sky\桌面\MyFile.txt";
            //string file = File.ReadAllText(path);
            //string[] id = file.Split(',');
            //MenuUC menuUC1 = new MenuUC();
            //menuUC1.MenuText = "首页";
            //menuUC1.MenuImage = Resources.home;
            //flPanelMenu.Controls.Add(menuUC1);

        }
    }
}
