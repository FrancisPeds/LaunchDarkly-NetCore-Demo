using LaunchDarkly.NetCore.Demo.Interfaces;
using LaunchDarkly.Sdk;
using LaunchDarkly.Sdk.Server;

namespace LaunchDarkly.NetCore.Demo.Services
{
    public class FeatureFlagService : IFeatureFlagService
    {
        private readonly LdClient _ldClient;

        public FeatureFlagService(LdClient ldClient)
        {
            _ldClient = ldClient;
        }

        public bool IsEnabled(string flagKey)
        {
            return _ldClient.BoolVariation(flagKey, new Context(), false);
        }
    }
}
