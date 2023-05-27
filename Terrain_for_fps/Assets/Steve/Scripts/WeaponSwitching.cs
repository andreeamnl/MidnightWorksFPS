using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    public GameObject[]  arms;
    // Start is called before the first frame update
    void Start()
    {   
        arms[1].gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeWeapon();
    }

    void ChangeWeapon(){

        if(Input.GetKey(KeyCode.Alpha1)){
            arms[0].SetActive(true);
            arms[1].SetActive(false);
        }else if(Input.GetKey(KeyCode.Alpha2)){
            arms[0].SetActive(false);
            arms[1].SetActive(true);
        }

        

    }
}
