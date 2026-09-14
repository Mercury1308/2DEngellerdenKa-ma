using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesAçKapaSC : MonoBehaviour
{
    public GameObject sesacik, seskapali;
    void Start()
    {

    }

    void Update()
    {
        if (PlayerPrefs.GetInt("sesDurum") == 1)
        {
            sesacik.SetActive(true);
            seskapali.SetActive(false);
        }
        else
        {

            sesacik.SetActive(false);
            seskapali.SetActive(true);
        }

    }

    public void sesDurum(string durum)
    {
        if (durum == "acik")
        {
            sesacik.SetActive(false);
            seskapali.SetActive(true);
            PlayerPrefs.SetInt("sesDurum", 0);
        }
        else if (durum == "kapali")
        {

            sesacik.SetActive(true);
            seskapali.SetActive(false);
            PlayerPrefs.SetInt("sesDurum", 1);
        }



    }

}
