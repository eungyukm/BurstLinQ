using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Unity.PerformanceTesting;

#pragma warning disable CS0219

namespace BurstLinq.Tests
{
    // Sample Unit :  Microsecond
    // LINQ Min 88.10 | For Min 38.70| BurstLinq Min 0.30
    // LINQ Median 88.60 | For Median 38.80 | BurstLinq Median 0.50
    // LINQ Max 90.00 | For 42.00 | BurstLinq 0.80
    public class BenchmarkFloatSum
    {
        const int WarmupCount = 5;
        const int MeasurementCount = 100;

        static readonly float[] array = Enumerable.Repeat(1.0f, 10000).ToArray();

        [TearDown]
        public void TearDown()
        {
            GC.Collect();
        }
        
        [Test, Performance]
        public void For()
        {
            Measure.Method(() =>
            {
                if (array == null) return;

                var result = 0.0f;
                for (int i = 0; i < array.Length; i++)
                {
                    result += array[i];
                }
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .SampleGroup(new SampleGroup("Float Sum: For", SampleUnit.Microsecond))
            .Run();
        }

        [Test, Performance]
        public void LINQ()
        {
            Measure.Method(() =>
            {
                Enumerable.Sum(array);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .SampleGroup(new SampleGroup("Float Sum: LINQ", SampleUnit.Microsecond))
            .Run();
        }

        [Test, Performance]
        public void BurstLinq()
        {
            Measure.Method(() =>
            {
                BurstLinqExtensions.Sum(array);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .SampleGroup(new SampleGroup("Float Sum: BurstLinq", SampleUnit.Microsecond))
            .Run();
        }
    }

    // Sample Unit :  Microsecond
    // LINQ Min 85.70 | For Min 8.10| BurstLinq Min 0.90
    // LINQ Median 88.00 | For Median 8.20 | BurstLinq Median 1.00
    // LINQ Max 92.80 | For 9.10 | BurstLinq 3.80
    public class BenchmarkIntSequenceEqual
    {
        const int WarmupCount = 5;
        const int MeasurementCount = 100;

        static readonly int[] array1 = Enumerable.Range(0, 10000).ToArray();
        static readonly int[] array2 = Enumerable.Range(0, 10000).ToArray();

        [TearDown]
        public void TearDown()
        {
            GC.Collect();
        }

        [Test, Performance]
        public void For()
        {
            Measure.Method(() =>
            {
                if (array1 == null) return;
                if (array2 == null) return;

                var result = true;
                if (array1.Length != array2.Length)
                {
                    result = false;
                    return;
                }

                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] != array2[i])
                    {
                        result = false;
                        break;
                    }
                }
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .SampleGroup(new SampleGroup("Int SequenceEqual: For", SampleUnit.Microsecond))
            .Run();
        }

        [Test, Performance]
        public void LINQ()
        {
            Measure.Method(() =>
            {
                Enumerable.SequenceEqual(array1, array2);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .SampleGroup(new SampleGroup("Int SequenceEqual: LINQ", SampleUnit.Microsecond))
            .Run();
        }

        [Test, Performance]
        public void BurstLinq()
        {
            Measure.Method(() =>
            {
                BurstLinqExtensions.SequenceEqual(array1, array2);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .SampleGroup(new SampleGroup("Int SequenceEqual: BurstLinq", SampleUnit.Microsecond))
            .Run();
        }
    }
    // Sample Unit :  Microsecond
    // LINQ Min 68.80 | For Min 6.00 | BurstLinq Min 2.10
    // LINQ Median 69.40 | For Median 6.20 | BurstLinq Median 2.10
    // LINQ Max 71.90 | For 6.00 | BurstLinq
    public class BenchmarkDoubleMin
    {
        const int WarmupCount = 5;
        const int MeasurementCount = 100;

        static readonly double[] array = DoubleRange(10000).ToArray();
        static IEnumerable<double> DoubleRange(int count)
        {
            var current = 0.0;
            for (int i = 0; i < count; i++) yield return current++;
        }

        [TearDown]
        public void TearDown()
        {
            GC.Collect();
        }

        [Test, Performance]
        public void For()
        {
            Measure.Method(() =>
            {
                if (array == null) return;

                var result = double.MaxValue;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < result) result = array[i];
                }
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .SampleGroup(new SampleGroup("Double Min: For", SampleUnit.Microsecond))
            .Run();
        }

        [Test, Performance]
        public void LINQ()
        {
            Measure.Method(() =>
            {
                Enumerable.Min(array);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .SampleGroup(new SampleGroup("Double Min: LINQ", SampleUnit.Microsecond))
            .Run();
        }

        [Test, Performance]
        public void BurstLinq()
        {
            Measure.Method(() =>
            {
                BurstLinqExtensions.Min(array);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .SampleGroup(new SampleGroup("Double Min: BurstLinq", SampleUnit.Microsecond))
            .Run();
        }
    }
    // Sample Unit :  Microsecond
    // LINQ Min 57.60 | For Min 5.10 | BurstLinq Min 0.40
    // LINQ Median 57.90 | For Median 6.20 | BurstLinq Median 0.50
    // LINQ Max 68.90 | For 6.50 | BurstLinq 3.50
    public class BenchmarkIntMin
    {
        const int WarmupCount = 5;
        const int MeasurementCount = 100;

        static readonly int[] array = Enumerable.Range(0, 10000).ToArray();

        [TearDown]
        public void TearDown()
        {
            GC.Collect();
        }

        [Test, Performance]
        public void For()
        {
            Measure.Method(() =>
            {
                if (array == null) return;

                var result = int.MaxValue;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < result) result = array[i];
                }
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .SampleGroup(new SampleGroup("Int Min: For", SampleUnit.Microsecond))
            .Run();
        }

        [Test, Performance]
        public void LINQ()
        {
            Measure.Method(() =>
            {
                Enumerable.Min(array);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .SampleGroup(new SampleGroup("Int Min: LINQ", SampleUnit.Microsecond))
            .Run();
        }

        [Test, Performance]
        public void BurstLinq()
        {
            Measure.Method(() =>
            {
                BurstLinqExtensions.Min(array);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .SampleGroup(new SampleGroup("Int Min: BurstLinq", SampleUnit.Microsecond))
            .Run();
        }
    }

    // Sample Unit :  Microsecond
    // LINQ Min 384.50 | For Min 5.00 | BurstLinq Min 0.90
    // LINQ Median 393.50 | For Median 5.20 | BurstLinq Median 1.10
    // LINQ Max 478.80 | For 7.20 | BurstLinq 3.50
    public class BenchmarkIntContains
    {
        const int WarmupCount = 5;
        const int MeasurementCount = 100;

        static readonly int[] array = Enumerable.Range(0, 10000).ToArray();

        [TearDown]
        public void TearDown()
        {
            GC.Collect();
        }

        [Test, Performance]
        public void For()
        {
            Measure.Method(() =>
            {
                if (array == null) return;

                var value = array.Last();
                var result = false;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == value)
                    {
                        result = true;
                        break;
                    }
                }
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .SampleGroup(new SampleGroup("Int Contains: For", SampleUnit.Microsecond))
            .Run();
        }

        [Test, Performance]
        public void LINQ()
        {
            Measure.Method(() =>
            {
                Enumerable.Contains(array, array.Last());
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .SampleGroup(new SampleGroup("Int Contains: LINQ", SampleUnit.Microsecond))
            .Run();
        }

        [Test, Performance]
        public void BurstLinq()
        {
            Measure.Method(() =>
            {
                BurstLinqExtensions.Contains(array, array.Last());
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .SampleGroup(new SampleGroup("Int Contains: BurstLinq", SampleUnit.Microsecond))
            .Run();
        }
    }

}

#pragma warning restore CS0219