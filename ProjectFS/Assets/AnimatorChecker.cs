using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimatorChecker : MonoBehaviour
{
    public Animator anim;
    public GameObject panel;
    public float howLong;
    public string sceneName;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Wait()
    {
        anim.SetTrigger("End");
        yield return new WaitForSeconds(howLong);
        panel.SetActive(false);
        SceneManager.LoadScene(sceneName);
    }
}
