using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float Speed = 2f;
    public GameObject Munition;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
             MovePlayer(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
             MovePlayer(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
             MovePlayer(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
             MovePlayer(Vector3.right);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
             Shoot();
        }
    }

    private void MovePlayer (Vector3 direction)
    {
        transform.Translate(direction * Speed * Time.deltaTime);
    }
    
    private void Shoot() {
          Debug.Log("DISPARAR");
         Instantiate(Munition, transform.position, Munition.transform.rotation);
    }
    
}
