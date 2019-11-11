using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string sceneName;

    public void OnClick()
    {
        EditorSceneManager.LoadScene(sceneName);
    }
}
