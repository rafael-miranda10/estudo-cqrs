using FluentValidation.Results;
using System.Text.Json.Serialization;

namespace Shop.API.Domain.Common
{
    public abstract class Command
    {
        public Command()
        {
        }
        [JsonIgnore]
        public ValidationResult ValidationResult { get; set; }

        public bool IsValid() => ValidationResult.IsValid;
    }
}
