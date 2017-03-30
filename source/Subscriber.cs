namespace source
{
    public interface ISubscriber 
    {
        void ReceiveMessage(int message);
        void ReceiveMessage(string message);
    }
    public class Subscriber : ISubscriber
    {
        public void ReceiveMessage(int message)
        {
        }

        public void ReceiveMessage(string message)
        {
        }
    }
}
