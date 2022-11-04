using System.Collections.Generic;
using MediatR;

namespace ProvaApi.Api.Core.Domain.Shared
{
    public interface IAggregateRoot
    {
        ICollection<INotification> GetDomainEvents();
        void ClearDomainEvents();
    }
}