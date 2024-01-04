using System;
using System.Timers;

namespace EventExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NOTE: 事件拥有者
            Timer timer = new Timer();
            timer.Interval = 1000;

            // NOTE 事件响应者
            Boy boy = new Boy();
            Girl girl = new Girl();

            // NOTE: Elapsed 事件
            // NOTE: += 事件订阅 subscribe
            timer.Elapsed += boy.Action;
            timer.Elapsed += girl.Action;
            timer.Start();
            Console.ReadLine();
        }
    }

    class Boy
    {
        // NOTE: 事件处理器 event handler
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Jump!"); 
        }
    }
    
    class Girl
    {
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Sing!"); ;
        }
    }
}
