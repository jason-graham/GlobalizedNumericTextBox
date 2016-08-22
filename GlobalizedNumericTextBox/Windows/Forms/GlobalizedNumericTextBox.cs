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
//  21/08/16    Added smart tags for designer.
//---------------------------------------------------------------------------

namespace System.Windows.Forms
{
    using Design;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Globalization;
    using System.Media;
    using System.Runtime.InteropServices.Enums;

    /// <summary>
    /// The <see cref="GlobalizedNumericTextBox"/> control restricts and validates numeric input
    /// in any culturally appropriate format. 
    /// </summary>
    [Description("Restricts and validates numeric input in any culturally appropriate format."), DefaultProperty("Value"), DefaultEvent("ValueValidated"), Designer(typeof(GlobalizedNumericTextBoxDesigner))]
    public sealed class GlobalizedNumericTextBox : TextBox
    {
        #region Constants
        private const string VALUE_DESCRIPTION = "Defines the numerical value.";
        private const string APPEARANCE_CATEGORY = "Appearance";
        private const string BEHAVIOR_CATEGORY = "Behavior";
        private const string FORMATTING_CATEGORY = "Formatting";
        private const string SYSTEMBEEPONVALIDATIONFAILURE_DESCRIPTION = "Determines if the system Beep sound is played if a value fails validation.";
        private const string MAXIMUM_DESCRIPTION = "Defines the maximum number that can be entered and displayed.";
        private const string MINIMUM_DESCRIPTION = "Defined the minimum number that can be entered and displayed.";
        private const string DESETONESCAPE_DESCRIPTION = "Determines if pressing the Escape key while the GlobalizedNumericTextBox has focus will cause the field to revert back to the last validated value.";
        private const string CUSTOMFORMAT_DESCRIPTION = "Defines a custom format to use while formatting the underlying decimal value.";
        private const string DISPLAYFORMAT_DESCRIPTION = "Defines the type of formatting used to display the decimal value.";
        private const string POSITIVESIGN_DESCRIPTION = "Defines the string that denotes the associated number is positive.";
        private const string NumberNegativePattern_DESCRIPTION = "Defines the format pattern for negative numeric values.";
        private const string CurrencyDecimalDigits_DESCRIPTION = "Defines the number of decimal places to use in currency values.";
        private const string CurrencyDecimalSeparator_DESCRIPTION = "Defines the string to use as the decimal separator in currency values.";
        private const string CurrencyGroupSeparator_DESCRIPTION = "Defines the string that separates groups of digits to the left of the decimal in currency values.";
        private const string CurrencyGroupSizes_DESCRIPTION = "Defines the number of digits in each group to the left of the decimal in currency values.";
        private const string CurrencyNegativePattern_DESCRIPTION = "Defines the format pattern for negative currency values.";
        private const string CurrencyPositivePattern_DESCRIPTION = "Defines the format pattern for positive currency values.";
        private const string NumberGroupSizes_DESCRIPTION = "Defines the number of digits in each group to the left of the decimal in numeric values.";
        private const string CurrencySymbol_DESCRIPTION = "Defines the string to use as the currency symbol.";
        private const string NegativeSign_DESCRIPTION = "Defines the string that denotes that the associated number is negative.";
        private const string NumberDecimalDigits_DESCRIPTION = "Defines the number of decimal places to use in numeric values.";
        private const string NumberDecimalSeparator_DESCRIPTION = "Defines the string to use as the decimal separator in numeric values.";
        private const string NumberGroupSeparator_DESCRIPTION = "Defines the string the separates groups of digits to the left of the decimal in numeric values.";
        #endregion

        #region GlobalizedNumericTextBoxDesigner Class
        public class GlobalizedNumericTextBoxDesigner : ControlDesigner
        {
            private DesignerActionListCollection actionLists;

            public override DesignerActionListCollection ActionLists
            {
                get
                {
                    if (actionLists == null)
                    {
                        actionLists = new DesignerActionListCollection();

                        actionLists.Add(new GlobalizedNumbericTextBoxActionList(this.Component));
                    }

                    return actionLists;
                }
            }

            public class GlobalizedNumbericTextBoxActionList : System.ComponentModel.Design.DesignerActionList
            {
                private GlobalizedNumericTextBox component;
                private DesignerActionUIService service;

                public GlobalizedNumbericTextBoxActionList(IComponent component)
                    : base(component)
                {
                    this.component = component as GlobalizedNumericTextBox;
                    this.service = GetService(typeof(DesignerActionUIService)) as DesignerActionUIService;
                }

                private PropertyDescriptor GetPropertyByName(String propName)
                {
                    PropertyDescriptor prop = TypeDescriptor.GetProperties(component)[propName];

                    if (prop == null)
                        throw new ArgumentException("The specified GlobalizedNumericTextBox property does not exist.", propName);
                    else
                        return prop;
                }

