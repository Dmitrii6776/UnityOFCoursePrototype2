using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForvard : MonoBehaviour
{
    public int Speed = 20;

    public int TopBound = 30;

    public int BBound = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
        if (transform.position.z > TopBound)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < BBound)
        {
            Destroy(gameObject);
        }
        
    }
    
    
}
