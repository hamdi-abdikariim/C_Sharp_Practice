## Using Explain the Code of Chapter3

## Test Score Average (try-catch)

In this example, a button click event is used to calculate the average of three test scores and display it in a Label.

When the user clicks the **Calculate Average** button, the `btn_CalculateAverage` event runs. The scores are read from three TextBox controls and converted with `double.Parse()`. The average is shown with one decimal place using `ToString("n1")`. If the average is higher than the `HIGH_SCORE` constant (95), a congratulation message is shown. If the user types something that is not a number, the `catch` block shows the error message instead of crashing the program.

### Code

private void btn_CalculateAverage(object sender, EventArgs e)
{
    try
    {
        const double HIGH_SCORE = 95.0;      // High Score value
        double test1, test2, test3, average; // Variables

        // Get the test scores from the TextBoxes
        test1 = double.Parse(test1TextBox.Text);
        test2 = double.Parse(test2TextBox.Text);
        test3 = double.Parse(test3TextBox.Text);

        // Calculate the average test score
        average = (test1 + test2 + test3) / 3.0;

        // Display the average, rounded to 1 decimal place
        averageLabel.Text = average.ToString("n1");

        // If the average is a high score, congratulate the user
        if (average > HIGH_SCORE)
        {
            MessageBox.Show("Congratulations! Great job!");
        }
    }
    catch (Exception ex)
    {
        // Display the default error message
        MessageBox.Show(ex.Message);
    }
}

## Nested Decision Structures

In this example, one `if` statement is placed inside another to test more than one condition. "Nested" means one inside another.

When the user clicks the button, the `btn_LoanQualify` event runs. The outer `if` checks the salary. Only if the salary is at least 40,000 does the inner `if` check the years on the job. A person qualifies for the loan only when both conditions are met, and the result is shown in `decisionLabel`.

### Code

private void btn_LoanQualify(object sender, EventArgs e)
{
    double salary = 400;
    double yearsOnJob = 2;

    if (salary >= 40000)
    {
        if (yearsOnJob >= 2)
        {
            decisionLabel.Text = "You qualify for the loan";
        }
        else
        {
            decisionLabel.Text = "Minimum years at current job not met.";
        }
    }
    else
    {
        decisionLabel.Text = "Minimum salary requirement not met.";
    }
}

## The if-else-if Statement

In this example, an `if-else-if` statement is used to test several conditions and pick one result.

When the user clicks the button, the `btn_Grade` event runs. The score is read from a TextBox and converted with `int.Parse()`. The conditions are checked from top to bottom, and the first one that is true decides the grade. If none of them is true, the final `else` gives the grade "F".

### Code

private void btn_Grade(object sender, EventArgs e)
{
    int score = int.Parse(testScoreTextBox.Text);
    string grade = "A";

    if (score >= 90)
    {
        grade = "A";
    }
    else if (score >= 80)
    {
        grade = "B";
    }
    else if (score >= 70)
    {
        grade = "C";
    }
    else if (score >= 60)
    {
        grade = "D";
    }
    else
    {
        grade = "F";
    }
}

## Logical Operators

In this example, logical operators are used to connect more than one Boolean expression.

When the user clicks the button, the `btn_LogicalOperators` event runs. The `&&` (AND) operator requires both expressions to be true. The `||` (OR) operator requires at least one expression to be true. The `!` (NOT) operator reverses the result of an expression.

### Code

private void btn_LogicalOperators(object sender, EventArgs e)
{
    // The && operator
    if (temperature < 20 && minutes > 12)
    {
        MessageBox.Show("The temperature is in the danger zone.");
    }

    // The || operator
    if (temperature < 20 || temperature > 100)
    {
        MessageBox.Show("The temperature is in the danger zone.");
    }

    // The ! operator
    if (!(temperature > 100))
    {
        MessageBox.Show("The temperature is below the maximum.");
    }
}

## Input Validation with `TryParse()`

In this example, a button click event is used to validate the number of hours entered by the user.

`Parse()` throws an exception if the user enters invalid data, but `TryParse()` returns `true` if the conversion succeeds and `false` if it fails. The `out` keyword is required: it specifies that `hours` is an output variable that receives the converted value.

`TryParse()` only checks that the input is a number, not that it makes sense. For example, nobody can work 999 hours in a week. So after `TryParse()` succeeds, the `&&` operator is used to check that `hours` is in a reasonable range (more than 0 and no more than 168).

### Code

private void btn_ValidateHours(object sender, EventArgs e)
{
    int hours;

    if (int.TryParse(textBox1.Text, out hours))
    {
        // TryParse succeeded - it's a number! Now check the range
        if (hours > 0 && hours <= 168)
        {
            MessageBox.Show("Valid hours.");
        }
        else
        {
            MessageBox.Show("Hours must be between 1 and 168.");
        }
    }
    else
    {
        MessageBox.Show("Please enter a valid whole number.");
    }
}

## Removing Items from a ListBox

In this example, a button click event is used to remove the selected item from a ListBox.

When the user clicks the button, the `btn_RemoveSelected` event runs. `SelectedIndex` is `-1` when no item is selected, so it is checked first. If an item is selected, `Items.RemoveAt()` removes the item at the selected index. If not, a message asks the user to select an item. Calling `RemoveAt()` with an invalid index would throw an exception, which is why this check is needed.

### Code

private void btn_RemoveSelected(object sender, EventArgs e)
{
    if (listBox1.SelectedIndex != -1) // Check if an item is selected
    {
        listBox1.Items.RemoveAt(listBox1.SelectedIndex); // Remove selected item
    }
    else
    {
        MessageBox.Show("Please select an item to remove.");
    }
}
