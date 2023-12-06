using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelController : MonoBehaviour
{
    // Start is called before the first frame update
  public static FuelController instance;

    [SerializeField] private Image _fuelImage;
    [SerializeField,Range(0.1f, 5f)] private float _fuelDrainSpeed = 1f;
    [SerializeField] private float _maxFuelAmount = 100f;
    [SerializeField] private Gradient _fuelGradiant;


    private float _currentFuelAmount; 

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        _currentFuelAmount = _maxFuelAmount;
        UpdateUI();


    }
    private void Update() {
    
    _currentFuelAmount -= Time.deltaTime * _fuelDrainSpeed;
        UpdateUI();

        if (_currentFuelAmount <= 0f)
        {
            GameManager.instance.GameOver();
        }
    
    }

    private void UpdateUI()
    {
        _fuelImage.fillAmount = (_currentFuelAmount / _maxFuelAmount);
        _fuelImage.color = _fuelGradiant.Evaluate(_fuelImage.fillAmount);

    }
}
