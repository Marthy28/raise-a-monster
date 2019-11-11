using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuDeroulant : MonoBehaviour
{

    public Vector2 scrollPosition = Vector2.zero;
    // Start is called before the first frame update

    private void OnGUI()
    {
        scrollPosition = GUI.BeginScrollView(new Rect(10, 300, 100, 100), scrollPosition, new Rect(0, 0, 220, 200));

        // Make four buttons - one in each corner. The coordinate system is defined
        // by the last parameter to BeginScrollView.
        GUI.Button(new Rect(0, 0, 100, 20), "Top-left");
        GUI.Button(new Rect(120, 0, 100, 20), "Top-right");
        GUI.Button(new Rect(0, 180, 100, 20), "Bottom-left");
        GUI.Button(new Rect(120, 180, 100, 20), "Bottom-right");

        // End the scroll view that we began above.
        GUI.EndScrollView();
    }
}
