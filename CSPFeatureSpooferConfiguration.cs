using AssettoServer.Server.Configuration;
namespace CSPFeatureSpooferPlugin;

public class CSPFeatureSpooferConfiguration : IValidateConfiguration<CSPFeatureSpooferConfigurationValidator>
{
    public List<string> FakeCSPFeatures { get; init; } = new();
}
