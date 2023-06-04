using System;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private const String Target = "Target";
    private const String PinLine = "Square";
    private bool _isPinned;
    private bool _isLaunched;
    
    [SerializeField] private float moveSpeed = 10f;
    void Start()
    {
        _isPinned = false;
        _isLaunched = false;
    }
    void FixedUpdate()
    {
        if (_isPinned == false && _isLaunched)
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

            GameManager.Instance.DecreaseGoal();
        }
    }

    public void Launch()
    {
        _isLaunched = true;
    }
}
