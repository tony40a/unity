using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public float XRotation = -100;
    public float YRotation = 10;
    public float ZRotation = 0;
    public float DegreesPerSecond = 360;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        XRotation += 1;
        if (XRotation > 100) 
        {
            XRotation = -100;
        }
        Vector3 axis = new Vector3 (XRotation * Time.deltaTime, YRotation, ZRotation);
        transform.RotateAround(Vector3.zero, axis, DegreesPerSecond * Time.deltaTime);
        Debug.DrawRay(Vector3.zero, axis, Color.yellow, .5f);
    }
}
