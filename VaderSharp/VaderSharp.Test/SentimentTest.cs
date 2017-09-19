using System;
using Xunit;
using VaderSharp.Domain;

namespace VaderSharp.Test
{
    public class SentimentTest
    {
        [Fact]
        public void GivenAPositiveSentence_WhenPolarityScores_ThenTheScoreIsPositive()
        {
            SentimentIntensityAnalyzer analyzer = new SentimentIntensityAnalyzer();

            var standardGoodTest = analyzer.CalculatePolarityScores("VADER is smart, handsome, and funny.");
            Assert.Equal(standardGoodTest.Negative, 0);
            Assert.Equal(standardGoodTest.Neutral, 0.254);
            Assert.Equal(standardGoodTest.Positive, 0.746);
            Assert.Equal(standardGoodTest.Compound, 0.8316);
        }

        [Fact]
        public void GivenANeutralSentence_WhenPolarityScores_ThenTheScoreIsNeutral()
        {
            SentimentIntensityAnalyzer analyzer = new SentimentIntensityAnalyzer();

            var kindOfTest = analyzer.CalculatePolarityScores("The book was kind of good.");
            Assert.Equal(kindOfTest.Negative, 0);
            Assert.Equal(kindOfTest.Neutral, 0.657);
            Assert.Equal(kindOfTest.Positive, 0.343);
            Assert.Equal(kindOfTest.Compound, 0.3832);
        }

        [Fact]
        public void GivenAComplexSentence_WhenPolarityScores_ThenTheScoreIsComplex()
        {
            SentimentIntensityAnalyzer analyzer = new SentimentIntensityAnalyzer();

            var complexTest =
                analyzer.CalculatePolarityScores(
                    "The plot was good, but the characters are uncompelling and the dialog is not great.");
            Assert.Equal(complexTest.Negative, 0.327);
            Assert.Equal(complexTest.Neutral, 0.579);
            Assert.Equal(complexTest.Positive, 0.094);
            Assert.Equal(complexTest.Compound, -0.7042);            
        }
    }
}
