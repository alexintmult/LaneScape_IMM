using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHealth : MonoBehaviour
{
    public int car_health = 10;

    private void OnCollisionEnter(Collision collision)
    {
       if(collision.collider.gameObject.layer == 3)
       {
          car_health -= 1;
          Destroy(collision.collider.gameObject);
          print(car_health);
          }
       }
}
