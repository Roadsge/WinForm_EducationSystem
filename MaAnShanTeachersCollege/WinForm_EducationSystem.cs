using EducationSystem.Models;
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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EducationSystem
{
    public delegate void MyDelegate(string messgee);
    public partial class WinForm_EducationSystem : Form
    {
        public static int UserID = 0;
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
        /// <summary>
        /// 根据字符串获取相应的图片资源
        /// </summary>
        /// <param name="name">图片名称</param>
        /// <returns></returns>
        public Bitmap GetBitmapFromResx(string name)
        {
            Type type = typeof(Resources);
            //用反射获取
            PropertyInfo info = type.GetProperty(name, BindingFlags.Static | BindingFlags.NonPublic);
            if(info!=null&&info.PropertyType==typeof(Bitmap))
            {
                return (Bitmap)info.GetValue(null);
            }
            return null;
        }
        private void MenuJump_Click(object sender,EventArgs e)
        {
            panelContent.Controls.Clear();

        }
        /// <summary>
        /// Loads a user control by name and displays it in the content panel.
        /// </summary>
        /// <remarks>Displays a message box if the control type is not found or cannot be
        /// instantiated.</remarks>
        /// <param name="pageName">The name of the user control to load.</param>
        public UserControl LoadPage(string pageName)
        {
            var assemly = Assembly.GetExecutingAssembly();
            string fullTypeName = $"{this.GetType().Namespace}.Pages.{pageName}";
            Type type = assemly.GetType(fullTypeName);
            if(type==null)
            {
                MessageBox.Show($"未找到相应控件{fullTypeName}" );
                return null;
            }
            var page = Activator.CreateInstance(type) as UserControl;
            if(page==null)
            {
                MessageBox.Show("无法创建页面实例");
                return null;
            }
            
            page.Dock = DockStyle.Fill;
            return page;

        }

        private void EducationSystem_Load(object sender, EventArgs e)
        {
            ////加载菜单
            string path = @"C:\Users\sky\Desktop\MyFile.txt";
            string file = File.ReadAllText(path);
            List<MenuModel> listModels = JsonConvert.DeserializeObject<List<MenuModel>>(file);

            foreach(MenuModel menu in listModels)
            {

                MenuUC menuUC1 = new MenuUC();
                menuUC1.MenuText = menu.MenuText;
                menuUC1.MenuImage = GetBitmapFromResx(menu.MenuImage);
                menuUC1.LabelClick += (newSender, newE) =>
                {
                    panelContent.Controls.Clear();
                    
                    panelContent.Controls.Add(LoadPage(menu.MenuPage));
                };
                flPanelMenu.Controls.Add(menuUC1);
            }

            

        }
    }
}
