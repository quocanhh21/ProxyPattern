using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class ConcreteSubject : Subject
    {
        public override void DoSomeWork()
        {
            Console.WriteLine("Tien hanh yeu cau cua ban");
        }
    }
}
