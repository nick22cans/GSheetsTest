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
[CustomEditor(typeof(Sheet01))]
public class Sheet01Editor : BaseGoogleEditor<Sheet01>
{	    
    public override bool Load()
    {        
        Sheet01 targetData = target as Sheet01;
        
        var client = new DatabaseClient("", "");
        string error = string.Empty;
        var db = client.GetDatabase(targetData.SheetName, ref error);	
        var table = db.GetTable<Sheet01Data>(targetData.WorksheetName) ?? db.CreateTable<Sheet01Data>(targetData.WorksheetName);
        
        List<Sheet01Data> myDataList = new List<Sheet01Data>();
        
        var all = table.FindAll();
        foreach(var elem in all)
        {
            Sheet01Data data = new Sheet01Data();
            
            data = Cloner.DeepCopy<Sheet01Data>(elem.Element);
            myDataList.Add(data);
        }
                
        targetData.dataArray = myDataList.ToArray();
        
        EditorUtility.SetDirty(targetData);
        AssetDatabase.SaveAssets();
        
        return true;
    }
}
