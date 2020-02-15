using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class GameHelper {
    private int _low;
    private int _high;

    public GameHelper(int low, int high) {
        _low = low;
        _high = high;
    }

    public int guess() {
        int[] nums = { _low, _high };
        int average = (int)nums.Average();
        return average;
    }

    public void feedbackGuessWasLow() {
        _low = guess() + 1;
    }

    public void feedbackGuessWasHigh() {
        _high = guess() - 1;
    }
}
