namespace CustomException
{
    internal class CarIsDeadException : ApplicationException
    {
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }
        public CarIsDeadException() { }
        public CarIsDeadException(string message, string cause, DateTime time)
            : base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
        public CarIsDeadException(string message, string cause, DateTime time, Exception inner)
            : base(message, inner)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
        protected CarIsDeadException(
                     System.Runtime.Serialization.SerializationInfo info,
                              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

}

