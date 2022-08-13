using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCoin : MonoBehaviour
{
   void Update()
    {
        transform.Rotate(new Vector3(4, 4, 40) * Time.deltaTime);
    }
}
