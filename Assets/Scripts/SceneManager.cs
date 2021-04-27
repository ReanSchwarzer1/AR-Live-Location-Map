using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManager : MonoBehaviour
{
    public void GenLoadScenes()
    {
        Application.LoadLevel("ARFoundationScene 1");
    }

    public void SatelliteImagery()
    {
        Application.LoadLevel("ARFoundationScene");
    }
}
