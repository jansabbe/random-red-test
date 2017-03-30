using System;
using System.Collections.Generic;

namespace source
{
    
    public class Publisher 
    {
        private IEnumerable<ISubscriber> _subscribers;

        public bool IsOffline {get;set;} = false;

        public Publisher(IEnumerable<ISubscriber> subscribers) {
            _subscribers = subscribers;
        }

        public void Publish(string message) {
            if (IsOffline) return;
            foreach(var s in _subscribers) {
                s.ReceiveMessage(message);
            }
        }

        public void Publish(int message) {
            if (IsOffline) return;
            foreach(var s in _subscribers) {
                s.ReceiveMessage(message);
            }
        }
    }
}
