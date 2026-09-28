## Using Explain the Code of Chapter2


## Clearing a TextBox

In this example, a button click event is used to clear the text inside a TextBox control.

When the user clicks the **Clear** button, the `clearButton_Click` event runs and removes the text from `textBox1`. There are three ways to do this:

1. Assign an empty string `""` to the `Text` property.
2. Assign `string.Empty` to the `Text` property.
3. Call the `Clear()` method.

All three give the same result: the TextBox becomes empty.

### Code

```csharp
private void btn_Clear(object sender, EventArgs e)
{
    // Way 1: Assign an empty string to the Text property
    textBox1.Text = "";

    // Way 2: Assign string.Empty to the Text property
    textBox1.Text = string.Empty;

    // Way 3: Use the Clear() method to remove the text
    textBox1.Clear();
}
```

## String Concatenation


In this example, a button click event is used to join (concatenate) two strings into one, then display the result in a message box.

When the user clicks the button, the `concatButton_Click` event runs. It declares a string variable named `message`, joins `"Jamhuuriya"` and `"University"` using the `+` operator, and shows the result with `MessageBox.Show()`.

### Code

```csharp
private void btn_MessageBox(object sender, EventArgs e)
{
    // Example of string concatenation
    // Declare a string variable
    string message;

    // Concatenate two strings using the + operator
    // and store the result in the message variable
    message = "Jamhuuriya" + "University";

    // Display the output using a MessageBox
    MessageBox.Show(message);
}
```

## Converting TextBox Input to Numbers with `Parse()`

The `Text` property of a TextBox always holds a string, even when the user types a number. To use that value in calculations, you must convert it to a numeric type. Each numeric type has a `Parse` method for this: `int.Parse()` converts a string to an `int`, and `double.Parse()` converts a string to a `double`.

In this example, the hours worked (a whole number) and the temperature (a number that may have decimals) are read from two TextBox controls and stored in variables.

### Code

```csharp
private void btn_Parse(object sender, EventArgs e)
{
    // Convert the text in hoursWorkedTextBox to an int
    int hoursWorked = int.Parse(hoursWorkedTextBox.Text);

    // Convert the text in temperatureTextBox to a double
    double temperature = double.Parse(temperatureTextBox.Text);
}
```

## Converting Numbers to Strings with `ToString()`

The `Text` property of a Label and the `MessageBox.Show()` method both work with strings. To display a number, you must first convert it to a string using the `ToString()` method.

In this example, a `decimal` value is shown in a Label, and an `int` value is shown in a message box.

### Code

```csharp
private void convertButton_Click(object sender, EventArgs e)
{
    // Declare a decimal variable (the "m" suffix marks it as decimal)
    decimal grossPay = 1550.0m;

    // Convert the decimal to a string and display it in the label
    grossPayLabel.Text = grossPay.ToString();

    // Declare an integer variable
    int myNumber = 123;

    // Convert the integer to a string and display it in a message box
    MessageBox.Show(myNumber.ToString());
}
```



