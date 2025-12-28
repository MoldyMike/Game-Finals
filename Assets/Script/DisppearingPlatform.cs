using UnityEngine;
using System.Collections;

public class DisappearingPlatform : MonoBehaviour
{
    public float delayBeforeDisappear = 2f;

    private Collider solidCollider;
    private Collider triggerCollider;
    private Renderer platformRenderer;
    private bool triggered = false;

    void Start()
    {
        Collider[] colliders = GetComponents<Collider>();

        foreach (Collider col in colliders)
        {
            if (col.isTrigger)
                triggerCollider = col;
            else
                solidCollider = col;
        }

        platformRenderer = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (triggered) return;

        if (other.CompareTag("Player"))
        {
            triggered = true;
            StartCoroutine(Disappear());
        }
    }

    IEnumerator Disappear()
    {
        yield return new WaitForSeconds(delayBeforeDisappear);

        // Disable platform completely
        solidCollider.enabled = false;
        triggerCollider.enabled = false;
        platformRenderer.enabled = false;
    }
}