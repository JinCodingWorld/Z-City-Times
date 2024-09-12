using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{

    public void youtube()
    {
        Application.OpenURL("https://youtu.be/nvRoSY6vBeQ?si=2OH5BHKxqirRuKxl");
    }
    public void linkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/jiho-lee-a5321a244?utm_source=share&utm_campaign=share_via&utm_content=profile&utm_medium=android_app");
    }

    public void instagram()
    {
        Application.OpenURL("https://www.instagram.com/easyho_jin?igsh=MWY3NW82ZTU3ZTl2dw==");
    }

    public void twitter()
    {
        Application.OpenURL("https://x.com/?lang=ko");
    }

}
