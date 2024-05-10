using System;
namespace Mediator
{
    public interface IChatMediator
    {
        void SendMessage(string message, User user);
        void SendPrivateMessage(string message, User user);
        void AddUser(User user);
        void RemoveUser(User user);
    }
}

