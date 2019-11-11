using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Close : MonoBehaviour
{
    public Canvas canvas;
    // Start is called before the first frame update
    
    void OnClick()
    {
        canvas.gameObject.SetActive(false);

    }

}
