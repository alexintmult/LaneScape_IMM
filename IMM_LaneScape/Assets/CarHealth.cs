using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHealth : MonoBehaviour
{
    public int car_health = 10;
    public GameObject crash_screen;
    
    private void Start()
    {
      crash_screen.SetActive(false);
    }
    
    private void Update()
    {
       if(car_health == 0)
       {
          crash_screen.SetActive(true);
          car_health = 10;
          Time.timeScale = 0;
          }
        }

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
