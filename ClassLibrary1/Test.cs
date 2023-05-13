
namespace TestClassLibrary
{
    public class Test
    {
        public IEnumerable<string> ListCalculator(int count, List<PairEntity> pairEntities)
        {
            for (int i = 1; i <= count; i++)
            {
                var matchedPair = pairEntities.Where(pe => i % pe.Number == 0)
                                              .OrderBy(pe => pe.Number)
                                              .Select(pe => pe.Word);
                if (matchedPair.Any())
                { 
                    yield return String.Join(", ", matchedPair);
                }
                else
                {
                    yield return i.ToString();
                }
            }
        }
    }
}
