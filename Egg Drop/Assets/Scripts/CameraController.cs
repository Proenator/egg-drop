using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player; //This connects the object this script is attatched to with another object in the Unity Editor (in this case, the player)
    private Vector3 offset; //Difference between the position of the player and the position of the camera (line 12)
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position; //Transform references the object this script is attatched to (in this case, the camera)
    }

    // Update is called once per frame
    void LateUpdate() //void LateUpdate guarantees that the action happens after void Update
    {
        transform.position = player.transform.position + offset;
    }
}
