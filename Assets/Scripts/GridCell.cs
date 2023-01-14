using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCell : MonoBehaviour
{
    private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("Grid").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }
    
    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }

    private void OnMouseUp()
    {
        GameObject go = Instantiate(gm.building, transform.position + (Vector3.up/2), Quaternion.identity);
        go.name = "building_" + gameObject.name;
    }
}
