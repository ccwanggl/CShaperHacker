namespace IspExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKiller killer = new WarmKiller();
            killer.Kill();

            var wk = killer as WarmKiller;
            wk.Love();

        }
    }

    interface IGentleman
    {
        void Love();
    }

    interface IKiller
    {
        void Kill();
    }


    class WarmKiller : IGentleman, IKiller
    {

        public void Love()
        {
            Console.WriteLine("I will love you for ever ...");
        }

        // killer must hide himself in the daily life.
        void IKiller.Kill()
        {
            Console.WriteLine("Let me kill the enemy...");
        }
    }
}