﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    void Start()
    {

        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {


        transform.position += transform.forward * Time.deltaTime * speed;
    }
}
