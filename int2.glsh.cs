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
        /// Returns a bool2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool2 LesserThan(int2 lhs, int2 rhs) => int2.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool2 LesserThanEqual(int2 lhs, int2 rhs) => int2.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool2 GreaterThan(int2 lhs, int2 rhs) => int2.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool2 GreaterThanEqual(int2 lhs, int2 rhs) => int2.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool2 Equal(int2 lhs, int2 rhs) => int2.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool2 NotEqual(int2 lhs, int2 rhs) => int2.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a int2 from component-wise application of Abs (Maths.Abs(v)).
        /// </summary>
        public static int2 Abs(int2 v) => int2.Abs(v);
        
        /// <summary>
        /// Returns a int2 from component-wise application of Sign (Maths.Sign(v)).
        /// </summary>
        public static int2 Sign(int2 v) => int2.Sign(v);
        
        /// <summary>
        /// Returns a int2 from component-wise application of Min (Maths.Min(lhs, rhs)).
        /// </summary>
        public static int2 Min(int2 lhs, int2 rhs) => int2.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a int2 from component-wise application of Max (Maths.Max(lhs, rhs)).
        /// </summary>
        public static int2 Max(int2 lhs, int2 rhs) => int2.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a int2 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static int2 Clamp(int2 v, int2 min, int2 max) => int2.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a int2 from component-wise application of Clamp (Maths.Clamp(v, min, max)).
        /// </summary>
        public static int2 Clamp(int2 v, int min, int max) => int2.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a int2 from component-wise application of Mix (a ? y : x).
        /// </summary>
        public static int2 Mix(int2 x, int2 y, bool2 a) => int2.Mix(x, y, a);
        
        /// <summary>
        /// Returns a float2 from component-wise application of IntBitsToFloat (Unsafe.As&lt;int, float&gt;(ref v)).
        /// </summary>
        public static float2 IntBitsToFloat(int2 v) => int2.IntBitsToFloat(v);
        
        /// <summary>
        /// Returns HashCode
        /// </summary>
        public static int GetHashCode(int2 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a string representation of this vector.
        /// </summary>
        public static string ToString(int2 v) => v.ToString();
        
        public static bool Equals(int2 v, int2 other) => v.Equals(other);
        
        public static bool Equals(int2 v, object? obj) => v.Equals(obj);

    }
}
