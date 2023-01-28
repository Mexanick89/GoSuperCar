using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControll : MonoBehaviour
{
    public Rigidbody2D carRig;
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;

    public float speed = 20;
    public float carTorque = 10;
    private float movement;

    public float horizontalspeed;

    private void FixedUpdate()
    {
        if (movement == 0)
        {
            backTire.AddTorque(movement * speed * Time.fixedDeltaTime);
            frontTire.AddTorque(movement * speed * Time.fixedDeltaTime);
            carRig.AddTorque(movement * carTorque * Time.fixedDeltaTime);
        }

        if (movement == 1)
        {
            backTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            frontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            carRig.AddTorque(-movement * carTorque * Time.fixedDeltaTime);
        }
    }

    public void Gaz()
    {
        movement = 1;
    }

    public void Gaz2()
    {
        movement = 0;
    }
}
