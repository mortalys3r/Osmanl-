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
        // Eðer targetler bitmediyse
        if (!targetsFinished)
        {
            // Eðer ajan hedefine ulaþtýysa, bir sonraki hedefi ayarla
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

        // Eðer tüm targetler zaten tamamlanmýþsa, iþlemi sonlandýr
        if (currentTargetIndex >= target.Length)
        {
            targetsFinished = true;
            ajan.isStopped = true; // Ajanýn hareketini durdur
            return;
        }

        // Ajanýn hedefini belirler
        ajan.destination = target[currentTargetIndex].position;
        currentTargetIndex++;
    }
}
