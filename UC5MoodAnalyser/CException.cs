using System;
using System.Collections.Generic;
using System.Text;

namespace UC5MoodAnalyser
{
    class CException:Exception
    {
        public enum ExceptionType
        {
            null_message,
            empty_message,
            no_such_field,
            no_such_method,
            no_such_class,
            object_creation_issue
        }
        private ExceptionType type;
        public CException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
