using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public GameObject score_label;
    float timer;

    // Update is called once per frame
    void Update()
    {
        timer = Time.time;
        score_label.GetComponent<Text>().text = Mathf.Round(timer).ToString();
    }
}
