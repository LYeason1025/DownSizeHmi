   M S B A M L   `   `   `  ����P  Ldownsizing_machineHMI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:downsizing_machineHMIdownsizing_machineHMI  5   	   &     downsizing_machineHMI.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   A =Wpf.Ui, Version=2.0.3.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml  5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   /local#clr-namespace:downsizing_machineHMI  5   	     � WindowStyle$
  None=�5	       � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency$
 True��6.   
������ $��0q�6a    � Title$ 
MainWindow��5   	   $
��1080��6   $
��1920��6*   .��5      �  � RowDefinitions 5   
   �� 5      $	��110 �6   �� 5      $	��865 �6   �� 5      $	��105 �6   .+�5   
   �� -   5        $��titleBar��5      $��0��6!   ���#312d50$��0q�6b   �� 5   
   $��1��6   $��0q�6   ���#382f505      �� 5   
   $��2��6   ���#252321$��0q�63   � 5   
   $��0��6    � ColumnDefinitions 5      �� 5      �� 5      �� 5      .+�5"      ��  �� Orientation$ 
Horizontal=�6   $��0��62   .+�5#      �� ���#312d50$	��100��6,   �� 5$      -   5        $��cassOpen��5$   2   $	��100��6   $	��100��6%   $��10,10,10,10q�6B   .��5%      �� $��Center=�6!   $��Center=�6<   .+�5&      "  FontAwesome.WPF.ImageAwesome     Icon$ Magic=�6*   $��50��67      
Foreground
 �����6B   �� 5'      $��	Cass.open��6$   $��8q�65   5(      5)      5+      A� 5-      $��5,5,5,5q�6   $��1��6+   .+�50      �� -   5        $��timeTextBox��50      $��5,5,5,5q�6.   $��Stretch=�6?      main_TextBox#��[  6]   �� 51      -   5        $��statusTextBox��51      $��5,5,5,5q�60   $��Stretch=�6A   #��[  6_   �� 52      -   5        $��numberTextBox��52      $��5,5,5,5q�60   $��Stretch=�6A   #��[  6_   �� 53      $��5,5,5,5q�6   $��Stretch=�6,   #��[  6J   �� 55      $��5,5,5,5q�6   $��Stretch=�6+   #��[  6I   56      �� 58      $��2��6   $ 
Horizontal=�6)   $��Right=�6B   .+�59      �� $��10,10,10,10q�6   $	��100��6/   $	��100��6;   .��5:      �� $��Center=�6!   $��Center=�6<   .+�5;        $ Terminal=�6*   $��50��6;   
 �����6F   �� 5<      $��修改串口��6$   $��Center=�60   $��8q�6M   $��FontAwesome)�6X   5=      5>      �� 5@      -   5        $��MiniBtn��5@      $
��Mini��6(   $��10,10,10,10q�67   $	��100��6L   $	��100��6X   6e   �� 5B      -   5        $��CloseBtn��5B      $��Close��6)   $��10,10,10,10q�69   $	��100��6N   $	��100��6Z   6g   5C      5E      �� 5J   
   -   5        	 ��Name$	 MainArea��5J   &   $��1��6   6&   � 5L   
   $��1��6   5N      � 5Q   
   $��1��6   .+�5R      �  5S      �� 5T      $��* �6'   �� 5U      $��* �6'   .+�5[      �� -	   5        $	 ContentControl��5[   1   $��0��6!   61   �� 5\      -
   5        $	 ContentControlRight��5\   1   $��1��6!   61   5]      5^      � 5`   
   $��2��6    5a      �� 5b      �� 5c      .+�5g      �� -   5        $��menuLeft��5g      $��0��6-   .��5h      �� $ 
