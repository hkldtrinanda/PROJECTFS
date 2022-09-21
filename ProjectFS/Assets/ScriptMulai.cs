using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMulai : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Panel;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void Mulai()
    {
        Panel.SetActive(false);
        Time.timeScale = 1;
    }
}
