using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{

    float rotSpeed = 0;


    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            this.rotSpeed = 10;
        }

        transform.Rotate(0, 0, this.rotSpeed);

        if (this.rotSpeed < 2)
        {
            this.rotSpeed *= 0.97f;
        }

        this.rotSpeed *= 0.99f;
    }
}
