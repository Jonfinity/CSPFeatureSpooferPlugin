using AssettoServer.Server;
using Serilog;

namespace CSPFeatureSpooferPlugin;

public class CSPFeatureSpoofer
{

    private const int MAX_ENTRIES = 4;
    private const int ENTRY_LENGTH_MAX = 40;

    public CSPFeatureSpoofer(CSPFeatureSpooferConfiguration configuration, CSPFeatureManager cspFeatureManager)
    {
        List<string> featureList = configuration.FakeCSPFeatures;
        if (featureList.Count > MAX_ENTRIES)
        {
            featureList = featureList.Take(MAX_ENTRIES).ToList();
        }

        for (int i = 0; i < featureList.Count; i++)
        {
            string s = featureList[i];
            if (s.Length > ENTRY_LENGTH_MAX)
            {
                s = s[..ENTRY_LENGTH_MAX];
            }

            cspFeatureManager.Add(new CSPFeature { Name = s });
        }

        Log.Information($"Loaded CSPFeatureSpooferPlugin with ({featureList.Count}) entries: {string.Join(", ", featureList)}");
    }
}
