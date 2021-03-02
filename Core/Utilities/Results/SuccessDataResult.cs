using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, false, message)
        {

        }
        public SuccessDataResult(T data) : base(data, false)
        {

        }
       
        public SuccessDataResult(string message) : base(default, false, message)
        {

        }
        public SuccessDataResult() : base(default, false)
        {

        }
    }
}
