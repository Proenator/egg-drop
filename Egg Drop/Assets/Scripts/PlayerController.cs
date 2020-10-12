using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float RotationSpeed; //Adds Rotation Speed property in Unity editor

    void FixedUpdate() //Use void FixedUpdate whenever Physics are used
    {
        if (Input.GetKey(KeyCode.LeftArrow)) //If the left key is held down
            transform.Rotate(0, 0, RotationSpeed); //Rotate the player (Rotation Speed) degrees left
        else if (Input.GetKey(KeyCode.RightArrow)) //Otherwise, if the right key is held down
            transform.Rotate(0, 0, -(RotationSpeed)); //Rotate the player (Rotation Speed) degrees right
    }


}
