using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    [SerializeField] private TextMeshProUGUI textGoal;
    [SerializeField] private int goal;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    
    void Start()
    {
        textGoal.SetText(goal.ToString());
    }
    
    void Update()
    {
        
    }

    public void DecreaseGoal()
    {
        goal -= 1;
        textGoal.SetText(goal.ToString());
    }
}
