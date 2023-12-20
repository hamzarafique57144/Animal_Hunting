using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public GameObject Panel;
   void OnCollisionEnter(Collision Other)
    {
        if(Other.gameObject.tag=="Player")
            {
            Destroy(Other.gameObject);
            Panel.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            Destroy(gameObject);
        }
       
        
        
        
      
    }
}
