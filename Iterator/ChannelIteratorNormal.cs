using System;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace Iterator
{
    public class ChannelIteratorNormal : IChannelIterator
    {
        private List<Channel> channels;
        private int currentPosition = 0;
        private List<int> shuffleList;

        public ChannelIteratorNormal(List<Channel> channels) //constru
        {
            this.channels = channels;
        }

        public bool HasNext()
        {
            if (currentPosition < channels.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Channel Next()
        {
            return channels[currentPosition++]; 
        }

        public Channel Shuffle()
        {
            if (shuffleList == null)
            {
                shuffleList = new List<int>
                {
                    RandomNumberGenerator.GetInt32(channels.Count)
                };

                for (int i = 1; i < channels.Count; i++)
                {
                    int randomIndex = RandomNumberGenerator.GetInt32(channels.Count);
                    while (shuffleList.Contains(randomIndex))
                    {
                        randomIndex = RandomNumberGenerator.GetInt32(channels.Count);
                    }
                    shuffleList.Add(randomIndex);
                }
            }

            return channels[shuffleList[currentPosition++]];
        }
    }
}

