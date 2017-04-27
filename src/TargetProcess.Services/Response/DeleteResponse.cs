namespace TargetProcess.Response
{
    /// <summary>
    ///     Class DeleteResponse.
    /// </summary>
    public class DeleteResponse
    {
        /// <summary>
        ///     Gets or sets the type of the resource.
        /// </summary>
        /// <value>The type of the resource.</value>
        public string ResourceType { get; set; }

        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int? Id { get; set; }
    }
}