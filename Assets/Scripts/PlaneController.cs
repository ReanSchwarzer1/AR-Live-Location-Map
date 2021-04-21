using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class PlaneController : MonoBehaviour
{
    ARPlaneManager m_ARPlaneManager;
    public Text buttonText;
    // Start is called before the first frame update
    void Start()
    {
        m_ARPlaneManager = GetComponent<ARPlaneManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TogglePlaneDetectionAndVisibility()
    {
        m_ARPlaneManager.enabled = !m_ARPlaneManager.enabled;

        if (m_ARPlaneManager.enabled)
        {
            SetAllPlaneActiveOrDeactive(true);
            GetComponent<ARPlacer>().enabled = true;
            buttonText.text = "Disable Plane Detection";
        }
        else
        {
            SetAllPlaneActiveOrDeactive(false);
            GetComponent<ARPlacer>().enabled = false;
            buttonText.text = "Enable Plane Detection";
        }
    }

    void SetAllPlaneActiveOrDeactive(bool value)
    {
        foreach (var plane in m_ARPlaneManager.trackables)
        {
            plane.gameObject.SetActive(value);
        }
    }
}
