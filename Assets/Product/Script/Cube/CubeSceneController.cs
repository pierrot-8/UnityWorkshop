using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WorkShop.Cube
{
    public class CubeSceneController : MonoBehaviour
    {
        [SerializeField]
        CubeSceneView view;

        void Start()
        {
            var viewModel = new CubeSceneViewModel();
            view.Initialized(viewModel);
        }

    }
}
