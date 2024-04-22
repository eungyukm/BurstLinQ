using System;
using System.Linq;
using System.Runtime.InteropServices;
using NUnit.Framework;
using Unity.PerformanceTesting;
using UnityEngine;
using Assert = UnityEngine.Assertions.Assert;
using Random = UnityEngine.Random;

namespace BurstLinq.Tests
{
    public class ContainsTest
    {
        const int IterationCount = 10000;

        [SetUp]
        public void SetUp()
        {
            Random.InitState((int)DateTime.Now.Ticks);
        }
        // Test_Contains_Int_List (0.260s)
        [Test, Performance]
        public void Test_Contains_Int_List()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var list = RandomEnumerable.RepeatInt(0, 100, 1000).ToList();
                var value = Random.Range(0, 2) == 0 ? 50 : -1;

                var result1 = Enumerable.Contains(list, value);
            }
        }
        // Test_Contains_Int_List_Burst (0.262s)
        [Test, Performance]
        public void Test_Contains_Int_List_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var list = RandomEnumerable.RepeatInt(0, 100, 1000).ToList();
                var value = Random.Range(0, 2) == 0 ? 50 : -1;
                
                var result2 = BurstLinqExtensions.Contains(list, value);
            }
        }
        
        [Test, Performance]
        public void Test_Contains_Int_List_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var list = RandomEnumerable.RepeatInt(0, 100, 1000).ToList();
                var value = Random.Range(0, 2) == 0 ? 50 : -1;

                var result1 = Enumerable.Contains(list, value);
                var result2 = BurstLinqExtensions.Contains(list, value);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Contains_Int_Array (0.209s)
        [Test, Performance]
        public void Test_Contains_Int_Array()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatInt(0, 100, 100).ToArray();
                var value = Random.Range(0, 2) == 0 ? 50 : -1;

                var result1 = Enumerable.Contains(array, value);
            }
        }
        // Test_Contains_Int_Array_Burst (0.177s)
        [Test, Performance]
        public void Test_Contains_Int_Array_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatInt(0, 100, 100).ToArray();
                var value = Random.Range(0, 2) == 0 ? 50 : -1;
                
                var result2 = BurstLinqExtensions.Contains(array, value);
            }
        }
        // Test_Contains_Int_List_Burst (0.262s)
        [Test, Performance]
        public void Test_Contains_Int_Array_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatInt(0, 100, 100).ToArray();
                var value = Random.Range(0, 2) == 0 ? 50 : -1;

                var result1 = Enumerable.Contains(array, value);
                var result2 = BurstLinqExtensions.Contains(array, value);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Contains_Float_Array (0.922s)
        [Test, Performance]
        public void Test_Contains_Float_Array()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatFloat(0f, 100f, 1000).ToArray();
                var value = Random.Range(0, 2) == 0 ? 50f : -1f;

                var result1 = Enumerable.Contains(array, value);
            }
        }
        // Test_Contains_Float_Array_Burst (0.426s)
        [Test, Performance]
        public void Test_Contains_Float_Array_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatFloat(0f, 100f, 1000).ToArray();
                var value = Random.Range(0, 2) == 0 ? 50f : -1f;
                
                var result2 = BurstLinqExtensions.Contains(array, value);
            }
        }
        
        [Test, Performance]
        public void Test_Contains_Float_Array_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatFloat(0f, 100f, 1000).ToArray();
                var value = Random.Range(0, 2) == 0 ? 50f : -1f;

                var result1 = Enumerable.Contains(array, value);
                var result2 = BurstLinqExtensions.Contains(array, value);

                Assert.AreEqual(result1, result2);
            }
        }
    }
}