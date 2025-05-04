using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class thread
    {
        public void threads()
        {
            Thread foreground = new Thread(Doforegroundwork);
            foreground.IsBackground = false;
            foreground.Start();

            Thread background = new Thread(Dobackgroundwork);
            background.IsBackground = true;
            background.Start();

            foreground.Join();
            Console.WriteLine("foreground completed");

        }

        public void Doforegroundwork()
        {
            Console.WriteLine("foreground---");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"f.g{i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("f.g completed");
        }

        public void Dobackgroundwork()
        {
            Console.WriteLine("background---");
            for (int i = 0;i < 20;i++)
            {
                Console.WriteLine($"b.g {i}");
                Thread.Sleep(1500);
            }
            Console.WriteLine("b.g completed");
        }
        
        
            public void Task()
            {
                //create a foreground thread 
                Thread foregroundThread = new Thread(DoForegroundWork);
                foregroundThread.IsBackground = false;  
                foregroundThread.Start();

                //create a background thread
                Thread backgroundThread = new Thread(DoBackgroundWork);
                backgroundThread.IsBackground = true; // background thread has a default value false.
                backgroundThread.Start();

                //wait for foreground thread to completed
                foregroundThread.Join();
                Console.WriteLine("FOREGROUND THREAD IS COMPLETED.");
                //Background thread will continue running in the background,and 
                //the application will exit even if it's not completed
            }
            public void DoForegroundWork()
            {
                Console.WriteLine("Foreground thread Is starting...");
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine($"Foreground Thread iteration{i}");
                    Thread.Sleep(1000); //1000millisecond = 1second delay now 
                }
                Console.WriteLine("Foreground thread is completed.");
            }

            public  void DoBackgroundWork()
            {
                Console.WriteLine("Background thread is Running...");
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"Background Thread iteration{i}");
                    Thread.Sleep(1500); //1500 millisecond = 1.5 second delay on background
                }
                Console.WriteLine("Background Thread Is Completed.");
            }

        
        
    }
    public class programe
    {
        public class mainmethod()
        {
            thread first = new thread(new ThreadStart(thread1));
            thread secound = new thread(new ThreadStart)(thread2));

            thread1.strat();
            thread2.start();

        public void thread1()
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }

            }
            public void thread2()
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);

                }
            }

        }































































































































































































































































































































































































































































































































































































































































































































































































































































































    }
}

