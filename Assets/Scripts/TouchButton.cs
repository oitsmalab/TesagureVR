using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchButton : MonoBehaviour {

    //触れているColliderの真偽値。触れている時をTrueとする。
    private bool _touchesTouchSphereCollider;   //TouchSphereオブジェクトに触れているか。

    //Colliderの真偽値の読み取り専用のプロパティ
    public bool TouchesTouchSphereCollider
    {
        get { return this._touchesTouchSphereCollider; }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "TouchSphereCollider")
            _touchesTouchSphereCollider = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "TouchSphereCollider")
            _touchesTouchSphereCollider = false;
    }

}
