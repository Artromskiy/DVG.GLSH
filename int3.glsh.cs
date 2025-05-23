using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Numerics;


namespace DVG
{
    /// <summary>
    /// Static class that contains static glsh functions
    /// </summary>
    public static partial class glsh
    {
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool3 LesserThan(int3 lhs, int3 rhs) => int3.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool3 LesserThanEqual(int3 lhs, int3 rhs) => int3.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool3 GreaterThan(int3 lhs, int3 rhs) => int3.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool3 GreaterThanEqual(int3 lhs, int3 rhs) => int3.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool3 Equal(int3 lhs, int3 rhs) => int3.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool3 NotEqual(int3 lhs, int3 rhs) => int3.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Abs (Maths.Abs(v)).
        /// </summary>
        public static int3 Abs(int3 v) => int3.Abs(v);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Sign (Maths.Sign(v)).
        /// </summary>
        public static int3 Sign(int3 v) => int3.Sign(v);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        public static int3 Min(int3 lhs, int3 rhs) => int3.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        public static int3 Max(int3 lhs, int3 rhs) => int3.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static int3 Clamp(int3 v, int3 min, int3 max) => int3.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static int3 Clamp(int3 v, int min, int max) => int3.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Mix (a ? y : x).
        /// </summary>
        public static int3 Mix(int3 x, int3 y, bool3 a) => int3.Mix(x, y, a);
        
        /// <summary>
        /// Returns a float3 from component-wise application of IntBitsToFloat (Unsafe.As&lt;int, float&gt;(ref v)).
        /// </summary>
        public static float3 IntBitsToFloat(int3 v) => int3.IntBitsToFloat(v);
        
        /// <summary>
        /// Returns HashCode
        /// </summary>
        public static int GetHashCode(int3 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        public static string ToString(int3 v) => v.ToString();
        
        public static bool Equals(int3 v, int3 other) => v.Equals(other);
        
        public static bool Equals(int3 v, object? obj) => v.Equals(obj);

    }
}
