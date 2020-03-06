using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSceneController : MonoBehaviour
{
    [SerializeField]
    TitleSceneView titelView;

    void Start()
    {
        titelView.Initialized();
    }
}
