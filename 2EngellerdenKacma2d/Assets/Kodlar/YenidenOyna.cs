using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YenidenOyna : MonoBehaviour
{
    public void Yen1denOyna()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Hak.kalanhak = 3;
        Time.timeScale = 1;

    }
}
