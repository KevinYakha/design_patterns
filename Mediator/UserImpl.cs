using System;
namespace Mediator
{
    public class UserImpl : User
    {
        public UserImpl(string name, IChatMediator mediator) : base(name, mediator) { }

        public override void ReceiveMessage(string message, User user)
        {
            Console.WriteLine(Name + " has received a message"); 
            Console.WriteLine(user.Name + ": " + message);
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine(Name + ": " + message);
            Mediator.SendMessage(message, this);
        }

        public override void SendPrivateMessage(string message, User user)
        {
            Console.WriteLine(Name + ": " + message);
            Mediator.SendPrivateMessage(message, user);
        }
    }
}

