# introduction to c#

## Topics

-1.1 Objects
-1.2 The Program Development Process
-1.8 Getting Started with Visual Studio
-2.1 Getting Started with Forms and Controls
-2.2 Creating the G U I for Your First Visual C# Application
-2.3 Introduction to C# code
-2.4 Writing Code for the Hello World Application
-2.5 Label Controls
-2.6 Making Sense of IntelliSense
-2.7 PictureBox Controls
-2.8 Comments, Blank Lines, and Indentation
-2.9 Writing the Code to Close an Application’s Form
-2.10 Dealing with Syntax Errors

<h1> What is C#?

C# (pronounced “C-Sharp”) is a modern, general-purpose programming language developed by Microsoft.

---

## 1.1 Objects

- An object is a program component that contains data and performs operations. Programs use objects to perform specific tasks.
- Most programming languages use object-oriented programming, in which a program component is called an “object”.
- Program objects have **properties** (or fields) and **methods**.
  - Properties – data stored in an object
  - Methods – the operations an object can perform

### Controls

- Objects that are visible in a program G U I are known as **controls**.
- Commonly used controls are Labels, Buttons, and TextBoxes. They enhance the functionality of your programs.
- There are invisible objects in a G U I such as Timers and OpenFileDialog.
- A **class** is code that describes a particular type of object.

### .NET Framework

- .NET is a collection of classes and other code that can be used to create programs for the Windows operating system.
- is a language supported by .NET
- Controls are defined by specialized classes provided by .NET.
- You can also write your own class to perform a special task.

---

## 1.8 Getting Started with Visual Studio

- Visual Studio is a professional integrated development environment (I D E).
- The Visual Studio environment includes: Designer Window, Solution Explorer Window, Properties Window.
- **Auto Hide** allows a window to display only as a tab on the edges.

### Menu Bar and Standard Toolbar

- The menu bar provides menus such as File, Edit, View, Project, etc.
- The standard toolbar contains buttons that execute frequently used commands.

### The Toolbox

- The Toolbox is a window for selecting controls to use in an application.
- It typically appears on the left side of the Visual Studio environment and is often in Auto Hide mode.
- It is divided into sections such as “All Windows Forms” and “Common Controls”.

### Tooltips

- A Tooltip is a small box that pops up when you hover the mouse pointer over an item on the toolbar or toolbox.

### Docked and Floating Windows

- When a window such as Solution Explorer is docked, it is attached to one of the edges of the Visual Studio environment.
- When a window is floating, you can click and drag it around the screen.
- A window cannot float if it is in Auto Hide mode.
- Right click a window’s title bar and select Float or Dock to change between them.

### Projects and Solutions

- Each Visual Studio application you will create is a **project**. A project contains several files, typically Form1.cs, Program.cs, etc.
- A **solution** is a container that can hold one or more Visual Studio projects. Each project, however, is saved in its own solution.
- You can specify the project name the first time you save the project.

### Displaying the Designer

Sometimes when you open an existing project, the project’s form is not automatically displayed in the Designer. To display it:

1. Right click Form1.cs in the Solution Explorer.
2. Click View Designer in the pop-up menu.

---

## 2.1 Getting Started with Forms and Controls

- When you start a new Windows Forms App, an empty form named Form1 is automatically created. Initially the form’s size is 300 pixels wide by 300 pixels high.
- **Bounding box and sizing handles:** a form in the Designer is enclosed with thin dotted lines called the bounding box. It has small sizing handles that you can use to resize the form.

### The Properties Window

- The appearance and other characteristics of a G U I object are determined by the object’s properties. Properties are settings that control how the object looks and behaves.
- The Properties window lists all properties of the selected object. Each property has 2 columns: the name (left) and the value (right).

### Changing a Property’s Value

1. Select an object, such as the Form, by clicking it once.
2. If the Properties panel is not visible, go to the View menu → Properties Window.
3. Find the property’s name in the list and change its value.

The Text property determines the text displayed in the form’s title bar. Example: change the value from “Form1” to “My First Program”.

### Adding Controls to a Form

In the Toolbox, select the control (e.g. a Button), then either double click it or click and drag it to the form. On the form you can:

- resize the control using its bounding box and sizing handles
- move the control by dragging it
- change its properties in the Properties window

To delete a control, select it and press the Delete key on the keyboard.

### Rules for Naming Controls

- Controls are identified by their names in code. Control names are also known as identifiers.
- The first character must be a letter (lower or uppercase) or an underscore (_).
- All other characters can be alphanumeric characters or underscores.
- The name cannot contain spaces.
- Examples of valid names: `showDayButton`, `DisplayTotal`, `_ScoreLabel`
- Most C# programmers use the **camelCase** naming convention: begin the name with lowercase letters, and write the first character of the second and subsequent words in uppercase.

---

## 2.2 Creating the G U I for Your First Visual C# Application

