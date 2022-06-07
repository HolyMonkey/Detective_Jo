using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastHandler : MonoBehaviour
{
    public bool TryPickUp()
    {
        if (TryGetRayCastHit(out RaycastHit raycastHit))
        {
            if (TryPickUp(raycastHit))
                return true;
        }

        return false;
    }

    private bool TryPickUp(RaycastHit raycastHit)
    {
        if (raycastHit.collider.TryGetComponent(out Pickable pickable))
        {
            pickable.PickUp();
            return true;
        }

        return false;
    }

    private bool TryGetRayCastHit(out RaycastHit raycastHit)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out raycastHit))
            return true;

        return false;
    }
}
