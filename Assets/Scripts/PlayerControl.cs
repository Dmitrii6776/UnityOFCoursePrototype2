using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float _horizontalMove;

    public float Speed = 10f;

    public int xRange = 10;

    public GameObject FoodPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        _horizontalMove = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * _horizontalMove * Time.deltaTime * Speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(FoodPrefab, transform.position, FoodPrefab.transform.rotation);
        }
    }
}
