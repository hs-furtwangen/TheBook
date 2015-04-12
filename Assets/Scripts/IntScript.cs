﻿using UnityEngine;

public class IntScript : MonoBehaviour
{
    private bool _active;
    private bool _talking;

    private GameObject _other;

    void Start()
    {
        _talking = false;
    }

    public void ShowBubble(GameObject other)
    {
        _active = true;
        _other = other;

        this.GetComponent<SpriteRenderer>().enabled = _active;
    }

    public void HideBubble()
    {
        _active = false;
        this.GetComponent<SpriteRenderer>().enabled = _active;
    }

    void Update()
    {
        if (!_active)
            return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _talking = true;
            Debug.Log("HELLO! HELLO! HEEEEELLLOOOO!");
        }

        if (_talking)
        {
            _other.GetComponent<Animator>().SetBool("Walk", false);
            _other.GetComponent<Animator>().SetBool("Talk", true);
        }
    }
}
