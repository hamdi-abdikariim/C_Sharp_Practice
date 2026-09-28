# processing data

## Topics

- 3.1 Reading Input with TextBox Controls
- 3.2 A First Look at Variables
- 3.3 Numeric Data Type and Variables
- 3.4 Performing Calculations
- 3.5 Inputting and Outputting Numeric Values
- 3.6 Formatting Numbers with the ToString Method
- 3.7 Simple Exception Handling
- 3.9 Declaring Variables as Fields
- 3.10 Using the Math Class
- 3.11 More G U I Details
- 3.12 Using the Debugger to Locate Logic Errors

---

## 3.1 Reading Input with TextBox Controls

A TextBox control:

- is a rectangular area
- can accept keyboard input from the user
- is located in the Common Control group of the Toolbox
- is added to the form by double clicking it
- has a default name of `textBoxn`, where n is 1, 2, 3, …

### The Text Property

- A TextBox control’s Text property stores the user’s input.
- The Text property accepts only string values.
- To clear the content of a TextBox control, assign an empty string (`""`), assign `string.Empty`, or call the `Clear()` method.

---

## 3.2 A First Look at Variables

- A variable is a storage location in memory. A variable name represents the memory location.
- you must declare a variable in a program before In using it to store data
- The syntax to declare variables is: `DataType VariableName;`

### Data Types

