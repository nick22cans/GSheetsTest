using UnityEngine;
using UnityEditor;
using System.IO;
using UnityQuickSheet;

///
/// !!! Machine generated code !!!
/// 
public partial class GoogleDataAssetUtility
{
    [MenuItem("Assets/Create/Google/Combined")]
    public static void CreateCombinedAssetFile()
    {
        Combined asset = CustomAssetUtility.CreateAsset<Combined>();
        asset.SheetName = "LegacyBalance";
        asset.WorksheetName = "Combined";
        EditorUtility.SetDirty(asset);        
    }
    
}