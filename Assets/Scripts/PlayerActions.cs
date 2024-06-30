using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private int attackDamage;
    [SerializeField] private float overlapDistance;
    [SerializeField] private float attackDistance;

    private void Update()
    {
        Movement();

        if (Input.GetKeyDown(KeyCode.R))
            Interact();

        if (Input.GetKeyDown(KeyCode.E))
            Attack();
    }

    private void Movement()
    {
        float xInput = Input.GetAxisRaw("Horizontal");

        Vector2 moveDirection = new(xInput, 0f);

        transform.Translate(moveSpeed * Time.deltaTime * moveDirection);
    }

    private void Interact()
    {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position, overlapDistance);         

        foreach (var hitCollider in hitColliders)
        {            
            hitCollider.GetComponent<IPresentacion>()?.Accion();            
        }
    }

    private void Attack()
    {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position, attackDistance);

        foreach (var hitCollider in hitColliders)
        {
            hitCollider.GetComponent<ITakeDamage>()?.TakeDamage(attackDamage);
        }
    }
}
