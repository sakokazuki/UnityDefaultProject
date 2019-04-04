using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SKZ.Utils {
	
	public class MemoryRelease : MonoBehaviour {
		private void OnGUI()
		{
			if (GUI.Button(new Rect(10, 10, 150, 100), "MemoryRelease"))
			{
				System.GC.Collect();
				Resources.UnloadUnusedAssets();
			}
		}
	}
		
}


