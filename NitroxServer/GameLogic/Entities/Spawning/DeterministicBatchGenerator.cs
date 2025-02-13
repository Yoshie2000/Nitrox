﻿using System;
using NitroxModel.DataStructures;

namespace NitroxServer.GameLogic.Entities.Spawning
{
    public class DeterministicBatchGenerator
    {
        private readonly Random random;

        public DeterministicBatchGenerator(string seed, NitroxInt3 batchId)
        {
            random = new Random(seed.GetHashCode() + batchId.GetHashCode());
        }

        public double NextDouble()
        {
            return random.NextDouble();
        }

        public int NextInt(int min, int max)
        {
            return random.Next(min, max);
        }

        public NitroxId NextId()
        {
            byte[] bytes = new byte[16];
            random.NextBytes(bytes);
            return new NitroxId(bytes);
        }
    }
}
