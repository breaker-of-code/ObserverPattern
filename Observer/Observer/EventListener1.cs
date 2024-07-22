using System;

namespace Observer
{
    public class EventListener1 : IEvent
    {
        //[Inject]
        private Publisher publisher;

        private void Start()
        {
            publisher.Subscribe(this);
        }

        private void OnDestroy()
        {
            publisher.Unsubscribe(this);
        }

        public void OnEvent(EventCode eventCode)
        {
            if (eventCode == EventCode.Event1)
            {
                Console.WriteLine($"event {eventCode} received");
            }
        }
    }
}