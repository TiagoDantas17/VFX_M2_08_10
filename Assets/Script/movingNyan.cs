using UnityEngine;

public class MovingNyan : MonoBehaviour
{
    float horizontal;
    float vertical;


    void Update()
    {
        horizontal = -Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, vertical, 0) * Time.deltaTime * 5);
    }
  
}
