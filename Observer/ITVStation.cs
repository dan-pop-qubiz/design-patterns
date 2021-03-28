using System;

namespace DesignPatterns.Observer
{
   public interface ITVStation
   {
        public string Name { get; set; }

        public event EventHandler<NotifyEventArgs> Notify;

        void Update(Sport sport, ActionType type);
   }
}
