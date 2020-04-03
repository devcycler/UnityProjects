using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Interactable focus;
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        CustomInteract();
    }


    void CustomInteract()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Debug.DrawRay(transform.position + new Vector3(0f, 1.5f, 0f), transform.forward, Color.green);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                Interactable _interactable = hit.collider.GetComponent<Interactable>();
                if (_interactable != null)
                {
                    SetFocus(_interactable);
                    if (_interactable.tag == "Throne")
                    {
                        ThroneManager.singleton.ThroneMenuOn();
                    }
                }
                else
                {
                    //BUG - clicking a button in the menu currently activates this line! 15May2019
                    //RemoveFocus();
                    //ThroneManager.singleton.ThroneMenuOff();
                }
            }
        }
    }


    void SetFocus(Interactable newFocus)
    {
        focus = newFocus;
    }

    void RemoveFocus()
    {
        focus = null;
    }
}
