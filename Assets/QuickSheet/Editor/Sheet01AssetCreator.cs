using UnityEngine;
using UnityEditor;
using System.IO;
using UnityQuickSheet;

///
/// !!! Machine generated code !!!
/// 
public partial class GoogleDataAssetUtility
{
    [MenuItem("Assets/Create/Google/Sheet01")]
    public static void CreateSheet01AssetFile()
    {
        Sheet01 asset = CustomAssetUtility.CreateAsset<Sheet01>();
        asset.SheetName = "QuickUnitySheet22c";
        asset.WorksheetName = "Sheet01";
        EditorUtility.SetDirty(asset);        
    }
    
}