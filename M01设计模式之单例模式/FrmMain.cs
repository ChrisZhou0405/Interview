using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M01设计模式之单例模式
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //调用FrmSingle的GetInstence方法 得窗口实例
            FrmSingle frmSingle = FrmSingle.GetInstence();
            frmSingle.Show();
        }
    }
}
