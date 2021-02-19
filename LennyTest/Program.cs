using LennyAPI.Stuff;

namespace LennyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            LennyAction sleep = new LennyAction(ELennyStatus.Status_Sleeping, "nobody because he is alone...");

            LennyAction wakeUp = new LennyAction(ELennyStatus.Status_Custom, "wakes up");

            LennyAction getBuillied = new LennyAction(ELennyStatus.Status_Custom, "gets bullied by Max and Brandon.");

            LennyAction talkToMegan = new LennyAction(ELennyStatus.Status_DMing_Megan, "his love for her.");

            LennyAction procrastinate = new LennyAction(ELennyStatus.Status_Custom, "is procrastinating.");

            LennyAction wankingOverMegan = new LennyAction(ELennyStatus.Status_Custom, "wanking over Megan");

            LennyAction eating = new LennyAction(ELennyStatus.Status_Eating, "viagra tablets for Megan!");

            TaskQueue lennyQueue = new TaskQueue("Lenny's (Sample) Day", "Max", new LennyAction[] { sleep, wakeUp, getBuillied, talkToMegan, procrastinate, wankingOverMegan, eating });

            while (true)
            {
                lennyQueue.PerformActions();

                lennyQueue.ResetActions();

                lennyQueue.Wait(1);
            }

        }
    }
}
