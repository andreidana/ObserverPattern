using System.Collections.Generic;

namespace ObserverExample.Observer
{
    public class GoalNumber
    {
        private int _goals;

        public int Goals {
            get => _goals;
            set
            {
                if (_goals == value) return;
                _goals = value;
                Notify();
            }
        }
        private readonly List<IObserver> _scoreObservers = new List<IObserver>();

        public GoalNumber(int goals)
        {
            this.Goals = goals;
        }

        public void AddObserver(IObserver observer)
        {
            _scoreObservers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _scoreObservers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var scoreObserver in _scoreObservers)
            {
                scoreObserver.Update(Goals);
            }
        }
    }
}