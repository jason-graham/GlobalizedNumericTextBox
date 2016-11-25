//---------------------------------------------------------------------------- 
//
//  Copyright (C) Jason Graham.  All rights reserved.
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
    /// Defines the display format for values in the <see cref="GlobalizedNumericTextBox"/>.
    /// </summary>
    public enum GlobalizedNumericTextBoxDisplayFormat
    {
        /// <summary>
        /// Indicates that the numeric string is formatted with default formatting.
        /// </summary>
        Normal = 0,
        /// <summary>
        /// Indicates that the numeric string is formatted with a currency symbol.
        /// </summary>
        Currency = 1,
        /// <summary>
        /// Indicates that the numeric string is formatted in exponential notation.
        /// </summary>
        Exponent = 2,
        /// <summary>
        /// Indicates that the numeric string is formatted using the user provided CustomFormat.
        /// </summary>
        CustomFormat = 3
    }
}
