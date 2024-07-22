namespace Observer
{
    public enum EventCode
    {
        Event1,
        Event2,
    }

    
    public interface IEvent
    {
        void OnEvent(EventCode eventCode);
    }
}