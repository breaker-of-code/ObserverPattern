using System.Collections.Generic;

namespace Observer
{
    public class Publisher
    {
        private static Publisher _instance;
        private List<IEvent> observers = new List<IEvent>();

        public static Publisher Instance => _instance ?? (_instance = new Publisher());
        
        public void Subscribe(IEvent observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }

        public void Unsubscribe(IEvent observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }

        public void Notify(EventCode eventCode)
        {
            foreach (var observer in observers)
            {
                observer.OnEvent(eventCode);
            }
        }
    }
}