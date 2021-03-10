using System;
using System.Collections.Generic;
using System.Text;

namespace CustomExceptionHandlingDemo
{
    /*
    class AgeLessThanEighteenException : ApplicationException
    {
        public AgeLessThanEighteenException() : base("license can't be issued to anyone aged less than 18")
        {

        }
        public AgeLessThanEighteenException(string errorMessage) : base(errorMessage)
        {

        }
    }
    */

    class AgeLessThanEighteenException : ApplicationException
    {
        private string errorMessage;

        public AgeLessThanEighteenException()
        {
            errorMessage = "license can't be issued to anyone aged less than 18";
        }
        public AgeLessThanEighteenException(string errorMessage)
        {
            this.errorMessage = errorMessage;
        }
        //public override string Message
        //{
        //    get => errorMessage;
        //}
        public override string Message => errorMessage;
    }
}
