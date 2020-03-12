using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WorkShop.Cube
{
    public class CubeSceneView : MonoBehaviour
    {
        CubeSceneViewModel viewModel;

        public void Initialized(CubeSceneViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
    }
}
