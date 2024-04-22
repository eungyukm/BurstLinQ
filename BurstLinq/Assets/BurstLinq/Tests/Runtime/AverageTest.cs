using System;
using System.Linq;
using NUnit.Framework;
using UnityEngine;
using Unity.Mathematics;
using Unity.PerformanceTesting;
using Assert = UnityEngine.Assertions.Assert;
using Random = UnityEngine.Random;

namespace BurstLinq.Tests
{
    public class AverageTest
    {
        [SetUp]
        public void SetUp()
        {
            Random.InitState((int)DateTime.Now.Ticks);
        }
        // Test_List (0.307s)
        [Test, Performance]
        public void Test_List()
        {
            for (int i = 0; i < 10000; i++)
            {
                var list = RandomEnumerable.RepeatInt(0, 100, 1000).ToList();

                var result1 = Enumerable.Average(list);
            }
        }
        // Test_List_Burst (0.261s)
        [Test, Performance]
        public void Test_List_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var list = RandomEnumerable.RepeatInt(0, 100, 1000).ToList();
                
                var result2 = BurstLinqExtensions.Average(list);
            }
        }

        
        [Test, Performance]
        public void Test_List_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var list = RandomEnumerable.RepeatInt(0, 100, 1000).ToList();

                var result1 = Enumerable.Average(list);
                var result2 = BurstLinqExtensions.Average(list);

                Assert.AreEqual(result1, result2);
            }
        }
        // Test_Array_Int (0.328s)
        [Test, Performance]
        public void Test_Array_Int()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt(0, 100, 1000).ToArray();

                var result1 = Enumerable.Average(array);
            }
        }
        // Test_Array_Int_Burst (0.278s)
        [Test, Performance]
        public void Test_Array_Int_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt(0, 100, 1000).ToArray();

                var result2 = BurstLinqExtensions.Average(array);
            }
        }

        
        [Test, Performance]
        public void Test_Array_Int_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt(0, 100, 1000).ToArray();

                var result1 = Enumerable.Average(array);
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_UInt (0.269s)
        [Test, Performance]
        public void Test_Array_UInt()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatUInt(0, 100, 1000).ToArray();

                uint sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double)sum / array.Length;
            }
        }
        // Test_Array_UInt_Burst (0.269s)
        [Test, Performance]
        public void Test_Array_UInt_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatUInt(0, 100, 1000).ToArray();

                uint sum = default;
                var result2 = BurstLinqExtensions.Average(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_UInt_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatUInt(0, 100, 1000).ToArray();

                uint sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_Long (0.353s)
        [Test, Performance]
        public void Test_Array_Long()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatLong(0, 100, 1000).ToArray();

                var result1 = Enumerable.Average(array);
            }
        }
        // Test_Array_Long_Burst (0.293s)
        [Test, Performance]
        public void Test_Array_Long_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatLong(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Average(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Long_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatLong(0, 100, 1000).ToArray();

                var result1 = Enumerable.Average(array);
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_ULong (0.297s)
        [Test, Performance]
        public void Test_Array_ULong()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatULong(0, 100, 1000).ToArray();

                ulong sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double)sum / array.Length;
            }
        }
        // Test_Array_ULong_Burst (0.290s)
        [Test, Performance]
        public void Test_Array_ULong_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatULong(0, 100, 1000).ToArray();

                ulong sum = default;
                var result2 = BurstLinqExtensions.Average(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_ULong_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatULong(0, 100, 1000).ToArray();

                ulong sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_Float (0.521s)
        [Test, Performance]
        public void Test_Array_Float()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatFloat(0, 100, 1000).ToArray();

                var result1 = Enumerable.Average(array);
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_Float_Burst (0.517s)
        [Test, Performance]
        public void Test_Array_Float_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatFloat(0, 100, 1000).ToArray();

                var result1 = Enumerable.Average(array);
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Float_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatFloat(0, 100, 1000).ToArray();

                var result1 = Enumerable.Average(array);
            }
        }
        // Test_Array_Double (0.368s)
        [Test, Performance]
        public void Test_Array_Double()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble(0, 100, 1000).ToArray();
                var result2 = BurstLinqExtensions.Average(array);
            }
        }
        // Test_Array_Double_Burst (0.347s)
        [Test, Performance]
        public void Test_Array_Double_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Average(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Double_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble(0, 100, 1000).ToArray();

                var result1 = Enumerable.Average(array);
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_Vector2 (0.931s)
        [Test, Performance]
        public void Test_Array_Vector2()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector2(0, 100, 1000).ToArray();

                Vector2 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (Vector2)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_Vector2_Burst (0.929s)
        [Test, Performance]
        public void Test_Array_Vector2_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector2(0, 100, 1000).ToArray();

                Vector2 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (Vector2)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Vector2_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector2(0, 100, 1000).ToArray();

                Vector2 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (Vector2)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_Vector2Int (0.466s)
        [Test, Performance]
        public void Test_Array_Vector2Int()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector2Int(0, 100, 1000).ToArray();

                Vector2Int sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (Vector2)sum / array.Length;
            }
        }
        // Test_Array_Vector2Int_Burst (0.433s)
        [Test, Performance]
        public void Test_Array_Vector2Int_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector2Int(0, 100, 1000).ToArray();
                var result2 = BurstLinqExtensions.Average(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Vector2Int_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector2Int(0, 100, 1000).ToArray();

                Vector2Int sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (Vector2)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_Vector3 (1.270s)
        [Test, Performance]
        public void Test_Array_Vector3()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector3(0, 100, 1000).ToArray();

                Vector3 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (Vector3)sum / array.Length;
            }
        }
        // Test_Array_Vector3_Burst (1.032s)
        [Test, Performance]
        public void Test_Array_Vector3_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector3(0, 100, 1000).ToArray();
                var result2 = BurstLinqExtensions.Average(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Vector3_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector3(0, 100, 1000).ToArray();

                Vector3 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (Vector3)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_Vector3Int (0.573s)
        [Test, Performance]
        public void Test_Array_Vector3Int()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector3Int(0, 100, 1000).ToArray();

                Vector3Int sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (Vector3)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_Vector3Int_Burst (0.573s)
        [Test, Performance]
        public void Test_Array_Vector3Int_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector3Int(0, 100, 1000).ToArray();

                Vector3Int sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (Vector3)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Vector3Int_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector3Int(0, 100, 1000).ToArray();

                Vector3Int sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (Vector3)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_Vector4 (1.274s)
        [Test, Performance]
        public void Test_Array_Vector4()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector4(0, 100, 1000).ToArray();

                Vector4 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (Vector4)sum / array.Length;
            }
        }
        // Test_Array_Vector4_Burst (1.184s)
        [Test, Performance]
        public void Test_Array_Vector4_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector4(0, 100, 1000).ToArray();

                var result2 = BurstLinqExtensions.Average(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Vector4_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatVector4(0, 100, 1000).ToArray();

                Vector4 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (Vector4)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_Int2 (0.474s)
        [Test, Performance]
        public void Test_Array_Int2()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt2(0, 100, 1000).ToArray();

                int2 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double2)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_Int2_Burst (0.472s)
        [Test, Performance]
        public void Test_Array_Int2_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt2(0, 100, 1000).ToArray();

                int2 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double2)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Int2_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt2(0, 100, 1000).ToArray();

                int2 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double2)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_Int3 (0.568s)
        [Test, Performance]
        public void Test_Array_Int3()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt3(0, 100, 1000).ToArray();

                int3 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double3)sum / array.Length;
            }
        }
        // Test_Array_Int3_Burst (0.537s)
        [Test, Performance]
        public void Test_Array_Int3_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt3(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Average(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Int3_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt3(0, 100, 1000).ToArray();

                int3 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double3)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_Int4 (0.843s)
        [Test, Performance]
        public void Test_Array_Int4()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt4(0, 100, 1000).ToArray();

                int4 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double4)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_Int4_Burst (0.703s)
        [Test, Performance]
        public void Test_Array_Int4_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt4(0, 100, 1000).ToArray();

                int4 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double4)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Int4_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatInt4(0, 100, 1000).ToArray();

                int4 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double4)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_Float2 (0.908s)
        [Test, Performance]
        public void Test_Array_Float2()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatFloat2(0, 100, 1000).ToArray();

                float2 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (float2)sum / array.Length;
            }
        }
        // Test_Array_Float2_Burst (0.817s)
        [Test, Performance]
        public void Test_Array_Float2_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatFloat2(0, 100, 1000).ToArray();
                var result2 = BurstLinqExtensions.Average(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Float2_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatFloat2(0, 100, 1000).ToArray();

                float2 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (float2)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_Float3 (1.093s)
        [Test, Performance]
        public void Test_Array_Float3()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatFloat3(0, 100, 1000).ToArray();

                float3 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (float3)sum / array.Length;
            }
        }
        // Test_Array_Float3_Burst (1.007s)
        [Test, Performance]
        public void Test_Array_Float3_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatFloat3(0, 100, 1000).ToArray();

                var result2 = BurstLinqExtensions.Average(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Float3_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatFloat3(0, 100, 1000).ToArray();

                float3 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (float3)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_Float4 (1.251s)
        [Test, Performance]
        public void Test_Array_Float4()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatFloat4(0, 100, 1000).ToArray();

                float4 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (float4)sum / array.Length;
            }
        }
        // Test_Array_Float4_Burst (1.174s)
        [Test, Performance]
        public void Test_Array_Float4_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatFloat4(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Average(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Float4_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatFloat4(0, 100, 1000).ToArray();

                float4 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (float4)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        
        // Test_Array_Double2 (0.627s)
        [Test, Performance]
        public void Test_Array_Double2()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble2(0, 100, 1000).ToArray();

                double2 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double2)sum / array.Length;
            }
        }
        
        // Test_Array_Double2_Burst (0.739s)
        [Test, Performance]
        public void Test_Array_Double2_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble2(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Average(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Double2_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble2(0, 100, 1000).ToArray();

                double2 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double2)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_Double3 (0.797s)
        [Test, Performance]
        public void Test_Array_Double3()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble3(0, 100, 1000).ToArray();

                double3 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double3)sum / array.Length;
            }
        }
        // Test_Array_Double3_Burst (0.756s)
        [Test, Performance]
        public void Test_Array_Double3_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble3(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Average(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Double3_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble3(0, 100, 1000).ToArray();

                double3 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double3)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
        // Test_Array_Double4 (1.128s)
        [Test, Performance]
        public void Test_Array_Double4()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble4(0, 100, 1000).ToArray();

                double4 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double4)sum / array.Length;
            }
        }
        // Test_Array_Double4_Burst (0.938s)
        [Test, Performance]
        public void Test_Array_Double4_Burst()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble4(0, 100, 1000).ToArray();
                
                var result2 = BurstLinqExtensions.Average(array);
            }
        }
        
        [Test, Performance]
        public void Test_Array_Double4_Check()
        {
            for (int i = 0; i < 10000; i++)
            {
                var array = RandomEnumerable.RepeatDouble4(0, 100, 1000).ToArray();

                double4 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double4)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }
    }
}