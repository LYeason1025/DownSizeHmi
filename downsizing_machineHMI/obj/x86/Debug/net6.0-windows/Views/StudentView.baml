   M S B A M L   `   `   `  ����P  Ldownsizing_machineHMI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:downsizing_machineHMI.Viewsdownsizing_machineHMI.Views  5   	   -    'downsizing_machineHMI.Views.StudentView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:downsizing_machineHMI.Views     5   	     � Title$  StudentView��5   	   $	��450��6   $	��800��6*   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0,10,0,0q�6   $��Center=�6'   $��Center=�6D    �� Orientation$ 
Horizontal=�6_   .+�5      �� $��	学号：��6   �� 5      -   5        $��txtStudentId��5      $	��150��6*   ��66   �� *	StudentId+ �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5   
   $��1��6   $��0,10,0,0q�6"   $��Center=�64   $��Center=�6Q   $ 
Horizontal=�6l   .+�5      �� $��	姓名：��6   �� 5      -   5        $��txtStudentName��5      $	��150��6,   ��68   �� *StudentName+$ PropertyChanged=�5      �� 5   
   $��2��6   $��0,10,0,0q�6#   $��Center=�65   $��Center=�6R   $ 
Horizontal=�6m   .+�5      �� $��	年龄：��6   �� 5      -   5        $��txtStudentAge��5      $	��150��6+   ��67   �� *
StudentAge+$ PropertyChanged=�5      �� 5   
   $��3��6   $��0,10,0,0q�6"   $��Center=�64   $��Center=�6Q   $ 
Horizontal=�6l   .+�5      �� $��	性别：��6   �� 5      -   5        $��cbbStudentGender��5      $	��150��6/   ��6;   �� *	Genders+ �� SelectedItem 6[   �� *StudentGender+$ PropertyChanged=�5       �� 5!   
   $��4��6   $��0,10,0,0q�6"   $��Center=�64   $��Center=�6Q   $ 
Horizontal=�6l   .+�5"      �� -   5        $��btnSubmitStudent��5"      $��80��6-   $��提交信息��6w   ��68   �� *SubmitCommand+��6Z   �� 6w   �� 5#      -   5        $��btnResetStudent��5#   '   $��10,0,0,0q�6   $��80��6>   $��重置信息��6J   5$      5%      5&      