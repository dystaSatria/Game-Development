using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("Timer")]
    public float countDownTimer = 5f;

    [Header("Things to stop")]
    public PlayerCarController playerCarController;
    public OpponentCar opponentCar;
    public OpponentCar opponentCar1;

    public TextMeshProUGUI countDownText;

    void Start()
    {
        StartCoroutine(TimeCount());
    }

    void Update()
    {
        if (countDownTimer > 1)
        {
            playerCarController.accelerationForce = 0f;
            opponentCar.movingSpeed = 0f;
            opponentCar1.movingSpeed = 0f;
        }
        else if (countDownTimer == 0)
        {
            playerCarController.accelerationForce = 300f;
            opponentCar.movingSpeed = 12f;
            opponentCar1.movingSpeed = 13f;
        }
    }

    IEnumerator TimeCount()
    {
        while (countDownTimer > 0)
        {
            countDownText.text = countDownTimer.ToString();
            yield return new WaitForSeconds(1f);
            countDownTimer--;
        }

        countDownText.text = "GO";
        yield return new WaitForSeconds(1f);
        countDownText.gameObject.SetActive(false);
    }
}
