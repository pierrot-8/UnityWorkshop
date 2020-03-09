using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UnityEngine.SceneManagement;

namespace WorkShop.Title
{
    public class TitleSceneView : MonoBehaviour
    {
        [SerializeField]
        Image backGround;

        [SerializeField]
        Button tapButton;

        public void Initialized()
        {
            // シーン遷移のアクション登録
            tapButton.onClick.AsObservable().Subscribe(_ => SceneManager.LoadScene(WorkShop.Common.SceneName.SelectScene)).AddTo(this);
        }
    }
}
