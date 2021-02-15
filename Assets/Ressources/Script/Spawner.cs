using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject balloon;
    public Transform balloonPos;
    private float repeatRate = 2000f;


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
                InvokeRepeating("SpawnBalloon", 0.5f, repeatRate);
                gameObject.GetComponent<BoxCollider>().enabled = false;
            }
        }
    }
    void SpawnBalloon()
    {
        Instantiate(balloon, balloonPos.position, balloonPos.rotation);
    }
    
}
