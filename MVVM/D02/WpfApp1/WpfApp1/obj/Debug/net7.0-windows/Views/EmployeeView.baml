   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.ViewsWpfApp1.Views  5   	        WpfApp1.Views.EmployeeView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfApp1.Views     5   	     � Title$  EmployeeView��5   	   $	��450��6   $	��800��6+   .��5	      �� .+�5   
   �� .+�5      �� .��5      ��  � DataContext 6   �� *EmployeeData+.+�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��	FirstName��6$   67   �� 5      $	��100��6"   $��30��6I   ��6.   �� *	FirstName+6W   5      �� 5      $ 
Horizontal=�6!   .+�5      �� $��LastName��6$   66   �� 5      $	��100��6"   $��30��6I   ��6.   �� *
LastName+6W   5      �� 5      $ 
Horizontal=�6!   .+�5      �� $��Grade��6$   63   �� 5      $	��100��6"   $��30��6F   ��6.   �� *Grade+6T   5      5      5      �� 5      $ 
Horizontal=�6   .+�5!      �� $
��Save��6   $	��100��5"      $��40��5#      ��5$      �� *SaveCommand+67   5+      5,      &   System.Windows.Controls.DataGrid  57   
      AutoGenerateColumns$ False��66   ��6   �� *	employees+   Columns 58      0  *System.Windows.Controls.DataGridTextColumn  59      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      
Visibility$ Hidden=�6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+5;        5<      $
 Name��6%    63   �� *	FirstName+5>        5?      $	 Age��6%    62   �� *
LastName+5A        5B      $ Address��6%    66   �� *Grade+5D      4  .System.Windows.Controls.DataGridTemplateColumn  5F         Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6)   	   CellTemplate	 5G      �� 5H      .R�5I      �� $��Delete��6%   ��67   �� *Id+��6W   �� 
 �� Path$
 DataContext.DeleteCommand� �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window5J   d   5K      5M        5P      $ 50 6)   	 5Q      �� 5R      .R�5S      �� $��Select��6%   ��5T   %   �� ��5U   %   �� $
 DataContext.SelectCommand� �� *FindAncestor+
 Window5V   g   5W      5Y      5[      5\      5]      