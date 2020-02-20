using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GuessBinarySearchWithVariance : IGuessBinarySearch {
    private int _low;
    private int _high;
    private int _lastGuess;
    private System.Random _random;
    public GuessBinarySearchWithVariance(int low, int high) {
        _low = low;
        _high = high;
        _random = new System.Random();
    }
    public GuessBinarySearchWithVariance(int low, int high, System.Random random) {
        _low = low;
        _high = high;
        _random = random;
    }

    public int guess() {
        int average = _getAverage();
        int variance = _getVariance();
        int guess = average + variance;
        _lastGuess = guess;
        return guess;
    }

    private int _getAverage() {
        int[] nums = { _low, _high };
        int average = (int)nums.Average();
        return average;
    }

    private int _getVariance() {
        int range = _high - _low;
        double maxVariance = range * 0.05;

        int[] signs = { -1, 1 };
        int signMultiplier = signs[_random.Next(2)];

        double varianceMultiplier = _random.NextDouble();

        return Convert.ToInt32(maxVariance * varianceMultiplier * signMultiplier);
    }

    public void feedbackGuessWasLow() {
        _low = _lastGuess + 1;
    }

    public void feedbackGuessWasHigh() {
        _high = _lastGuess - 1;
    }
}
