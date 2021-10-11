namespace Model.Domain.Parsers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class MovesParser
    {
        public static IEnumerable<char> Parse(string moves)
            => moves.Split(",").Select(s=>char.Parse(s));
    }
}
