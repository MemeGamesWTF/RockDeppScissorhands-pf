using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startpanel : MonoBehaviour
{
    public GameObject StartPanel;
    public GameObject click1;
    public GameObject click3;
    public GameObject click2;
    public void StartGame()
    {
        StartPanel.SetActive(false);
        click1.SetActive(true);
        click2.SetActive(true);
        click3.SetActive(true);

    }
    // Start is called before the first frame update
    void Start()
    {
        click1.SetActive(false);
        click2.SetActive(false);
        click3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
