using System;

namespace TargetProcess.Services.Exceptions
{
    /// <summary>
    /// Class TargetProcessServiceCreateEntityException.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class TargetProcessServiceCreateEntityException : Exception
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="TargetProcessServiceCreateEntityException"/> class from being created.
        /// </summary>
        private TargetProcessServiceCreateEntityException() {}

        /// <summary>
        /// Initializes a new instance of the <see cref="TargetProcessServiceCreateEntityException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public TargetProcessServiceCreateEntityException(string message)
            : base(message) {}
    }
}