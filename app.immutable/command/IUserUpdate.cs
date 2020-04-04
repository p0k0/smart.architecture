using System;

using app.immutable.data;

namespace app.immutable.command
{
    public interface IUserUpdate
    {
        public IAppeal Appeal { get; }
        public ICommunicationSource CommunicationSource { get; }
    }
}
