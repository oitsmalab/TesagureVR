using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchSphere : MonoBehaviour {

    //触れているColliderの真偽値。触れている時をTrueとする。
    private bool _touchesCollider;         //何かのオブジェクトに触れているか
    private bool _touchesInsideCollider;   //透明オブジェクトの内側のコライダーに触れているか
    private bool _touchesOutsideCollider;  //透明オブジェクトの外側のコライダーに触れているか
    private bool _touchesSwitchCollider;   //スイッチオブジェクトのコライダーに触れているか

    //Colliderの真偽値の読み取り専用のプロパティ
    public bool TouchesCollider
    {
        get { return this._touchesCollider; }
    }

    public bool TouchesInsideCollider
    {
        get { return this._touchesInsideCollider; }
    }

    public bool TouchesOutsideCollider
    {
        get { return this._touchesOutsideCollider; }
    }

    public bool TouchesSwitchCollider
    {
        get { return this._touchesSwitchCollider; }
    }
    //ここまでプロパティ

    void OnTriggerEnter(Collider other)
    {
        _touchesCollider = true;

        if (other.tag == "InsideCollider")
            _touchesInsideCollider = true;

        if (other.tag == "OutsideCollider")
            _touchesOutsideCollider = true;

        if (other.tag == "SwitchCollider")
            _touchesSwitchCollider = true;

        TouchesColliderCheck();
    }

    void OnTriggerExit(Collider other)
    {
        _touchesCollider = false;

        if (other.tag == "InsideCollider")
            _touchesInsideCollider = false;

        if (other.tag == "OutsideCollider")
            _touchesOutsideCollider = false;

        if (other.tag == "SwitchCollider")
            _touchesSwitchCollider = false;

        TouchesColliderCheck();
    }

    void TouchesColliderCheck()
    {
        Debug.Log("OutsideCollider:" + _touchesOutsideCollider);
        Debug.Log("InsideCollider:" + _touchesInsideCollider);
        Debug.Log(_touchesSwitchCollider);
    }

}