                public decimal Value
                {
                    get
                    {
                        return component.Value;
                    }
                    set
                    {
                        GetPropertyByName(nameof(component.Value)).SetValue(component, value);
                    }
                }

                public decimal Maximum
                {
                    get
                    {
                        return component.Maximum;
                    }
                    set
                    {
                        GetPropertyByName(nameof(component.Maximum)).SetValue(component, value);
                    }
                }

                public decimal Minimum
                {
                    get
                    {
                        return component.Minimum;
                    }
                    set
                    {
                        GetPropertyByName(nameof(component.Minimum)).SetValue(component, value);
                    }
                }

                public bool ResetOnEscape
                {
                    get
                    {
                        return component.ResetOnEscape;
                    }
                    set
                    {
                        GetPropertyByName(nameof(component.ResetOnEscape)).SetValue(component, value);
                    }
                }

                public bool SystemBeepOnValidationFailure
                {
                    get
                    {
                        return component.SystemBeepOnValidationFailure;
                    }
                    set
                    {
                        GetPropertyByName(nameof(component.SystemBeepOnValidationFailure)).SetValue(component, value);
                    }
                }

                public string CustomFormat
                {
                    get
                    {
                        return component.CustomFormat;
                    }
                    set
                    {
                        GetPropertyByName(nameof(component.CustomFormat)).SetValue(component, value);
                    }
                }

                public int CurrencyDecimalDigits
                {
                    get
                    {
                        return component.CurrencyDecimalDigits;
                    }
                    set
                    {
                        GetPropertyByName(nameof(component.CurrencyDecimalDigits)).SetValue(component, value);
                    }
                }

                public string CurrencyDecimalSeparator
                {
                    get
                    {
                        return component.CurrencyDecimalSeparator;
                    }
                    set
                    {
                        GetPropertyByName(nameof(component.CurrencyDecimalSeparator)).SetValue(component, value);
                    }
                }

                public string CurrencyGroupSeparator
                {
                    get
                    {
                        return component.CurrencyGroupSeparator;
                    }
                    set
                    {
                        GetPropertyByName(nameof(component.CurrencyGroupSeparator)).SetValue(component, value);
                    }
                }

                public int[] CurrencyGroupSizes
                {
                    get
                    {
                        return component.CurrencyGroupSizes;
                    }
                    set
                    {
                        GetPropertyByName(nameof(component.CurrencyGroupSizes)).SetValue(component, value);
                    }
                }

                public int CurrencyNegativePattern
                {
                    get
                    {
                        return component.CurrencyNegativePattern;
                    }
                    set
                    {
                        GetPropertyByName(nameof(component.CurrencyNegativePattern)).SetValue(component, value);
                    }
                }

                public int CurrencyPositivePattern
                {
                    get
                    {
                        return component.CurrencyPositivePattern;
                    }
                    set
                    {
                        GetPropertyByName(nameof(component.CurrencyPositivePattern)).SetValue(component, value);
                    }
                }

                public string CurrencySymbol
                {
                    get
                    {
                        return component.CurrencySymbol;
                    }
                    set
                    {
                        GetPropertyByName(nameof(component.CurrencySymbol)).SetValue(component, value);
                    }
                }

                public string NegativeSign
                {
                    get
                    {
                        return component.NegativeSign;
                    }
                    set
                    {
                        GetPropertyByName(nameof(component.NegativeSign)).SetValue(component, value);
                    }
                }

                public int NumberDecimalDigits
                {
                    get
                    {
                        return component.NumberDecimalDigits;
                    }
                    set
                    {
                        GetPropertyByName(nameof(component.NumberDecimalDigits)).SetValue(component, value);
                    }
                }

                public string NumberDecimalSeparator
                {
                    get
                    {
                        return component.NumberDecimalSeparator;
                    }
                    set
                    {
                        GetPropertyByName(nameof(component.NumberDecimalSeparator)).SetValue(component, value);
                    }
                }

                public string NumberGroupSeparator
                {
                    get
                    {
                        return component.NumberGroupSeparator;
                    }
                    set
                    {
                        GetPropertyByName(nameof(component.NumberGroupSeparator)).SetValue(component, value);
                    }
                }

                public int[] NumberGroupSizes
                {
                    get
                    {
                        return component.NumberGroupSizes;
                    }
                    set
                    {
                        GetPropertyByName(nameof(component.NumberGroupSizes)).SetValue(component, value);
                    }
                }

                public int NumberNegativePattern
                {
                    get
                    {
                        return component.NumberNegativePattern;
                    }
                    set
                    {
                        GetPropertyByName(nameof(component.NumberNegativePattern)).SetValue(component, value);
                    }
                }

                public string PositiveSign
                {
                    get
                    {
                        return component.PositiveSign;
                    }
                    set
                    {
                        GetPropertyByName(nameof(component.PositiveSign)).SetValue(component, value);
                    }
                }

