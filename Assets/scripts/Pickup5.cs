using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup5 : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(15, 3, 45) * Time.deltaTime * 99999999999);
    }
}