using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaAnShanTeachersCollege.UserControls
{
    public partial class MenuUC : UserControl
    {
        public event EventHandler LabelClick;
        public MenuUC()
        {
            InitializeComponent();
            this.Click += AllControlClick;
            foreach(Control item in this.Controls)
            {
                item.Click += AllControlClick;
            }
        }
        public void AllControlClick(object sender,EventArgs e)
        {
            LabelClick?.Invoke(sender, e);
        }
        //此项控制在设计界面属性中，是否显示
        [Browsable(true)]
        //此项控制在设计界面属性中，显示对应注释说明
        [Description("设置当前菜单的文字")]
        public string MenuText
        {
            set { label1.Text = value; }
            get { return label1.Text; }
        }

        private void MenuUC_Click(object sender, EventArgs e)
        {
            LabelClick?.Invoke(sender, e);
        }
    }
}
