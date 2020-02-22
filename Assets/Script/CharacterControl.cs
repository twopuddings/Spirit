using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

    float _current;
    public float _smoothtime;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        //获取原始的XY轴数据
        Vector2 vector2 = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 inputdir = vector2.normalized;
        //计算与起始的夹角量
        float _targetrotation = Mathf.Atan2(inputdir.x, inputdir.y) * Mathf.Rad2Deg;
        if (inputdir != Vector2.zero)
        {
            //平滑旋转角度（旋转Y轴，旋转量，旋转后正确角度，平滑时长）
            transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y,_targetrotation,ref _current,_smoothtime);
        }
        
    }
}
