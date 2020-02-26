using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public GameObject panel;
    private int level = 1;

    public void Levelcomplete()
    {
        else
        {
        panel.SetActive(true);
        level += 1;
        }
    }
}