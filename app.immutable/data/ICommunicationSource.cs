using System;

namespace app.immutable.data
{
    public interface ICommunicationSource
    {
        public string Email { get; }
        public string MobilePhoneNumber { get; }
    }
}