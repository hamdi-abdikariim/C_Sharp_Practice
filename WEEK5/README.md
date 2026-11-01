## Using Explain the Code of Chapter4 (Week 5 – Files, Random Numbers and the Load Event)

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

When the user clicks the button, the `btn_OpenFile` event runs.

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

## SaveFileDialog

In this example, a Save As dialog box is shown so the user can choose where to save a file.

The `SaveFileDialog` control works the same way as `OpenFileDialog`. Its `ShowDialog()` method displays the standard Windows Save As dialog box and returns `DialogResult.OK` or `DialogResult.Cancel`. If the user clicks **Save**, the chosen path is stored in `FileName`, and `File.CreateText()` creates the file at that location.

When the user clicks the button, the `btn_SaveFile` event runs. The name "Mohamed" is written to the new file, and then the file is closed.

### Code

private void btn_SaveFile(object sender, EventArgs e)
{
    StreamWriter write;

    DialogResult result = saveFileDialog1.ShowDialog();

    if (result == DialogResult.OK)
    {
        // Create the file using the selected path
        write = File.CreateText(saveFileDialog1.FileName);
        write.WriteLine("Mohamed");
        write.Close();
    }
    else if (result == DialogResult.Cancel)
    {
        MessageBox.Show("Wala Cancalay");
    }
}

## Random Numbers

In this example, the `Random` class is used to generate random numbers.

First a `Random` object is created with `new Random()`. Two commonly used methods are:

- `Next()`: randomly creates an integer from 0 to 2,147,483,647.
- `NextDouble()`: randomly creates a floating-point number from 0.0 up to (but not including) 1.0.

`Next()` can also take a maximum value. The syntax is `RandomObject.Next(max + 1)`, so `rand.Next(100)` creates a random number from 0 to 99.

When the user clicks the button, the `btn_Random` event runs and shows the three random numbers.

### Code

private void btn_Random(object sender, EventArgs e)
{
    Random rand = new Random();

    int number1 = rand.Next();         // 0 to 2,147,483,647
    double number2 = rand.NextDouble(); // 0.0 to 1.0
    int number3 = rand.Next(100);      // 0 to 99

    MessageBox.Show(number1.ToString());
    MessageBox.Show(number2.ToString());
    MessageBox.Show(number3.ToString());
}

## The Load Event

In this example, the form's `Load` event is used to run code as soon as the form is launched.

When an application runs, its form is loaded into memory and an event known as **Load** takes place. To create a Load event handler, double-click the form in the Designer; Visual Studio generates an empty handler. Any code written inside it executes when the form is launched.

Here, the message "Prepare to see the form!" is shown before the form appears.

### Code

private void Form1_Load(object sender, EventArgs e)
{
    MessageBox.Show("Prepare to see the form!");
}
