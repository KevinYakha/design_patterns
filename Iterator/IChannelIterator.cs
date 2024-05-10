using System;
namespace Iterator
{
    public interface IChannelIterator
    {
        bool HasNext(); //bool
        Channel Next(); //return the channel
        Channel Shuffle(); // returns a channel from a randomly ordered list
    }
}

