using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Turret : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [Header("References")]
    [SerializeField] private LayerMask enemyMask; 
    [Header("Attribute")]
    [SerializeField] private float targetingRange = 5f;

    private Transform target;

    private void Update() {
        if (target == null)
        {
            FindTarget();
            return;
        }
    }
       
        }
   
        
    

{
    RaycastHit2D[] hits = Physics2D.CircleCastAll(Transform.position, targetingRange, (Vector2)
    Transform.position, 0f, enemyMask);

    if (hits.Length > 0)
    {
        Target = hits[0].transform;
    }
}
    private void OnDrawGizmosSelected()
    {
        Handles.color = Color.cyan;
        Handles.DrawWireDisc(transform.position, transform.forward, targetingRange);
    }
}