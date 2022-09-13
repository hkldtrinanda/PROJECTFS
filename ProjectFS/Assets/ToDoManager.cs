using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine;

public class ToDoManager : MonoBehaviour
{
    public static ToDoManager instance;

    [SerializeField] GameObject check;
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] TextMeshProUGUI countText;
    [SerializeField] TextMeshProUGUI countLimitText;
    [SerializeField] int toDoCounter =  0;

    [Serializable]
    public struct toDoList
    {
        public string toDoName;
        public int progressCount;
        public int progressLimit;
    }

    private void Awake()
    {
        instance = this;
        nameText.text = toDoLists[toDoCounter].toDoName;
        countText.text = toDoLists[toDoCounter].progressCount.ToString();
        countLimitText.text = toDoLists[toDoCounter].progressLimit.ToString();
        Debug.Log("Current to do is number " + toDoCounter);
    }

    [SerializeField] public toDoList[] toDoLists;

    public void updateUI()
    {
       
        toDoLists[toDoCounter].progressCount++;
        countText.text = toDoLists[toDoCounter].progressCount.ToString();

        int N = toDoLists.Length;
        if (toDoLists[toDoCounter].progressCount == toDoLists[toDoCounter].progressLimit && toDoCounter < toDoLists.Length-1)
        {
          
                Debug.Log("Current to do is number " + toDoCounter);
                toDoCounter++;
                nameText.text = toDoLists[toDoCounter].toDoName;
                countText.text = toDoLists[toDoCounter].progressCount.ToString();
                countLimitText.text = toDoLists[toDoCounter].progressLimit.ToString();
            
        }
       
    }
}
