using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticatlInput;
    private float speed = 12f;

    private int moveRangeX = 24;
    private int moveRangeZ = 9;
    
    [SerializeField] private GameObject foodPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(foodPrefab, transform.position, foodPrefab.transform.rotation);
        }

        MovePlayer();    
    }

    private void MovePlayer()
    {
        if(transform.position.x < -moveRangeX)
        {
            transform.position = new Vector3(-moveRangeX, transform.position.y, transform.position.z);
        }
        if(transform.position.x > moveRangeX)
        {
            transform.position = new Vector3(moveRangeX, transform.position.y, transform.position.z);
        }
        if(transform.position.z < -moveRangeZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -moveRangeZ);
        }
        if(transform.position.z > moveRangeZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, moveRangeZ);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticatlInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * verticatlInput * speed * Time.deltaTime);
    }
}