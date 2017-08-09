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
[CustomEditor(typeof(SG_Food))]
public class SG_FoodEditor : BaseGoogleEditor<SG_Food>
{	    
    public override bool Load()
    {        
        SG_Food targetData = target as SG_Food;
        
        var client = new DatabaseClient("", "");
        string error = string.Empty;
        var db = client.GetDatabase(targetData.SheetName, ref error);	
        var table = db.GetTable<SG_FoodData>(targetData.WorksheetName) ?? db.CreateTable<SG_FoodData>(targetData.WorksheetName);
        
        List<SG_FoodData> myDataList = new List<SG_FoodData>();
        
        var all = table.FindAll();
        foreach(var elem in all)
        {
            SG_FoodData data = new SG_FoodData();
            
            data = Cloner.DeepCopy<SG_FoodData>(elem.Element);
            myDataList.Add(data);
        }
                
        targetData.dataArray = myDataList.ToArray();
        
        EditorUtility.SetDirty(targetData);
        AssetDatabase.SaveAssets();
        
        return true;
    }
}
