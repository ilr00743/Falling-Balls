using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private TMP_Text _scoreText;
    private int _value;

    private void Awake()
    {
        _scoreText = GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        EventsHolder.Hit += OnHit;
    }

    private void OnHit(int value)
    {
        Debug.Log(value);
        _value += value;
        _scoreText.SetText($"Score: {_value}");
    }

    private void OnDisable()
    {
        EventsHolder.Hit -= OnHit;
    }
}
