using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransicionDialogos : MonoBehaviour
{
    public Animator bossAnimator;
    private BossRun bossRunScript;

    private void Start()
    {
        // Obtén el script BossRun asociado al Animator
        bossRunScript = bossAnimator.GetComponent<BossRun>();
    }

    public void OnButtonPress()
    {
        if (bossRunScript != null)
        {
            // Llama al método BossRunUpdate en la instancia de BossRun
            bossRunScript.BossRunUpdate();
        }
    }
}