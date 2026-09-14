using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Timeline.Actions;
public class Hak : MonoBehaviour
{
    public static int kalanhak = 3;
    public TextMeshProUGUI hakyazisi;

    public GameObject bitispaneli;

    void Update()
    {
        hakyazisi.text = "Hak " + kalanhak.ToString();
        if (kalanhak == 0)
        {
            bitispaneli.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
