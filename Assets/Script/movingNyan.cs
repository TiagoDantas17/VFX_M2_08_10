using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingNyan : MonoBehaviour
{
    float horizontal;
    float vertical;
    void Update()
    {
        horizontal = -Input.GetAxis("horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, vertical, 0)* Time.deltaTime*5);
    }
  
}
