using UnityEngine;
using UnityEditor;
using System.IO;
using UnityQuickSheet;

///
/// !!! Machine generated code !!!
/// 
public partial class GoogleDataAssetUtility
{
    [MenuItem("Assets/Create/Google/WorkerNeeds")]
    public static void CreateWorkerNeedsAssetFile()
    {
        WorkerNeeds asset = CustomAssetUtility.CreateAsset<WorkerNeeds>();
        asset.SheetName = "LegacyBalance";
        asset.WorksheetName = "WorkerNeeds";
        EditorUtility.SetDirty(asset);        
    }
    
}