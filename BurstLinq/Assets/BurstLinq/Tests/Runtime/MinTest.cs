using System;
using System.Linq;
using NUnit.Framework;
using Unity.PerformanceTesting;
using Assert = UnityEngine.Assertions.Assert;
using Random = UnityEngine.Random;

namespace BurstLinq.Tests
{
    public class MinTest
    {
        const int IterationCount = 10000;
        
        [SetUp]
        public void SetUp()
        {
            Random.InitState((int)DateTime.Now.Ticks);
        }
        // Test_List (0.633s)
        [Test, Performance]
        public void Test_List()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var list = RandomEnumerable.RepeatInt(0, 100, 1000).ToList();

                var result1 = Enumerable.Min(list);
            }
        }
        // Test_List_Burst (0.563s)
        [Test, Performance]
        public void Test_List_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var list = RandomEnumerable.RepeatInt(0, 100, 1000).ToList();
                
                var result2 = BurstLinqExtensions.Min(list);
            }
        }
        
        [Test, Performance]
        public void Test_List_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var list = RandomEnumerable.RepeatInt(0, 100, 1000).ToList();

                var result1 = Enumerable.Min(list);
                var result2 = BurstLinqExtensions.Min(list);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Byte (0.726s)
        [Test, Performance]
        public void Test_Array_Byte()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatByte(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
            }
        }
        // Test_Array_Byte_Burst (0.510s)
        [Test, Performance]
        public void Test_Array_Byte_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatByte(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Min(array);
            }
        }
        [Test, Performance]
        public void Test_Array_Byte_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatByte(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_SByte (0.794s)
        [Test, Performance]
        public void Test_Array_SByte()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatSByte(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
            }
        }
        // Test_Array_SByte_Burst (0.629s)
        [Test, Performance]
        public void Test_Array_SByte_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatSByte(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Min(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_SByte_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatSByte(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Short (0.786s)
        [Test, Performance]
        public void Test_Array_Short()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatShort(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
            }
        }
        // Test_Array_Short_Burst (0.589s)
        [Test, Performance]
        public void Test_Array_Short_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatShort(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Min(array);
            }
        }

        
        [Test, Performance]
        public void Test_Array_Short_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatShort(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_UShort (0.772s)
        [Test, Performance]
        public void Test_Array_UShort()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatUShort(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
            }
        }
        // Test_Array_UShort_Burst (0.596s)
        [Test, Performance]
        public void Test_Array_UShort_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatUShort(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Min(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_UShort_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatUShort(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Int (0.657s)
        [Test, Performance]
        public void Test_Array_Int()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatInt(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Int_Burst (0.637s)
        [Test, Performance]
        public void Test_Array_Int_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatInt(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Int_Burst (0.637s)
        [Test, Performance]
        public void Test_Array_Int_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatInt(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_UInt (0.790s)
        [Test, Performance]
        public void Test_Array_UInt()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatUInt(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
            }
        }
        // Test_Array_UInt_Burst (0.590s)
        [Test, Performance]
        public void Test_Array_UInt_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatUInt(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Min(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_UInt_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatUInt(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Long (0.735s)
        [Test, Performance]
        public void Test_Array_Long()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatLong(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
            }
        }
        // Test_Array_Long_Burst (0.582s)
        [Test, Performance]
        public void Test_Array_Long_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatLong(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Min(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Long_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatLong(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_ULong (0.764s)
        [Test, Performance]
        public void Test_Array_ULong()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatULong(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
            }
        }
        // Test_Array_ULong_Burst (0.656s)
        [Test, Performance]
        public void Test_Array_ULong_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatULong(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Min(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_ULong_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatULong(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Float (1.031s)
        [Test, Performance]
        public void Test_Array_Float()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatFloat(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
            }
        }
        // Test_Array_Float_Burst (0.783s)
        [Test, Performance]
        public void Test_Array_Float_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatFloat(0, 100, 1000).ToArray();
                var result2 = BurstLinqExtensions.Min(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Float_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatFloat(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Double (0.838s)
        [Test, Performance]
        public void Test_Array_Double()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatDouble(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
            }
        }
        // Test_Array_Double_Burst (0.656s)
        [Test, Performance]
        public void Test_Array_Double_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatDouble(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Min(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Double_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatDouble(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }
    }
}