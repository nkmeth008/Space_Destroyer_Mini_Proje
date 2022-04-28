using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameControl : MonoBehaviour
{
    public GameObject Asteroid;
    public Vector3 randomPosition;
    public float Baslangic;
    public float Bekleme;
    public float Dongu;
    public float sayi;
    public Text text;
    int score;

    void Start()
        
    {
        //score = 0;
        //text.text = "Score " + score;
        StartCoroutine(olustur());
    }

    IEnumerator olustur()
    {
        yield return new WaitForSeconds(Baslangic);
        while (true){
            for (int i = 0; i < sayi; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randomPosition.x, randomPosition.x), 0, randomPosition.z);
                Instantiate(Asteroid, vec, Quaternion.identity);
                yield return new WaitForSeconds(Bekleme);

            }
            yield return new WaitForSeconds(Dongu);
        }
            
       
    }
    public void ScoreArttir(int gelenScore)
    {
        //score += gelenScore;
        //text.text = "Score " + score;
       // Debug.Log(score);
    }

    public void oyunBitti()
    {
        SceneManager.LoadScene(2);


    }

}
