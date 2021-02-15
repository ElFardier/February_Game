using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wincondition : MonoBehaviour
{
    [SerializeField] 
    private Animator myAnimationController;
    public AudioClip Yaaay;

    void Start()
    {
    }

    void Update()
    {


    }

     void OnTriggerStay(Collider other)
     {
        if(other.gameObject.tag == "Player")
        {
              if (Input.GetKeyDown("f"))
            {
            
            myAnimationController.SetBool("Press",true);
            
            AudioSource.PlayClipAtPoint(Yaaay, transform.position, 1);
            }
        }
    }
    
}
