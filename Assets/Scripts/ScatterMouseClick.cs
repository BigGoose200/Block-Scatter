﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScatterMouseClick : MonoBehaviour
{
    Rigidbody2D rb;
    private float explode = 500f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 move = transform.position;

            rb.AddForce(move * explode);
        }
    }
}
