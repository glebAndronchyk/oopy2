namespace lb1.OwnTimer;

public class OwnTimer
{
    public static void Execute(Action callback, int intervalS)
    {
        Thread timerThread = new Thread(() =>
        {
            while (true)
            {
                Thread.Sleep(intervalS * 1000);
                callback();
            }
        });
        
        timerThread.Start();
    }
}