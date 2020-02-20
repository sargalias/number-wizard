using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {
    [SerializeField]
    private Text text;

    private IGuessBinarySearch _gbs;
    void Start() {
        _gbs = new GuessBinarySearchWithVariance(1, 1000);
        updateUI();
    }

    public void onGuessWasLow() {
        _gbs.feedbackGuessWasLow();
        updateUI();
    }

    public void onGuessWasHigh() {
        _gbs.feedbackGuessWasHigh();
        updateUI();
    }

    private void updateUI() {
        int newGuess = _gbs.guess();
        text.text = Convert.ToString(newGuess);
    }
}
