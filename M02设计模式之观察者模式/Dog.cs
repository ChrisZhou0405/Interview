using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02设计模式之观察者模式
{
  public class Dog
    {
        public void Shout()
        {
            Console.WriteLine(" 狗-->有小偷！！ ");
            EventMgr.Run();
        }
    }
}
