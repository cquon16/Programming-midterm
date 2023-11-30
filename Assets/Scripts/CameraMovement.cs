using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    private Camera mainCam;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        mainCam.transform.position = new Vector3(GameObject.Find("Ball").transform.position.x -11, GameObject.Find("Ball").transform.position.y + 16, GameObject.Find("Ball").transform.position.z -14);
    }
}
