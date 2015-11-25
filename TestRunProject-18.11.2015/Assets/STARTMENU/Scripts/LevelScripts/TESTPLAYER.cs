﻿using UnityEngine;
using System.Collections;

public class TESTPLAYER : MonoBehaviour
{
        public float speed;
    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    void FixedUpdate()
    {
        float moveVertical;
        float moveHorizontal;
        moveVertical = Input.GetAxis("Vertical");
        moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }

}

