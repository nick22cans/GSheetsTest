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
[CustomEditor(typeof(Combined))]
public class CombinedEditor : BaseGoogleEditor<Combined>
{	    
    public override bool Load()
    {        
        Combined targetData = target as Combined;
        
        var client = new DatabaseClient("", "");
        string error = string.Empty;
        var db = client.GetDatabase(targetData.SheetName, ref error);	
        var table = db.GetTable<CombinedData>(targetData.WorksheetName) ?? db.CreateTable<CombinedData>(targetData.WorksheetName);
        
        List<CombinedData> myDataList = new List<CombinedData>();
        
        var all = table.FindAll();
        foreach(var elem in all)
        {
            CombinedData data = new CombinedData();
            
            data = Cloner.DeepCopy<CombinedData>(elem.Element);
            myDataList.Add(data);
        }
                
        targetData.dataArray = myDataList.ToArray();
        
        EditorUtility.SetDirty(targetData);
        AssetDatabase.SaveAssets();
        
        return true;
    }
}
