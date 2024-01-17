using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wait : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait_Intro());
    }

    IEnumerator Wait_Intro()
    {
        yield return new WaitForSeconds(40);

        SceneManager.LoadScene(1);
    }
}
