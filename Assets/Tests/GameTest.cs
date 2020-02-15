using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests {
    public class GameTest {
        [Test]
        public void gameHelper_can_find_guess_1_with_numbers_1_to_1000() {
            testChoiceNumber(1, 10);
        }

        [Test]
        public void gameHelper_can_find_guess_2_with_numbers_1_to_1000() {
            testChoiceNumber(2, 10);
        }

        [Test]
        public void gameHelper_can_find_guess_1000_with_numbers_1_to_1000() {
            testChoiceNumber(1000, 10);
        }

        private void testChoiceNumber(int num, int maxTries) {
            GameHelper gameHelper = new GameHelper();
            gameHelper.initialise(1, 1000);

            int guess = gameHelper.guess();
            int currentTry = 1;

            while (currentTry < maxTries && guess != num) {
                if (guess > num) gameHelper.feedbackGuessWasHigh();
                else gameHelper.feedbackGuessWasLow();
                currentTry++;
                guess = gameHelper.guess();
            }

            Assert.AreEqual(guess, num);
        }
    }
}
