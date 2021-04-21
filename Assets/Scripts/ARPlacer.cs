using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARPlacer : MonoBehaviour
{
    ARRaycastManager m_ARRaycastManager;

    public GameObject LocationBasedARPrefab;

    List<ARRaycastHit> raycast_hits = new List<ARRaycastHit>();
    // Start is called before the first frame update

    private void Awake()
    {
        
    }
    void Start()
    {
        m_ARRaycastManager = GetComponent<ARRaycastManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (m_ARRaycastManager.Raycast(touch.position, raycast_hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
            {
                Pose pose = raycast_hits[0].pose;

                LocationBasedARPrefab.transform.position = pose.position;
            }
        }
    }
}
