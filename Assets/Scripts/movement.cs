using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private Rigidbody player;
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal")*speed*Time.deltaTime;
        vertical = speed * Time.deltaTime;

        gameObject.transform.Translate(horizontal, 0, vertical);
        

    }
}
