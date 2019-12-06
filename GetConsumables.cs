using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetConsumables : MonoBehaviour
{

    public GameObject Runner;


    public void OnTriggerEnter(Collider other)
    {

        if (other.name.Contains("Sword"))
        {

            if (!Runner.GetComponent<Runner>().hasSword)
                Runner.GetComponent<Runner>().equipment.Add("Sword");
            Runner.GetComponent<Runner>().hasSword = true;
            Destroy(other.gameObject);



        }
        if (other.name.Contains("Gun"))
        {
            if (!Runner.GetComponent<Runner>().hasGun)
                Runner.GetComponent<Runner>().equipment.Add("Gun");
            Runner.GetComponent<Runner>().hasGun = true;
            Destroy(other.gameObject);


        }
        if (other.name.Contains("Ammo"))
        {

            Runner.GetComponent<Runner>().ammoCount += 20;
            Destroy(other.gameObject);

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
