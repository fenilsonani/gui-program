# C# .net Answer And Question

## 2 Marks Question 

Question:-
### Explain any two properties of PictureBox control with example.
Answer:-
The PictureBox control is used for displaying images on the form². It has many properties that can be set at design time or at run time. Here are two examples of such properties:

- The **Image** property gets or sets the image that is displayed on the PictureBox¹². You can assign an image object to this property either in the Properties window or in code. For example:

```vb
PictureBox1.Image = Image.FromFile("C:\Users\Public\Pictures\Sample Pictures\Koala.jpg")
```

- The **SizeMode** property gets or sets how an image is displayed within a PictureBox¹⁴. It can be set to one of the values in the PictureBoxSizeMode enumeration, such as Normal, StretchImage, AutoSize, CenterImage, or Zoom. For example:

```vb
PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
```

Question:-
### Differenciate GroupBox and Panel control.
Answer:-
GroupBox and Panel are two controls that can be used to group other controls on a form¹². They have some similarities and differences. Here are some of them:

- A GroupBox can display a caption (i.e., text) at the top of its border, whereas a Panel does not have a caption¹²³.
- A Panel can include scrollbars to allow scrolling through its contents, whereas a GroupBox does not have scrollbars¹²³.
- A GroupBox always displays a thin border around its edges, whereas a Panel's border is determined by its BorderStyle property. It can be set to None, Single, or Fixed3D¹⁴.
- A GroupBox always has its TabStop property enabled, which means it can receive focus when the user presses the Tab key. A Panel's TabStop property can be enabled or disabled⁵.

Question:-
###  What is the significance of Timer control? Explain with example
Answer:-
The Timer control is a component that allows you to execute some code at specific time intervals123. It can be used for various purposes, such as updating the user interface, performing background tasks, scheduling events, etc23.
For example, suppose you want to create a simple stopwatch application that displays how many seconds have passed since you started it. You can use a Timer control and a Label control for this purpose

Question:-
### How can you add new Forms to a program?
Answer:-
You can add new Forms to a program by dragging the Form control from the Toolbox to the form¹²³. You can also add a Form by double-clicking the Form control in the Toolbox. This will add a new Form to the project¹²³.

## 5 Marks Question

Question:-
### List out the input controls. Explain any three in brief and list at least three properties of each control.
Answer:-
The following are the input controls:

Input controls are the UI elements that allow users to enter information into forms³. Some common input controls that can be added to forms are:

Input Controls:-
- TextBox
- Combobox
- CheckBox

- TextBox: A control that allows users to enter and edit text. Some properties of this control are Text, ReadOnly, Multiline, MaxLength, etc²⁵.
- ComboBox: A control that allows users to select an item from a drop-down list or type a new value. Some properties of this control are Items, SelectedItem, SelectedIndex, DropDownStyle, etc²⁵.
- CheckBox: A control that allows users to toggle a yes/no option. Some properties of this control are Checked, CheckState, AutoCheck, ThreeState, etc²⁵.
- RadioButton: A control that allows users to select one option from a group of mutually exclusive options. Some properties of this control are Checked, AutoCheck, GroupName, TextImageRelation, etc²⁵.
- DateTimePicker: A control that allows users to select a date and time using a graphical calendar and a spin button. Some properties of this control are Value, Format, ShowCheckBox,ShowUpDown,MinDate,MaxDate,etc²⁵.