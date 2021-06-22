using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;

namespace KM01
{
    [Binding]
    public sealed class PredictViralEscapeSteps
    {
        private readonly ScenarioContext _scenarioContext;

        private readonly ViralEscapeModel _ViralEscapeModel = new ViralEscapeModel();

        public PredictViralEscapeSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"viral evolution generates the following structral patterns of sequence data:")]
        public void GivenViralEvolutionGeneratesTheFollowingStructralPatternsOfSequenceData(Table table)
        {
            var StructralPatterns = table.CreateSet<StructralPattern>();
            _scenarioContext.Add("StructralPatterns", StructralPatterns);
        }

        [When(@"the structral patterns of sequence data are predicted")]
        public void WhenTheStructralPatternsOfSequenceDataArePredicted()
        {
            var StructralPatterns = _scenarioContext["StructralPatterns"] as IEnumerable<StructralPattern>;
            List<string> list = new List<string>();
            //list.Add("Prediction Result");
            foreach (var item in StructralPatterns)
            {
                string res = _ViralEscapeModel.Predict(item);
                list.Add(res);
            }
            _scenarioContext.Add("PredictionResult", list.AsEnumerable());
        }

        [Then(@"the prediction result should be as follows:")]
        public void ThenThePredictionResultShouldBeAsFollows(Table table)
        {
            var ExpectedResults = table.Rows.Select(r => r[0]).ToArray();
            var PredictionResult = _scenarioContext["PredictionResult"] as IEnumerable<string>;
            Assert.IsTrue(ExpectedResults.SequenceEqual(PredictionResult));
        }

        //[Then(@"it should match")]
        //public void ThenItShouldMatch(Table table)
        //{
        //    var collection = _scenarioContext["Collection"] as IEnumerable<Item>;
        //    Assert.IsTrue(table.RowCount == collection.Count() && table.ToProjection<Item>().Except(collection.ToProjection()).Count() == 0);
        //}

        //[Then(@"it should exactly match")]
        //public void ThenItShouldExactlyMatch(Table table)
        //{
        //    var collection = _scenarioContext["Collection"] as IEnumerable<Item>;
        //    Assert.IsTrue(table.ToProjection<Item>().SequenceEqual(collection.ToProjection()));
        //}

        //[Then(@"it should not match")]
        //public void ThenItShouldNotMatch(Table table)
        //{
        //    var collection = _scenarioContext["Collection"] as IEnumerable<Item>;
        //    Assert.IsFalse(table.RowCount == collection.Count() && table.ToProjection<Item>().Except(collection.ToProjection()).Count() == 0);
        //}

        //[Then(@"it should not exactly match")]
        //public void ThenItShouldNotExactlyMatch(Table table)
        //{
        //    var collection = _scenarioContext["Collection"] as IEnumerable<Item>;
        //    Assert.IsFalse(table.ToProjection<Item>().SequenceEqual(collection.ToProjection()));
        //}

        //[Then(@"it should contain all items")]
        //public void ThenItShouldContainAllItems(Table table)
        //{
        //    var collection = _scenarioContext["Collection"] as IEnumerable<Item>;
        //    Assert.IsTrue(table.ToProjection<Item>().Except(collection.ToProjection()).Count() == 0);
        //}

        //[Then(@"it should not contain all items")]
        //public void ThenItShouldNotContainAllItems(Table table)
        //{
        //    var collection = _scenarioContext["Collection"] as IEnumerable<Item>;
        //    Assert.IsFalse(table.ToProjection<Item>().Except(collection.ToProjection()).Count() == 0);
        //}

        //[Then(@"it should not contain any of items")]
        //public void ThenItShouldNotContainAnyOfItems(Table table)
        //{
        //    var collection = _scenarioContext["Collection"] as IEnumerable<Item>;
        //    Assert.IsTrue(table.ToProjection<Item>().Except(collection.ToProjection()).Count() == table.RowCount);
        //}

    }
}



