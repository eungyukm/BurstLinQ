using System;
using System.Linq;
using NUnit.Framework;
using Unity.PerformanceTesting;
using Assert = UnityEngine.Assertions.Assert;
using Random = UnityEngine.Random;

namespace BurstLinq.Tests
{
    public class SequenceEqualTest
    {
        const int IterationCount = 10000;
        
        [SetUp]
        public void SetUp()
        {
            Random.InitState((int)DateTime.Now.Ticks);
        }

        [Test, Performance]
        public void Test_List()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var list1 = RandomEnumerable.RepeatInt(0, 2, 10).ToList();
                var list2 = RandomEnumerable.RepeatInt(0, 2, 10).ToList();

                var result1 = Enumerable.SequenceEqual(list1, list2);
            }
        }
        
        [Test, Performance]
        public void Test_List_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var list1 = RandomEnumerable.RepeatInt(0, 2, 10).ToList();
                var list2 = RandomEnumerable.RepeatInt(0, 2, 10).ToList();
                
                var result2 = BurstLinqExtensions.SequenceEqual(list1, list2);
            }
        }
        
        [Test, Performance]
        public void Test_List_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var list1 = RandomEnumerable.RepeatInt(0, 2, 10).ToList();
                var list2 = RandomEnumerable.RepeatInt(0, 2, 10).ToList();

                var result1 = Enumerable.SequenceEqual(list1, list2);
                var result2 = BurstLinqExtensions.SequenceEqual(list1, list2);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Byte (0.199s)
        [Test, Performance]
        public void Test_Array_Byte()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatByte(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatByte(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        // Test_Array_Byte_Burst (0.174s)
        [Test, Performance]
        public void Test_Array_Byte_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatByte(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatByte(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Byte_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatByte(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatByte(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_SByte (0.178s)
        [Test, Performance]
        public void Test_Array_SByte()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatSByte(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatSByte(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        // Test_Array_SByte_Burst (0.171s)
        [Test, Performance]
        public void Test_Array_SByte_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatSByte(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatSByte(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_SByte_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatSByte(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatSByte(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Short (0.174s)
        [Test, Performance]
        public void Test_Array_Short()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatShort(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatShort(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        // Test_Array_Short_Burst (0.175s)
        [Test, Performance]
        public void Test_Array_Short_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatShort(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatShort(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Short_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatShort(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatShort(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test, Performance]
        public void Test_Array_UShort()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatUShort(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatUShort(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        
        
        [Test, Performance]
        public void Test_Array_UShort_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatUShort(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatUShort(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        
        [Test, Performance]
        public void Test_Array_UShort_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatUShort(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatUShort(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Int (0.170s)
        [Test, Performance]
        public void Test_Array_Int()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatInt(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatInt(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        // Test_Array_Int_Burst (0.173s)
        [Test, Performance]
        public void Test_Array_Int_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatInt(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatInt(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Int_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatInt(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatInt(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_UInt (0.173s)
        [Test, Performance]
        public void Test_Array_UInt()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatUInt(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatUInt(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        // Test_Array_UInt_Burst (0.171s)
        [Test, Performance]
        public void Test_Array_UInt_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatUInt(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatUInt(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_UInt_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatUInt(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatUInt(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Long (0.178s)
        [Test, Performance]
        public void Test_Array_Long()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatLong(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatLong(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        // Test_Array_Long_Burst (0.175s)
        [Test, Performance]
        public void Test_Array_Long_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatLong(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatLong(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Long_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatLong(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatLong(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_ULong (0.172s)
        [Test, Performance]
        public void Test_Array_ULong()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatULong(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatULong(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        // Test_Array_ULong_Check (0.173s)
        [Test, Performance]
        public void Test_Array_ULong_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatULong(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatULong(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_ULong_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatULong(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatULong(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Float (0.179s)
        [Test, Performance]
        public void Test_Array_Float()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatFloat(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatFloat(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        // Test_Array_Float_Burst (0.176s)
        [Test, Performance]
        public void Test_Array_Float_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatFloat(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatFloat(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Float_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatFloat(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatFloat(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Double (0.172s)
        [Test, Performance]
        public void Test_Array_Double()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatDouble(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatDouble(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        // Test_Array_Double_Burst (0.173s)
        [Test, Performance]
        public void Test_Array_Double_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatDouble(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatDouble(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Double_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatDouble(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatDouble(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test, Performance]
        public void Test_Array_Vector2()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatVector2(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatVector2(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Vector2_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatVector2(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatVector2(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Vector2_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatVector2(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatVector2(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test, Performance]
        public void Test_Array_Vector2Int()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatVector2Int(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatVector2Int(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Vector2Int_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatVector2Int(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatVector2Int(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Vector2Int_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatVector2Int(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatVector2Int(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test, Performance]
        public void Test_Array_Vector3()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatVector3(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatVector3(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Vector3_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatVector3(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatVector3(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Vector3_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatVector3(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatVector3(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test, Performance]
        public void Test_Array_Vector3Int()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatVector3Int(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatVector3Int(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Vector3Int_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatVector3Int(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatVector3Int(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Vector3Int_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatVector3Int(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatVector3Int(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Vector4()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatVector4(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatVector4(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Vector4_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatVector4(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatVector4(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Vector4_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatVector4(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatVector4(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Int2 (0.177s)
        [Test, Performance]
        public void Test_Array_Int2()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatInt2(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatInt2(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        // Test_Array_Int2_Burst (0.176s)
        [Test, Performance]
        public void Test_Array_Int2_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatInt2(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatInt2(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Int2_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatInt2(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatInt2(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Int3 (0.179s)
        [Test, Performance]
        public void Test_Array_Int3()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatInt3(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatInt3(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        // Test_Array_Int3_Burst (0.182s)
        [Test, Performance]
        public void Test_Array_Int3_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatInt3(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatInt3(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Int3_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatInt3(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatInt3(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Int4 (0.182s)
        [Test, Performance]
        public void Test_Array_Int4()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatInt4(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatInt4(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        // Test_Array_Int4_Burst (0.185s)
        [Test, Performance]
        public void Test_Array_Int4_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatInt4(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatInt4(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        // 
        [Test, Performance]
        public void Test_Array_Int4_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatInt4(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatInt4(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_UInt2 (0.176s)
        [Test, Performance]
        public void Test_Array_UInt2()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatUInt2(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatUInt2(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        // Test_Array_UInt2_Burst (0.175s)
        [Test, Performance]
        public void Test_Array_UInt2_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatUInt2(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatUInt2(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_UInt2_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatUInt2(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatUInt2(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_UInt3 (0.178s)
        [Test, Performance]
        public void Test_Array_UInt3()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatUInt3(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatUInt3(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        // Test_Array_UInt3_Burst (0.178s)
        [Test, Performance]
        public void Test_Array_UInt3_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatUInt3(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatUInt3(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_UInt3_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatUInt3(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatUInt3(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_UInt4 (0.180s)
        [Test, Performance]
        public void Test_Array_UInt4()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatUInt4(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatUInt4(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        // Test_Array_UInt4_Burst (0.180s)
        [Test, Performance]
        public void Test_Array_UInt4_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatUInt4(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatUInt4(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_UInt4_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatUInt4(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatUInt4(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Float2 (0.184s)
        [Test, Performance]
        public void Test_Array_Float2()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatFloat2(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatFloat2(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        // Test_Array_Float2_Burst (0.184s)
        [Test, Performance]
        public void Test_Array_Float2_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatFloat2(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatFloat2(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Float2_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatFloat2(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatFloat2(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Float3 (0.193s)
        [Test, Performance]
        public void Test_Array_Float3()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatFloat3(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatFloat3(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        // Test_Array_Float3_Burst (0.189s)
        [Test, Performance]
        public void Test_Array_Float3_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatFloat3(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatFloat3(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Float3_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatFloat3(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatFloat3(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Float4 (0.202s)
        [Test, Performance]
        public void Test_Array_Float4()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatFloat4(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatFloat4(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        // Test_Array_Float4_Burst (0.195s)
        [Test, Performance]
        public void Test_Array_Float4_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatFloat4(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatFloat4(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Float4_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatFloat4(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatFloat4(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Double2 (0.180s)
        [Test, Performance]
        public void Test_Array_Double2()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatDouble2(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatDouble2(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        // Test_Array_Double2_Burst (0.179s)
        [Test, Performance]
        public void Test_Array_Double2_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatDouble2(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatDouble2(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Double2_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatDouble2(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatDouble2(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Double3 (0.183s)
        [Test, Performance]
        public void Test_Array_Double3()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatDouble3(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatDouble3(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
            }
        }
        // Test_Array_Double3_Burst (0.192s)
        [Test, Performance]
        public void Test_Array_Double3_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatDouble3(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatDouble3(0, 2, 10).ToArray();
                
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Double3_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatDouble3(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatDouble3(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Double4 (0.193s)
        [Test, Performance]
        public void Test_Array_Double4()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatDouble4(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatDouble4(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Double4_Burst (0.189s)
        [Test, Performance]
        public void Test_Array_Double4_Burst()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatDouble4(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatDouble4(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Double4_Check()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array1 = RandomEnumerable.RepeatDouble4(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatDouble4(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }
    }
}
