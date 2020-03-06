﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UnityEngine.SceneManagement;

public class TitleSceneView : MonoBehaviour
{
    [SerializeField]
    Image backGround;

    [SerializeField]
    Button tapButton;

    public void Initialized()
    {
        // test差分
        // シーン遷移のとりあえず実装 
        tapButton.onClick.AsObservable().Subscribe(a => SceneManager.LoadScene("SelectScene")).AddTo(this);
    }
}
