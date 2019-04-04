using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SKZ.Utils {
	
	public class ActiveTrigger : MonoBehaviour {
		#region Public variables

		public void Active()
		{
			gameObject.SetActive(true);
		}

		public void Deactive()
		{
			gameObject.SetActive(false);
		}
		#endregion
	
	}
		
}


