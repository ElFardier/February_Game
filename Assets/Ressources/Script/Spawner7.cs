using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner7 : MonoBehaviour
{

    public GameObject balloonV;
    public Transform balloonVPos;
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
                InvokeRepeating("SpawnBalloonV", 0.5f, repeatRate);
                gameObject.GetComponent<BoxCollider>().enabled = false;
            }
        }
    }
    void SpawnBalloonV()
    {
        Instantiate(balloonV, balloonVPos.position, balloonVPos.rotation);
    }
    
}
