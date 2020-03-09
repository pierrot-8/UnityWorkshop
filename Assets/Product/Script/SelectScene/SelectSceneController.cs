using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WorkShop.SelectScene
{
    public class SelectSceneController : MonoBehaviour
    {
        [SerializeField]
        SelectSceneView selectSceneView;

        void Start()
        {
            selectSceneView.Initialize();
        }
    }
}
