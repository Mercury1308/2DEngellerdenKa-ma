using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public float KarakterHizi;

    void Update()
    {
        float hiz = KarakterHizi * Input.GetAxis("Horizontal");
        transform.Translate(hiz * Time.deltaTime,0 , 0);
    }
}
