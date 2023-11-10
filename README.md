# CSPFeatureSpooferPlugin
An [AssettoServer](https://github.com/compujuckel/AssettoServer) plugin that will add fake features to your server "CSP Features" list.

![](https://i.imgur.com/2yKhzD3.png)

### Configuration
Enable the plugin in your `extra_cfg.yml`
```YAML
EnablePlugins:
- CSPFeatureSpooferPlugin
```

Add the plugin configuration to the bottom of your `extra_cfg.yml`
```YAML
---
!CSPFeatureSpooferConfiguration
#The plugin will only read the first 4 entries
FakeCSPFeatures:
  - "Extra fake feature 1"
  - "Another extra fake feature 2"
  - "Fake feature 3"
  - "Fake feature 4"
```
