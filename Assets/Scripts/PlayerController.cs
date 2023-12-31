using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    private float xRange = 22.0f;
    public GameObject projectilePrefab;
    public GameObject spwanPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput*speed * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Luanch a projectile form the player
            Instantiate(projectilePrefab, spwanPrefab.transform.position, projectilePrefab.transform.rotation);
            
        }
    }
    
}
