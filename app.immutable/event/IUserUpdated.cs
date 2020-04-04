using System;

using app.immutable.data;

namespace app.immutable.@event
{
    public interface IUserUpdated
    {
        public IAppeal Appeal { get; }
        public ICommunicationSource CommunicationSource { get; }
    }
}
