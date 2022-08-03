using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
       public float posicionY = 3f;
    public float Scale = 2;
    public float Speed = 2;
    public int Attack = 3;
    public int hp = 3;
    public int Heal = 1;
    public Vector3 Direction = new Vector3 (0f,1f,0f);
    // Start is called before the first frame update
    void Start()
    {
      
     //  transform.position = Vector3.up * posicionY;
      // transform.localScale = transform.localScale *Scale;
       Damage (Attack);
       Healing (Heal);
        Debug.Log(hp);
      
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
    }

    void Damage(int newAttack)
    {
        hp = hp - newAttack;

    }

    void Healing (int newHeal)
    {
        hp = hp + newHeal;
    }
    private void Move () 
    {
        transform.position += Direction * Speed * Time.deltaTime;
       // transform.Translate(Vector3.forward * Speed * Time.deltaTime)
    }
  
}
//  new Vector3(1f,0f,1f)
