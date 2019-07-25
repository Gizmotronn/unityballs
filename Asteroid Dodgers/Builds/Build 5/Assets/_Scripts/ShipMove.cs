using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipMove : MonoBehaviour
{
    public Text ScoreText;
    public Text WinText;

    private Rigidbody rb;
    private int score;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        SetScoreText();
        WinText.text = "";
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal") * 5;
        float v = Input.GetAxis("Vertical") * 5;

        Vector3 vel = rb.velocity;

        vel.x = h;
        vel.z = v;
        rb.velocity = vel;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            score = score + 1;
            SetScoreText();
        }

        if (other.gameObject.CompareTag("Asteroid"))
        {
            other.gameObject.SetActive(false);
            score = score - 1;
            SetScoreText();
        }
    }

    void SetScoreText ()
    {
        ScoreText.text = "Score: " +
            score.ToString();
                if (score >=5)
        {
            WinText.text = "You Win!";
            Application.LoadLevel("Level2Home");
        }
    }

}