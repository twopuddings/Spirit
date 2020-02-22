using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerControl2 : MonoBehaviour {

    public GameObject rotateY;
    public GameObject rotateX;


    private Quaternion targetTransY;
    private Quaternion targetTransX;


    private float mouseY;
    private float mouseX;


    private float YAngleChange;
    private float XAngleChange;


    private float smoothSpeed = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void LateUpdate()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");


        RotateByX(mouseY);
        RotateByY(mouseX);
    }

    void RotateByY(float xValue)
    {
        YAngleChange += xValue * smoothSpeed * Time.deltaTime * 90;
        targetTransY = Quaternion.Euler(0, YAngleChange, 0);
        rotateY.transform.localRotation = Quaternion.Slerp(rotateY.transform.localRotation, targetTransY, 2);


    }
    void RotateByX(float yValue)
    {
        XAngleChange -= yValue * smoothSpeed * Time.deltaTime * 90;
        XAngleChange = Mathf.Clamp(XAngleChange, -70f, 40f);
        targetTransX = Quaternion.Euler(XAngleChange, 0, 0);
        rotateX.transform.localRotation = Quaternion.Slerp(rotateX.transform.localRotation, targetTransX, 2);
    }
}
