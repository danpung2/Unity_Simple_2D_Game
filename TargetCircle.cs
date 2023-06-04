using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCircle : MonoBehaviour
{
    private const int DefaultAngle = 0;
    [SerializeField] private float rotateSpeed = -30f;

    void Start()
    {
        
    }

    void Update()
    {
        if (GameManager.Instance.isGameOver == false)
        {
            transform.Rotate(DefaultAngle, DefaultAngle, rotateSpeed * Time.deltaTime);    
        }
    }
}
