using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
      
        if (other.gameObject.CompareTag("SheepAgent") )
        {

            Destroy(other.gameObject);

        
        }


    }
}
