using System;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private const String Target = "Target";
    private const String PinLine = "Square";
    private bool _isPinned;
    
    [SerializeField] private float moveSpeed = 10f;
    void Start()
    {
        _isPinned = false;
    }
    void Update()
    {
        if (_isPinned == false)
        {
            transform.position += Vector3.up * (moveSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        _isPinned = true;
        if (other.gameObject.CompareTag(Target))
        {
            GameObject pinLineObject = transform.Find(PinLine).gameObject;
            SpriteRenderer pinLineSpriteRenderer = pinLineObject.GetComponent<SpriteRenderer>();
            pinLineSpriteRenderer.enabled = true;
            transform.SetParent(other.gameObject.transform);
        }
    }
}
