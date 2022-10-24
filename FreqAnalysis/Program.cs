﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreqAnalysis
{
    [MemoryDiagnoser]
    public class Program
    {

        public Program()
        {
            testFirst();
            testSecond();
            testThird();
        }


        static void Main(String[] args)
        {
            CharCounter3 counter = new CharCounter3();

            var summary = BenchmarkRunner.Run<Program>();
        }

        [Benchmark]
        public void testFirst()
        {
            CharCounter counter = new CharCounter();
        }

        [Benchmark]
        public void testSecond()
        {
            CharCounter2 counter = new CharCounter2();
        }

        [Benchmark]
        public void testThird()
        {
            CharCounter3 counter = new CharCounter3();
        }

    }

    
}