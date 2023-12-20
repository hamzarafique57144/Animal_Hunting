using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameObjectDestroy : MonoBehaviour
{
    public float topBoundry=4;
    public GameObject GameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBoundry)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < -topBoundry)
        {
            Destroy(gameObject);
            Time.timeScale = 0f;
            GameOverPanel.SetActive(true);
            
        }

    }
   
}
