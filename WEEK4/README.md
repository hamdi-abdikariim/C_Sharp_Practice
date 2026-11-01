## Using Explain the Code of Chapter4

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

## The for Loop

In this example, a button click event is used to show a message box five times with a `for` loop.

The `for` loop is designed for situations that need a counter variable. Its three parts are written in the parentheses, separated by semicolons:

1. **Initialization**: a one-time expression that sets the initial value of the counter.
2. **Test**: a Boolean expression; if it is `true`, the loop iterates.
3. **Update**: increases or decreases the counter after each iteration.

When the user clicks the button, the `btn_For` event runs. The counter `count` starts at 0, the loop runs while `count < 5`, and `count++` adds 1 after each iteration. The counter can also be declared inside the initialization expression, as in the second loop. The update expression does not have to add 1; it can count by another step or count backward.


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

    // Increment by 10
    for (int n = 0; n <= 100; n += 10)
    {
        MessageBox.Show(n.ToString());
    }

    // Counting backward
    for (int k = 10; k >= 0; k--)
    {
        MessageBox.Show(k.ToString());
    }
}

## The do-while Loop

In this example, a `do-while` loop and a `while` loop are compared.

A `do-while` loop is a **posttest** loop: it performs an iteration **before** testing its Boolean expression, so it always runs at least once. A `while` loop is a pretest loop, so it may not run at all.

When the user clicks the button, the `btn_DoWhile` event runs. In both loops `number` is 1 and the condition is `number < 0`, which is false. The `do-while` loop still shows the message box once, because the test happens after the body. The `while` loop shows nothing, because the test happens first.



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

## Writing Data to a File

In this example, three course names are written to a text file.

To write to a text file, three steps are always needed: open the file, process it (write to it), and close it. The `StreamWriter` class is used for writing. `File.CreateText()` creates the file and returns a `StreamWriter` object. If the file already exists, its contents are erased. To keep the existing contents and add to the end of the file, use `File.AppendText()` instead.

The `WriteLine()` method writes an item and then a newline character, so each item goes on its own line. The `Write()` method writes an item without a newline. Finally, `Close()` disconnects the file from the program. The `System.IO` namespace is needed, so add `using System.IO;` at the top of the form.

When the user clicks the button, the `btn_WriteFile` event runs.

### Code

private void btn_WriteFile(object sender, EventArgs e)
{
    StreamWriter outputFile;
    outputFile = File.CreateText("courses.txt");
    outputFile.WriteLine("Introduction to Computer Science");
    outputFile.WriteLine("English Composition");
    outputFile.WriteLine("Calculus I");
    outputFile.Close();
}

## Reading a File with a Loop

In this example, every line of a text file is read and added to a ListBox.

The `StreamReader` class is used for reading. `File.OpenText()` opens the file and returns a `StreamReader` object, and `ReadLine()` reads one line of text and returns it as a string. `StreamReader` objects have a Boolean property named `EndOfStream` that is `true` when the end of the file has been reached, so a `while` loop can read line by line until the file ends. `!reader.EndOfStream` is the same as `reader.EndOfStream == false`.

The code is placed in a `try-catch` block, so if something goes wrong (for example, the file does not exist), the error message is shown instead of crashing the program. When the user clicks the button, the `btn_ReadFile` event runs.

### Code

private void btn_ReadFile(object sender, EventArgs e)
{
    StreamReader reader;

    try
    {
        reader = File.OpenText("courses.txt");

        while (reader.EndOfStream == false)
        {
            string line;
            line = reader.ReadLine();
            listBox1.Items.Add(line);
        }

        reader.Close();
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
}

## OpenFileDialog and DialogResult

In this example, an Open dialog box is shown so the user can choose which file to read.

The `OpenFileDialog` control is invisible: it appears in the component tray at the bottom of the Designer, not on the form. Calling its `ShowDialog()` method displays the standard Windows Open dialog box. `ShowDialog()` returns a `DialogResult` value that tells which button the user clicked: `DialogResult.OK` if the user clicked **Open**, or `DialogResult.Cancel` if the user clicked **Cancel**. When the user selects a file, its path and name are stored in the control's `FileName` property, which is passed to `File.OpenText()`.

When the user clicks the button, the `btn_OpenFile` event runs. The `SaveFileDialog` control works the same way and is used with `File.CreateText(saveFileDialog1.FileName)` to choose where to save a file.

### Code

private void btn_OpenFile(object sender, EventArgs e)
{
    StreamReader reader;

    DialogResult result = openFileDialog1.ShowDialog();

    if (result == DialogResult.OK)
    {
        // Open the file using the selected path
        reader = File.OpenText(openFileDialog1.FileName);
        string readline;
        readline = reader.ReadLine();
        listBox1.Items.Add(readline);
        reader.Close();
    }
    else if (result == DialogResult.Cancel)
    {
        MessageBox.Show("Wala Cancalay");
    }
}
