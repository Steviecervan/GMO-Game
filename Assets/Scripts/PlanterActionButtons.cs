using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanterActionButtons : MonoBehaviour
{

    public GameObject planterParent;
    public GameObject showPackets;

    // Start is called before the first frame update
    void Start()
    {
        planterParent = gameObject.transform.parent.gameObject;
        showPackets = planterParent.transform.GetChild(2).gameObject;
        showPackets.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void showDifferentPackets()
    {
        showPackets.SetActive(true);

        if (planterParent.activeInHierarchy == false)
        {
            showPackets.SetActive(false);
        }
    }
}
