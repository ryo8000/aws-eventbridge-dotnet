using Amazon.Lambda.CloudWatchEvents;
using Amazon.Lambda.Core;
using Newtonsoft.Json;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSEventbridgeDotnet;

public class Function
{
    /// <summary>
    /// Default constructor. This constructor is used by Lambda to construct the instance. When invoked in a Lambda environment
    /// the AWS credentials will come from the IAM role associated with the function and the AWS region will be set to the
    /// region the Lambda function is executed in.
    /// </summary>
    public Function()
    {
    }

    /// <summary>
    /// This method is called for every Lambda invocation.
    /// </summary>
    /// <param name="cloudWatchEvent"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public void FunctionHandler(CloudWatchEvent<object> cloudWatchEvent, ILambdaContext context)
    {
        context.Logger.LogInformation("Information");
        context.Logger.LogWarning("Warning");
        context.Logger.LogError("Error");
        context.Logger.LogInformation(JsonConvert.SerializeObject(cloudWatchEvent));
    }
}
