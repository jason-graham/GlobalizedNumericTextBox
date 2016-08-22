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
    /// is successfully validated.
    /// </summary>
    public class GlobalizedNumericTextBoxValueValidated : EventArgs
    {
        /// <summary>
        /// Defines the <see cref="GlobalizedNumericTextBoxValue.Text"/> value
        /// that has been successfully validated.
        /// </summary>
        public readonly string Text;
        /// <summary>
        /// Defines the <see cref="GlobalizedNumericTextBoxValue.Value"/>
        /// that has been successfully validated.
        /// </summary>
        public readonly decimal Value;

        /// <summary>
        /// Initializes the event data with the text that has been validated and the resulting value.        
        /// </summary>
        /// <param name="text">The text that has been validated.</param>
        /// <param name="value">The validated text converted to a decimal.</param>
        public GlobalizedNumericTextBoxValueValidated(string text, decimal value)
        {
            Text = text;
            Value = value;
        }
    }
}
