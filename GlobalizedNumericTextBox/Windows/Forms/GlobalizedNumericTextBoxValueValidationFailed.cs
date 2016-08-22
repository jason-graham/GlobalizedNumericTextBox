//---------------------------------------------------------------------------- 
//
//  Copyright (C) CSharp Labs.  All rights reserved.
// 
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
// 
// History
//  27/07/13    Created 
//
//---------------------------------------------------------------------------

namespace System.Windows.Forms
{
    /// <summary>
    /// Represents event data for when the <see cref="GlobalizedNumericTextBox.Text"/> property
    /// has failed validation.
    /// </summary>
    public sealed class GlobalizedNumericTextBoxValueValidationFailed : EventArgs
    {
        #region Fields
        /// <summary>
        /// Defines the invalid user input value.
        /// </summary>
        public readonly string Text;
        /// <summary>
        /// Defines the maximum number that can be entered and displayed.
        /// </summary>
        public readonly decimal Maximum;
        /// <summary>
        /// Defines the minimum number that can be entered and displayed.
        /// </summary>
        public readonly decimal Minimum;
        /// <summary>
        /// Defines a value to replace the invalid value with.
        /// </summary>
        private decimal? _ReplacementValue; 
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the replacement value to substitute for invalid user input.
        /// </summary>
        /// <exception cref="ArgumentException">Value greater-than Maximum.</exception>
        /// <exception cref="ArgumentException">Value less-than Minimum.</exception>
        public decimal? ReplacementValue
        {
            get
            {
                return _ReplacementValue;
            }
            set
            {
                if (_ReplacementValue != value)
                {
                    if (value > Maximum)
                        throw new ArgumentException("The specified value cannot be greater-than Maximum.", "ReplacementValue");

                    if (value < Minimum)
                        throw new ArgumentException("The specified value cannot be less-than Minimum.", "ReplacementValue");

                    _ReplacementValue = value;
                }
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes the event data with the text that failed validation and the minimum and maximum values.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        public GlobalizedNumericTextBoxValueValidationFailed(string text, decimal minimum, decimal maximum)
        {
            Text = text;
            Minimum = minimum;
            Maximum = maximum;
        } 
        #endregion
    }
}
