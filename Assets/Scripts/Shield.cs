using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    [SerializeField] private GameObject shield;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) )
        {
            if(shield.activeSelf)
            {
                shield.SetActive(false);
            }
            else
            {
                shield.SetActive(true);
            }
            
        }
    }
}
