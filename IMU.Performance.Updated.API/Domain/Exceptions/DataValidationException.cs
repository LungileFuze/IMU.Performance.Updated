namespace IMU.Performance.Updated.API.Domain.Exceptions
{
    public class DataValidationException : Exception
    {
        public DataValidationException(string message): base(message) { }
    }
}
