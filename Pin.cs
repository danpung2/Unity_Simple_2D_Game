using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private const String target = "Target";
    private bool isPinned = false;
    [SerializeField] private float moveSpeed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPinned)
        {
            transform.position += Vector3.up * (moveSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        isPinned = true;
        if (other.gameObject.CompareTag(target))
        {
            transform.SetParent(other.gameObject.transform);
        }
    }
}
