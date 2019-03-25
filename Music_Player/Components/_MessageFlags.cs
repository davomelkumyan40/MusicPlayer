using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.Components
{
    public enum MessageFlags
    {
        Warning = 0,
        Error = 1,
        WrongAuth = 2,
        Success = 3,
        UserMessage = 4
    }
}
