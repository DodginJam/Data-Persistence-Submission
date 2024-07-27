using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using static UnityEditor.PlayerSettings;

public class Paddle : MonoBehaviour
{
    public float Speed = 2.0f;
    public float MaxMovement = 2.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Speed * Time.deltaTime * input);

        if (transform.position.x > MaxMovement)
            transform.position = new Vector3(MaxMovement, transform.position.y, transform.position.z);
        else if (transform.position.x < -MaxMovement)
            transform.position = new Vector3(-MaxMovement, transform.position.y, transform.position.z);
    }
}
