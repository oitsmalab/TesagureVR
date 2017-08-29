using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteControllerForiOS : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Input.gyro.enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
        //傾き情報をコントローラーに適応する。
            var rotRH = Input.gyro.attitude;
            var rot = new Quaternion(-rotRH.x, -rotRH.z, -rotRH.y, rotRH.w) * Quaternion.Euler(90f, 0f, 0f);

            transform.localRotation = rot;
    }
}
