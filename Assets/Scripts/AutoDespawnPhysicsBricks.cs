﻿using UnityEngine.XR.Interaction.Toolkit;
using System.Collections;
using UnityEngine;

public class AutoDespawnPhysicsBricks : MonoBehaviour
{
    private XRGrabInteractable _grabInteractable;

    private int despawnIndex;

    private Vector3 lastPosition;
    private int lastPositionCheckCount;

    // Start is called before the first frame update
    void Start()
    {
        _grabInteractable = GetComponent<XRGrabInteractable>();
        if (!_grabInteractable) return;

        StartCoroutine(DespawnProcess());
    }

    private IEnumerator DespawnProcess()
    {
        if (lastPositionCheckCount > 5 && this)
        {
            BrickStore.GetInstance().Delete(GetComponent<BrickAttach>().GetUuid());
            PlacedBrickCreator.DestroyBrickObject(gameObject);
            yield return null;
        }
        else
        {
            if (lastPosition == transform.position)
            {
                lastPositionCheckCount += 1;
            }
            else
            {
                lastPosition = transform.position;
                lastPositionCheckCount = 0;
            }

            yield return new WaitForSeconds(1);

            yield return DespawnProcess();
        }
    }
}
