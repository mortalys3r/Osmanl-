using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class takip_sistemi : MonoBehaviour
{
    NavMeshAgent ajan;
    public Transform[] target;
    private int currentTargetIndex = 0;
    private bool targetsFinished = false;

    // Start is called before the first frame update
    void Start()
    {
        ajan = GetComponent<NavMeshAgent>();
        SetNextTarget();
    }

    // Update is called once per frame
    void Update()
    {
        // E�er targetler bitmediyse
        if (!targetsFinished)
        {
            // E�er ajan hedefine ula�t�ysa, bir sonraki hedefi ayarla
            if (!ajan.pathPending && ajan.remainingDistance < 0.1f)
            {
                SetNextTarget();
            }
        }
    }

    // Bir sonraki hedefi ayarlar
    void SetNextTarget()
    {
        if (target.Length == 0)
            return;

        // E�er t�m targetler zaten tamamlanm��sa, i�lemi sonland�r
        if (currentTargetIndex >= target.Length)
        {
            targetsFinished = true;
            ajan.isStopped = true; // Ajan�n hareketini durdur
            return;
        }

        // Ajan�n hedefini belirler
        ajan.destination = target[currentTargetIndex].position;
        currentTargetIndex++;
    }
}
