using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private int sceneNumber;

    private void OnEnable()
    {
        SceneManager.LoadScene(sceneNumber);
        
    }
}