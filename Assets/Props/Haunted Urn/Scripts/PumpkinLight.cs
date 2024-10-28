using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinLight : MonoBehaviour
{
    public Light pumpkinLight;
    public float proximityThreshold = 5f; 

    // Start is called before the first frame update
    void Start()
    {
      if (pumpkinLight != null)
      {
        pumpkinLight.enabled = false; 
      }
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
        if (pumpkinLight != null && IsPlayerClose())
        {
         pumpkinLight.enabled = !pumpkinLight.enabled; 
        }
      }
    }

    bool IsPlayerClose()
    {
      GameObject player = GameObject.FindGameObjectWithTag("Player"); 
      if (player != null)
      {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        return distance <= proximityThreshold;
      }
      return false; 
    }
}