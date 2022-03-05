using UnityEngine;
using UnityEditor;

public class PackageTool
{
    [MenuItem("Package/Update Package")]
    static void UpdatePackage()
    {
		AssetDatabase.ExportPackage( "Assets/EditorExtensions", "EditorExtensions.unitypackage", ExportPackageOptions.Recurse );
        Debug.Log( "Exported package!" );
    }
}
