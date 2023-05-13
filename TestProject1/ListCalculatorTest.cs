using TestClassLibrary;

namespace TestProject1
{
    public class ListCalculatorTest
    {
        private const string SadekWord = "SADEK";
        private const string BuzzWord = "BUZZ";
        private const string FizzWord = "FIZZ";

        [Fact]
        public void Test_ListLength()
        {
            // create instance 
            var instance = new Test();
            Assert.NotNull(instance);
            //define params
            var pairEntities = new List<PairEntity>
            {
                new PairEntity { Number = 10, Word = SadekWord },
                new PairEntity { Number = 5, Word = BuzzWord},
                new PairEntity { Number = 3, Word = FizzWord }
            };
            int listCount = 15;
            var result = instance.ListCalculator(listCount, pairEntities).ToList();

            foreach (var pairEntity in pairEntities)
            {
                Assert.True(result.Count(x => x == pairEntity.Word || x.Split(",").Select(p => p.Trim()).ToList().Contains(pairEntity.Word)) > 0);
            }

        }

        [Fact]
        public void Test_ValidateLogicCaseOne()
        {
            // create instance 
            var instance = new Test();
            Assert.NotNull(instance);
            // define params
            var pairEntities = new List<PairEntity>
            {
                new PairEntity { Number = 15, Word = SadekWord },
                new PairEntity { Number = 5, Word = BuzzWord },
                new PairEntity { Number = 3, Word = FizzWord }
            };
            int listCount = 7;
            var result = instance.ListCalculator(listCount, pairEntities).ToList();
            Assert.True(result.Count(x => x == FizzWord) == 2);
            Assert.True(result.Count(x => x == BuzzWord) == 1);
            Assert.True(result.Count(x => x == SadekWord) == 0);

        }

        [Fact]
        public void Test_ValidateLogicCaseTwo()
        {
            // create instance 
            var instance = new Test();
            Assert.NotNull(instance);
            // define params
            var pairEntities = new List<PairEntity>
            {
                new PairEntity { Number = 15, Word = SadekWord },
                new PairEntity { Number = 5, Word = BuzzWord },
                new PairEntity { Number = 3, Word = FizzWord }
            };
            int listCount = 15;
            var result = instance.ListCalculator(listCount, pairEntities).ToList();
            Assert.True(result.Count(x => x == FizzWord || x.Split(",").Select(p => p.Trim()).ToList().Contains(FizzWord)) == 5);
            Assert.True(result.Count(x => x == BuzzWord || x.Split(",").Select(p => p.Trim()).ToList().Contains(BuzzWord)) == 3);
            Assert.True(result.Count(x => x == SadekWord || x.Split(",").Select(p => p.Trim()).ToList().Contains(SadekWord)) == 1);
        }
    }
}