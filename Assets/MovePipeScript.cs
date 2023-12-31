using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipeScript : MonoBehaviour
{
    public float moveSpeed = 5;
    private float deadZone = -45;
    public BirdScript birdscript;


    // Start is called before the first frame update
    void Start()
    {
        birdscript = GameObject.FindGameObjectWithTag("BirdScript").GetComponent<BirdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (birdscript.birdIsAlive)
        {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        }

        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
