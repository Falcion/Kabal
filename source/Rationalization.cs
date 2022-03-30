using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFX
{
    public static class Rationalization
    {
        // TOSTRING;
        /// <summary>
        /// Converts given expression |F| - |G| to new view: (F - G)(F + G)
        /// <example>
        /// For example:
        /// <code>
        /// absDiffToInt(4, -5); // => "(4 - (-5))(4 + (-5))
        /// </code>
        /// <c>Formula: (F - G)(F + G).</c>. 
        /// </example>
        /// </summary>
        /// <param name="F">First submodule number: a 32-bit integer.</param>
        /// <param name="G">Secondary submodule number: a 32-bit integer.</param>
        /// <returns>A rationalized integer from given expression in given formula.</returns>
        public static string absDiffToString(int F, int G)
        {
            if(F > 0)
            {
                if(G > 0)
                {
                    return $"({F} - {G})({F} + {G})";
                }
                else
                {
                    return $"({F} - ({G}))({F} + ({G}))";
                }
            }
            else
            {
                if (G > 0)
                {
                    return $"(({F}) - {G})(({F}) + {G})";
                }
                else
                {
                    return $"(({F}) - ({G}))(({F}) + ({G}))";
                }
            }
            
        }

        // TOINTEGER;
        /// <summary>
        /// Converts given expression |F| - |G| to new view: (F - G)(F + G)
        /// <example>
        /// For example:
        /// <code>
        /// absDiffToInt(4, -5); // => 9.
        /// </code>
        /// <c>Formula: (F - G)(F + G).</c>. 
        /// </example>
        /// </summary>
        /// <param name="F">First submodule number: a 32-bit integer.</param>
        /// <param name="G">Secondary submodule number: a 32-bit integer.</param>
        /// <returns>A rationalized integer from given expression in given formula.</returns>
        public static int absDiffToInt(int F, int G)
        {
            return (F - G) * (F + G);
        }

        // TOSTRING;
        /// <summary>
        /// Converts given expression F^H - G^H (F > 0; G > 0); to new view: (F - G) * H
        /// <example>
        /// For example:
        /// <code>
        /// Rationalization.powersDiffToInt(6, 5, 2); // => "(6 - 5) * 2"
        /// </code>
        /// <c>Formula: (F - G) * H</c>. 
        /// </example>
        /// </summary>
        /// <param name="F">First subpower number: a 32-bit non-negative integer.</param>
        /// <param name="G">Secondary subpower number: a 32-bit non-negative integer.</param>
        /// <param name="H">A power "pow" number: a 32-bit integer.</param>
        /// <returns>A rationalized string from given expression in given formula.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when F lesser or equals than 0 and G lesser or equals than 0.</exception>
        public static string powersDiffToString(uint F, uint G, int H)
        {
            if (F == 0 || G == 0)
                throw new ArgumentOutOfRangeException("Rationalization error of: F && G != 0!");

            if(H > 0)
                return $"({F} - {G}) * {H}";
            else
                return $"({F} - {G}) * ({H})";
        }

        // TOINTEGER;
        /// <summary>
        /// Converts given expression F^H - G^H (F > 0; G > 0); to new view: (F - G) * H
        /// <example>
        /// For example:
        /// <code>
        /// Rationalization.powersDiffToInt(6, 5, 2); // => 2
        /// </code>
        /// <c>Formula: (F - G) * H</c>. 
        /// </example>
        /// </summary>
        /// <param name="F">First subpower number: a 32-bit non-negative integer.</param>
        /// <param name="G">Secondary subpower number: a 32-bit non-negative integer.</param>
        /// <param name="H">A power "pow" number: a 32-bit integer.</param>
        /// <returns>A rationalized integer from given expression in given formula.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when F lesser or equals than 0 and G lesser or equals than 0.</exception>
        public static int powersDiffToInt(uint F, uint G, int H)
        {
            if (F == 0 || G == 0)
                throw new ArgumentOutOfRangeException("Rationalization error of: F && G != 0!");

            return (int)(F - G)*H;
        }

        // TOSTRING;
        /// <summary>
        /// Converts given expression H^F - H^G (H > 0); to new view: (H - 1)(F - G).
        /// <example>
        /// For example:
        /// <code>
        /// Rationalization.diffPowersWithBasesToString(2, 10, 8); // => "(2 - 1)(10 - 8)"
        /// </code>
        /// <c>Formula: (H - 1)(F - G)</c>. 
        /// </example>
        /// </summary>
        /// <param name="H">Main subpower number: a 32-bit non-negative integer.</param>
        /// <param name="F">First power "pow" number: a 32-bit negative integer.</param>
        /// <param name="G">Secondary power "pow" number: a 32-bit negative integer.</param>
        /// <returns>A rationalized string from given expression in given formula.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when H lesser or equals than 0.</exception>
        public static string diffPowersWithBasesToString(uint H, int F, int G)
        {
            if (H <= 0)
                throw new ArgumentOutOfRangeException("Rationalization error of: H != 0!");

            if(F > 0)
            {
                if(G > 0)
                {
                    return $"({H} - 1)({F} - {G})";
                }
                else
                {
                    return $"({H} - 1)({F} - ({G}))";
                }
            }
            else
            {
                if (G > 0)
                {
                    return $"(({H}) - 1)({F} - {G})";
                }
                else
                {
                    return $"(({H}) - 1)({F} - ({G}))";
                }
            }
        }

        // TOINTEGER;
        /// <summary>
        /// Converts given expression H^F - H^G (H > 0); to new view: (H - 1)(F - G).
        /// <example>
        /// For example:
        /// <code>
        /// Rationalization.diffPowersWithBasesToString(2, 10, 8); // => 2.
        /// </code>
        /// <c>Formula: (H - 1)(F - G)</c>. 
        /// </example>
        /// </summary>
        /// <param name="F">First subpower number: a 32-bit non-negative integer.</param>
        /// <param name="G">Secondary subpower number: a 32-bit non-negative integer.</param>
        /// <param name="H">A power "pow" number: a 32-bit integer.</param>
        /// <returns>A rationalized integer from given expression in given formula.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when H lesser or equals than 0.</exception>
        public static int diffPowersWithBasesToInt(uint H, int F, int G)
        {
            if(H <= 0)
                throw new ArgumentOutOfRangeException("Rationalization error of: H != 0!");

            return (int)(H - 1) * (F - G);
        }

        // TOSTRING;
        /// <summary>
        /// Converts given expression logF(H) - logG(H) (F != 1; G != 1; F, G, H > 0); to new view: (F - 1)(G - 1)(H - 1)(G - F)
        /// <example>
        /// For example:
        /// <code>
        /// Rationalization.diffNumberLogsToInt(13, 2, 3); // => (13 - 1)(2 - 1)(3 - 1)(2 - 13)
        /// </code>
        /// <c>Formula: (F - 1)(G - 1)(H - 1)(G - F)</c>. 
        /// </example>
        /// </summary>
        /// <param name="F">Base number of first logariphm: a 32-bit integer (>0).</param>
        /// <param name="G">Base number of second logariphm: a 32-bit integer (>0).</param>
        /// <param name="H">A sublogariphmic number: a 32-bit integer (>0).</param>
        /// <returns>A rationalized integer from given expression in given formula.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when F and G equals 1 and when sublogariphmic numbers aren't greater than zero.</exception>
        public static string diffNumberLogsToString(int F, int G, int H)
        {
            if (F == 1 || G == 1)
                throw new ArgumentOutOfRangeException("Rationalization error of: F != 1 and G != 1!");

            if (F <= 0 || G <= 0 || H <= 0)
                throw new ArgumentOutOfRangeException("Rationalization error of: sublogariphmic numbers are greater than zero!");

            return $"({F} - 1)({G} - 1)({H - 1})({G - F})";
        }

        // TOINTEGER;
        /// <summary>
        /// Converts given expression logF(H) - logG(H) (F != 1; G != 1; F, G, H > 0); to new view: (F - 1)(G - 1)(H - 1)(G - F)
        /// <example>
        /// For example:
        /// <code>
        /// Rationalization.diffNumberLogsToInt(13, 2, 3); // => -264.
        /// </code>
        /// <c>Formula: (F - 1)(G - 1)(H - 1)(G - F)</c>. 
        /// </example>
        /// </summary>
        /// <param name="F">Base number of first logariphm: a 32-bit integer (>0).</param>
        /// <param name="G">Base number of second logariphm: a 32-bit integer (>0).</param>
        /// <param name="H">A sublogariphmic number: a 32-bit integer (>0).</param>
        /// <returns>A rationalized integer from given expression in given formula.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when F and G equals 1 and when sublogariphmic numbers aren't greater than zero.</exception>
        public static int diffNumberLogsToInt(uint F, uint G, uint H)
        {
            if (F == 1 || G == 1)
                throw new ArgumentOutOfRangeException("Rationalization error of: F != 1 and G != 1!");

            if (F <= 0 || G <= 0 || H <= 0)
                throw new ArgumentOutOfRangeException("Rationalization error of: sublogariphmic numbers are greater than zero!");

            return (int)((int)(F - 1) * (G - 1) * (H - 1) * (G - F));
        }

        // TOSTRING;
        /// <summary>
        /// Converts given expression logH(F) - logH(G) to new view:: (H - 1)(F - G).
        /// </summary>
        /// <param name="H">Base number of logariphms: a 32-bit integer (>0).</param>
        /// <param name="F">A first sublogariphmic number: a 32-bit integer (>0).</param>
        /// <param name="G">A second sublogariphmic number: a 32-bit integer (>0).</param>
        /// <returns>A ratio in string value of given expression.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when sublogariphmic numbers aren't greater than zero.</exception>
        public static string logRatioFormulaToString2(int H, int F, int G)
        {
            if (F <= 0 || G <= 0 || H <= 0)
                throw new ArgumentOutOfRangeException("Rationalization error of: sublogariphmic numbers are greater than zero!");

            return $"({H} - 1)({F} - {G})";
        }

        // TOINTEGER;
        /// <summary>
        /// Converts given expression logH(F) - logH(G) to new view:: (H - 1)(F - G).
        /// </summary>
        /// <param name="H">Base number of logariphms: a 32-bit integer (>0).</param>
        /// <param name="F">A first sublogariphmic number: a 32-bit integer (>0).</param>
        /// <param name="G">A second sublogariphmic number: a 32-bit integer (>0).</param>
        /// <returns>A ratio in integer value of given expression.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when sublogariphmic numbers aren't greater than zero.</exception>
        public static int logRatioFormulaToInt2(int H, int F, int G)
        {
            if (F <= 0 || G <= 0 || H <= 0)
                throw new ArgumentOutOfRangeException("Rationalization error of: sublogariphmic numbers are greater than zero!");

            return (int)(H - 1) * (F - G);
        }

        /// <summary>
        /// Converts given expression logH(F) to new view:: (H - 1)(F - H).
        /// </summary>
        /// <param name="H">Base number of logariphms: a 32-bit integer (>0).</param>
        /// <param name="F">A sublogariphmic number: a 32-bit integer (>0).</param>
        /// <returns>A ratio in string value of given expression.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when sublogariphmic numbers aren't greater than zero.</exception>
        public static string logRatioFormulaToString2A(int H, int F)
        {
            if (F <= 0 || H <= 0)
                throw new ArgumentOutOfRangeException("Rationalization error of: sublogariphmic numbers are greater than zero!");

            return $"({H} - 1)({F} - {H})";
        }

        /// <summary>
        /// Converts given expression logH(F) to new view:: (H - 1)(F - H).
        /// </summary>
        /// <param name="H">Base number of logariphms: a 32-bit integer (>0).</param>
        /// <param name="F">A sublogariphmic number: a 32-bit integer (>0).</param>
        /// <returns>A ratio in integer value of given expression.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when sublogariphmic numbers aren't greater than zero.</exception>
        public static int logRatioFormulaToInt2A(int H, int F)
        {
            if (F <= 0 || H <= 0)
                throw new ArgumentOutOfRangeException("Rationalization error of: sublogariphmic numbers are greater than zero!");

            return (int)(H - 1)*(F - H);
        }

        // TOSTRING;
        /// <summary>
        /// Converts given expression logH(F) to new view:: (H - 1)(F - 1).
        /// </summary>
        /// <param name="H">Base number of logariphms: a 32-bit integer (>0).</param>
        /// <param name="F">A sublogariphmic number: a 32-bit integer (>0).</param>
        /// <returns>A ratio in string value of given expression.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when sublogariphmic numbers aren't greater than zero.</exception>
        public static string logRatioFormulaToString2B(int H, int F, int G)
        {
            if (F <= 0 || G <= 0 || H <= 0)
                throw new ArgumentOutOfRangeException("Rationalization error of: sublogariphmic numbers are greater than zero!");

            return $"({H} - 1)({F} - 1)";
        }

        // TOINTEGER;
        /// <summary>
        /// Converts given expression logH(F) to new view:: (H - 1)(F - 1).
        /// </summary>
        /// <param name="H">Base number of logariphms: a 32-bit integer (>0).</param>
        /// <param name="F">A sublogariphmic number: a 32-bit integer (>0).</param>
        /// <returns>A ratio in integer value of given expression.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when sublogariphmic numbers aren't greater than zero.</exception>
        public static int logRatioFormulaToInt2B(int H, int F)
        {
            if (F <= 0 || H <= 0)
                throw new ArgumentOutOfRangeException("Rationalization error of: sublogariphmic numbers are greater than zero!");

            return (int)(H - 1) * (F - 1);
        }
    }
}
