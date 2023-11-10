using FluentValidation;

namespace CSPFeatureSpooferPlugin;

public class CSPFeatureSpooferConfigurationValidator : AbstractValidator<CSPFeatureSpooferConfiguration>
{
    public CSPFeatureSpooferConfigurationValidator()
    {
        RuleFor(cfg => cfg.FakeCSPFeatures).NotNull();
    }
}
