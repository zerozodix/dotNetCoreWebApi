using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pop.BusinessLogic
{
    public class ValueGenerater
    {
        private static async Task<List<string>> GetDataValueFirst() => new List<string> {"abc", "defg"};

        private static async Task<List<string>> GetDataValueMiddle() => new List<string> {"hij", "lmno"};

        private static async Task<List<string>> GetDataValueLast() => new List<string> {"pqr", "stwv"};

        public async Task<List<string>> GetAllValue()
        {
            var result = (await Task.WhenAll(GetDataValueFirst(), GetDataValueMiddle(), GetDataValueLast())).SelectMany(item => item).ToList();
            return result;
        }
    }
}