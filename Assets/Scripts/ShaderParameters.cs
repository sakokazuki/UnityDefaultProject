using UnityEngine;

namespace SKZ.Utils
{
    //!!!! WIP
    public class ShaderParameters : MonoBehaviour
    {

        #region private field
        Material mat;

        #endregion

        #region MonoBehaviour Functions

        // Use this for initialization
        void Start()
        {
            mat = GetComponent<Renderer>().sharedMaterial;
        }

        // Update is called once per frame
        void Update()
        {
            if (mat == null) return;
        }
        #endregion
    }

}
