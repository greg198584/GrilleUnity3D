using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateurZone : MonoBehaviour
{
    public GameObject Zone;
    
    // Start is called before the first frame update
    void Start()
    {
        APIGrid.GrilleManager.GetStatus();
        StartCoroutine("WaiBuild");
        //         int nbrZone  = 100;
        // for (int i = 0; i < nbrZone; i++)
        // {
        //     GameObject go = Instantiate(Zone, new Vector3(0, 0, i * 30), Quaternion.Euler(0,90,0));
        //     go.transform.parent = transform;
        //     go.name = "zone_" + i;
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    IEnumerator WaiBuild()
    {
        int nbrZone  = 100;
        for (int i = 0; i < nbrZone; i++)
        {
            GameObject go = Instantiate(Zone, new Vector3(-0, 0, i * 30), Quaternion.Euler(0,90,0));
            go.transform.parent = transform;
            go.name = "zone_" + i;
            yield return new WaitForSeconds(0.600f);
        }

    }
}
