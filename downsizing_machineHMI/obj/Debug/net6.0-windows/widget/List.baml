   M S B A M L   `   `   `  ����P  Ldownsizing_machineHMI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:downsizing_machineHMI.widgetdownsizing_machineHMI.widget  5      '    !downsizing_machineHMI.widget.List   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:downsizing_machineHMI.widget     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      .��5
      �   � ColumnDefinitions  5   
   �� 5      $��8* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  $��0��6      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%     5      $ CONMENT��6%     5      $
 Size��6%     5      $
 Org.��6%     5      $
 Fin.��6%     5      $ Attr.��6%     5      $ Date.��6%   5      �� 5   
   $��1��6   .+�5      �� $��
Current ID��6      main_TextBlock#��[  6*   �� 5        main_TextBox#��[ 6   ��6<   ��  �� Path$
 text� �� ElementName$ 	IDTextBox���� 5       $��
Current ID��6   #��[  6*   �� 5!      #��[ 6   �� 5#      -   5         ��Name$ Select��5#        main_Button#��[ 6%   .��5$      �  � RowDefinitions 5%      �� 5&      �� 5'      .+�5)      "  FontAwesome.WPF.ImageAwesome     Icon$ CheckCircle=�6&   $��50��69   $��5,5,5,5q�6D      
Foreground
 �����6U   �� 5*      $��选择��6    $��1��6*   $��Center=�68   $��FontAwesome)�6U   $��5,5,5,5q�6n   5+      5,      �� 5/      
������ $��70��6+   �� 51      .+�53      �� -   5        $
 Copy��53      #��[ 6'   .��54      �  55      �� 56      �� 57      .+�59        $
 Copy=�6*   $��50��66   $��5,5,5,5q�6A   
 �����6R   �� 5:      $��复制��6$   $��1��6.   $��Center=�6<   $��FontAwesome)�6Y   $��5,5,5,5q�6r   5;      5<      �� 5=      -   5        $ Delete��5=      #��[ 6)   .��5>      �  5?      �� 5@      �� 5A      .+�5C        $ Eraser=�6*   $��50��68   $��5,5,5,5q�6C   
 �����6T   �� 5D      $��删除��6$   $��1��6.   $��Center=�6<   $��FontAwesome)�6Y   $��5,5,5,5q�6r   5E      5F      �� 5H      -   5        $ Rename��5H      #��[ 6)   .��5I      �  5J      �� 5K      �� 5L      .+�5N        $ SignOut=�6*   $��50��69   $��5,5,5,5q�6D   
 �����6U   �� 5O      $��	重命名��6$   $��1��6/   $��Center=�6=   $��FontAwesome)�6Z   $��5,5,5,5q�6s   5P      5Q      �� 5S      -   5        $ 	Attribute��5S      #��[ 6,   .��5T      �  5U      �� 5V      �� 5W      .+�5Y        $ 	Paperclip=�6*   $��50��6;   $��5,5,5,5q�6F   
 �����6W   �� 5Z      $��属性��6$   $��1��6.   $��Center=�6<   $��FontAwesome)�6Y   $��5,5,5,5q�6r   5[      5\      �� 5]      -   5        $ 
ListOption��5]      #��[ 6-   .��5^      �  5_      �� 5`      �� 5a      .+�5c        $ Compass=�6*   $��50��69   $��5,5,5,5q�6D   
 �����6U   �� 5d      $��选项��6$   $��1��6.   $��Center=�6<   $��FontAwesome)�6Y   $��5,5,5,5q�6r   5e      5f      �� 5g      -   5        $ Cancel��5g      #��[ 6)   .��5h      �  5i      �� 5j      �� 5k      .+�5m        $
 Undo=�6*   $��50��66   $��5,5,5,5q�6A   
 �����6R   �� 5n      $��取消��6$   $��1��6.   $��Center=�6<   $��FontAwesome)�6Y   $��5,5,5,5q�6r   5o      5p      5r      5v      5x      5y      