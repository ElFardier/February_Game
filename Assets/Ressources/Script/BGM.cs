using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGM : MonoBehaviour
{
    [SerializeField]     
    void Start()
    {    }

    void Update()
    {


    }

     void OnTriggerStay(Collider other)
     {
        if(other.gameObject.tag == "Player")
        {
              if (Input.GetKeyDown("f"))
            {
        AudioSource audioSource = Camera.main.GetComponent<AudioSource>();
            audioSource.Stop();;
            Destroy(gameObject);
            }
        }
    }
    
    
}