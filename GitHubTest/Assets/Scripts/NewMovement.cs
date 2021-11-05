using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovement : MonoBehaviour
{

    public float moveSpeed =5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 5f, 0f);

      Vector3 movement = new Vector3(Input.GetAxis("Vertical"), 0f, 5f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    
    }

    void Jump ()
    {
       
    }
}
