using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedButtonManager : MonoBehaviour
{
    public void OnMouseDown(){
        GameManager.instance.isPressed = true;
    }
 
    public void OnMouseUp(){
        GameManager.instance.isPressed = false;
    }
}
