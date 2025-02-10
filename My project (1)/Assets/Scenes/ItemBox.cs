using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{   

    public bool isOveraped = false;
    public Color touchColor;
    private Color originalColor;
    private Renderer myRenderer;
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //OnTriggerExit 충돌했다가 분리 감지
    //OnTriggerStay 충돌하고있는 동안
    void OnTriggerEnter(Collider other) {

        if(other.tag == "Endpoint") {

            isOveraped = true;
            myRenderer.material.color = touchColor;
            //Debug.Log("You've reached to EndPoint!!");
        }
        
    }

    void OnTriggerExit(Collider other) {

        if(other.tag == "Endpoint") {
            
            isOveraped = false;
            myRenderer.material.color = originalColor;
        }
    }

    void OnTriggerStay(Collider other) {

        if(other.tag == "Endpoint") {

            isOveraped = true;
            myRenderer.material.color = touchColor;
        }
    }

    
}
