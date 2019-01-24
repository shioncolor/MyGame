using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Glovalobjcts
{
    public class Glovalobj : MonoBehaviour
    {
        public SceneChang sceneChang;
        public Score score;
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
