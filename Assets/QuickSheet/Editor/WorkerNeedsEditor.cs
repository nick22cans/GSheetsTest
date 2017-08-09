using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using GDataDB;
using GDataDB.Linq;

using UnityQuickSheet;

///
/// !!! Machine generated code !!!
///
[CustomEditor(typeof(WorkerNeeds))]
public class WorkerNeedsEditor : BaseGoogleEditor<WorkerNeeds>
{	    
    public override bool Load()
    {        
        WorkerNeeds targetData = target as WorkerNeeds;
        
        var client = new DatabaseClient("", "");
        string error = string.Empty;
        var db = client.GetDatabase(targetData.SheetName, ref error);	
        var table = db.GetTable<WorkerNeedsData>(targetData.WorksheetName) ?? db.CreateTable<WorkerNeedsData>(targetData.WorksheetName);
        
        List<WorkerNeedsData> myDataList = new List<WorkerNeedsData>();
        
        var all = table.FindAll();
        foreach(var elem in all)
        {
            WorkerNeedsData data = new WorkerNeedsData();
            
            data = Cloner.DeepCopy<WorkerNeedsData>(elem.Element);
            myDataList.Add(data);
        }
                
        targetData.dataArray = myDataList.ToArray();
        
        EditorUtility.SetDirty(targetData);
        AssetDatabase.SaveAssets();
        
        return true;
    }
}
