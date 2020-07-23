﻿using System;

namespace ShelbyRating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Letum Insurance Rating System Starting...");

            var engine = new RatingEngine();
            engine.Rate();

            if (engine.Rating > 0)
            {
                Console.WriteLine($"Rating: {engine.Rating}");
            }
            else
            {
                Console.WriteLine("No rating produced.");
            }

        }
    }
}
