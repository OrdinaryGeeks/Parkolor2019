using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackBullet : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {

           Debug.Log("In OTE Bullet");
        // if (!ColorNinja.AttackPlayer)
           if (other.gameObject.tag == "ColorNinjaASpheres")
        {
            ColorNinja.Health -= 2;


            Destroy(transform.parent.gameObject);



        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
