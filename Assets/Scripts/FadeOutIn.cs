using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeOutIn : MonoBehaviour
{
    public Animator Fade;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void GoMain()
    {
        Fade.SetTrigger("fadeOut");
        Invoke("SceneChange", 1f);
    }

    public void SceneChange()
    {
        SceneManager.LoadScene("MainScene");
        Fade.SetTrigger("fadeIn");
    }
}
