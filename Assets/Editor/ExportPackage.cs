using System.IO;
using UnityEngine;
using UnityEditor;

public class ExportPackage
{
    private readonly static string[] Paths = {
        "Assets/Plugins/UnityExtensions",
    };

    private const string ReadMe = "README.md";
    private const string License = "LICENSE";

    [MenuItem("Assets/Export UnityExtensions")]
    private static void Export()
    {
        string readmePath = Path.Combine(Application.dataPath, "Plugins/UnityExtensions", ReadMe);
        string licensePath = Path.Combine(Application.dataPath, "Plugins/UnityExtensions", License);
        File.Copy(Path.Combine(Application.dataPath, "..", ReadMe), readmePath);
        File.Copy(Path.Combine(Application.dataPath, "..", License), licensePath);
        AssetDatabase.Refresh();

        AssetDatabase.ExportPackage(Paths, "ExtensionMethod-for-Unity.unitypackage", ExportPackageOptions.Recurse);
        Debug.Log("Export complete!");

        File.Delete(readmePath);
        File.Delete(licensePath);
        AssetDatabase.Refresh();
    }
}
