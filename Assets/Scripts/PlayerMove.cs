using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {

    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;

    //public Button wButton;
    //public Button sButton;
    //public Button aButton;
    //public Button dButton;


    //float translationZ;
    //float translationX;

    public Vector3 forceVec;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {

        rb.AddForce(Input.gyro.userAcceleration,ForceMode.Acceleration);

        //if (!wButton)
        //{
        //    Debug.Log("ok");
        //    translationZ = 1;
        //}

        //float translationX = Input.gyro.userAcceleration.x * speed;
        //float translationY = Input.gyro.userAcceleration.y * speed;
        //float translationZ = Input.gyro.userAcceleration.z * speed;

        //transform.Translate(translationX,translationY,translationZ);

        //float translationZ = Input.GetAxis("Vertical") * speed;
        //float translationX = Input.GetAxis("Horizontal") * speed;
        //float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        //rotation *= Time.deltaTime;
        //transform.Translate(translationX, 0, translationZ);
        //transform.Rotate(0, rotation, 0);
    }
}
