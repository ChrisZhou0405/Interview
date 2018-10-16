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
    public partial class FrmSingle : Form
    {
        // 1.0首先将构造函数私有化
       private  FrmSingle()
        {
            InitializeComponent();
        }

        //2.0提供一个共有的创建实例的方法 供外界访问调用
       private static  FrmSingle single;
        public static FrmSingle GetInstence()
        {
            if (single==null||single.IsDisposed)
            {
               single = new FrmSingle();
            }
            
            return single;
        }

    }
}
