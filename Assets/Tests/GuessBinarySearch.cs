using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests {
    public class GuessBinarySearchTest {
        [Test]
        public void guessBinarySearch_can_find_guess_1_with_numbers_1_to_1000() {
            testChoiceNumber(1, 10);
        }

        [Test]
        public void guessBinarySearch_can_find_guess_2_with_numbers_1_to_1000() {
            testChoiceNumber(2, 10);
        }

        [Test]
        public void guessBinarySearch_can_find_guess_1000_with_numbers_1_to_1000() {
            testChoiceNumber(1000, 10);
        }

        [Test]
        public void guessBinarySearch_can_find_guess_999_with_numbers_1_to_1000() {
            testChoiceNumber(999, 10);
        }

        [Test]
        public void guessBinarySearch_can_find_guess_5_with_numbers_1_to_1000() {
            testChoiceNumber(5, 10);
        }

        [Test]
        public void guessBinarySearch_can_find_guess_200_with_numbers_1_to_1000() {
            testChoiceNumber(200, 10);
        }

        private void testChoiceNumber(int num, int maxTries) {
            GuessBinarySearch guessBinarySearch = new GuessBinarySearch(1, 1000);

            int guess = guessBinarySearch.guess();
            int currentTry = 1;

            while (currentTry < maxTries && guess != num) {
                if (guess > num) guessBinarySearch.feedbackGuessWasHigh();
                else guessBinarySearch.feedbackGuessWasLow();
                currentTry++;
                guess = guessBinarySearch.guess();
            }

            Assert.AreEqual(guess, num);
        }
    }
}
