using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeController : MonoBehaviour
{
    [SerializeField]
    GameObject targetObject;

    Vector3 startPosition;
    Vector3 endPosition;

    Quaternion startRotation;
    Quaternion endRotation;

    float height;
    float width;

    float tx;
    float ty;

    bool press;
    Vector3 touch;

    // Start is called before the first frame update
    void Start()
    {
        width = Screen.width;
        height = Screen.height;
        press = false;
    }

    // Update is called once per frame
    void Update()
    {
        // 画面をtapした
        if (Input.GetMouseButtonDown(0))
        {
            press = true;
            IsCheckCubeObjectTap();
        }



        //if (press == false && Input.GetMouseButtonDown(0))
        //{
        //    press = true;
        //    startPosition = Input.mousePosition;
        //}

        //if (press)
        //{
        //    if (Input.GetMouseButtonUp(0))
        //    {
        //        endPosition = Input.mousePosition;
        //        Vector3 direction = endPosition - startPosition;

        //        // TODO ベクトルの方向を判定して Cubeの回転軸を決めて回転させる必要がある



        //        press = false;
        //    }

            //if (Input.GetMouseButtonUp(0))
            //{
            //}
            //else if (Input.GetMouseButton(0))
            //{
            //    //Debug.Log("//// GetMousButton  ");
            //    tx = (touch.x - startPosition.x) / width;
            //    ty = (touch.y - startPosition.y) / height;

            //    targetObject.transform.rotation = startRotation;

            //    //targetObject.transform.rotation = Quaternion.FromToRotation(startPosition, touch);
            //    //targetObject.transform.rotation = Quaternion.LookRotation((touch - startPosition));

            //    targetObject.transform.Rotate(new Vector3(90 * ty, -90 * tx, 0), Space.World);
            //    endRotation = targetObject.transform.rotation;
            //}
        //}

        // TODO 記述途中 ベクトルの方向を判定するメソッド
        void CheckVectorDirection(Vector3 vec)
        {
            bool upDirection = Mathf.Abs(vec.x) <= Mathf.Abs(vec.y) ? true : false;

;        }

        bool IsCheckCubeObjectTap()
        {
            GameObject clickObject = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if(Physics.Raycast(ray,out hit))
            {
                clickObject = hit.collider.gameObject;
            }
            Debug.Log("当たったゲームオブジェクト");
            Debug.Log(clickObject);

            return true;
        }

    }
}
