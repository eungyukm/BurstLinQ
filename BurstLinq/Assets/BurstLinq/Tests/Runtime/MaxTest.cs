using System;
using System.Linq;
using NUnit.Framework;
using Unity.PerformanceTesting;
using Assert = UnityEngine.Assertions.Assert;
using Random = UnityEngine.Random;

namespace BurstLinq.Tests
{
    public class MaxTest
    {
        const int IterationCount = 10000;
        
        [SetUp]
        public void SetUp()
        {
            Random.InitState((int)DateTime.Now.Ticks);
        }
        // Test_List (0.302s)
        [Test, Performance]
        public void Test_List()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var list = RandomEnumerable.RepeatInt(0, 100, 1000).ToList();

                var result1 = Enumerable.Max(list);
            }
        }
        // Test_List_Burst (0.258s)
        [Test, Performance]
        public void Test_List_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var list = RandomEnumerable.RepeatInt(0, 100, 1000).ToList();
                var result2 = BurstLinqExtensions.Max(list);
            }
        }
        
        [Test, Performance]
        public void Test_List_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var list = RandomEnumerable.RepeatInt(0, 100, 1000).ToList();

                var result1 = Enumerable.Max(list);
                var result2 = BurstLinqExtensions.Max(list);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Byte (0.355s)
        [Test, Performance]
        public void Test_Array_Byte()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatByte(0, 100, 1000).ToArray();

                var result1 = Enumerable.Max(array);
            }
        }
        // Test_Array_Byte_Burst (0.249s)
        [Test, Performance]
        public void Test_Array_Byte_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatByte(0, 100, 1000).ToArray();
                var result2 = BurstLinqExtensions.Max(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Byte_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatByte(0, 100, 1000).ToArray();

                var result1 = Enumerable.Max(array);
                var result2 = BurstLinqExtensions.Max(array);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_SByte (0.369s)
        [Test, Performance]
        public void Test_Array_SByte()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatSByte(0, 100, 1000).ToArray();

                var result1 = Enumerable.Max(array);
            }
        }
        // Test_Array_SByte_Burst (0.252s)
        [Test, Performance]
        public void Test_Array_SByte_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatSByte(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Max(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_SByte_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatSByte(0, 100, 1000).ToArray();

                var result1 = Enumerable.Max(array);
                var result2 = BurstLinqExtensions.Max(array);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Short (0.346s)
        [Test, Performance]
        public void Test_Array_Short()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatShort(0, 100, 1000).ToArray();

                var result1 = Enumerable.Max(array);
            }
        }
        // Test_Array_Short_Burst (0.279s)
        [Test, Performance]
        public void Test_Array_Short_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatShort(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Max(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Short_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatShort(0, 100, 1000).ToArray();

                var result1 = Enumerable.Max(array);
                var result2 = BurstLinqExtensions.Max(array);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_UShort (0.353s)
        [Test, Performance]
        public void Test_Array_UShort()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatUShort(0, 100, 1000).ToArray();

                var result1 = Enumerable.Max(array);
            }
        }
        // Test_Array_UShort_Burst (0.255s)
        [Test, Performance]
        public void Test_Array_UShort_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatUShort(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Max(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_UShort_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatUShort(0, 100, 1000).ToArray();

                var result1 = Enumerable.Max(array);
                var result2 = BurstLinqExtensions.Max(array);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Int (0.318s)
        [Test, Performance]
        public void Test_Array_Int()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatInt(0, 100, 1000).ToArray();

                var result1 = Enumerable.Max(array);
            }
        }
        // Test_Array_Int_Busrt (0.260s)
        [Test, Performance]
        public void Test_Array_Int_Busrt()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatInt(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Max(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Int_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatInt(0, 100, 1000).ToArray();

                var result1 = Enumerable.Max(array);
                var result2 = BurstLinqExtensions.Max(array);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_UInt (0.362s)
        [Test, Performance]
        public void Test_Array_UInt()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatUInt(0, 100, 1000).ToArray();

                var result1 = Enumerable.Max(array);
            }
        }
        // Test_Array_UInt_Burst (0.259s)
        [Test, Performance]
        public void Test_Array_UInt_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatUInt(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Max(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_UInt_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatUInt(0, 100, 1000).ToArray();

                var result1 = Enumerable.Max(array);
                var result2 = BurstLinqExtensions.Max(array);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Long (0.368s)
        [Test, Performance]
        public void Test_Array_Long()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatLong(0, 100, 1000).ToArray();

                var result1 = Enumerable.Max(array);
            }
        }
        // Test_Array_Long_Burst (0.293s)
        [Test, Performance]
        public void Test_Array_Long_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatLong(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Max(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Long_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatLong(0, 100, 1000).ToArray();

                var result1 = Enumerable.Max(array);
                var result2 = BurstLinqExtensions.Max(array);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_ULong (0.366s)
        [Test, Performance]
        public void Test_Array_ULong()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatULong(0, 100, 1000).ToArray();

                var result1 = Enumerable.Max(array);
            }
        }
        // Test_Array_ULong_Burst (0.291s)
        [Test, Performance]
        public void Test_Array_ULong_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatULong(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Max(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_ULong_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatULong(0, 100, 1000).ToArray();

                var result1 = Enumerable.Max(array);
                var result2 = BurstLinqExtensions.Max(array);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Float (0.516s)
        [Test, Performance]
        public void Test_Array_Float()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatFloat(0, 100, 1000).ToArray();

                var result1 = Enumerable.Max(array);
            }
        }
        // Test_Array_Float_Burst (0.428s)
        [Test, Performance]
        public void Test_Array_Float_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatFloat(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Max(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Float_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatFloat(0, 100, 1000).ToArray();

                var result1 = Enumerable.Max(array);
                var result2 = BurstLinqExtensions.Max(array);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Double (0.400s)
        [Test, Performance]
        public void Test_Array_Double()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatDouble(0, 100, 1000).ToArray();

                var result1 = Enumerable.Max(array);
            }
        }
        // Test_Array_Double_Burst (0.331s)
        [Test, Performance]
        public void Test_Array_Double_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatDouble(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Max(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Double_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatDouble(0, 100, 1000).ToArray();

                var result1 = Enumerable.Max(array);
                var result2 = BurstLinqExtensions.Max(array);

                Assert.AreEqual(result1, result2);
            }
        }

    }
}