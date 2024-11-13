using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectFalsePlatforms : MonoBehaviour
{
    private bool hit;
    public Text detectText;

    void Update()
    {
        hit = Physics.Raycast(transform.position, transform.forward, 2f, 1<<8);
        Debug.DrawRay(transform.position, transform.forward * 2f, Color.red);
        if (hit) detectText.text = "Be careful!"; 
        else detectText.text = "Safe";
    }
}
