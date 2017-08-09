using UnityEngine;
using UnityEditor;
using System.IO;
using UnityQuickSheet;

///
/// !!! Machine generated code !!!
/// 
public partial class GoogleDataAssetUtility
{
    [MenuItem("Assets/Create/Google/SG_Food")]
    public static void CreateSG_FoodAssetFile()
    {
        SG_Food asset = CustomAssetUtility.CreateAsset<SG_Food>();
        asset.SheetName = "QuickUnitySheet22c";
        asset.WorksheetName = "SG_Food";
        EditorUtility.SetDirty(asset);        
    }
    
}