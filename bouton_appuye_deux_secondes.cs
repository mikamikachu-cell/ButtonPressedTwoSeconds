using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouton_appuye_deux_secondes : MonoBehaviour
{
    private bool buttonPressed= false;
    private float timeButtonPressed = 0.0f;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.X)){
            buttonPressed = true;
            timeButtonPressed = Time.time;
        }
        else if (Input.GetKeyUp(KeyCode.X)){
            buttonPressed = false;
            timeButtonPressed = 0.0f; 
        }
        else if (buttonPressed &&Time.time - timeButtonPressed>= 2.0f){
            Debug.Log("le bouton a été appuyé deux secondes");
        }
    }
}
