using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownloadContent : MonoBehaviour
{
    public GameObject nextbutton;
    public void downloadNP()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/1pqDnbbsJEWgWLilckex-VKU7fPQXMMmF?usp=sharing");

        nextbutton.SetActive(true);
    }
}
