using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
      //  Debug.Log(Runner.AttackColorNinja1);
     //   Debug.Log(other.gameObject.tag);
        // Debug.Log(ColorNinja.AttackPlayer);
        if (!Runner.AttackColorNinja1 && Runner.isAttacking)
            if (other.gameObject.tag == "ColorNinjaASpheres")
            {

             //   Debug.Log("got a slash");
                ColorNinja.Health -= 1;
                //Debug.Log("got a slash");
                //Runner.DamageTaken -= 2;

                Runner.AttackColorNinja1 = true;



            }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
