using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public GameObject exclamationMark;

    void Start()
    {
        if (exclamationMark != null)
        {
            exclamationMark.SetActive(false); // Ausrufezeichen zunächst verstecken
        }
        else
        {
            Debug.Log("Not assigned");
        }
    }

    void OnMouseOver()
    {
        Debug.Log("Mouse is over the object.");
        if (exclamationMark != null)
        {
            exclamationMark.SetActive(true); // Ausrufezeichen anzeigen, wenn der Mauszeiger über dem Objekt ist
        }
        else
        {
            Debug.Log("Something wrong");
        }
    }

    void OnMouseExit()
    {
        Debug.Log("Mouse exited the object.");
        if (exclamationMark != null)
        {
            exclamationMark.SetActive(false); // Ausrufezeichen verstecken, wenn der Mauszeiger das Objekt verlässt
        }
        else
        {
            Debug.Log("Something wrong");
        }
    }
}
