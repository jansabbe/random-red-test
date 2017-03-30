using System.Collections.Generic;
using NSubstitute;
using source;
using Xunit;

namespace test5
{
    public class PublisherShouldSendStringMessageWhenOnline
    {
        
        [Fact]
        public void Test()
        {
            var mockSubscriber = Substitute.For<ISubscriber>();
            var publisher = new Publisher(new List<ISubscriber>() {mockSubscriber});

            publisher.Publish("sjokobanaan");
            
            mockSubscriber.Received().ReceiveMessage("sjokobanaan");
        }
    }
    public class PublisherShouldSendStringMessageWhenOffline
    {
        [Fact]
        public void Test()
        {
            var mockSubscriber = Substitute.For<ISubscriber>();
            var publisher = new Publisher(new List<ISubscriber>() {mockSubscriber});
            publisher.IsOffline = true;

            publisher.Publish("sjokobanaan");
            
            mockSubscriber.DidNotReceive().ReceiveMessage(Arg.Any<string>());
        }
    }

    public class PublisherShouldSendIntMessageWhenOnline
    {
        
        [Fact]
        public void Test()
        {
            var mockSubscriber = Substitute.For<ISubscriber>();
            var publisher = new Publisher(new List<ISubscriber>() {mockSubscriber});

            publisher.Publish(4);
            
            mockSubscriber.Received().ReceiveMessage(4);
        }
    }
    public class PublisherShouldSendIntMessageWhenOffline
    {
    
        [Fact]
        public void Test()
        {
            var mockSubscriber = Substitute.For<ISubscriber>();
            var publisher = new Publisher(new List<ISubscriber>() {mockSubscriber});
            publisher.IsOffline = true;

            publisher.Publish(3);
            
            mockSubscriber.DidNotReceive().ReceiveMessage(Arg.Any<int>());
        }
    }
}
