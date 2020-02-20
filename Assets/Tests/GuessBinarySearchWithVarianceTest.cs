using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NSubstitute;

namespace Tests {
    public class GuessBinarySearchWithVarianceTest {
        [Test]
        public void should_guess_1000_correctly() {
            IGuessBinarySearch gbs = new GuessBinarySearchWithVariance(1, 1000);

            for (int i = 0; i < 10; i++) {
                gbs.guess();
                gbs.feedbackGuessWasLow();
            }

            Assert.AreEqual(gbs.guess(), 1000);
        }

        [Test]
        public void should_apply_variance_up_to_5_percent() {
            System.Random random = Substitute.For<System.Random>();
            IGuessBinarySearch gbs = new GuessBinarySearchWithVariance(1, 1000, random);

            random.NextDouble().Returns(0.9999);
            random.Next(2).Returns(0);

            int guess = gbs.guess();

            Assert.AreEqual(guess, 450);
        }
    }
}
