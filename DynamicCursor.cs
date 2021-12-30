using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicCrosshair : MonoBehaviour
{
    public GameObject crosshair;
    bool mouseOver = false;

    void OnTriggerEnter(Collider jennyCollider)
    {
        if(jennyCollider.GetComponent<Collider>().tag == "Player" && mouseOver == true)
        {
            crosshair.SetActive(true);
        }

        else
        {
            crosshair.SetActive(false);
        }
    }

    void OnTriggerExit(Collider jennyCollider)
    {
        crosshair.SetActive(false);
    }

    void OnMouseOver()
    {
        mouseOver = true;
    }

    void OnMouseExit()
    {
        mouseOver = false;
    }
}
