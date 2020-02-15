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
            int guess = 1;

            GameHelper gameHelper = new GameHelper();
            gameHelper.initialise(1, 1000);
            int result = gameHelper.guess();

            Assert.AreEqual(result, guess);
        }

        [Test]
        public void gameHelper_can_find_guess_2_with_numbers_1_to_1000() {
            int guess = 2;

            GameHelper gameHelper = new GameHelper();
            gameHelper.initialise(1, 1000);
            int result = gameHelper.guess();
            gameHelper.feedbackGuessWasLow();
            result = gameHelper.guess();

            Assert.AreEqual(result, guess);
        }
    }
}
