using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkEntityFramework.Exceptions
{
    class NullReferenceException:Exception
    {
        public NullReferenceException(string message) : base(message)
        {

        }
    }
}
