using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayDistanceText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _distanceText;
    [SerializeField] private Transform _playerTrans;

    private Vector2 _startPosition;

    private void Start()
    {
        _startPosition = _playerTrans.position;
    }

    private void Update()
    {
        Vector2 distance = (Vector2)_playerTrans.position - _startPosition;
        distance.y = 0f;

        if(distance.x < 0)
        {
            distance.x = 0;
        }

        _distanceText.text = distance.x.ToString("F0") + "m";

    }

}
