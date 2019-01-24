using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Glovalobjct
{
    public class Glovalobj : MonoBehaviour
    {
        public SceneChang sceneChang;

        private static Glovalobj instance;
        public static Glovalobj Instance
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
