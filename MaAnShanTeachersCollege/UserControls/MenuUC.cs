using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationSystem.UserControls
{
    public partial class MenuUC : UserControl
    {
        public event EventHandler LabelClick;
        public MenuUC()
        {
            InitializeComponent();

            //给当前控件添加点击事件
            this.Click += AllControlClick;
            //给当前用户控件添加鼠标移入事件
            this.MouseEnter += MenuUC_MouseEnter;
            //给当前用户控件添加鼠标移出事件
            this.MouseLeave += MenuUC_MouseLeave;

            this.MouseDown += MenuUC_MouseDown;
            this.MouseUp += MenuUC_MouseUp;

            //循环遍历所有基础控件，并添加必须事件
            foreach (Control item in this.Controls)
            {
                //给当前控件添加点击事件
                item.Click += AllControlClick;
                //给当前用户控件添加鼠标移入事件
                item.MouseEnter += MenuUC_MouseEnter;
                //给当前用户控件添加鼠标移出事件
                item.MouseLeave += MenuUC_MouseLeave;

                item.MouseDown += MenuUC_MouseDown;
                item.MouseUp += MenuUC_MouseUp;
            }



        }
        #region MenuUC_Function
        private void MenuUC_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = MenuBaseColor;
        }
        private void MenuUC_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = MenuPressColor;
        }
        private void MenuUC_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = this.MenuHoverColor;
        }
        private void MenuUC_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = MenuBaseColor;
        }
        public void AllControlClick(object sender, EventArgs e)
        {
            LabelClick?.Invoke(sender, e);
        }
        private void MenuUC_Click(object sender, EventArgs e)
        {
            LabelClick?.Invoke(sender, e);
        }
        #endregion

        //此项控制在设计界面属性中，是否显示
        [Browsable(true)]
        //此项控制在设计界面属性中，显示对应注释说明
        [Description("设置当前菜单的文字")]
        public string MenuText
        {
            set { label1.Text = value; }
            get { return label1.Text; }
        }
        //此项控制在设计界面属性中，是否显示
        [Browsable(true)]
        //此项控制在设计界面属性中，显示对应注释说明
        [Description("设置当前菜单图标")]
        public Image MenuImage
        {
            set { pictureBox1.Image = value; }
            get { return pictureBox1.Image; }
        }


        [Description("控件默认颜色")]
        [DefaultValue(typeof(Color), "35, 40, 45")]
        public Color MenuBaseColor
        {
            get;
            set;
        } = Color.FromArgb(35, 40, 45);
        [Description("鼠标移入控件的颜色")]
        [DefaultValue(typeof(Color), "55,60,70")]
        public Color MenuHoverColor
        {
            get; set;
        } = Color.FromArgb(55, 60, 70);
        [Description("鼠标点击时的颜色")]
        [DefaultValue(typeof(Color), "25, 30, 35")]
        public Color MenuPressColor
        {
            set; get;
        } = Color.FromArgb(25, 30, 35);


    }
}
