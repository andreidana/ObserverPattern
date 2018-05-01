using System;

namespace ObserverExample.Observer
{
    public class ScoreObserver: IObserver
    {
        private readonly string _name;

        public ScoreObserver(string name)
        {
            _name = name;
        }

        public void Update(int goals)
        {
            Console.WriteLine($"Notified {_name} of {goals} scored");
        }
    }
}