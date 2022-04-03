using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace inputmenrger
{
    public class C_inputMenager : MonoBehaviour
    {


        void Update()
        {

            if (Input.GetKey(KeyCode.S))
            {
                C_PlayerControler.instance.moveRight = true;
            }
            else
            {
                C_PlayerControler.instance.moveRight = false;
            }

            if (Input.GetKey(KeyCode.W))
            {
                C_PlayerControler.instance.moveLeft = true;
            }
            else
            {
                C_PlayerControler.instance.moveLeft = false;
            }

            if (Input.GetKey(KeyCode.A))
            {
                C_PlayerControler.instance.moveForward = true;
            }
            else
            {
                C_PlayerControler.instance.moveForward = false;
            }

            if (Input.GetKey(KeyCode.D))
            {
                C_PlayerControler.instance.moveBackward = true;
            }
            else
            {
                C_PlayerControler.instance.moveBackward = false;
            }
        }

        void OnTriggerEnter(Collider other)
        {
            print("test1");
            if (other.gameObject.tag == "boat")
            {
                print("test2");

            }

        }
    }
}