Horizontal=�6   $��Center=�67   .+�5i      �� -   5        
 ��Name$
 AutoBtn��5i        main_Button#��[ 6.   .��5j      �  5k      �� 5l   "   �� 5m   "   .+�5o        $
 Font=�6.   $��50��6:   $��5,5,5,5q�6E   
 �����6V   �� 5p      $��自动��6(   $��1��62   $��Center=�6@   $��FontAwesome)�6]   $��5,5,5,5q�6v   5q      5r      �� 5t      -   5        $
 MaintBtn��5t      #��[ 6/   .��5u      �  5v      �� 5w   "   �� 5x   "   .+�5z        $ Wrench=�6.   $��50��6<   $��5,5,5,5q�6G   
 �����6X   �� 5{      $��维护��6(   $��1��62   $��Center=�6@   $��FontAwesome)�6]   $��5,5,5,5q�6v   5|      5}      �� 5      -   5        $
 DataBtn��5      #��[ 6.   .��5�      �  5�      �� 5�   "   �� 5�   "   .+�5�        $ Database=�6.   $��50��6>   $��5,5,5,5q�6I   
 �����6Z   �� 5�      $��数据��6(   $��1��62   $��Center=�6@   $��FontAwesome)�6]   $��5,5,5,5q�6v   5�      5�      5�      5�      �� 5�      -   5        $	 initialTextBox��5�      $��0��65   $y�	Collapsed=�6E   .��5�      �� .+�5�      �� $	��111��6   $��90��6)   #��[  65   5�      5�      �� 5�      -   5        $��	menuRight��5�   -   $��1��6   .��5�      �� $ 
Horizontal=�6   $��Center=�67   .+�5�      �� -   5        $
 
InitialBtn��5�      #��[ 61   .��5�      �  5�      �� 5�   "   �� 5�   "   .+�5�        $ Refresh=�6.   $��50��6=   $��5,5,5,5q�6H   
 �����6Y   �� 5�      $��	初始化��6(   $��1��63   $��Center=�6A   $��FontAwesome)�6^   $��5,5,5,5q�6w   5�      5�      �� 5�      -   5        $
 	WarmUpBtn��5�      #��[ 60   .��5�      �  5�      �� 5�   "   �� 5�   "   .+�5�        $ DotCircleOutline=�6.   $��50��6F   $��5,5,5,5q�6Q   
 �����6b   �� 5�      $��热机��6(   $��1��62   $��Center=�6@   $��FontAwesome)�6]   $��5,5,5,5q�6v   5�      5�      �� 5�      -   5        $
 GaugeTestBtn��5�      #��[ 63   .��5�      �  5�      �� 5�   "   �� 5�   "   .+�5�        $ 
textheight=�6.   $��50��6@   $��5,5,5,5q�6K   
 �����6\   �� 5�      $��厚度测试��6(   $��1��64   $��Center=�6B   $��FontAwesome)�6_   $��5,5,5,5q�6x   5�      5�      5�      5�      �� 5�      -   5        $��initialStart��5�   -   $��1��6   $y�	Collapsed=�6A   .��5�      �� $ 
Horizontal=�6   $��Center=�67   .+�5�      �� -   5        $
 InitialStartBtn��5�      #��[ 66   .��5�      �  5�      �� 5�   "   �� 5�   "   .+�5�        $
 Play=�6.   $��50��6:   $��5,5,5,5q�6E   
 �����6V   �� 5�      $��开始��6(   $��1��62   $��Center=�6@   $��FontAwesome)�6]   $��5,5,5,5q�6v   5�      5�      5�      5�      �� 5�      -   5        $��WarmUpStart��5�   -   $��1��6   $y�	Collapsed=�6@   .��5�      �� $ 
