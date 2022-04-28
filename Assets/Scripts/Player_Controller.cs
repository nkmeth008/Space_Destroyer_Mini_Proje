using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player_Controller : MonoBehaviour
{
    
    public Joystick joystick;
    public Joybutton joybutton;
    public float hiz;
    float atesZamani = 0;
    public float gecenZaman = 0;
    public GameObject Kursun;
    public Transform KursununCikisYeri;
    
    

    void Start()
    {
        
       joystick = FindObjectOfType<Joystick>();
       joybutton = FindObjectOfType<Joybutton>();
       
    }   

    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(joystick.Horizontal *hiz,rigidbody.velocity.y);

        if(joybutton.Pressed && Time.time > atesZamani)
        {
            atesZamani = Time.time + gecenZaman;
            Instantiate(Kursun, KursununCikisYeri.position, Quaternion.identity);
           
            
        }
        
    }
   

}
