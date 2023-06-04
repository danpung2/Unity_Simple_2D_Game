using System;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private const String TargetTag = "Target";
    private const String PinLineTag = "Square";
    private const String PinTag = "Pin";
    
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
        if (other.gameObject.CompareTag(TargetTag))
        {
            GameObject pinLineObject = transform.Find(PinLineTag).gameObject;
            SpriteRenderer pinLineSpriteRenderer = pinLineObject.GetComponent<SpriteRenderer>();
            pinLineSpriteRenderer.enabled = true;
            transform.SetParent(other.gameObject.transform);

            GameManager.Instance.DecreaseGoal();
        } else if (other.gameObject.CompareTag(PinTag))
        {
            GameManager.Instance.SetGameOver(false);
        }
    }

    public void Launch()
    {
        _isLaunched = true;
    }
}
