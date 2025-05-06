using LaunchDarkly.Sdk.Server;

namespace LaunchDarkly.NetCore.Demo.LaunchDarkly
{
    public class LaunchDarklyClientProvider
    {
        public static LdClient CreateClient(IConfiguration config)
        {
            var sdkKey = config["LaunchDarkly:SdkKey"];
            return new LdClient(sdkKey);
        }
    }
}
