using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;


public class EasySwitch : MonoBehaviour {

    [SerializeField]
    Material _defaultMaterial;
    [SerializeField]
    Material _changeMaterial;

    TouchButton _touchButton;

	// Use this for initialization
	void Start () {
        _touchButton = gameObject.GetComponent<TouchButton>();
	}
	
	// Update is called once per frame
	void Update () {
        //TouchesTouchSphereObject();
	}

    //void TouchesTouchSphereObject()
    //{
    //   if(_touchButton.TouchesTouchSphereCollider)
    //    {
    //        gameObject.GetComponent<Renderer>().material = _changeMaterial;
    //    }else
    //    {
    //        gameObject.GetComponent<Renderer>().material = _defaultMaterial;
    //    }
    //}

    IEnumerator TouchesTouchSphereObject()
    {
        while (true)
        {
            if (_touchButton.TouchesTouchSphereCollider)
            {
                gameObject.GetComponent<Renderer>().material = _changeMaterial;
            }
            else
            {
                gameObject.GetComponent<Renderer>().material = _defaultMaterial;
            }
            yield return null;
        }
    }

}
