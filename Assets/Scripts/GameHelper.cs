using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class GameHelper {
    private int _low;
    private int _high;
    private int lastGuess;

    public void initialise(int low, int high) {
        _low = low;
        _high = high;
    }

    public int guess() {
        return _calculateGuess();
    }

    private int _calculateGuess() {
        int[] nums = { _low, _high };
        int average = (int)nums.Average();
        return average;
    }

    public void feedbackGuessWasLow() {
        _low = _calculateGuess() + 1;
    }

    public void feedbackGuessWasHigh() {
        _high = _calculateGuess() - 1;
    }
}
