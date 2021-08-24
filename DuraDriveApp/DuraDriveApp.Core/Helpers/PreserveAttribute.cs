using System;
using System.Collections.Generic;
using System.Text;

namespace DuraDriveApp.Core.Helpers
{
    public sealed class PreserveAttribute : System.Attribute
    {
        public bool AllMembers;
        public bool Conditional;
    }
}
