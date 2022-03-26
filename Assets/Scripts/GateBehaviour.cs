using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GateBehaviour : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject prefab;
    public GameObject gate;
    public TextMeshPro text;
    public GameObject newSheeps;
    
    public int howMany;
    int i = 0;

    private void OnTriggerEnter(Collider other)
    {   if (other.gameObject.CompareTag("Sheep"))
        {
            while (i < howMany)
            {

                newSheeps =Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
                SpawnManager.sheeps.Add(newSheeps);
                i++;
            }
            gate.GetComponent<MeshRenderer>().enabled = false;
            text.GetComponent<TextMeshPro>().enabled = false;
            //play animation here.
        }
        

    }


}
