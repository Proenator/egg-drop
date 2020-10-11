using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float RotationSpeed; //Adds Rotation Speed property in Unity editor

    void FixedUpdate() //Use void FixedUpdate whenever Physics are used
    {
        if (Input.GetButton("Horizontal")) //If the left or right key is held down
            transform.Rotate(0, 0, RotationSpeed); //Rotate the player (Rotation Speed) degrees in the direction held down
    }


}
