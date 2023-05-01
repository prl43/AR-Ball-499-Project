using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;






public class BallSpawner : MonoBehaviour
   {
    public ARRaycastManager arRaycastManager;

    public GameObject ballPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
       {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
           {
            Vector2 touchPosition = Input.GetTouch(0).position;
            List<ARRaycastHit> hits = new List<ARRaycastHit>();
            if (arRaycastManager.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
               {
                Pose hitPose = hits[0].pose;
                Instantiate(ballPrefab, hitPose.position, Quaternion.identity);
               }
           }

       }
   }
