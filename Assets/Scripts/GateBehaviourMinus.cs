using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateBehaviourMinus : MonoBehaviour
{
    private GateBehaviour gateBehaviour;
    
    int collisionCount = 0;
    public int objectToDestroy=15;
    bool destroyEnable=true;
    private void OnTriggerEnter(Collider other)
    {
            collisionCount += 1;

            Debug.Log(collisionCount);

        if (other.gameObject.CompareTag("SheepAgent") && destroyEnable==true && collisionCount < objectToDestroy)
        {   
            
                Destroy(other.gameObject);
           
            destroyEnable = false;
            
        }
        

    }
    
}
