using System;
using System.IO;

namespace myos
{
    public abstract class LogBase
    {
        public abstract void Log(string Messsage);
    }

    public class Logger : LogBase
    {

        private String CurrentDirectory
        {
            get;
            set;
        }

        private String FileName
        {
            get;
            set;
        }

        private String FilePath
        {
            get;
            set;
        }

        public Logger()
        {
            this.CurrentDirectory = Directory.GetCurrentDirectory();
            this.FileName = "Log.txt";
            this.FilePath = this.CurrentDirectory + "/" + this.FileName;

        }

        public override void Log(string Messsage)
        {

           //Console.WriteLine("Logged : {0}", Messsage);

            using (StreamWriter w = File.AppendText(this.FilePath))
            {
                w.Write("\r\nLog Entry : ");
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                w.WriteLine("  :{0}", Messsage);
                w.WriteLine("-----------------------------------------------");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var logger = new Logger();

            string str;
            Console.WriteLine("Enter Message to log");
            str=Console.ReadLine();
            logger.Log(str);
            Console.WriteLine("Logged : {0}",str);

        }
    }
}