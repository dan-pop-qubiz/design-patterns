using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public enum ActionType
    {
        None,
        Start,
        Stop,
        Score
    }

    public abstract class Sport
    {
        private string _opponent1;  
        private string _opponent2;
        private string _score;
        private string _name;

        private List<ITVStation> _tvStations = new List<ITVStation>();

        public Sport(string name, string opponent1, string opponent2)
        {
            _name = name;

            _opponent1 = opponent1;
            _opponent2 = opponent2;
        }

        public string GetOpponents()
        {
            return _opponent1 + " vs " + _opponent2;
        }

        public string GetScore()
        {
            return _score;
        }

        public string GetName()
        {
            return _name;
        }

        public void AddTVStation(ITVStation tvStation)
        {
            _tvStations.Add(tvStation);
        }

        public void RemoveTVStation(ITVStation tvStation)
        {
            _tvStations.Remove(tvStation);
        }

        public void Start()
        {
            Notify(ActionType.Start);
        }

        public void Stop()
        {
            Notify(ActionType.Stop);
        }

        public void Score(string score)
        {
            _score = score;
            Notify(ActionType.Score);
        }

        public void Notify(ActionType type)
        {
            foreach (ITVStation station in _tvStations)
            {
                station.Update(this, type);
            }
        }
    }
}