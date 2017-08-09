using UnityEngine;
using System.Collections;

public class SheetReadingScr : MonoBehaviour {
    //public Sheet01DataObj obj;
    //public float a;
	public SG_Food c;
	// Use this for initialization
	void Start () {
		Debug.Log (c);
		for (int i = 0; i < c.dataArray.Length; i++)
		{
			Debug.Log (c.dataArray [i].Name);
			//Debug.Log (c.dataArray [i].);
//			Debug.Log (c.dataArray [i].Y);
//			Debug.Log (c.dataArray [i].Z);
			Debug.Log ("=================");
		}
        //var a =ScriptableObject.CreateInstance("Sheet01DataObj");
        //ScriptableObject.CreateInstance<Sheet01Data>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
