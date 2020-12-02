using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Walking : MonoBehaviour
{
    // Start is called before the first frame update
    private float currentSpeed;
    public float walkSpeed;
    public float runSpeed;

    void Start()
    {
        currentSpeed = walkSpeed;
    }
 void Update ()
    {
        transform.Translate (Input.GetAxisRaw ("Horizontal") * currentSpeed/1000,  0,Input.GetAxisRaw ("Vertical") * currentSpeed/1000);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = runSpeed;
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            currentSpeed = walkSpeed;
        }
    }
}
