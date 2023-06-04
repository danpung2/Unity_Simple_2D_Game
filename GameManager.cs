using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    public bool isGameOver;

    [SerializeField] private TextMeshProUGUI textGoal;
    [SerializeField] public int goal;

    [SerializeField] private Color green;
    [SerializeField] private Color red;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        isGameOver = false;
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

        if (goal <= 0)
        {
            SetGameOver(true);
        }
    }

    public void SetGameOver(bool success)
    {
        if (isGameOver == false)
        {
            isGameOver = true;

            if (Camera.main != null) Camera.main.backgroundColor = success ? green : red;
        }
    }
}
