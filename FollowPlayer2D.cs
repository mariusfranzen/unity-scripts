using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2D : MonoBehaviour
{
    //Attach the script to the camera that you want to follow the player

    public GameObject FollowedTarget;
    public float Distance = 10;
    private Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3(FollowedTarget.transform.position.x, FollowedTarget.transform.position.y, Distance * -1);
        camera.transform.position = newPosition;
    }
}
