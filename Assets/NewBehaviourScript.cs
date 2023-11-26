using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Color origCol;
    private Color hoverCol = Color.blue;
    private Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        origCol = rend.material.color; 
    }
    
    void OnMouseEnter()
    {
        rend.material.color = hoverCol;
    }

    void OnMouseExit()
    {
        rend.material.color = origCol;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
