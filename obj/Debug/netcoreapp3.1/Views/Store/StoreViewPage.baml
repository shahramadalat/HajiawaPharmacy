   M S B A M L   `   `   `  ����J  FPharmacyHajiawa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:PharmacyHajiawa.Views.StorePharmacyHajiawa.Views.Store  5      /    )PharmacyHajiawa.Views.Store.StoreViewPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:PharmacyHajiawa.Views.Store     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6?   -   5          N� Title$  کۆگا��5	       � 	Resources 5
      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Property �� Value   CenterGridHeaderStyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%  '        &	  �     �� 5   
   "  6   �5      �� 5       �@��TextAlignment$ Center=�6<   �� 5       � ��$ Center=�6@   6Q   5      �� 5   
   "  6.   .�5      ��  � ��$ Center=�6;   �� 5       � ��$ Center=�69   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��125 �6   �� 5      $��* �6   .+�5   
   �� $��	10,5,10,5q�6   $��0��6(   .+�5      �� -   5         ��Name$ 	stackTest��5      5"      �� 5$      $��Center=�6   $��Center=�66   .+�5&      ��  �� Orientation$ 
Horizontal=�6   $��Center=�66   .+�5'      �� -   5        $	��150��5'   6   $��35��6B   $
��10,0q�6N   $��Arabic Typesetting)�6\   $��28(�6}   .��6�   ڕەشکراوەکان6�   �� 5(      -   5        $	��150��5(   9   $��35��6E   $
��10,0q�6Q   $��Arabic Typesetting)�6_   $��28(�6�   .��6�   بەردەست6�   5)      �� 5*      -   5        $��50��5+      
������ $��0q�5-      .��50      '  !MaterialDesignThemes.Wpf.PackIcon  $��30��51      $��30��52         Kind$	 Add=�53      ���#27AEE9$��Center=�55      $��Center=�56      58      59      �� 5:      $ 
Horizontal=�6   $��Center=�62   .+�5;      �� -   5        	 ��Name$	 buttonRemoveSearchText��5;      $��60��5<      
������ $��0q�5>      $y�Hidden=�5@      .��5B        $��30��5C      $��30��5D      $ Close=�5E      
�������$��Center=�5G      $��Center=�5H      5J      �� 5K      -   5        
 ��Name$
 textboxSeatch��5K      $��Center=�61   $	��200��6N    �� 
CaretBrush
 � ��� w� Text$ Search here��5M      .��5O      5Q        5R      $��30��5S      $��30��5T      $ Search=�5U      
��� ���$��Center=�5W      $��Center=�5X      5Z      5^      &   System.Windows.Controls.DataGrid  5`   
   -   5          Name$ mainDatagrid��5h      $��1��5a      $��	0,10,0,10q�5b      $
��auto��5c      $
��auto��5d      $
��True��5e      $
��Auto=�5f         ColumnHeaderStyle# �   5g         CanUserAddRows$ False��5i         CanUserDeleteRows$ False��5j         CanUserReorderColumns$ False��5k      $|�False��5l         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5m         	RowHeight$ 50Q�5n      $��Arabic Typesetting)�5o   @   $��30(�6`      	CellStyle 5s      �� 5t      "  6   .�5u      ��  �@��TextAlignment$ Center=�6@   �� 5v       � �� 5w      �� 5x       �� 
TargetType"  6.   .R�5y   "   � #��z��6'   .+�5z   &   �� $��Center=�67   5{   #   5|      5~      5      5�      5�      5�      