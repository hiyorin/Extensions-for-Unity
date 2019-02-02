using UnityEditor;

public class ExportPackage
{
    [MenuItem("Assets/Export/UnityExtensions")]
    private static void Export()
    {
        AssetDatabase.ExportPackage(
            "Assets/Plugins/UnityExtensions",
            "Extensions-for-Unity.unitypackage",
            ExportPackageOptions.Recurse);
    }

    [MenuItem("Assets/Export/UnityExtensions.UniRx")]
    private static void ExportUniRx()
    {
        AssetDatabase.ExportPackage(
            "Assets/Plugins/UnityExtensions.UniRx",
            "Extensions-for-Unity.UniRx.unitypackage",
            ExportPackageOptions.Recurse);
    }

    [MenuItem("Assets/Export/UnityExtensions.DOTween")]
    private static void ExportDoTween()
    {
        AssetDatabase.ExportPackage(
            "Assets/Plugins/UnityExtensions.DOTween",
            "Extensions-for-Unity.DOTween.unitypackage",
            ExportPackageOptions.Recurse);
    }

    [MenuItem("Assets/Export/All")]
    private static void ExportAll()
    {
        Export();
        ExportUniRx();
        ExportDoTween();
    }
}
