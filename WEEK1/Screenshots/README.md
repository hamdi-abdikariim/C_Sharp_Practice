## Using Explain the Code of Chapter1

## Displaying a Message Using `MessageBox`

When the user clicks the button, the `myButton_Click` event runs and shows a message box with the text **Thanks for clicking the button!**

### Code

```csharp
private void chapter1_btn(object sender, EventArgs e)
{
    // Display a message box with a message for the user
    MessageBox.Show("Thanks for clicking the button!");
}
```

## Displaying Text in a Label

In this example, a button click event is used to display text inside a Label control.

When the user clicks the **Show Answer** button, the `showAnswerButton_Click` event runs and changes the text of the label to:

**Jamhuuriya University**

### Code

```csharp
private void chapter1_btn(object sender, EventArgs e)
{
    // Assign a string to the Text property of answerLabel to display it
    answerLabel.Text = "Jamhuuriya University";
}
```

## Creating Clickable Images

Double clicking a PictureBox control in the Designer creates a Click event handler. You can then add your own code to it.

In the first example, clicking the logo PictureBox shows a message box. In the second example, clicking the student PictureBox hides it by setting its `Visible` property to `false`.

### Code

```csharp
private void chapter1_btn(object sender, EventArgs e)
{
    // Display a message box when the logo image is clicked
    MessageBox.Show("welcome best class");
}

private void chapter1_btn(object sender, EventArgs e)
{
    studentpicturebox.Visible = false;
}
```

## Closing an Application's Form

When the user clicks the Exit button, the `exitButton_Click` event runs and closes the form using `this.Close()`.

### Code

```csharp
private void chapter1_btn(object sender, EventArgs e)
{
    // Close the form.
    this.Close();
}
```
