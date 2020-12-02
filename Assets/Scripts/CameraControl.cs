using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
   public float sensitivityX;
   public float sensitivityY;
   private Vector3 motion;
 
   void Update()
   {
      float rotationY = Input.GetAxis("Mouse Y")*sensitivityX;
      float rotationX = Input.GetAxis("Mouse X")*sensitivityY;
      if(rotationY>0)
         motion = new Vector3(Mathf.MoveTowards(motion.x, -80, rotationY), motion.y + rotationX, 0);
      else
         motion = new Vector3(Mathf.MoveTowards(motion.x, 80, -rotationY), motion.y + rotationX, 0);
      transform.localEulerAngles = motion;
   }


}
