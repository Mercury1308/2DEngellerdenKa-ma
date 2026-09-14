using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Engeller : MonoBehaviour
{
    private static int skor;
    public TextMeshProUGUI skoryazisi, bitisYazisi;

    void Start()
    {
        skor = 0;
    }
    void Update()
    {

        skoryazisi.text = skor.ToString();
        bitisYazisi.text = "Oyun Bitti \n Skor :  " + skor.ToString();
    }
    void OnCollisionEnter2D(Collision2D temas)
    {
        float xPozisyonu = Random.Range(-5.6f, 5.6f);
        float yPozisyonu = Random.Range(6f, 10f);
        if (temas.gameObject.tag == "Control_Cubugu")
        {
            transform.position = new Vector2(xPozisyonu, yPozisyonu);
            skor += Random.Range(7, 12);
        }
        else if (temas.gameObject.tag == "Karakter")
        {
            transform.position = new Vector2(xPozisyonu, yPozisyonu);
            Hak.kalanhak--;
        }
    }
}
