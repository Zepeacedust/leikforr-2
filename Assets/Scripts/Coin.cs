using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public Transform body;
    // Update is called once per frame
    void FixedUpdate()
    {
        body.Rotate(0f, 1f, 0f, Space.World);
    }
}
