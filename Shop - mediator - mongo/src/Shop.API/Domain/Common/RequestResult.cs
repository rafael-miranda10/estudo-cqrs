using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;

namespace Shop.API.Domain.Common
{
    public class RequestResult
    {
        public RequestResult(){}

        public List<string> Notifications { get; set; } = new List<string>();

        public bool HasNotifications()
        {
            return Notifications.Any();
        }

        public bool IsValid()
        {
            return !HasNotifications();
        }

        public static RequestResult OK()
        {
            return new RequestResult();
        }

        public void AddNotification(string message)
        {
            Notifications.Add(message);
        }
    }
}
