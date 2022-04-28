using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Options : MonoBehaviour

{
    GameObject gamecontrol;
    GameControl control;
    void Start()
    {
        gamecontrol = GameObject.FindGameObjectWithTag("oyunkontrol");
        control = gamecontrol.GetComponent<GameControl>();
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag != "Sinir")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            
        }

        if (col.tag == "Player")
        {
            control.oyunBitti();
        }

    

    }
    
}
