﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snowflake.Core.Exceptions
{
    [Serializable]
    public class MessageException : Exception
    {
        public MessageException(string message) : base(message) { }

        public MessageException(string message, Exception innerException) : base(message, innerException) { }
    }
}
