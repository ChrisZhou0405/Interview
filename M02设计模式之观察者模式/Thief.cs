using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02设计模式之观察者模式
{
   public  class Thief
    {
        public Thief()
        {
            EventMgr.DGActionHandle += Escape;
        }

        public void Escape()
        {
            Console.WriteLine("小偷-->糟糕！赶紧跑！！");
        }
    }
}
