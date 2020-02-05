using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collection : MonoBehaviour
{
    public Text money;
    public int remaining = 0;
    public GameObject panel;
    public void Start()
    {
        remaining = FindObjectsOfType<Coin>().Length;
        money.text = "coins remaining: " + remaining.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "COIN")
        {
            remaining--;
            money.text = "coins remaining: " + remaining.ToString();
            if (remaining <= 0)
            {
                panel.SetActive(true);
            }
            Destroy(other.gameObject);
        }
    }
} 