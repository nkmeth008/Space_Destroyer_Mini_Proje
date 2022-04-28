using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {
     if(transform.position.x<=-5.92f || transform.position.x>= 5.82f)  {

         float SinirX = Mathf.Clamp(gameObject.transform.position.x, -5.92f, 5.82f);
         transform.position = new Vector3(SinirX, transform.position.y, transform.position.z);
     } 
    }
}
