using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float speedGainedPerSecond = 0.2f;
    [SerializeField] private float turnSpeed = 50f;

    private int steerValue;

    // Update is called once per frame
    void Update()
    {
        /** moving forward: * Time.deltaTime it's how long since the last frame */
        speed = speed + speedGainedPerSecond * Time.deltaTime;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);   

        /** steering */
        transform.Rotate(0f, steerValue * turnSpeed * Time.deltaTime, 0f);
    }
        public void Steer(int value) {
        steerValue = value;
    }
}