                public GlobalizedNumericTextBoxDisplayFormat DisplayFormat
                {
                    get
                    {
                        return component.DisplayFormat;
                    }
                    set
                    {
                        GetPropertyByName(nameof(component.DisplayFormat)).SetValue(component, value);
                    }
                }

                public override DesignerActionItemCollection GetSortedActionItems()
                {
                    DesignerActionItemCollection items = new DesignerActionItemCollection();

                    items.Add(new DesignerActionHeaderItem(APPEARANCE_CATEGORY));
                    items.Add(new DesignerActionHeaderItem(BEHAVIOR_CATEGORY));
                    items.Add(new DesignerActionHeaderItem(FORMATTING_CATEGORY));

                    items.Add(new DesignerActionPropertyItem(nameof(Value),
                                         "Value", APPEARANCE_CATEGORY,
                                         VALUE_DESCRIPTION));

                    items.Add(new DesignerActionPropertyItem(nameof(Maximum),
                                         "Maximum", BEHAVIOR_CATEGORY,
                                         MAXIMUM_DESCRIPTION));

                    items.Add(new DesignerActionPropertyItem(nameof(Minimum),
                                         "Minimum", BEHAVIOR_CATEGORY,
                                         MINIMUM_DESCRIPTION));

                    items.Add(new DesignerActionPropertyItem(nameof(ResetOnEscape),
                                         "Reset On Escape", BEHAVIOR_CATEGORY,
                                         DESETONESCAPE_DESCRIPTION));

                    items.Add(new DesignerActionPropertyItem(nameof(CustomFormat),
                                         "Custom Format", BEHAVIOR_CATEGORY,
                                         CUSTOMFORMAT_DESCRIPTION));

                    items.Add(new DesignerActionPropertyItem(nameof(SystemBeepOnValidationFailure),
                                         "System Beep On Validation Failure", BEHAVIOR_CATEGORY,
                                         SYSTEMBEEPONVALIDATIONFAILURE_DESCRIPTION));

                    items.Add(new DesignerActionPropertyItem(nameof(CurrencyDecimalDigits),
                                         "Currency Decimal Digits", FORMATTING_CATEGORY,
                                         CurrencyDecimalDigits_DESCRIPTION));

                    items.Add(new DesignerActionPropertyItem(nameof(CurrencyDecimalSeparator),
                                         "Currency Decimal Separator", FORMATTING_CATEGORY,
                                         CurrencyDecimalSeparator_DESCRIPTION));

                    items.Add(new DesignerActionPropertyItem(nameof(CurrencyGroupSeparator),
                                         "Currency Group Separator", FORMATTING_CATEGORY,
                                         CurrencyGroupSeparator_DESCRIPTION));

                    items.Add(new DesignerActionPropertyItem(nameof(CurrencyGroupSizes),
                                         "Currency Group Sizes", FORMATTING_CATEGORY,
                                         CurrencyGroupSizes_DESCRIPTION));

                    items.Add(new DesignerActionPropertyItem(nameof(CurrencyNegativePattern),
                                         "Currency Negative Pattern", FORMATTING_CATEGORY,
                                         CurrencyNegativePattern_DESCRIPTION));

                    items.Add(new DesignerActionPropertyItem(nameof(CurrencyPositivePattern),
                                         "Currency Positive Pattern", FORMATTING_CATEGORY,
                                         CurrencyPositivePattern_DESCRIPTION));

                    items.Add(new DesignerActionPropertyItem(nameof(CurrencySymbol),
                                         "Currency Symbol", FORMATTING_CATEGORY,
                                         CurrencySymbol_DESCRIPTION));

                    items.Add(new DesignerActionPropertyItem(nameof(NegativeSign),
                                         "Negative Sign", FORMATTING_CATEGORY,
                                         NegativeSign_DESCRIPTION));

                    items.Add(new DesignerActionPropertyItem(nameof(NumberDecimalDigits),
                                         "Number Decimal Digits", FORMATTING_CATEGORY,
                                         NumberDecimalDigits_DESCRIPTION));

                    items.Add(new DesignerActionPropertyItem(nameof(NumberDecimalSeparator),
                                         "Number Decimal Separator", FORMATTING_CATEGORY,
                                         NumberDecimalSeparator_DESCRIPTION));

                    items.Add(new DesignerActionPropertyItem(nameof(NumberGroupSeparator),
                                         "Number Group Separator", FORMATTING_CATEGORY,
                                         NumberGroupSeparator_DESCRIPTION));

                    items.Add(new DesignerActionPropertyItem(nameof(NumberGroupSizes),
                                         "Number Group Sizes", FORMATTING_CATEGORY,
                                         NumberGroupSizes_DESCRIPTION));

                    items.Add(new DesignerActionPropertyItem(nameof(NumberNegativePattern),
                                         "Number Negative Pattern", FORMATTING_CATEGORY,
                                         NumberNegativePattern_DESCRIPTION));

                    items.Add(new DesignerActionPropertyItem(nameof(PositiveSign),
                                         "Positive Sign", FORMATTING_CATEGORY,
                                         POSITIVESIGN_DESCRIPTION));

                    items.Add(new DesignerActionPropertyItem(nameof(DisplayFormat),
                                         "Display Format", FORMATTING_CATEGORY,
                                         DISPLAYFORMAT_DESCRIPTION));

                    return items;
                }
            }
        }
        #endregion

