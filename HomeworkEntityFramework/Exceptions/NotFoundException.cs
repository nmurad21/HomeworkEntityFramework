using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkEntityFramework.Exceptions
{
    class NotFoundException:Exception
    {
        public NotFoundException(string message):base(message)
        {

        }
    }
}
