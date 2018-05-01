using ObserverExample.Observer;

namespace ObserverExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var goalNumber = new GoalNumber(2);
            goalNumber.AddObserver(new TvObserver("CBS"));
            goalNumber.AddObserver(new RadioObserver("Virgin"));

            goalNumber.Goals = 4;
            goalNumber.Goals = 5;
            goalNumber.Goals = 6;
        }
    }
}