- In section 2.2 you start creating an app that has a Form and a Button control.
- When the app is finished, it will display the message “Hello World” when the Button control is clicked.
- In this section you create the G U I.
- In section 2.3 you learn the details of coding an app.
- In section 2.4 you write the code that displays “Hello World” when the user clicks the button.

---

## 2.3 Introduction to C# code

code is primarily organized in three ways:

- **Namespace:** a container that holds classes
- **Class:** a container that holds methods
- **Method:** a group of one or more programming statements that perform some operations

A file that contains program code is called a source code file.

### Source Code in the Solution Explorer

Each time a new project is created, two source code files are automatically created:

- `Program.cs` – contains the application’s start-up code to be executed when the application runs
- `Form1.cs` – contains code that is associated with the Form1 form

You can open them through the Solution Explorer (right click Form1.cs → View Code).

### Organization of Form1.cs

A sample of Form1.cs shows the user-defined namespace of the project, the class declaration, and a method.

### Adding Your Code

- G U I applications are **event-driven**: they respond to events that occur while the application is running. The program waits for the user to do something (like clicking a button, typing, or moving the mouse) and then responds.
- An **event** is a user’s action such as mouse clicking, key pressing, or moving.
- In the Designer, double clicking a control such as a Button links the control to a default **event handler**.
- An event handler is a method that executes when a specific event takes place.

### Message Boxes

- A message box (a k a dialog box) displays a message.
- .NET provides a method named `MessageBox.Show`, which displays a window with a message.
- Placing it in the `myButton_Click` event handler displays the string in the message box when the button is clicked.

---

## 2.4 Writing Code for the Hello World Application

The completed source code of Form1.cs is shown in the slides.

---

## 2.5 Label Controls

A Label control displays text on a form and can be used to display unchanging text or program output. Commonly used properties:

- **Text:** gets (reads) or sets (writes/changes) the text associated with the Label control
- **Name:** gets or sets the name of the Label control
- **Font:** sets the font, font style, and font size
- **BorderStyle:** displays a border around the control’s text
- **AutoSize:** controls the way the label can be resized
- **TextAlign:** sets the text alignment

### Handling Text Alignments

The TextAlign property supports the following values (select them by clicking the down-arrow button of the property):

| TopLeft | TopCenter | TopRight |
| --- | --- | --- |
| MiddleLeft | MiddleCenter | MiddleRight |
| BottomLeft | BottomCenter | BottomRight |

### Using Code to Display Output in a Label Control

By adding a line to a Button’s event handler, a Label control can display output of the application. Notice that:

- the equal sign (=) is known as the assignment operator
- the item receiving the value must be on the left of the = operator
- the Text property accepts a string only
- to clear the text of a Label, assign an empty string (“”) to the Text property

---

## 2.6 Making Sense of IntelliSense

- IntelliSense provides automatic code completion as you write programming statements.
- It is a smart code completion feature: as you type, it automatically suggests possible keywords, variables, methods, classes, or properties that you might want to use.
- It provides an array of options that make language references easily accessible.
- With it, you can find the information you need and insert language elements directly into your code.

---

## 2.7 PictureBox Controls

A PictureBox control displays a graphic image on a form. Commonly used properties:

- **Image:** specifies the image that it will display
- **SizeMode:** specifies how the control’s image is to be displayed
- **Visible:** determines whether the control is visible on the form at run time

### Creating Clickable Images

Double click the PictureBox control in the Designer to create a Click event handler, then add your code to it.

### Sequential Execution of Statements

- Programmers need to carefully arrange the sequence of statements to generate the correct results.
- The statements in a method execute in the order that they appear.

This makes sense because when you click the button you want to flip the card: back is visible, face is hidden.

- If both lines set `Visible` to false, the first line hides the face and the second also hides the back. Result: both pictures are hidden.
- Incorrect arrangement of the sequence can cause logic errors.

---

## 2.8 Comments, Blank Lines, and Indentation

- Comments are brief notes placed in a program’s source code to explain how parts of the program work.
- A **line comment** appears on one line.

- A **block comment** can occupy multiple consecutive lines in a program.

### Using Blank Lines and Indentation

Programmers frequently use blank lines and indentation in their code to make it more human-readable. The slides compare two identical versions of the same code (one without indentation and blank lines, one with them).

---

## 2.9 Writing the Code to Close an Application’s Form

To close an application’s form in code, use a Close statement on the form.

A commonly used practice is to create an Exit button and manually add the code to it. The current form (Form1) is closed this way, while the whole application can be closed with `Application.Exit`.

---

## 2.10 Dealing with Syntax Errors

- The Visual Studio code editor examines each statement as you type it and reports any syntax errors that are found.
- If a syntax error is found, it is underlined with a jagged line.
- If a syntax error exists and you attempt to compile and execute, a window appears saying there were build errors and asking whether you would like to continue and run the last successful build.
