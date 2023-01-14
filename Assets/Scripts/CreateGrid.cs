using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGrid : MonoBehaviour
{
    public GameObject cellPrefab;

    public int gridSize = 10;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < gridSize; i++)
        {
            for (int j = 0; j < gridSize; j++)
            {
                GameObject go = Instantiate(cellPrefab, new Vector3(i, 0, j),Quaternion.Euler(90,0,0));
                go.transform.parent = transform;
                go.name += "_" + i + "-" + j;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
