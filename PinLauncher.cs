using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinLauncher : MonoBehaviour
{
    [SerializeField] private GameObject pinObject;
    private Pin _currentPin;
    void Start()
    {
        PreparePin();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && _currentPin != null)
        {
            _currentPin.Launch();
            _currentPin = null;
            Invoke(nameof(PreparePin), 0.1f);
        }
    }

    void PreparePin()
    {
        GameObject pin = Instantiate(pinObject, transform.position, Quaternion.identity);
        _currentPin = pin.GetComponent<Pin>();
    }
}
