using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner14 : MonoBehaviour
{

    public GameObject Light;
    public Transform LightPos;
    private float repeatRate = 100000f;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerStay(Collider other) 
    {
         if(other.gameObject.tag == "Player")
        {
              if (Input.GetKeyDown("f"))
            {
                InvokeRepeating("SpawnBalloonV", 0.5f, repeatRate);
                gameObject.GetComponent<BoxCollider>().enabled = false;
            }
        }
    }
    void SpawnBalloonV()
    {
        Instantiate(Light, LightPos.position, LightPos.rotation);
    }
    
}
