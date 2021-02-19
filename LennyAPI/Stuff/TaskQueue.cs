using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace LennyAPI.Stuff
{
    public class TaskQueue
    {

        public List<LennyAction> LennysActions = new List<LennyAction>();

        private List<LennyAction> CompletedActions = new List<LennyAction>();

        private string QueueName { get; set; }

        public bool HasPronouncedAuthor = false;
        private string Author { get; set; }

        public TaskQueue(string name, string author, params LennyAction[] lennysActions)
        {
            this.Author = author;
            this.QueueName = name;
            foreach (LennyAction l in lennysActions)
            {
                if (l != null)
                {
                    this.LennysActions.Add(l);
                }
            }
        }

        public string GetName()
        {
            return this.QueueName;
        }

        /// <summary>
        /// Add a new action to the queue.
        /// </summary>
        /// <param name="action"></param>
        public void Add(LennyAction action)
        {
            LennysActions.Add(action);
        }

        /// <summary>
        /// Remove an action from the queue if it's there.
        /// </summary>
        /// <param name="action">The action to remove.</param>
        public void Remove(LennyAction action)
        {
            if (LennysActions.Where(x => x == action).Count() > 0)
            {
                LennysActions.Remove(action);
            }
        }

        /// <summary>
        /// Perform the actions in the queue.
        /// </summary>
        public void PerformActions()
        {
            Console.WriteLine("[LennyAPI] Performing Lenny's Task Queue called: " + this.QueueName + (!HasPronouncedAuthor ? $" as Described by {this.Author}" : null));
            foreach (LennyAction action in this.LennysActions)
            {
                if (CompletedActions.Contains(action))
                {
                    continue;
                }
                action.Perform();
                CompletedActions.Add(action);
            }
        }

        public void ResetActions()
        {
            CompletedActions.Clear();
        }

        public void Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }

    }
}
