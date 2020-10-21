using FluentValidation.Results;

namespace Shop.API.Domain.Common
{
    public abstract class Handler
    {
        public Handler()
        {
            RequestResult = new RequestResult();
        }

        public RequestResult RequestResult { get; set; }

        public void AddNotifications(ValidationResult validationResult)
        {
            foreach (var erro in validationResult.Errors)
                RequestResult.AddNotification(erro.ErrorMessage);
        }

        public void AddNotification(string message)
        {
                RequestResult.AddNotification(message);
        }
    }
}
