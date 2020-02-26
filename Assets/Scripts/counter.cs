using UnityEngine;
using UnityEngine.UI;

public class counter : MonoBehaviour
{
    public Transform playerT;
    public Text scoreDisplay;

    // Update is called once per frame
    void Update()
    {
        float score = playerT.position.z + 6f;
        scoreDisplay.text = score.ToString("0");
    }
}