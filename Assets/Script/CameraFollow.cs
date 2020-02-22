using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    // 摄像机跟随的对象
    public Transform _charactor;

    // The speed with which the camera will be following.
    public float smoothing = 5f;

    //偏移量
    Vector3 _playerCam;

    // Use this for initialization
    void Start () {
        //计算相机与被跟随物体的相对量
        _playerCam = transform.position - _charactor.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //延迟更新
    private void LateUpdate()
    {
        //计算最终相机位置
        Vector3 _charactorCamPos = _charactor.position + _playerCam;
        transform.position = Vector3.Lerp(transform.position, _charactorCamPos, smoothing * Time.deltaTime);
        float _Mousx = Input.GetAxis("Mouse X");
        Quaternion quaternion = Quaternion.Euler(0, _Mousx, 0);
        transform.rotation = quaternion * transform.rotation;
    }
}
