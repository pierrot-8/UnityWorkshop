using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UnityEngine.SceneManagement;

namespace WorkShop.SelectScene
{
    public class SelectSceneView : MonoBehaviour
    {
        [SerializeField]
        Button cubeButton;


        public void Initialize()
        {
            // シーン遷移のアクション登録
            cubeButton.onClick.AsObservable().Subscribe(_ => SceneManager.LoadScene(WorkShop.Common.SceneName.CubeScene)).AddTo(this);
            
        }


    }
}
