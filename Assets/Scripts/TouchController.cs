using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{

    [SerializeField]
    GameObject touchSphereObj;
    [SerializeField]
    Material touchSphere_blue;
    [SerializeField]
    Material touchSphere_yellow;
    [SerializeField]
    Material touchSphere_red;

    TouchSphere touchSphere;

    // Use this for initialization
    void Start()
    {
        touchSphere = touchSphereObj.GetComponent<TouchSphere>();
    }

    // Update is called once per frame
    void Update()
    {
        TouchesInvisibleObject();
        TouchesSwitchObject();
        ResetMaterial();
    }

    //透明な物体に触れたとき、コントローラーを振動させる関数
    void TouchesInvisibleObject()
    {
        if (touchSphere.TouchesOutsideCollider)
        {
            touchSphereObj.GetComponent<Renderer>().material = touchSphere_red;
            Debug.Log("振動:強");
            if (touchSphere.TouchesInsideCollider)
            {
                touchSphereObj.GetComponent<Renderer>().material = touchSphere_yellow;
                Debug.Log("振動:弱");
            }
        }
    }

    void TouchesSwitchObject()
    {
        if(touchSphere.TouchesSwitchCollider)
        {
            touchSphereObj.GetComponent<Renderer>().material = touchSphere_red;
        }
    }

    void ResetMaterial()
    {
        if(!touchSphere.TouchesCollider)
        {
            touchSphereObj.GetComponent<Renderer>().material = touchSphere_blue;
        }

    }
}