Horizontal=�6   $��Center=�67   .+�5�      �� -   5        $
 WarmUpStartBtn��5�      #��[ 65   .��5�      �  5�      �� 5�   "   �� 5�   "   .+�5�        $
 Play=�6.   $��50��6:   $��5,5,5,5q�6E   
 �����6V   �� 5�      $��开始��6(   $��1��62   $��Center=�6@   $��FontAwesome)�6]   $��5,5,5,5q�6v   5�      5�      �� 5�      -   5        $
 WarmUpStopBtn��5�      #��[ 64   .��5�      �  5�      �� 5�   "   �� 5�   "   .+�5�        $ Pause=�6.   $��50��6;   $��5,5,5,5q�6F   
 �����6W   �� 5�      $��停止��6(   $��1��62   $��Center=�6@   $��FontAwesome)�6]   $��5,5,5,5q�6v   5�      5�      5�      5�      �� 5�      -   5        $��FAPasue��5�   -   $��1��6   $y�	Collapsed=�6<   .��5�      �� $ 
Horizontal=�6   $��Center=�67   .+�5�      �� -   5        $
 
FAPasueBtn��5�      #��[ 61   .��5�      �  5�      �� 5�   "   �� 5�   "   .+�5�        $ Pause=�6.   $��50��6;   $��5,5,5,5q�6F   
 �����6W   �� 5�      $��暂停��6(   $��1��62   $��Center=�6@   $��FontAwesome)�6]   $��5,5,5,5q�6v   5�      5�      5�      5�      �� 5�      -   5        $��	FAPasueCL��5�   -   $��1��6   $y�	Collapsed=�6>   .��5�      �� $ 
Horizontal=�6   $��Center=�67   .+�5�      �� -   5        $
 FAPasueContinueBtn��5�      #��[ 69   .��5�      �  5�      �� 5�   "   �� 5�   "   .+�5       $
 Play=�6.   $��50��6:   $��5,5,5,5q�6E   
 �����6V   �� 5     $��继续��6(   $��1��62   $��Center=�6@   $��FontAwesome)�6]   $��5,5,5,5q�6v   5     5     �� 5     -   5        $
 FAPasuePurgeBtn��5     #��[ 66   .��5     �  5	     �� 5
  "   �� 5  "   .+�5       $ Compress=�6.   $��50��6>   $��5,5,5,5q�6I   
 �����6Z   �� 5     $��清除��6(   $��1��62   $��Center=�6@   $��FontAwesome)�6]   $��5,5,5,5q�6v   5     5     �� 5     -   5        $��FAPasuePurgeGPBtn��5     #��[ 66   .��5     �� .+�5     �� $��Purge��6(   $��Center=�65   �� 5     $��(Grind Pass)��6(   $��Center=�6<   5     5     �� 5     -   5        $
 FAPasueHOBtn��5     #��[ 63   .��5     �  5     �� 5  "   �� 5  "   .+�5        $ Header=�6.   $��50��6<   $��5,5,5,5q�6G   
 �����6X   �� 5!     $��高度偏移��6(   $��1��64   $��Center=�6B   $��FontAwesome)�6_   $��5,5,5,5q�6x   5"     5#     5&     5'     �� 5)     -    5        $��menuSkip��5)  d   $��Right=�6   $��1��69   $��Center=�6I   .��5+     �� -!   5        $
 FABtn��5+     #��[ 6(   .��5,     �  5-     �� 5.     �� 5/     .+�51       $
 Play=�6*   $��50��66   $��5,5,5,5q�6A   
 �����6R   �� 52     $��开始��6$   $��1��6.   $��Center=�6<   $��FontAwesome)�6Y   $��5,5,5,5q�6r   53     54     56     �� 58     -"   5        $��menuExit��58  d   $��Right=�6   $��1��69   $��Center=�6I   $y�	Collapsed=�6u   .��59     �� -#   5        $

 Exit��59     #��[ 6'   .��5:     �  5;     �� 5<     �� 5=     .+�5?       $ Reply=�6*   $��50��67   $��5,5,5,5q�6B   
 �����6S   �� 5@     $��返回��6$   $��1��6.   $��Center=�6<   $��FontAwesome)�6Y   $��5,5,5,5q�6r   5A     5B     5D     5G     5K     5L     