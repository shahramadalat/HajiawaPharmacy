   M S B A M L   `   `   `  ����J  FPharmacyHajiawa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:PharmacyHajiawa.Views.ItemsPharmacyHajiawa.Views.Items  5      .    (PharmacyHajiawa.Views.Items.ItemTypePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:PharmacyHajiawa.Views.Items     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          N� Title$  جۆری کاڵاکان��5
       � 	Resources 5      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Property �� Value   CenterGridHeaderStyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%  '        &	  �     �� 5   
   "  6   �5      �� 5       �@��TextAlignment$ Center=�6<   �� 5       � ��$ Center=�6@   6Q   5      �� 5   
   "  6.   .�5      ��  � ��$ Center=�6;   �� 5       � ��$ Center=�69   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��125 �6   �� 5      $��* �6   .+�5   
   �� $��	10,5,10,5q�6   $��0��6(   .+�5       �� -   5         ��Name$ 	stackTest��5!      5$      �� 5&      $��Center=�6   $��Center=�66   .+�5(      ��  �� Orientation$ 
Horizontal=�6   $��Center=�66   .+�5)      �� -   5        $	��150��5)   6   $��35��6B   $
��10,0q�6N   $��Arabic Typesetting)�6\   $��28(�6}   .��6�   ڕەشکراوەکان6�   �� 5*      -   5        $	��150��5*   9   $��35��6E   $
��10,0q�6Q   $��Arabic Typesetting)�6_   $��28(�6�   .��6�   بەردەست6�   5+      �� 5,      -   5        $��50��5-      
������ $��0q�5/      .��52      '  !MaterialDesignThemes.Wpf.PackIcon  $��30��53      $��30��54         Kind$	 Add=�55      ���#27AEE9$��Center=�57      $��Center=�58      5:      5;      �� 5<      $ 
Horizontal=�6   $��Center=�62   .+�5=      �� -   5        	 ��Name$	 buttonRemoveSearchText��5=      $��60��5>      
������ $��0q�5@      $y�Hidden=�5B      .��5D        $��30��5E      $��30��5F      $ Close=�5G      
�������$��Center=�5I      $��Center=�5J      5L      �� 5M      -   5        
 ��Name$
 textboxSeatch��5M      $��Center=�61   $	��200��6N    �� 
CaretBrush
 � ��� w� Text$ Search here��5O      .��5Q      5S        5T      $��30��5U      $��30��5V      $ Search=�5W      
��� ���$��Center=�5Y      $��Center=�5Z      5\      5`      &   System.Windows.Controls.DataGrid  5b   
   -   5          Name$ mainDatagrid��5j      $��1��5c      $��	0,10,0,10q�5d      $
��auto��5e      $
��auto��5f      $
��True��5g      $
��Auto=�5h         ColumnHeaderStyle# �   5i         CanUserAddRows$ False��5k         CanUserDeleteRows$ False��5l         CanUserReorderColumns$ False��5m      $|�False��5n         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5o         	RowHeight$ 50Q�5p      $��Arabic Typesetting)�5q   @   $��30(�6`      	CellStyle 5t      �� 5u      "  6   .�5v      ��  �@��TextAlignment$ Center=�6@   �� 5w       � �� 5x      �� 5y       �� 
TargetType"  6.   .R�5z   "   � #��z��6'   .+�5{   &   �� $��Center=�67   5|   #   5}      5      5�      5�      5�      5�      