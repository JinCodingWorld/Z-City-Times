using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressYoutube : MonoBehaviour
{
    public GameObject Plane_Video;
    public void DRjoeInterview()
    {
        Plane_Video.SetActive(true);
    }

    public void Interview()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=VQAeoXef6sI");
    }
}
