using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SceneGlobalVariables
{
    public class GlobalVariables : MonoBehaviour
    {
        public ActiveManager activeManager;
        public Touch touch;

        private static GlobalVariables instance;
        public static GlobalVariables Instance
        {
            get { return instance; }
        }

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;   
            }
            else if (instance != this)
            {
                Destroy(gameObject);
            }

        }
    }
}
