using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Camera camera;
    Interactable interactWith;
    void Start()
    {
        if (!camera)
            Debug.LogError("Set camera in Player Controller");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void checkRightButtonClick()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            LayerMask layer = 0;
            layer = LayerMask.NameToLayer("Interacable");
            if (layer == 0)
                Debug.LogError("Problem with layer");
            if (Physics.Raycast(ray, out hit, layer))
            {
                Interactable interactable  = hit.collider.GetComponent<Interactable>();
                if (!interactable)
                    Debug.LogError("no Interactable hit.");
                else
                {
                    SetFocusOn(interactable);
                }
            }
             
        }
    }

    void checkLeftButtonClick()
    {
        if (Input.GetKeyDown(0))
        {
            //atack
        }
    }
    void SetFocusOn(Interactable interactable)
    {
        interactWith = interactable;
    }
    void Removefocus()
    {
        interactWith = null;
    }
}
