using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WorkShop.Title
{
    public class TitleSceneController : MonoBehaviour
    {
        [SerializeField]
        TitleSceneView titelView;

        void Start()
        {
            titelView.Initialized();
        }
    }
}
