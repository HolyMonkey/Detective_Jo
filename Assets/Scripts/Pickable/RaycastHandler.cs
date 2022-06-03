using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastHandler : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(TryGetRayCastHit(out RaycastHit raycastHit))
                TryPickUp(raycastHit);
        }
    }

    private bool TryPickUp(RaycastHit raycastHit)
    {
        if (raycastHit.collider.TryGetComponent(out Pickable pickable))
            pickable.PickUp();

        return true;
    }

    private bool TryGetRayCastHit(out RaycastHit raycastHit)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out raycastHit))
            return true;

        return false;
    }
}
