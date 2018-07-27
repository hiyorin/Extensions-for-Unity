using UnityEngine;
using UnityEditor;

public class ExportPackage
{
    private readonly static string[] Paths = {
        "Assets/Plugins/UnityExtensions",
    };

    [MenuItem("Assets/Export UnityExtensions")]
    private static void Export()
    {
        AssetDatabase.ExportPackage(Paths, "ExtensionMethod-for-Unity.unitypackage", ExportPackageOptions.Recurse);
        Debug.Log("Export complete!");
    }
}
