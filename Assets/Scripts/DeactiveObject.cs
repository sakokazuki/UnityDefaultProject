using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SKZ.Utils
{
	public class DeactiveObject : MonoBehaviour
	{
		#region Monobehaviour
		// Use this for initialization
		void Awake()
		{
			gameObject.SetActive(false);
		}


		#endregion
	}

}