        #region Fields
        /// <summary>
        /// Defines the culturally appropriate format for displaying numbers and currency.
        /// </summary>
        private NumberFormatInfo numberFormat;
        /// <summary>
        /// Defines the display format used when formatting the underlying decimal value.
        /// </summary>
        private GlobalizedNumericTextBoxDisplayFormat displayFormat;
        /// <summary>
        /// Defines the style used when parsing text into a decimal.
        /// </summary>
        private NumberStyles numberStyle = NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign |
                NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint |
                NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowCurrencySymbol;
        /// <summary>
        /// Defines the underlying value represented by the <see cref="GlobalizedNumericTextBox"/>.
        /// </summary>
        private decimal value = 0;
        /// <summary>
        /// Defines the maximum value that can be displayed in the <see cref="GlobalizedNumericTextBox"/>.
        /// </summary>
        private decimal maximum = decimal.MaxValue;
        /// <summary>
        /// Defines the minimum value that can be displayed in the <see cref="GlobalizedNumericTextBox"/>.
        /// </summary>
        private decimal minimum = decimal.MinValue;
        /// <summary>
        /// Defines the custom format string used to format the underlying value into text.
        /// </summary>
        private string customFormat = string.Empty;
        #endregion

        #region Events
        /// <summary>
        /// The <see cref="ValueValidated"/> event is raised when the Text property has been changed
        /// and validated successfully.
        /// </summary>
        public event EventHandler<GlobalizedNumericTextBoxValueValidated> ValueValidated;
        /// <summary>
        /// The <see cref="ValidationFailed"/> event is raised when the Text property has been changed
        /// and validation failed.
        /// </summary>
        public event EventHandler<GlobalizedNumericTextBoxValueValidationFailed> ValidationFailed;
        #endregion

        #region Properties
        #region NumberFormat Properties
        /// <summary>
        /// Gets or sets the number of decimal places to use in currency values.
        /// </summary>
        [Description(CurrencyDecimalDigits_DESCRIPTION),
        Category(FORMATTING_CATEGORY)]
        public int CurrencyDecimalDigits
        {
            get
            {
                return NumberFormat.CurrencyDecimalDigits;
            }
            set
            {
                if (NumberFormat.CurrencyDecimalDigits != value)
                {
                    NumberFormat.CurrencyDecimalDigits = value;
                    FormatTextUpdateValue();
                }
            }
        }

        /// <summary>
        /// Gets or sets the string to use as the decimal separator in currency values.
        /// </summary>
        [Description(CurrencyDecimalSeparator_DESCRIPTION),
        Category(FORMATTING_CATEGORY)]
        public string CurrencyDecimalSeparator
        {
            get
            {
                return NumberFormat.CurrencyDecimalSeparator;
            }
            set
            {
                if (NumberFormat.CurrencyDecimalSeparator != value)
                {
                    NumberFormat.CurrencyDecimalSeparator = value;
                    FormatTextUpdateValue();
                }
            }
        }

        /// <summary>
        /// Gets or sets the string that separates groups of digits to the left of the decimal in currency values.
        /// </summary>
        [Description(CurrencyGroupSeparator_DESCRIPTION),
        Category(FORMATTING_CATEGORY)]
        public string CurrencyGroupSeparator
        {
            get
            {
                return NumberFormat.CurrencyGroupSeparator;
            }
            set
            {
                if (NumberFormat.CurrencyGroupSeparator != value)
                {
                    NumberFormat.CurrencyGroupSeparator = value;
                    FormatTextUpdateValue();
                }
            }
        }

        /// <summary>
        /// Gets or sets the number of digits in each group to the left of the decimal in currency values.
        /// </summary>
        [Description(CurrencyGroupSizes_DESCRIPTION),
        Category(FORMATTING_CATEGORY)]
        public int[] CurrencyGroupSizes
        {
            get
            {
                return NumberFormat.CurrencyGroupSizes;
            }
            set
            {
                if (NumberFormat.CurrencyGroupSizes != value)
                {
                    NumberFormat.CurrencyGroupSizes = value;
                    FormatTextUpdateValue();
                }
            }
        }

