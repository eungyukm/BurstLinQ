using System;
using System.Linq;
using BurstLinq;
using BurstLinq.Tests;
using Unity.Mathematics;
using UnityEngine;
using Assert = UnityEngine.Assertions.Assert;
using Random = UnityEngine.Random;
using NUnit.Framework;
using Unity.PerformanceTesting;

// Unity Version 2022.3.22f1
// 아래 유닛 테스트 결과는 2024-04-19에 측정한 결과 입니다.
namespace BurstLinq.Tests
{
    public class SumTest
    {
        [SetUp]
        public void SetUp()
        {
            Random.InitState((int)DateTime.Now.Ticks);
        }

        [Test, Performance]
        public void Test_List()
        {
            for (int i = 0; i < 10000; i++)
            {
                var list = RandomEnumerable.RepeatInt(0, 100, 1000).ToList();

                var result1 = Enumerable.Sum(list);
            }
        }
        
        [Test, Performance]
        public void Test_List_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var list = RandomEnumerable.RepeatInt(0, 100, 1000).ToList();
                
                var result2 = BurstLinqExtensions.Sum(list);
            }
        }
        
        [Test, Performance]
        public void Test_List_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var list = RandomEnumerable.RepeatInt(0, 100, 1000).ToList();

                var result1 = Enumerable.Sum(list);
                var result2 = BurstLinqExtensions.Sum(list);

                Assert.AreEqual(result1, result2);
            }
        }
        
        // Test_Array_Int (0.509s)
        [Test, Performance]
        public void Test_Array_Int()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt(0, 100, 1000).ToArray();

                var result1 = Enumerable.Sum(array);
            }
        }
        
        // Test_Array_Int_Burst (0.453s)
        [Test, Performance]
        public void Test_Array_Int_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Sum(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Int_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt(0, 100, 1000).ToArray();

                var result1 = Enumerable.Sum(array);
                var result2 = BurstLinqExtensions.Sum(array);

                Assert.AreEqual(result1, result2);
            }
        }
        
        // Test_Array_UInt (0.469s)
        [Test, Performance]
        public void Test_Array_UInt()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatUInt(0, 100, 1000).ToArray();

                uint result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
            }
        }
        
        // Test_Array_UInt_Burst (0.450s)
        [Test, Performance]
        public void Test_Array_UInt_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatUInt(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Sum(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_UInt_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatUInt(0, 100, 1000).ToArray();

                uint result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
                var result2 = BurstLinqExtensions.Sum(array);

                Assert.AreEqual(result1, result2);
            }
        }
        
        // Test_Array_Long (0.461s)
        [Test, Performance]
        public void Test_Array_Long()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatLong(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Sum(array);
            }
        }
        
        // Test_Array_Long_Burst (0.466s)
        [Test, Performance]
        public void Test_Array_Long_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatLong(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Sum(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Long_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatLong(0, 100, 1000).ToArray();

                var result1 = Enumerable.Sum(array);
                var result2 = BurstLinqExtensions.Sum(array);

                Assert.AreEqual(result1, result2);
            }
        }
        
        // Test_Array_ULong (0.464s)
        [Test, Performance]
        public void Test_Array_ULong()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatULong(0, 100, 1000).ToArray();

                ulong result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
            }
        }
        
        // Test_Array_ULong_Burst (0.459s)
        [Test, Performance]
        public void Test_Array_ULong_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatULong(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Sum(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_ULong_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatULong(0, 100, 1000).ToArray();

                ulong result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
            }
        }
        
        [Test, Performance]
        public void Test_Array_Float()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatFloat(0, 100, 1000).ToArray();

                var result1 = Enumerable.Sum(array);
                var result2 = BurstLinqExtensions.Sum(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        
        // Test_Array_Double (1.286s)
        [Test, Performance]
        public void Test_Array_Double()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble(0, 100, 1000).ToArray();

                var result1 = Enumerable.Sum(array);
            }
        }
        
        // Test_Array_Double_Burst (0.685s)
        [Test, Performance]
        public void Test_Array_Double_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Sum(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Double_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble(0, 100, 1000).ToArray();

                var result1 = Enumerable.Sum(array);
                var result2 = BurstLinqExtensions.Sum(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        
        // Test_Array_Vector2 (1.094s)
        [Test, Performance]
        public void Test_Array_Vector2()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector2(0, 100, 1000).ToArray();

                Vector2 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
            }
        }
        
        // Test_Array_Vector2_Burst (1.012s)
        [Test, Performance]
        public void Test_Array_Vector2_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector2(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Sum(array);
            }
        }
        
        // Assertion failure. Values are not equal. | Expected: 51087.92 == 51087.8
        [Test, Performance]
        public void Test_Array_Vector2_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector2(0, 100, 1000).ToArray();

                Vector2 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
                var result2 = BurstLinqExtensions.Sum(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        
        // Test_Array_Vector2Int (0.635s)
        [Test, Performance]
        public void Test_Array_Vector2Int()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector2Int(0, 100, 1000).ToArray();

                Vector2Int result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
            }
        }
        
        // Test_Array_Vector2Int_Burst (0.606s)
        [Test, Performance]
        public void Test_Array_Vector2Int_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector2Int(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Sum(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Vector2Int_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector2Int(0, 100, 1000).ToArray();

                Vector2Int result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
                var result2 = BurstLinqExtensions.Sum(array);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Vector3 (1.317s)
        [Test, Performance]
        public void Test_Array_Vector3()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector3(0, 100, 1000).ToArray();

                Vector3 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
            }
        }
        // Test_Array_Vector3_Burst (1.233s)
        [Test, Performance]
        public void Test_Array_Vector3_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector3(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Sum(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Vector3_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector3(0, 100, 1000).ToArray();

                Vector3 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
                var result2 = BurstLinqExtensions.Sum(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_Vector3Int (0.767s)
        [Test, Performance]
        public void Test_Array_Vector3Int()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector3Int(0, 100, 1000).ToArray();

                Vector3Int result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
            }
        }
        // Test_Array_Vector3Int_Burst (0.733s)
        [Test, Performance]
        public void Test_Array_Vector3Int_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector3Int(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Sum(array);
            }
        }
        // Assertion failure. Values are not equal. | Expected: 49212.75 == 49212.65
        [Test, Performance]
        public void Test_Array_Vector3Int_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector3Int(0, 100, 1000).ToArray();

                Vector3Int result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
                var result2 = BurstLinqExtensions.Sum(array);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Vector4 (1.473s)
        [Test, Performance]
        public void Test_Array_Vector4()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector4(0, 100, 1000).ToArray();

                Vector4 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
            }
        }
        // Test_Array_Vector4_Burst (1.734s)
        [Test, Performance]
        public void Test_Array_Vector4_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector4(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Sum(array);
            }
        }
        // Assertion failure. Values are not equal. | Expected: 49212.75 == 49212.65
        [Test, Performance]
        public void Test_Array_Vector4_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector4(0, 100, 1000).ToArray();

                Vector4 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
                var result2 = BurstLinqExtensions.Sum(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        
        // Test_Array_Int2 (0.647s)
        [Test, Performance]
        public void Test_Array_Int2()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt2(0, 100, 1000).ToArray();

                int2 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
                var result2 = BurstLinqExtensions.Sum(array);

                Assert.AreEqual(result1, result2);
            }
        }
        
        // Test_Array_Int2_Burst (0.611s)
        [Test, Performance]
        public void Test_Array_Int2_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt2(0, 100, 1000).ToArray();

                var result2 = BurstLinqExtensions.Sum(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Int2_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt2(0, 100, 1000).ToArray();

                int2 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
                var result2 = BurstLinqExtensions.Sum(array);

                Assert.AreEqual(result1, result2);
            }
        }
        
        // Test_Array_Int3 (0.772s)
        [Test, Performance]
        public void Test_Array_Int3()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt3(0, 100, 1000).ToArray();

                int3 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
            }
        }
        
        // Test_Array_Int3_Burst (0.727s)
        [Test, Performance]
        public void Test_Array_Int3_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt3(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Sum(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Int3_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt3(0, 100, 1000).ToArray();

                int3 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
                var result2 = BurstLinqExtensions.Sum(array);

                Assert.AreEqual(result1, result2);
            }
        }
        
        // Test_Array_Int4 (0.884s)
        [Test, Performance]
        public void Test_Array_Int4()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt4(0, 100, 1000).ToArray();

                int4 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
            }
        }
        
        // Test_Array_Int4_Burst (0.838s)
        [Test, Performance]
        public void Test_Array_Int4_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt4(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Sum(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Int4_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt4(0, 100, 1000).ToArray();

                int4 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
                var result2 = BurstLinqExtensions.Sum(array);

                Assert.AreEqual(result1, result2);
            }
        }
        
        // Test_Array_UInt3 (0.771s)
        [Test, Performance]
        public void Test_Array_UInt3()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatUInt3(0, 100, 1000).ToArray();

                uint3 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
            }
        }
        
        // Test_Array_UInt3_Burst (0.714s)
        [Test, Performance]
        public void Test_Array_UInt3_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatUInt3(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Sum(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_UInt3_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatUInt3(0, 100, 1000).ToArray();

                uint3 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
                var result2 = BurstLinqExtensions.Sum(array);

                Assert.AreEqual(result1, result2);
            }
        }
        
        // Test_Array_Float2 (1.088s)
        [Test, Performance]
        public void Test_Array_Float2()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatFloat2(0, 100, 1000).ToArray();

                float2 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
            }
        }
        
        // Test_Array_Float2_Burst (0.986s)
        [Test, Performance]
        public void Test_Array_Float2_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatFloat2(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Sum(array);
            }
        }
        
        // Expected: 50254.99 == 50255.1
        [Test, Performance]
        public void Test_Array_Float2_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatFloat2(0, 100, 1000).ToArray();

                float2 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
                var result2 = BurstLinqExtensions.Sum(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        
        // Test_Array_Float3 (1.310s)
        [Test, Performance]
        public void Test_Array_Float3()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatFloat3(0, 100, 1000).ToArray();

                float3 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
                var result2 = BurstLinqExtensions.Sum(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        
        // Test_Array_Float3_Burst (1.209s)
        [Test, Performance]
        public void Test_Array_Float3_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatFloat3(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Sum(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Float3_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatFloat3(0, 100, 1000).ToArray();

                float3 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
                var result2 = BurstLinqExtensions.Sum(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        
        // Test_Array_Float4 (1.449s)
        [Test, Performance]
        public void Test_Array_Float4()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatFloat4(0, 100, 1000).ToArray();

                float4 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
            }
        }
        
        // Test_Array_Float4_Burst (1.353s)
        [Test, Performance]
        public void Test_Array_Float4_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatFloat4(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Sum(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Float4_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatFloat4(0, 100, 1000).ToArray();

                float4 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
                var result2 = BurstLinqExtensions.Sum(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        
        // Test_Array_Double2 (1.162s)
        [Test, Performance]
        public void Test_Array_Double2()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble2(0, 100, 1000).ToArray();

                double2 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
                var result2 = BurstLinqExtensions.Sum(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        
        // Test_Array_Double2_Burst (0.818s)
        [Test, Performance]
        public void Test_Array_Double2_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble2(0, 100, 1000).ToArray();

                double2 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
                var result2 = BurstLinqExtensions.Sum(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Double2_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble2(0, 100, 1000).ToArray();

                double2 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
                var result2 = BurstLinqExtensions.Sum(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        
        // Test_Array_Double3 (0.999s)
        [Test, Performance]
        public void Test_Array_Double3()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble3(0, 100, 1000).ToArray();

                double3 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
            }
        }
        
        // Test_Array_Double3_Burst (0.961s)
        [Test, Performance]
        public void Test_Array_Double3_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble3(0, 100, 1000).ToArray();
                var result2 = BurstLinqExtensions.Sum(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Double3_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble3(0, 100, 1000).ToArray();

                double3 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
                var result2 = BurstLinqExtensions.Sum(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        
        // Test_Array_Double4 (1.204s)
        [Test, Performance]
        public void Test_Array_Double4()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble4(0, 100, 1000).ToArray();

                double4 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
            }
        }
        
        // Test_Array_Double4_Burst (1.185s)
        [Test, Performance]
        public void Test_Array_Double4_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble4(0, 100, 1000).ToArray();

                var result2 = BurstLinqExtensions.Sum(array);
            }
        }
        
        
        [Test, Performance]
        public void Test_Array_Double4_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble4(0, 100, 1000).ToArray();

                double4 result1 = default;
                for (int n = 0; n < array.Length; n++) result1 += array[n];
                var result2 = BurstLinqExtensions.Sum(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
    }
}