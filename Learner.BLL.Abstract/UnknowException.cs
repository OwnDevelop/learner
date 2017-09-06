using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learner.BLL.Abstract
{
    public class UnknownException :Exception
    {
        public UnknownException()
        {

        }

        public UnknownException(string message) : base(message)
        {

        }

        public UnknownException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
