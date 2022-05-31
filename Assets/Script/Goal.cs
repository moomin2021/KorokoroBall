using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public GameObject clearText;
    public GameObject nextButton;
    public GameObject titleButton;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {

        clearText.SetActive(true);
        nextButton.SetActive(true);
        titleButton.SetActive(true);
        if (gameObject.tag == "Level3")
        {
            SceneManager.LoadScene("TitleScene");
        }
        audioSource.Play();
    }
}
