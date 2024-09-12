using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class pistolPopup : MonoBehaviour
{
    // Start is called before the first frame update
    public void popup()
    {
        Vector3 targetScale = new Vector3(0.7643f, 0.7643f, 0.7643f);
        transform.DOScale(targetScale, 8.0f);
    }

    
}
