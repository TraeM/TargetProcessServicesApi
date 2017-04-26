namespace TargetProcess.Base
{
    public interface IRestServiceUrl
    {
        string EntityUrl { get; }
        string ApiBaseUrl { get; }
        int ApiVersion { get; }
    }
}