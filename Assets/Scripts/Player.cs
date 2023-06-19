using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 7;
    // Update is called once per frame
    private void Update()
    {
        Vector3 Dir = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.A))
            Dir.x = -1.0f;
        if (Input.GetKey(KeyCode.D))
            Dir.x = 1.0f; 
        if(Input.GetKey(KeyCode.W)) 
            Dir.z = 1.0f;
        if(Input.GetKey(KeyCode.S))
            Dir.z = -1.0f;
        Vector3 nomalDir = Dir.normalized;
        transform.position +=  moveSpeed * nomalDir * Time.deltaTime;
    }
}
