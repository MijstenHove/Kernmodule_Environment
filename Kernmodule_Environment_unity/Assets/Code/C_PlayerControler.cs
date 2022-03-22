using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class C_PlayerControler : MonoBehaviour
{
    public float speed = 10f;
    public bool moveRight;
    public bool moveLeft;
    public bool moveForward;
    public bool moveBackward;

    public static C_PlayerControler instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
            this.gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        }

        if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
            this.gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.Translate(-Vector3.right * speed * Time.deltaTime);
            this.gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
            this.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }


}
