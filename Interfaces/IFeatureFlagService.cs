namespace LaunchDarkly.NetCore.Demo.Interfaces
{
    public interface IFeatureFlagService
    {
        bool IsEnabled(string flagKey);
    }
}
