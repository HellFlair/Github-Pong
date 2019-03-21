using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
     public string Axis = " --- Select system axis for this paddle --- ";
     public float Speed = 30;
    // Start is called before the first frame update
    void Start()
    {
    }

// Update is called once per frame
    void Update()
    {
        var v = Input.GetAxisRaw(Axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * Speed;
    }

}