        /// <summary>
        /// Gets or sets the format pattern for negative currency values.
        /// </summary>
        [Description(CurrencyNegativePattern_DESCRIPTION),
        Category(FORMATTING_CATEGORY)]
        public int CurrencyNegativePattern
        {
            get
            {
                return NumberFormat.CurrencyNegativePattern;
            }
            set
            {
                if (NumberFormat.CurrencyNegativePattern != value)
                {
                    NumberFormat.CurrencyNegativePattern = value;
                    FormatTextUpdateValue();
                }
            }
        }

        /// <summary>
        /// Gets or sets the format pattern for positive currency values.
        /// </summary>
        [Description(CurrencyPositivePattern_DESCRIPTION),
        Category(FORMATTING_CATEGORY)]
        public int CurrencyPositivePattern
        {
            get
            {
                return NumberFormat.CurrencyPositivePattern;
            }
            set
            {
                if (NumberFormat.CurrencyPositivePattern != value)
                {
                    NumberFormat.CurrencyPositivePattern = value;
                    FormatTextUpdateValue();
                }
            }
        }

        /// <summary>
        /// Gets or sets the string to use as the currency symbol.
        /// </summary>
        [Description(CurrencySymbol_DESCRIPTION),
        Category(FORMATTING_CATEGORY)]
        public string CurrencySymbol
        {
            get
            {
                return NumberFormat.CurrencySymbol;
            }
            set
            {
                if (NumberFormat.CurrencySymbol != value)
                {
                    NumberFormat.CurrencySymbol = value;
                    FormatTextUpdateValue();
                }
            }
        }

        /// <summary>
        /// Gets or sets the string that denotes that the associated number is negative.
        /// </summary>
        [Description(NegativeSign_DESCRIPTION),
        Category(FORMATTING_CATEGORY)]
        public string NegativeSign
        {
            get
            {
                return NumberFormat.NegativeSign;
            }
            set
            {
                if (NumberFormat.NegativeSign != value)
                {
                    NumberFormat.NegativeSign = value;
                    FormatTextUpdateValue();
                }
            }
        }

        /// <summary>
        /// Gets or sets the number of decimal places to use in numeric values.
        /// </summary>
        [Description(NumberDecimalDigits_DESCRIPTION),
        Category(FORMATTING_CATEGORY)]
        public int NumberDecimalDigits
        {
            get
            {
                return NumberFormat.NumberDecimalDigits;
            }
            set
            {
                if (NumberFormat.NumberDecimalDigits != value)
                {
                    NumberFormat.NumberDecimalDigits = value;
                    FormatTextUpdateValue();
                }
            }
        }

        /// <summary>
        /// Gets or sets the string to use as the decimal separator in numeric values.
        /// </summary>
        [Description(NumberDecimalSeparator_DESCRIPTION),
        Category(FORMATTING_CATEGORY)]
        public string NumberDecimalSeparator
        {
            get
            {
                return NumberFormat.NumberDecimalSeparator;
            }
            set
            {
                if (NumberFormat.NumberDecimalSeparator != value)
                {
                    NumberFormat.NumberDecimalSeparator = value;
                    FormatTextUpdateValue();
                }
            }
        }

        /// <summary>
        /// Gets or sets the string that separates groups of digits to the left of the decimal in numeric values.
        /// </summary>
        [Description(NumberGroupSeparator_DESCRIPTION),
        Category(FORMATTING_CATEGORY)]
        public string NumberGroupSeparator
        {
            get
            {
                return NumberFormat.NumberGroupSeparator;
            }
            set
            {
                if (NumberFormat.NumberGroupSeparator != value)
                {
                    NumberFormat.NumberGroupSeparator = value;
                    FormatTextUpdateValue();
                }
            }
        }

        /// <summary>
        /// Gets or sets the number of digits in each group to the left of the decimal in numeric values.
        /// </summary>
        [Description(NumberGroupSizes_DESCRIPTION),
        Category(FORMATTING_CATEGORY)]
        public int[] NumberGroupSizes
        {
            get
            {
                return NumberFormat.NumberGroupSizes;
            }
            set
            {
                if (NumberFormat.NumberGroupSizes != value)
                {
                    NumberFormat.NumberGroupSizes = value;
                    FormatTextUpdateValue();
                }
            }
        }

        /// <summary>
        /// Gets or sets the format pattern for negative numeric values.
        /// </summary>
        [Description(NumberNegativePattern_DESCRIPTION),
        Category(FORMATTING_CATEGORY)]
        public int NumberNegativePattern
        {
            get
            {
                return NumberFormat.NumberNegativePattern;
            }
            set
            {
                if (NumberFormat.NumberNegativePattern != value)
                {
                    NumberFormat.NumberNegativePattern = value;
                    FormatTextUpdateValue();
                }
            }
        }

