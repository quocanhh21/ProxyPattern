using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class Proxy : Subject
    {
        Subject subject;
        public Proxy()
        {
            subject = null;
        }
        public Proxy(Subject subject)
        {
            this.subject = subject;
        }
        public override void DoSomeWork()
        {
            Console.WriteLine("Hello SD.");
            if (subject==null)
            {
                subject = new ConcreteSubject();
            }
            subject.DoSomeWork();
        }
    }
}
