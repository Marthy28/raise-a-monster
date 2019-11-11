using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadCanvas : MonoBehaviour
{
    public Canvas canvas_to_load;
    GameObject main_canvas;


    private void Awake()
    {
        main_canvas = GameObject.Find("Ui_mainView");
    }
    public void OnCLick()
    {
        canvas_to_load.gameObject.SetActive(true);
        main_canvas.SetActive(false);
    }
}
