using LaunchDarkly.Sdk.Server;
using LaunchDarkly.Sdk;
using LaunchDarkly.NetCore.Demo.Interfaces;

namespace LaunchDarkly.NetCore.Demo.Services
{
    public class SampleService : ISampleService
    {
        private readonly IFeatureFlagService _featureFlagService;

        public SampleService(IFeatureFlagService featureFlagService)
        {
            _featureFlagService = featureFlagService;
        }

        public async Task<string> GetMessageAsync()
        {
            var message = _featureFlagService.IsEnabled("show-new-message")
            ? "🚀 Welcome to the new feature!"
            : "👋 Hello, world!";

            return await Task.FromResult(message);
        }
    }
}
