using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02设计模式之观察者模式
{
   public class Master
    {
        public Master()
        {
            EventMgr.DGActionHandle += WakeUp;
        }

        //惊醒的方法
        public void WakeUp()
        {
            Console.WriteLine(" 主人-->站住 别跑！！");
        }
    }

   
}
