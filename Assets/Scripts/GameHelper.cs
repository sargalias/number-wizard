using System.Collections;
using System.Collections.Generic;

public class GameHelper {
    private int _low;
    private int _high;
    private int nextGuess;

    public void initialise(int low, int high) {
        _low = low;
        _high = high;
        nextGuess = 1;
    }

    public void feedbackGuessWasLow() {
        nextGuess = 2;
    }

    public int guess() {
        return nextGuess;
    }
}
