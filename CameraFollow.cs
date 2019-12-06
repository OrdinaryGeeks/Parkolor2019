using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject runner;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = runner.transform.position + new Vector3(0.0f, 15.0f, -8.0f);
      //  transform.LookAt(runner.transform.position);
    }
}
