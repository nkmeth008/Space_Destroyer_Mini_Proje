using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sinirlar : MonoBehaviour
{
    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "Yildirim")
        {
           Destroy(col.gameObject);
        }

        if(col.tag == "Ast")
        {
            Destroy(col.gameObject);
            SceneManager.LoadScene(2);
        }
        
    }

}