        /// <summary>
        /// Gets or sets the string that denotes that the associated number is positive.
        /// </summary>
        [Description(POSITIVESIGN_DESCRIPTION),
        Category(FORMATTING_CATEGORY)]
        public string PositiveSign
        {
            get
            {
                return NumberFormat.PositiveSign;
            }
            set
            {
                if (NumberFormat.PositiveSign != value)
                {
                    NumberFormat.PositiveSign = value;
                    FormatTextUpdateValue();
                }
            }
        }

        /// <summary>
        /// Gets or sets the format to display decimal value.
        /// </summary>
        /// <exception cref="InvalidEnumArgumentException">GlobalizedNumericTextBoxDisplayFormat value is not defined.</exception>
        [Description(DISPLAYFORMAT_DESCRIPTION),
        Category(FORMATTING_CATEGORY)]
        public GlobalizedNumericTextBoxDisplayFormat DisplayFormat
        {
            get
            {
                return displayFormat;
            }
            set
            {
                if (displayFormat != value)
                {
                    if (!Enum.IsDefined(typeof(GlobalizedNumericTextBoxDisplayFormat), value))
                        throw new InvalidEnumArgumentException(string.Format("The System.Enum Type: '{0}' Value: '{1}' is not defined.", value.GetType(), value));

                    displayFormat = value;
                    FormatTextUpdateValue();
                }
            }
        }

        /// <summary>
        /// Gets or sets how numeric values are formatted and displayed.
        /// </summary>
        [Browsable(false),
        EditorBrowsable(EditorBrowsableState.Never),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public NumberFormatInfo NumberFormat
        {
            get
            {
                if (numberFormat == null)
                    numberFormat = (NumberFormatInfo)CultureInfo.CurrentCulture.NumberFormat.Clone();

                return numberFormat;
            }
            set
            {
                if (numberFormat != value)
                {
                    if (value == null)
                        throw new ArgumentNullException("NumberFormat");

                    numberFormat = value;
                    FormatTextUpdateValue();
                }
            }
        }
        #endregion

        /// <summary>
        /// Gets or sets the maximum number that can be entered and displayed.
        /// </summary>
        /// <exception cref="ArgumentException">Maximum cannot be less than Minimum.</exception>
        [Description(MAXIMUM_DESCRIPTION),
        Category(BEHAVIOR_CATEGORY)]
        public decimal Maximum
        {
            get
            {
                return maximum;
            }
            set
            {
                if (maximum != value)
                {
                    if (value < minimum)
                        throw new ArgumentException("Maximum cannot be less than Minimum.");

                    maximum = value;

                    if (this.value > maximum)
                    {
                        this.value = maximum;
                        FormatTextUpdateValue();
                    }
                }
            }
        }

        /// <summary>
        /// Gets or sets the minimum number that can be entered and displayed.
        /// </summary>
        /// <exception cref="ArgumentException">Minimum cannot be greater than Maximum.</exception>
        [Description(MINIMUM_DESCRIPTION),
        Category(BEHAVIOR_CATEGORY)]
        public decimal Minimum
        {
            get
            {
                return minimum;
            }
            set
            {
                if (minimum != value)
                {
                    if (value > maximum)
                        throw new ArgumentException("Minimum cannot be greater than Maximum.");

                    minimum = value;

                    if (this.value < minimum)
                    {
                        this.value = minimum;
                        FormatTextUpdateValue();
                    }
                }
            }
        }

        /// <summary>
        /// Gets or sets if pressing the Escape key while the <see cref="GlobalizedNumericTextBox"/>
        /// has focus will cause the field to revert back to the last validated value.
        /// </summary>
        [Description(DESETONESCAPE_DESCRIPTION),
        Category(BEHAVIOR_CATEGORY)]
        public bool ResetOnEscape
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a custom format to use while formatting the underlying decimal value.
        /// </summary>
        [Description(CUSTOMFORMAT_DESCRIPTION),
        Category(BEHAVIOR_CATEGORY)]
        public string CustomFormat
        {
            get
            {
                return customFormat;
            }
            set
            {
                if (customFormat != value)
                {
                    customFormat = value;

                    if (DisplayFormat == GlobalizedNumericTextBoxDisplayFormat.CustomFormat)
                        FormatTextUpdateValue();
                }
            }
        }

        /// <summary>
        /// Gets or sets if the system Beep sound is played if a value fails validation.
        /// </summary>
        [Description(SYSTEMBEEPONVALIDATIONFAILURE_DESCRIPTION),
        Category(BEHAVIOR_CATEGORY)]
        private bool SystemBeepOnValidationFailure
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the numerical value of the <see cref="GlobalizedNumericTextBox"/> control.
        /// </summary>
        /// <exception cref="ArgumentException">Value greater-than Maximum.</exception>
        /// <exception cref="ArgumentException">Value less-than Minimum.</exception>
        [Description(VALUE_DESCRIPTION),
        Category(APPEARANCE_CATEGORY)]
        public decimal Value
        {
            get
            {
                return value;
            }
            set
            {
                if (this.value != value)
                {
                    if (value > maximum)
                        throw new ArgumentException("The specified value cannot be greater-than Maximum.", "Value");

                    if (value < minimum)
                        throw new ArgumentException("The specified value cannot be less-than Minimum.", "Value");

                    this.value = value;
                    FormatTextUpdateValue();
                }
            }
        }

        /// <summary>
        /// The <see cref="Text"/> property may return uncommitted or invalid data.
        /// For validated data, use the <see cref="Value"/> property instead.
        /// </summary>
        [Browsable(false),
        EditorBrowsable(EditorBrowsableState.Never),
        Bindable(false),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),
        ReadOnly(true)]
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {

            }
        }

