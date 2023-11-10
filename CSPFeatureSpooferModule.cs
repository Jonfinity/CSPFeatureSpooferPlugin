using AssettoServer.Server.Plugin;
using Autofac;

namespace CSPFeatureSpooferPlugin;

public class CSPFeatureSpooferModule : AssettoServerModule<CSPFeatureSpooferConfiguration>
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<CSPFeatureSpoofer>().AsSelf().AutoActivate().SingleInstance();
    }
}
