using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
    Rigidbody fizik;
    public float rotasyon;
   

    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        fizik.angularVelocity = Random.insideUnitSphere*rotasyon;
    }
}