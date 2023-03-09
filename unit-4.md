# Unit-4

## 5 marks Questions




Question 2:-
### Explain TreeView control in detail with example. List and explain in one line at least four properties and methods with example.
Answer:-
A TreeView control in C# is used to display the items in hierarchical form¹. Each item in TreeView control is called a node. A node can have sub-nodes too; and each sub-node has its own nodes, and so on¹. A TreeView control provides a way to display information in a hierarchical structure by using collapsible nodes².

Here is an example of how to use a TreeView control in C# Windows Application:

- First, you need to add a TreeView control to your form from the Toolbox. You can set its properties such as Name, Location, Size etc. in the Properties window.
- Next, you need to add nodes to your TreeView control. You can do this either at design time or at run time. To add nodes at design time, you can expand the Nodes property of the TreeView control and click on the ellipsis (...) button. This will open a TreeNode Editor where you can add, edit or delete nodes¹.
- To add nodes at run time, you can use the Nodes collection of the TreeView control and call its Add() method with parameters for node text and image index (optional). For example:

```csharp
// Create root node
TreeNode rootNode = treeView1.Nodes.Add("Root");
// Create child nodes
TreeNode childNode1 = rootNode.Nodes.Add("Child 1");
TreeNode childNode2 = rootNode.Nodes.Add("Child 2");
// Create grandchild nodes
TreeNode grandChildNode1 = childNode1.Nodes.Add("Grandchild 1");
TreeNode grandChildNode2 = childNode2.Nodes.Add("Grandchild 2");
```

Some of the common properties and methods of a TreeView control are:

- **SelectedNode**: Gets or sets the node that is currently selected in the tree view⁴. For example:

```csharp
// Get selected node
TreeNode selectedNode = treeView1.SelectedNode;
// Set selected node
treeView1.SelectedNode = childNode2;
```

- **ExpandAll()**: Expands all the tree nodes⁴. For example:

```csharp
// Expand all nodes
treeView1.ExpandAll();
```

- **CollapseAll()**: Collapses all the tree nodes⁴. For example:

```csharp
// Collapse all nodes
treeView1.CollapseAll();
```

- **AfterSelect**: Occurs when a tree node is selected⁴. You can handle this event to perform some actions based on the selected node. For example:

```csharp
// Handle AfterSelect event
private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
{
    // Get selected node text
    string nodeText = e.Node.Text;
    // Do something with nodeText
}
```

Question 3:-
### Explain ListView Control with an example.
Answer:-
A ListView control in C# is an ItemsControl that is derived from ListBox². It provides an interface to display a list of items using different views including text, small images, and large images³. You can also add columns, subitems, checkboxes, and groups to a ListView control⁵.

Here is an example of how to use a ListView control in C# Windows Application:

- First, you need to add a ListView control to your form from the Toolbox. You can set its properties such as Name, Location, Size etc. in the Properties window.
- Next, you need to add columns to your ListView control if you want to display items in details view. You can do this either at design time or at run time. To add columns at design time, you can expand the Columns property of the ListView control and click on the ellipsis (...) button. This will open a ColumnHeader Collection Editor where you can add, edit or delete columns².
- To add columns at run time, you can use the Columns collection of the ListView control and call its Add() method with parameters for column heading and width. For example:

```csharp
// Add columns
listView1.Columns.Add("Name", 100);
listView1.Columns.Add("Age", 50);
listView1.Columns.Add("Gender", 50);
```

- Next, you need to add items and subitems to your ListView control. You can do this either at design time or at run time. To add items and subitems at design time, you can expand the Items property of the ListView control and click on the ellipsis (...) button. This will open a ListViewItem Collection Editor where you can add, edit or delete items and subitems².
- To add items and subitems at run time, you can use the Items collection of the ListView control and call its Add() method with parameters for item text and image index (optional). You can also use the SubItems collection of each item and call its Add() method with parameters for subitem text. For example:

```csharp
// Add items
ListViewItem item1 = listView1.Items.Add("Alice", 0); // 0 is image index
ListViewItem item2 = listView1.Items.Add("Bob", 1); // 1 is image index
// Add subitems
item1.SubItems.Add("25");
item1.SubItems.Add("Female");
item2.SubItems.Add("30");
item2.SubItems.Add("Male");
```

Some of the common properties and methods of a ListView control are:

- **View**: Gets or sets how items are displayed in the control⁵. The possible values are LargeIcon (default), SmallIcon, List or Details. For example:

```csharp
// Set view mode
listView1.View = View.Details;
```

- **CheckBoxes**: Gets or sets a value indicating whether a check box appears next to each item in the control⁵. For example:

```csharp
// Enable check boxes
listView1.CheckBoxes = true;
```

- **Groups**: Gets a collection containing all groups that appear in the control⁵. You can use this collection to add new groups or remove existing groups. For example:

```csharp
// Create groups
ListViewGroup group1 = new ListViewGroup("Group 1");
ListViewGroup group2 = new ListViewGroup("Group 2");
// Add groups
listView1.Groups.Add(group1);
listView1.Groups.Add(group2);
// Assign items to groups
item1.Group = group1;
item2.Group = group2;
```

- **SelectedItems**: Gets a collection containing all selected items in the control⁵. You can use this collection to access or modify selected items. For example:

```csharp
// Get selected items count
int count = listView1.SelectedItems.Count;
// Loop through selected items
foreach (ListViewItem selectedItem in listView1.SelectedItems)
{
    // Do something with selectedItem 
}
```

### Practical Questions

<!-- link of github/fenilsonani/gui-prorams -->
<a href="https://github.com/fenilsonani/gui-program">Github</a>
