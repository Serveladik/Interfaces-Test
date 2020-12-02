using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    private Camera _camera;
    public float rayDistance;

    private void Start()
    {
        _camera = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
    }


    private void Update()
    {
        Interact();
    }


    private void Interact()
    {
        RaycastHit hit = new RaycastHit();
        var ray = _camera.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                var interactable = hit.transform.GetComponent<IInteract>();
                if (interactable != null)
                {
                    interactable.Interact();
                }
            }
        }
    }
}
