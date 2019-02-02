# ExtensionMethod-for-Unity
C# Extension Method for Unity

# Install
## unitypackage
Extensions-for-Unity.unitypackage
Extensions-for-Unity.UniRx.unitypackage
Extensions-for-Unity.DOTween.unitypackage

## package manager
Specify repository URL git://github.com/hiyorin/upm.Extension-for-Unity.git with key com.hiyorin.extensions into Packages/manifest.json like below.
```javascript
{
  "dependencies": {
    // ...
    "com.hiyorin.extensions": "git://github.com/hiyorin/upm.Extensions-for-Unity.git",
    "com.hiyorin.extensions.unirx": "git://github.com/hiyorin/upm.Extensions-for-Unity.UniRx.git",
    "com.hiyorin.extensions.dotween": "git://github.com/hiyorin/upm.Extensions-for-Unity.DOTween.git",
    // ...
  }
}
```


# Usage
```cs
using UnityExtensions;
```

# Support
* [UniRx](https://github.com/neuecc/UniRx)
* [DOTween](https://github.com/Demigiant/dotween)
