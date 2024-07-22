namespace Observer
{
    public class EventSender
    {
        private void Start()
        {
            PublishEvent1();
            PublishEvent2();
        }
        
        private void PublishEvent1()
        {
            Publisher.Instance.Notify(EventCode.Event1);
        }
        
        private void PublishEvent2()
        {
            Publisher.Instance.Notify(EventCode.Event2);
        }
    }
}