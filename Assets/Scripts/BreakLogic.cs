using System;
using System.Collections;
using UnityEngine;

public class BreakLogic : MonoBehaviour
{
    [SerializeField] private GameObject bTarget;
    [SerializeField] private UI playerUI;
    private MeshRenderer target;

    private void Awake()
    {
        target = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet") && target.enabled)
        {
            var sTarget = Instantiate(bTarget, transform.position, transform.rotation);
            Destroy(sTarget, 3);
            target.enabled = false;
            playerUI.UpdateUI();
            StartCoroutine(ReenableMeshRenderer());
        }
    }

    IEnumerator ReenableMeshRenderer()
    {
        yield return new WaitForSeconds(3);
        target.enabled = true;
    }
}
