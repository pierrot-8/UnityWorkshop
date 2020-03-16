using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeController : MonoBehaviour
{
    [SerializeField]
    GameObject targetObject;

    Vector3 startPosition;
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
        if (Input.GetMouseButtonDown(0))
        {
            press = true;
        }

        if (press)
        {
            touch = Input.mousePosition;
            if (Input.GetMouseButtonUp(0))
            {
                startPosition = touch;
                //startRotation = targetObject.transform.rotation;
                startRotation = endRotation;
                press = false;
            }
            else if (Input.GetMouseButton(0))
            {
                //Debug.Log("//// GetMousButton  ");
                tx = (touch.x - startPosition.x) / width;
                ty = (touch.y - startPosition.y) / height;

                targetObject.transform.rotation = startRotation;

                //targetObject.transform.rotation = Quaternion.FromToRotation(startPosition, touch);
                //targetObject.transform.rotation = Quaternion.LookRotation((touch - startPosition));

                targetObject.transform.Rotate(new Vector3(90 * ty, -90 * tx, 0), Space.World);
                endRotation = targetObject.transform.rotation;
            }
        }        
    }
}
