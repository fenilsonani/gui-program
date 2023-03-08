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


Question:-
###  What is the use of Label control? List and explain at least three properties with example. 
Answer:-

A label control is a user interface element that displays text on a form³⁴. It can be used to provide captions, instructions, or other information to the user. Some of the properties of a label control are:

- **Text**: This property sets or gets the text displayed by the label³⁴. For example, `label.Text = "This is a label control";` sets the text of the label to "This is a label control".
- **Font**: This property sets or gets the font used by the label³⁴. For example, `label.Font = new Font("Arial", 12);` sets the font of the label to Arial with size 12.
- **LineBreakMode**: This property sets or gets how text wrapping and truncation are handled by the label¹. For example, `label.LineBreakMode = LineBreakMode.TailTruncation;` sets the line break mode of the label to truncate text at the end with an ellipsis if it exceeds the width of the label.


Question:-
### Explain ListBox and ComboBox control with at least two properties. 
Answer:-
A listbox control is a user interface element that displays a list of items that the user can select from²⁴. A combobox control is a user interface element that combines a text box and a listbox in a single control¹³. The user can either select an item from the list or enter a new item in the text box. Some of the properties of these controls are:

- **Items**: This property gets or sets the collection of items contained in the control⁵⁶. For example, `listbox.Items.Add("Apple");` adds an item "Apple" to the listbox. `combobox.Items.Remove("Banana");` removes an item "Banana" from the combobox.
- **SelectedIndex**: This property gets or sets the index of the currently selected item in the control²³. For example, `listbox.SelectedIndex = 0;` selects the first item in the listbox. `combobox.SelectedIndex = -1;` clears any selection in the combobox.


Question:-
### State significance of following properties of the controls:
#### i. “passwordchar” property of TextBox.
#### ii. “default” property of command button.
#### iii. “style” property of CheckBox button.
#### iv. “multiselect” property of listbox.
#### v. “listindex” property of listbox

Answer:-
The significance of the following properties of the controls are:

- **PasswordChar**: This property sets or gets the character used to mask characters of a password in a text box³. For example, `textbox.PasswordChar = '*';` sets the password character to asterisk. The default value of this property is 0 (character value), which means no masking³.
- **Default**: This property sets or gets whether a command button is activated when the user presses Enter on a form⁴. For example, `button.Default = true;` sets the button as the default button on the form. The default value of this property is false⁴.
- **Style**: This property sets or gets how a check box appears on a form¹. For example, `checkbox.Style = CheckBoxStyle.Switch;` sets the style of the check box to a switch. The default value of this property is CheckBoxStyle.CheckBox, which means a standard check box¹.
- **MultiSelect**: This property sets or gets whether multiple items can be selected in a list box²⁴. For example, `listbox.MultiSelect = true;` enables multiple selection in the list box. The default value of this property is false, which means only one item can be selected at a time²⁴.
- **ListIndex**: This property gets or sets an integer that represents either an index into an array that contains data for populating an object's rows (such as ListBox) or an index into an array that contains data for populating an object's columns (such as ComboBox)[5]. For example, `listbox.ListIndex = 0;` selects the first item in the list box. The default value of this property is -1, which means no item is selected[5].

Question:-
### Explain Timer control with suitable example.
Answer:-
A timer control is a user interface element that executes a code block repeatedly at a specified interval¹³. For example, you can use a timer control to update a label with the current time every second, or to change the color of a button every five seconds. Some of the properties and methods of a timer control are:

- **Interval**: This property sets or gets the time, in milliseconds, between each tick event¹²³. For example, `timer.Interval = 1000;` sets the interval to one second.
- **Enabled**: This property sets or gets whether the timer is running or not¹²³. For example, `timer.Enabled = true;` starts the timer. The default value of this property is false¹²³.
- **Tick**: This event occurs when the specified interval has elapsed and the timer is enabled¹² [^3^. You can write your code inside this event handler to perform your desired actions. For example,

```csharp
// Create a timer with an interval of one second
Timer timer = new Timer();
timer.Interval = 1000;
timer.Enabled = true;

// Add an event handler for the tick event
timer.Tick += new EventHandler(OnTimerTick);

// Define the event handler method
private void OnTimerTick(object sender, EventArgs e)
{
    // Display the current time in a label
    label.Text = DateTime.Now.ToString("hh:mm:ss");
}
```

Question:-
### Explain ToolStrip control and its properties with example.
Answer:-
A ToolStrip control is a user interface element that displays a row of buttons, icons, menus, text boxes, labels or other controls¹⁵. You can use a ToolStrip control to create toolbars, menus or status bars for your application¹⁵. Some of the properties and methods of a ToolStrip control are:

- **Items**: This property gets or sets the collection of items that are displayed on the ToolStrip¹⁵. For example, `toolStrip.Items.Add("New");` adds a new item with the text "New" to the ToolStrip. You can also add items dynamically using the Opening event handler⁶.
- **Dock**: This property gets or sets which edge of the parent container a control is docked to³ [^5^. For example, `toolStrip.Dock = DockStyle.Bottom;` docks the ToolStrip to the bottom edge of the parent container. The default value of this property is DockStyle.Top³⁵.
- **LayoutStyle**: This property gets or sets how items are aligned and sized on a ToolStrip[^1^. For example, `toolStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;` sets the layout style to horizontal stack with overflow. The default value of this property is ToolStripLayoutStyle.StackWithOverflow[^1].
- **ContextMenuStrip**: This property gets or sets the ContextMenuStrip associated with this control[^4^. A ContextMenuStrip is a menu that appears when you right-click on a control. For example,

```csharp
// Create a context menu strip with two items
ContextMenuStrip contextMenu = new ContextMenuStrip();
contextMenu.Items.Add("Cut");
contextMenu.Items.Add("Copy");

// Associate it with a tool strip
toolStrip.ContextMenuStrip = contextMenu;
```

Question:-
### How can you add controls to a form at run time
Answer:-
You can add controls to a form at run time by creating an instance of the control, setting its properties and adding it to the Controls collection of the parent control²⁵. For example,

```csharp
// Create a button control
Button btn = new Button();
// Set its text, location and size
btn.Text = "Click Me";
btn.Location = new Point(100, 100);
btn.Size = new Size(75, 25);
// Add an event handler for the click event
btn.Click += new EventHandler(btn_Click);
// Add the button to the form's controls collection
this.Controls.Add(btn);
```

This code creates a button control and adds it to the form at run time. You can also remove a control from a form at run time by using the Remove method of the Controls collection⁵. For example,

```csharp
// Remove the button from the form's controls collection
this.Controls.Remove(btn);
```

This code removes the button control from the form at run time.



### Practical Questions

<!-- link of github/fenilsonani/gui-prorams -->
<a href="https://github.com/fenilsonani/gui-program">Github</a>