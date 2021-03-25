using System;
using System.Collections.Generic;
using System.Text;

namespace OMDbApiClient
{
    public class Movies
    {
        public List<MovieSearch> Search { get; set; }

        public Movies()
        {
            Search = new List<MovieSearch>();
        }
    }
}
