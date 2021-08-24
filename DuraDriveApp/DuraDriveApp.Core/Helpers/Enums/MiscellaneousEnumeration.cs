using System;
using System.Collections.Generic;
using System.Text;

namespace DuraDriveApp.Core.Helpers.Enums
{
    public enum MiscellaneousEnumeration
    {
    }
    public enum AppState
    {
        Undefinded,
        Foreground,
        Background
    }
    public enum ResultType
    {
        Ok,
        Invalid,
        Unauthorized,
        InternalError,
        PartialOk,
        NotFound,
        Unexpected
    }
    public enum TransitionType
    {
        SlideFromBottom = 0,
        None = 1,
        Default = 2,
    }
    public enum SendInvite
    {
        LOGIN_WAY = 0,
        HOME_WAY = 1,
        NONE = 2
    }
    public enum PaymentWay
    {
        BILLING_WAY = 0,
        HOME_MEMBERSHIP_WAY = 1,
        NONE = 2
    }
}
