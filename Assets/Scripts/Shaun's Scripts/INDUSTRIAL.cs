using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INDUSTRIAL : MonoBehaviour
{   
    public GameObject canvas;
  
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }

    public void loadcanvas()
    {
        canvas.SetActive(true);
    }
}