        /// <summary>
        /// Multiline is disabled for the <see cref="GlobalizedNumericTextBox"/>.
        /// </summary>
        [Browsable(false),
        EditorBrowsable(EditorBrowsableState.Never),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),
        ReadOnly(true)]
        public override bool Multiline
        {
            get
            {
                return false;
            }
            set
            {

            }
        }

        /// <summary>
        /// Gets if the <see cref="GlobalizedNumericTextBox.Text"/> property contains
        /// uncommitted data.
        /// </summary>
        [Browsable(false),
        EditorBrowsable(EditorBrowsableState.Never),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDirty
        {
            get
            {
                return Text != FormatText();
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes the numeric textbox.
        /// </summary>
        public GlobalizedNumericTextBox()
        {
            SystemBeepOnValidationFailure = ResetOnEscape = true;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Updates the <see cref="TextBox.Text"/> property when added to a container.
        /// </summary>
        protected override void InitLayout()
        {
            FormatTextUpdateValue();
            base.InitLayout();
        }

        /// <summary>
        /// Resets the <see cref="Text"/> property back to the last
        /// successfully validated value.
        /// </summary>
        public void CancelChanges()
        {
            base.Text = FormatText();
        }

        /// <summary>
        /// The OnValidating method is overridden to validate the underlying Text property
        /// to determine if focus can be lost.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnValidating(System.ComponentModel.CancelEventArgs e)
        {
            if (base.Text.Length > 0)
            {
                decimal candidate;
                //check if the Text can by parsed into a decimal with
                //the specified NumberStyles and NumberFormatInfo and
                //the resulting value is not greater-than or less-than
                //the maximum and minimum values:
                if (!decimal.TryParse(base.Text, numberStyle, NumberFormat, out candidate) ||
                    candidate > maximum || candidate < minimum)
                {
                    //if validation failed, raise the ValidationFailed
                    //event to allow a substitute value
                    if (ValidationFailed != null)
                    {
                        //create event args
                        GlobalizedNumericTextBoxValueValidationFailed args = new GlobalizedNumericTextBoxValueValidationFailed(base.Text, Minimum, Maximum);
                        //raise event
                        ValidationFailed(this, args);

                        //check if a replacement value was supplied
                        if (args.ReplacementValue.HasValue)
                            value = args.ReplacementValue.Value; //update _Value
                        else
                            e.Cancel = true; //validation failed
                    }
                    else
                        e.Cancel = true; //validation failed
                }
                else //validation succeeded
                    value = candidate; //update _Value
            }
            else if (maximum >= 0 && minimum <= 0) //attempt to infer meaning of empty Text
                value = 0; //update _Value
            else //could not infer
                e.Cancel = true; //validation failed

            //if validation failed, play system beep if applicable
            if (e.Cancel && SystemBeepOnValidationFailure)
                SystemSounds.Beep.Play();

            base.OnValidating(e);
        }

        #region Processing Messages
        /// <summary>
        /// This method will pre-process the WM_CHAR message for the purpose
        /// of consuming only valid characters.        
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public override bool PreProcessMessage(ref Message msg)
        {
            //look for the WM_CHAR message
            if ((WindowsMessages)msg.Msg == WindowsMessages.WM_CHAR)
                //determines if the character is valid and the message should be consumed
                //returns indicating if the message has been processed
                return !ConsumeCharacter((char)msg.WParam);
            else
                return base.PreProcessMessage(ref msg);
        }

        /// <summary>
        /// Determines if the specified character is part
        /// of a valid decimal.
        /// </summary>
        /// <param name="c">The character to validate.</param>
        /// <returns>true if the character should be consumed; otherwise, false.</returns>
        private bool ConsumeCharacter(char c)
        {
            //if escape is pressed, reset text and cancel key press
            if (ResetOnEscape && c == (char)27) //escape char : 27
            {
                //resets Text property
                CancelChanges();

                //select all text to allow easy changes and make the update apparent 
                SelectAll();

                //cancel character
                return false;
            }

            if (char.IsControl(c))
                //allow control characters
                return true;

            if (char.IsNumber(c))
                //allow number characters
                return true;

            //when validating decimal separators, or group separators, the string.IndexOf
            //method is used instead of comparing character due to the possibility of 
            //more then one character being used as a separator
            if (DisplayFormat == GlobalizedNumericTextBoxDisplayFormat.Currency)
            {
                //validate currency symbol
                if (NumberFormat.CurrencySymbol.IndexOf(c) > -1)
                    //allow currency symbol e.g. $1000
                    return true;

                //validate currency decimal separator
                if (numberStyle.HasFlag(NumberStyles.AllowDecimalPoint) && NumberFormat.CurrencyDecimalDigits > 0 && NumberFormat.CurrencyDecimalSeparator.IndexOf(c) > -1)
                    //allow decimal separator $1000.00
                    return true;

                //validate currency group separator
                if (numberStyle.HasFlag(NumberStyles.AllowThousands) && NumberFormat.CurrencyGroupSeparator.IndexOf(c) > -1)
                    //allow currency group separator e.g. $1,000
                    return true;
            }
            else
            {
                //validate decimal separator
                if (numberStyle.HasFlag(NumberStyles.AllowDecimalPoint) && NumberFormat.NumberDecimalDigits > 0 && NumberFormat.NumberDecimalSeparator.IndexOf(c) > -1)
                    //allow decimal separator e.g. 1000.00
                    return true;

                //validate group separator
                if (numberStyle.HasFlag(NumberStyles.AllowThousands) && NumberFormat.NumberGroupSeparator.IndexOf(c) > -1)
                    //allow group separator e.g. 1,000
                    return true;
            }

            //validate whitespace
            if ((numberStyle.HasFlag(NumberStyles.AllowLeadingWhite) || numberStyle.HasFlag(NumberStyles.AllowTrailingWhite)) && char.IsWhiteSpace(c))
                //allows whitespace e.g. ' 1000 ' || '$ 1000'
                return true;

            //validate number sign
            if ((numberStyle.HasFlag(NumberStyles.AllowLeadingSign) || numberStyle.HasFlag(NumberStyles.AllowTrailingSign)) && (NumberFormat.PositiveSign.IndexOf(c) > -1 || NumberFormat.NegativeSign.IndexOf(c) > -1))
                return true;

            //validate parentheses which are allowed to indicate
            //a negative number
            if (numberStyle.HasFlag(NumberStyles.AllowParentheses))
            {
                if (c == '(' && base.Text.IndexOf('(') == -1)
                    return true;

                if (c == ')' && base.Text.IndexOf(')') == -1)
                    return true;
            }

            //validate exponential notation E/e character
            if (numberStyle.HasFlag(NumberStyles.AllowExponent) && (c == 'E' || c == 'e'))
                return true;

            return false;
        }
        #endregion

        /// <summary>
        /// After the value is validated or changes are canceled,
        /// formats the decimal and updates the Text property.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnValidated(EventArgs e)
        {
            //formats the decimal as a string, updates the Text property,
            //raises events:
            FormatTextUpdateValue();

            base.OnValidated(e);
        }

        /// <summary>
        /// This method formats the underlying decimal and immediately updates
        /// the _Value field to the numerical equivalent. This is done to ensure
        /// both the <see cref="Text"/> and <see cref="Value"/> properties
        /// are equivalent.
        /// </summary>
        private void FormatTextUpdateValue()
        {
            //format decimal as string
            string text = FormatText();

            //check if Text property should be updated
            if (text != base.Text)
            {
                //update decimal value to ensure equality
                value = decimal.Parse(text, numberStyle, NumberFormat);

                //update Text property to new value
                base.Text = text;

                //raise ValueValidated event to notify changes
                if (ValueValidated != null)
                    ValueValidated(this, new GlobalizedNumericTextBoxValueValidated(base.Text, value));
            }
        }

        /// <summary>
        /// Formats the underlying decimal value to a string.
        /// </summary>
        /// <returns>The value formatted as a string.</returns>
        private string FormatText()
        {
            switch (DisplayFormat)
            {
                case GlobalizedNumericTextBoxDisplayFormat.Currency:
                    //format decimal as currency
                    return value.ToString("C", NumberFormat);
                case GlobalizedNumericTextBoxDisplayFormat.Exponent:
                    //format decimal as exponent
                    return value.ToString("E", NumberFormat);
                case GlobalizedNumericTextBoxDisplayFormat.Normal:
                    //format decimal default
                    return value.ToString("N", NumberFormat);
                case GlobalizedNumericTextBoxDisplayFormat.CustomFormat:
                    //format decimal custom
                    return value.ToString(CustomFormat, NumberFormat);
                default:
                    throw new InvalidEnumArgumentException(string.Format("The System.Enum Type: '{0}' Value: '{1}' is not defined.", DisplayFormat.GetType(), DisplayFormat));
            }
        }
        #endregion
    }
}