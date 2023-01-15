using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private int rangeBorderX = 26;
    private int rangeBorderZ = 12;
    
    void Update()
    {
        if (transform.position.z > rangeBorderZ 
            || transform.position.z < -rangeBorderZ
            || transform.position.x > rangeBorderX
            || transform.position.x < -rangeBorderX)
        {
            if (gameObject.tag == "Animal")
            {
                GameController.Instance.DecreasePlayerLives();
            }
            Destroy(gameObject);
        } 
    }
}