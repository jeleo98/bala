using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunitionMovement : MonoBehaviour
{
    public float Speed = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move(Vector3.forward);
    }
    private void Move (Vector3 direction)
    {
        transform.Translate(direction * Speed * Time.deltaTime);
        }
}
