using System;

namespace DesignPatterns.Observer
{
    public class TVStation : ITVStation
    {
        public string Name { get; set; }

        public TVStation(string name)
        {
            Name = name;
        }

        public event EventHandler<NotifyEventArgs> Notify = delegate { };

        public void Update(Sport sport, ActionType type)
        {
            string message = "";
            switch (type)
            {
                case ActionType.Start:
                    message = "Start match " + sport.GetOpponents();
                    break;
                case ActionType.Stop:
                    message = "Stop match " + sport.GetOpponents() + ". Final score: " + sport.GetScore();
                    break;
                case ActionType.Score:
                    message = "New score for match " + sport.GetOpponents() + ". Score: " + sport.GetScore();
                    break;
            }

            Notify(this, new NotifyEventArgs { Observer = this, Subject = sport, Message = message });
        }
    }


    public class NotifyEventArgs : EventArgs
    {
        public ITVStation Observer { get; set; }
        public Sport Subject { get; set; }
        public string Message { get; set; }
    }
}