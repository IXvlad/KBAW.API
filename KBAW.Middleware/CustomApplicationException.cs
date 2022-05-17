using System;

namespace KBAW.ErrorHandler
{
    public class CustomApplicationException : CustomApplicationExceptionBase
    {
        public CustomApplicationException(string message, CustomApplicationExceptionDetail detail = null!)
            : base(message)
        {
            Detail = detail;
        }

        public CustomApplicationException(string message, CustomApplicationExceptionDetail detail, Exception innerException = null!)
            : base(message, innerException)
        {
            Detail = detail;
        }

        public CustomApplicationExceptionDetail Detail { get; init; }
    }

    public class CustomApplicationExceptionDetail
    {
        public CustomApplicationExceptionDetail(string message)
        {
            Message = message;
        }

        public string Message { get; }
    }
}