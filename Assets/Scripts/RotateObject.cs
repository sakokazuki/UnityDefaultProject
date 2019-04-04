using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SKZ.Utils {
	
	public class RotateObject : MonoBehaviour {
        #region Public variables

        #endregion

        #region Private variables
        [SerializeField]
        float speed;

        [SerializeField]
        Vector3 direction;

		#endregion

		#region Public functions
        
		#endregion

		#region Private functions

		#endregion

		#region MonoBehaviour functions

		// Use this for initialization
		void Start () {
		}
	
		// Update is called once per frame
		void Update () {
            this.transform.Rotate(direction, speed);
		}
		#endregion
	}
		
}


