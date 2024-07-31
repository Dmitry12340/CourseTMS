
namespace Homework12
{
    [Serializable]
    internal class WrongLoginException : Exception
    {
        public WrongLoginException()
        {
        }

        public WrongLoginException(string? message) : base(message)
        {
        }

        public WrongLoginException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}