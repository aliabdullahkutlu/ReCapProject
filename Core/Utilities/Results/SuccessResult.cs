using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result //sen bir inheritancesin 
    {
        public SuccessResult(string message) : base(true, message)
        {

        }

        public SuccessResult() : base(true)
        {

        }

    }
}
