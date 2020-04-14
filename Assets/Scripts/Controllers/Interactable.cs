using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radious = 3f;
    bool isFocus = false;
    [SerializeField] Transform player;

    void Update()
    {
        if (isFocus)
        {
            float distance = Vector3.Distance(player.position, transform.position);
            if(distance <= radious)
            {
                Debug.Log("Interact");
            }
            else
            {
                OnDefocused();
            }

        }
    }
    public void OnFocused(Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;
    }
    public void OnDefocused()
    {
        isFocus = false;
        player = null;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radious);
    }

}
