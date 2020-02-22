using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharactor : MonoBehaviour {

    public float _moveSpeed;

    private Transform _chaTransform;
    private Rigidbody _chaRigidbody;

	// Use this for initialization
	void Start () {
        _chaRigidbody = gameObject.GetComponent<Rigidbody>();
        _chaTransform = gameObject.GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        //角色移动WASD，空格闪避
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
        //    if (Input.GetKeyDown(KeyCode.Space))
        //    {
        //        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime * 5);
        //    }
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(Vector3.back * _moveSpeed * Time.deltaTime);
        //    if (Input.GetKeyDown(KeyCode.Space))
        //    {
        //        transform.Translate(Vector3.back * _moveSpeed * Time.deltaTime * 5);
        //    }
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(Vector3.left * _moveSpeed * Time.deltaTime);
        //    if (Input.GetKeyDown(KeyCode.Space))
        //    {
        //        transform.Translate(Vector3.left * _moveSpeed * Time.deltaTime * 5);
        //    }
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(Vector3.right * _moveSpeed * Time.deltaTime);
        //    if (Input.GetKeyDown(KeyCode.Space))
        //    {
        //        transform.Translate(Vector3.right * _moveSpeed * Time.deltaTime * 5);
        //    }
        //}
    }

    private void LateUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 vector3 = new Vector3(h, 0, v);
        _chaRigidbody.MovePosition(_chaTransform.position + vector3 * _moveSpeed * Time.deltaTime);
    }
}
