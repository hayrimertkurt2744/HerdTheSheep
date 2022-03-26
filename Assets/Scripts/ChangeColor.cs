using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{   
    public Material purpleMaterial;
    private GateBehaviour gateBehavior;
    public string materialName = "";




    private void OnTriggerEnter(Collider other)
    {   if (other.gameObject.tag == "Sheep")
        {
            if (materialName == "Purple")
            {
                other.GetComponent<SpawnManager>().purple.gameObject.SetActive(true);
                other.GetComponent<SpawnManager>().white.gameObject.SetActive(false);
            }
        }
        if (other.gameObject.tag == "SheepAgent")
        {
            if (materialName == "Purple")
            {
                other.GetComponent<AgentController>().purple.gameObject.SetActive(true);
                other.GetComponent<AgentController>().white.gameObject.SetActive(false);
            }
        }
    }
}
