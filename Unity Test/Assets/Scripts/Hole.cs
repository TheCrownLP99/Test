using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hole : MonoBehaviour
{
    public int points = 0;
    public TMPro.TMP_Text pointsText;

    // Update is called once per frame
    void Update()
    {
        pointsText.text = "Points: " + points;
    }

    private void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Metal")
        {
            points = points + 5;
        }

        if (target.tag == "Wood")
        {
            points = points + 1;
        }
    }
}