- A variable must be declared with a proper data type. The data type specifies the type of data a variable can hold.
- many data types are known as primitive data types In they store fundamental types of data (means essential or core such as strings and integers
- “Primitive” means basic / simple / built-in. In C#, primitive data types are already defined by the language, not created by you.

### Variable Names

- A variable name identifies a variable. Always choose a meaningful name for variables.
- Basic naming conventions:
  - the first character must be a letter (upper or lowercase) or an underscore (_)
  - the name cannot contain spaces
  - keywords or reserved words do not use

### String Variables

- A string is a combination of characters.
- A variable of the string data type can hold any combination of characters, such as names, phone numbers, and social security numbers.
- The value of a string variable is assigned on the right of the = operator, surrounded by a pair of double quotes (e.g. `productDescription = "Jamhuuriya University";`).
- A string variable can be assigned to a Label control (e.g. `productLabel = productDescription;`) or displayed in a Message Box (`MessageBox.Show(productDescription);`).

### String Concatenation

- Concatenation is the appending of one string to the end of another string.
- the + operator is used for concatenation In
- Concatenation can happen between a string and another data type: int and string, double and string (e.g. `12 + " apples"`, `"Total is " + 25.75`).

### Declaring Variables Before Using Them

- You can declare variables and use them later.
- In the slides’ example, a string variable is declared to hold the full name, the names from two TextBoxes are combined with a space between them and assigned to the variable, and the variable is displayed in the fullName Label control.

### Local Variables and Scope

- A local variable belongs to the method in which it was declared. Only statements inside that method can access the variable.
- **Scope** describes the part of a program in which a variable may be accessed.
- **Lifetime** of a variable is the time period during which the variable exists in memory while the program is executing.
- A local variable is created in memory when the method in which it is declared starts executing. When the method ends, all the method’s local variables are destroyed.
- In the slides’ example, a variable declared in one Button’s Click method is used in another Button’s Click method, which causes an error.

### Duplicate Variable Names

- You cannot declare two variables with the same name in the same scope. For example, if you declare a variable named productDescription in an event handler, you cannot declare another variable with that name in the same event handler.
- You can, however, have variables of the same name declared in different methods.

### Assignment Compatibility

- You can assign a value to a variable only if the value is compatible with the variable’s data type.
- Only strings are compatible with the string data type.

### Initializing Variables

- In C#, a variable must be assigned a value before it can be used.
- If you try to display a variable’s value without assigning it a value first, compiling gives an error such as “Use of unassigned local variable ’productDescription’”.
- The C# compiler will not compile code that tries to use an unassigned variable.

### Declaring Multiple Variables with One Statement

- You can declare multiple variables of the same data type with one declaration statement (e.g. `string lastName, firstName, middleName;`).
- You can break up a long statement so it spreads across two or more lines. Long variable declarations are sometimes written across multiple lines, with a value assigned to each variable.

---

## 3.3 Numeric Data Types and Variables

If you need to store a number in a variable and use the number in a mathematical operation, the variable must be of a numeric data type. numeric data types: Commonly used to

- **int:** whole number in the range of 2,147,483,647
- **double:** real numbers, including numbers with fractional parts
- **decimal:** real numbers, stored with greater precision than doubles. Typically used in financial applications.

### Numeric Literals

- A numeric literal is a number that is written into a program’s code (e.g. `int hoursWorked = 40;`, `double temperature = 87.6;`).
- The literal value cannot be surrounded by quotes.
- Integer literals such as 40 and 99 are treated as an int.
- Numeric literals with a decimal point, such as 87.6, 3.14, and 1.0, are treated as a double.
- To create a decimal literal, append the letter M or m to a numeric literal (e.g. `decimal payRate = 28.75m;`).

### Assignment Compatibility for Numeric Variables

- **int variables:** you can assign int values, but you cannot assign double or decimal values.
- **double variables:** you can assign either double or int values, but you cannot assign decimal values.
- **decimal variables:** you can assign either decimal or int values, but you cannot assign double values.

### Explicit Conversion with Cast Operators

- allows you to explicitly convert among types, which is known as type casting
- You use the cast operator, which is simply the name of the type enclosed in parentheses (e.g. `wholeNumber = (int)moneyNumber;`, `realNumber = (double)moneyNumber;`).

### Declaring Local Variables with the var Keyword

- `var` is a keyword you can use instead of writing the full type of a variable.
- The compiler automatically figures out the type from the value you assign (this is called type inference).
- You can use `var` to declare and initialize a local variable (e.g. `var interestRate = 12.0;`, `var stockCode = "D465U";`, `var accountBalance = 1000.0m;`).
- You must provide an initialization value when declaring a variable with `var`. The compiler determines the variable’s data type from that value.
- `var` can be used only to declare local variables (variables declared inside a method).
- Later you will see how `var` can simplify complex declarations.

---

## 3.4 Performing Calculations

Basic calculations such as arithmetic calculations can be performed by math operators:

| Operator | Name of the operator | Description |
| --- | --- | --- |
| + | Addition | Adds two numbers |
| Minus sign | Subtraction | Subtracts one number from another |
| Asterisk | Multiplication | Multiplies one number by another |
| Forward slash | Division | Divides one number by another and gives the quotient |
| Percentage | Modulus | Divides one number by another and gives the remainder |

### Rules for Performing Calculations

- A math expression performs a calculation and gives a value.
- Be sure to follow the order of operations and group with parentheses if necessary (e.g. `result = (a + b) / 4;`).
- In a calculation of mixed data types, the data type of the result is determined by:
  - int and double: int is treated as double and the result is double
  - int and decimal: int is treated as decimal and the result is decimal
  - double and decimal: not allowed

### Integer Division

- When you divide an integer by an integer in the result is always given as an integer. The result of the following is 2. This is known as integer division.
- To avoid it, cast one of the values to double (e.g. `(double)x / y`) or declare the variables as double.

---

## 3.5 Inputting and Outputting Numeric Values

- Input collected from the keyboard is considered a combination of characters (strings), even if it looks like a number to you.
- A TextBox control reads keyboard input, such as 25.65, but treats it as a string, not a number.
- To assign a value entered into a TextBox to a numeric variable, you have to convert the control’s Text property to the desired numeric data type. You cannot use a cast operator to convert a string to a numeric type.
- In use the following Parse methods to convert string to numeric data types: `int.Parse`, `double.Parse`, `decimal.Parse`.
- Examples: `int hoursWorked = int.Parse(hoursWorkedTextBox.Text);`, `double temperature = double.Parse(temperatureTextBox.Text);`

### Displaying Numeric Values

- The Text property of a control only accepts strings.
- To display a number in a TextBox or Label control, you must convert the numeric data to the string type.
- In all variables work with the `ToString` method to convert the value of the variables to strings: The general format is `variableName.ToString()`.
- Another option is implicit string conversion with the + operator (e.g. `"Your ID number is " + idNumber`).

---

## 3.6 Formatting Numbers with the ToString Method

The ToString method can optionally format a number to appear in a specific way. Format strings:

| Format String | Description | Number | ToString() | Result |
| --- | --- | --- | --- | --- |
| "N" or "n" | Number format | 12.3 | ToString("n3") | 12.300 |
| "F" or "f" | Fixed-point scientific format | 123456.0 | ToString("f2") | 123456.00 |
| "E" or "e" | Exponential scientific format | 123456.0 | ToString("e3") | 1.235e+005 |
| "C" or "c" | Currency format | Negative 1234567.8 | ToString("C") | ($1,234,567.80) |
| "P" or "p" | Percentage format | .234 | ToString("P") | 23.40% |

---

## 3.7 Simple Exception Handling

- An exception is an unexpected error that happens while a program is running. Exceptions = runtime errors. Example errors:
  - dividing by zero
  - trying to open a file that does not exist
  - invalid user input
- If an exception is not handled by the program, the program will abruptly halt.
- **Exception handling** is writing special code that catches errors and tells the program what to do instead of crashing. This code is called an **exception handler**.

### Handling Exceptions with try-catch

- The `try` block is where you place the statements that can cause an exception.
- The `catch` block is where you place statements that respond to the exception when it happens.

### Throwing an Exception

- In the slides’ example, if the user enters nonnumeric data into the miles TextBox, the statement that converts it throws an exception.
- The program then jumps to the catch clause and executes the statements in the catch block (a message box saying invalid data was entered).

### What is the Difference Between Throwing and Catching

- Throwing = raising the error (the problem occurs).
- Catching = handling the error (deciding what to do about it).
- **ATM machine:** you enter your PIN incorrectly three times. Throwing: the ATM raises an error (“Invalid PIN”). Catching: instead of shutting down, it shows a friendly message: “Invalid PIN, please try again.”
- **Car driving:** your car runs out of fuel while driving. Throwing: the car has a problem (fuel is empty). Catching: the dashboard shows a warning light instead of letting the engine suddenly die without warning.

### Displaying an Exception’s Default Message

- Every exception (error) in C# is an object. That object has a property called `Message` which stores a description of the error.
- Use `catch (Exception ex)` and show `ex.Message` in a message box to display the exception’s default error message.

---

## 3.8 Using Named Constants

- A named constant is a name that represents a value that cannot be changed during the program’s execution.
- In a constant can be declared by `const` keyword: (e.g. `const double INTEREST_RATE = 0.129;`).
- Writing the name of a constant in uppercase letters is traditional in many programming languages but is not a requirement.

---

## 3.9 Declaring Variables as Fields

- A field is a variable that is declared at the class level. It is declared inside the class, but not inside of any method.
- A field’s scope is the entire class.
- In the FieldDemo application, the `name` variable is a field declared in the Form1 class. The name field is created in memory when the Form1 form is created.

---

## 3.10 Using the Math Class

The .NET Math class provides several methods for performing complex mathematical calculations:

- `Math.Sqrt(x)`: returns the square root of x (a double)
- `Math.Pow(x, y)`: returns the value of x raised to the power of y. Both x and y are double.
- `Math.Max(x, y)`: returns the greater of the two values x and y
- `Math.Min(x, y)`: returns the lesser of the two values x and y
- `Math.Round(x)`: returns the value of x (a double or a decimal) rounded to the nearest integer

There are two predefined constants:

- `Math.PI`: represents the ratio of the circumference of a circle to its diameter
- `Math.E`: represents the natural logarithmic base

---

## 3.11 More G U I Details

### Tab Order

- When an application is running, one of the form’s controls always has the focus. Focus means a control receives the user’s keyboard input.
- When a button has the focus, pressing the Enter key can execute the button’s Click event handler.
- The order in which controls receive the focus is called the **tab order**. When the user presses the Tab key to select controls, the program follows the tab order.
- The **TabIndex** property contains a numeric value indicating the control’s position in the tab order. The value starts with 0: the index of the first control is 0.
- To set the tab order, click Tab Order on the View menu. This activates the tab-order selection mode on the form. Then click the controls with the mouse in the order you want.
- Label controls do not accept input from the keyboard. They cannot receive focus, so their TabIndex values are irrelevant.
- You can use the `Focus` method to change the focus (`ControlName.Focus();`), for example to move the focus to nameTextBox when the user clicks the Clear button.

### Assign Keyboard Access Key to Buttons

- An access key (or mnemonic) is a key that is pressed in combination with the Alt key to quickly access a control.
- You can assign an access key to a button’s Text property by adding an ampersand (&) before a letter.
- The user can then use the keystrokes Alt + X or Alt + x. An access key does not distinguish between uppercase and lowercase.

### Setting Colors

- Forms and most controls have a **BackColor** property. Controls that can display text also have a **ForeColor** property.
- These color-related properties support a drop-down list of colors with three tabs:
  - Custom: displays a color palette
  - Web: lists colors displayed with consistency in web browsers
  - System: lists colors defined in the current Windows
- You can also set colors in code. The .NET Framework provides numerous values that represent colors (e.g. `messageLabel.BackColor = Color.Black;`, `messageLabel.ForeColor = Color.Yellow;`).

### Background Images for Forms

- A Form has a property named **BackgroundImage** that is similar to the Image property of a PictureBox. Simply import an image into the Select Resource window.
- A Form also has a **BackgroundImageLayout** property that is similar to the SizeMode property of a PictureBox. Options shown in the slides: None, Tile, Center, Stretch, Zoom.

### GroupBoxes versus Panels

- A GroupBox control is a container with a thin border and an optional title that can hold other controls.
- A Panel control is also a container that can hold other controls.
- Primary differences:
  - A panel cannot display a title and does not have a Text property, but a GroupBox supports both.
  - A panel’s border can be specified by its BorderStyle property, while the GroupBox’s cannot.

---

## 3.12 Using the Debugger to Locate Logic Errors

- A logic error is a mistake that does not prevent an application from running, but causes it to produce incorrect results. Examples: mathematical errors, assigning a value to the wrong variable, assigning the wrong value to a variable.
- Finding and fixing a logic error usually requires a bit of detective work. Visual Studio provides debugging tools that make locating logic errors easier.

### Breakpoints

- A breakpoint is a line you select in your source code.
- When the running application reaches a breakpoint, it pauses and enters **break mode**.
- While the application is paused, you may examine variable contents and the values stored in certain control properties.

### Break Mode

- In Break mode, to examine the contents of a variable or control property, hover the cursor over the variable or property’s name in the Code editor.

### The Locals and Watch Windows

- The **Locals** window displays a list of all the variables in the current procedure, with the current value and data type of each.
- The **Watch** window allows you to add the names of variables you want to watch. It displays only the variables you have added. Visual Studio lets you open multiple Watch windows.
- You can open these windows by clicking Debug on the menu bar, then selecting Windows, and then selecting the window you want to open.

### Single-Stepping

- Visual Studio allows you to single-step through an application’s code once its execution has been paused by a breakpoint. The application’s statements execute one at a time, under your control.
- After each statement executes, you can examine variable and property values. This helps you identify the line or lines of code causing the error.
- To single-step, do any of the following:
  - Press F11 on the keyboard
  - Click the Step Into command on the toolbar
  - Click Debug on the menu bar, and then select Step Into from the Debug menu
