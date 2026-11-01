## Using Explain the Code of Chapter4 (Week 4 – Loops)

## The while Loop

In this example, a button click event is used to show a message box five times with a `while` loop.

When the user clicks the button, the `btn_While` event runs. A `while` loop is a pretest loop: it tests its Boolean expression **before** each iteration. The counter variable `count` starts at 0, and each time the loop runs it shows "Hello" and adds 1 to `count`. When `count` reaches 5, the expression `count < 5` becomes false and the loop stops, so the loop iterates 5 times.

If the counter is never increased, the expression never becomes false and the loop never ends (an infinite loop). If the expression is false from the start (for example `count = 5`), the loop does not iterate at all.



### Code

private void btn_While(object sender, EventArgs e)
{
    int count = 0;

    while (count < 5)
    {
        MessageBox.Show("Hello");
        count = count + 1;
    }
}

## The ++ and -- Operators

In this example, a button click event is used to show the difference between postfix and prefix mode.

To increment a variable means to increase its value, and to decrement a variable means to decrease its value. C# provides the `++` and `--` operators for this. These three lines all add 1 to `count`:

```
count++;
count += 1;
count = count + 1;
```

When the operator is used on its own, postfix (`count++`) and prefix (`++count`) do the same thing. The difference appears when the result is assigned to another variable:

- **Postfix** (`x = count++`): use the old value, then change it.
- **Prefix** (`x = ++count`): change the value first, then use it.

When the user clicks the button, the `btn_PostfixPrefix` event runs. With `count = 5`, postfix gives `x = 5` and `count = 6`, while prefix gives `x = 6` and `count = 6`.

### Code

private void btn_PostfixPrefix(object sender, EventArgs e)
{
    // Postfix mode
    int count = 5;
    int x = 0;
    MessageBox.Show("The x before " + x.ToString());
    MessageBox.Show("The count before is " + count.ToString());
    x = count++;
    MessageBox.Show("The x after postfix " + x.ToString());
    MessageBox.Show("The count after postfix is " + count.ToString());

    // Prefix mode
    count = 5;
    x = 0;
    MessageBox.Show("The x before " + x.ToString());
    MessageBox.Show("The count before is " + count.ToString());
    x = ++count;
    MessageBox.Show("The x after prefix " + x.ToString());
    MessageBox.Show("The count after prefix is " + count.ToString());
}

## The for Loop

In this example, a button click event is used to show a message box five times with a `for` loop.

The `for` loop is designed for situations that need a counter variable. Its three parts are written in the parentheses, separated by semicolons:

1. **Initialization**: a one-time expression that sets the initial value of the counter.
2. **Test**: a Boolean expression; if it is `true`, the loop iterates.
3. **Update**: increases or decreases the counter after each iteration.

When the user clicks the button, the `btn_For` event runs. The counter `count` starts at 0, the loop runs while `count < 5`, and `count++` adds 1 after each iteration. The counter can also be declared inside the initialization expression, as in the second loop. The `for` loop is a pretest loop.

The general format is:

```
for (InitializationExpression; TestExpression; UpdateExpression)
{
}
```

### Code

private void btn_For(object sender, EventArgs e)
{
    // Declare the count variable before the loop
    int count;
    for (count = 0; count < 5; count++)
    {
        MessageBox.Show("Hello");
    }

    // Declare the count variable in the initialization expression
    for (int i = 0; i < 5; i++)
    {
        MessageBox.Show("Hello");
    }
}

## Other Forms of the Update Expression

In this example, the update expression of a `for` loop is changed. The counter is usually incremented by 1, but this is not a requirement.

When the user clicks the button, the `btn_ForUpdate` event runs. The first loop increments the counter by 10 using `count += 10`, so it shows 0, 10, 20, up to 100. The second loop decrements the counter with `count--` to count backward from 10 down to 0.

### Code

private void btn_ForUpdate(object sender, EventArgs e)
{
    // Increment by 10
    for (int count = 0; count <= 100; count += 10)
    {
        MessageBox.Show(count.ToString());
    }

    // Counting backward
    for (int count = 10; count >= 0; count--)
    {
        MessageBox.Show(count.ToString());
    }
}

## The do-while Loop

In this example, a `do-while` loop and a `while` loop are compared.

A `do-while` loop is a **posttest** loop: it performs an iteration **before** testing its Boolean expression, so it always runs at least once. A `while` loop is a pretest loop, so it may not run at all.

When the user clicks the button, the `btn_DoWhile` event runs. In both loops `number` is 1 and the condition is `number < 0`, which is false. The `do-while` loop still shows the message box once, because the test happens after the body. The `while` loop shows nothing, because the test happens first.

The general format is:

```
do
{
    statements
} while (BooleanExpression);

```

### Code

private void btn_DoWhile(object sender, EventArgs e)
{
    // The message box IS shown (once)
    int number = 1;
    do
    {
        MessageBox.Show(number.ToString());
    } while (number < 0);

    // The message box is NOT shown
    int number2 = 1;
    while (number2 < 0)
    {
        MessageBox.Show(number2.ToString());
    }
}
