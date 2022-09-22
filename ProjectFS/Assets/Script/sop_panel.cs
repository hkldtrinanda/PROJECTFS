using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using UnityEngine;

public class sop_panel : MonoBehaviour
{
    public bool doneCalculate;
    [Serializable]
   public struct SopList
    {
        public string sopName;
        public int score;

    }

    [SerializeField] public SopList[] SopLists;
    private void Awake()
    {
       
        GameObject buttonTemplate = transform.GetChild(0).gameObject;
        GameObject g;
       

        int N = SopLists.Length;
        for (int i = 0; i < N; i++)
        {
            g = Instantiate(buttonTemplate, transform);
            g.transform.GetChild(0).GetComponent<Text>().text = SopLists[i].sopName;
            g.transform.GetChild(1).GetComponent<Text>().text = "Score : " + SopLists[i].score;

        }
        Destroy(buttonTemplate);
        doneCalculate = true;
    }

}
