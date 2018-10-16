using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02设计模式之观察者模式
{
    //定义一个委托
    public delegate void DGAction();

    //事件管理类
   public class EventMgr
    {
        //定义一个DGAction委托类型的事件
        public static event DGAction DGActionHandle;
        public static void Run()
        {
            if (DGActionHandle!=null)
            {
                DGActionHandle(); //若不事件不为空 则执行事件
            }
        } 
    }
}
