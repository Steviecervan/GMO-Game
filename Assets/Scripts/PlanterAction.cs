using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanterAction : MonoBehaviour
{

    public GameObject showPlanterAction;

    void Start()
    {
        Transform parentObject = gameObject.transform.parent.gameObject.transform;
        showPlanterAction = parentObject.GetChild(2).gameObject;
    }

    public void showActionBox()
    {
        showPlanterAction.SetActive(true);
    }

    public void closeActionBox()
    {
        showPlanterAction.SetActive(false);
    }
}
