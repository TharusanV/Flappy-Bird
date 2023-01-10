using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InTransition : MonoBehaviour
{
    float currentTime = 0f;
    float beginTime = 3f;
    [SerializeField] Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = beginTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        
        
    }
}
