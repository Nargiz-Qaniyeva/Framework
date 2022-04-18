using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framework.Exceptionss
{
    internal class NotFoundException:Exception
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
