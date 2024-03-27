using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class Turret : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform turretRotationPoint;
    
    [Header("Attribute")]
    [SerializeField] private float targetingRange = 5f;

    private Transform target;

    private void Update()
    {
        if (target == null)
        {
            FindTarget();
        }
    }
    private void OnDrawGizmosSelected()
    {
        Handles.color = Color.cyan;
        Handles.DrawWireDisc(transform.position, transform.forward, targetingRange);
    }
}
