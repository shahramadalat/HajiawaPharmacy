   M S B A M L   `   `   `  ����J  FPharmacyHajiawa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:PharmacyHajiawa.Views.CostPharmacyHajiawa.Views.Cost  5      -    'PharmacyHajiawa.Views.Cost.CostViewPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:PharmacyHajiawa.Views.Cost     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6>   -   5          N� Title$  فرۆشتن��5	       � 	Resources 5      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Property �� Value   CenterGridHeaderStyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%  '        &	  �     �� 5   
   "  6   �5      �� 5       �@��TextAlignment$ Center=�6<   �� 5       � ��$ Center=�6@   6Q   5      �� 5   
   "  6.   .�5      ��  � ��$ Center=�6;   �� 5       � ��$ Center=�69   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   .+�5    
   �� $��	10,5,10,5q�6   .+�5#      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5$      �� -   5        $	��150��5$   2   $��35��6>   $
��10,0q�6J   $��Arabic Typesetting)�6X   $��28(�6y   .��6�   ڕەشکراوەکان6�   �� 5%      -   5        $	��150��5%   5   $��35��6A   $
��10,0q�6M   $��Arabic Typesetting)�6[   $��28(�6|   .��6�   بەردەست6�   5&      �� 5'      $��	10,5,10,5q�6   ���#27AEE969   �� 5(      $��Center=�6   $��Center=�66   .+�5*      �� -   5        $��50��5+      
������ $��0q�5-      .��50      '  !MaterialDesignThemes.Wpf.PackIcon  $��30��51      $��30��52         Kind$	 Add=�53      ���#27AEE9$��Center=�55      $��Center=�56      58      59      �� 5:      $ 
Horizontal=�6   $��Center=�62   .+�5;      �� -   5         ��Name$ buttonRemoveSearchText��5<      $��60��5=      
������ $��0q�5?      $y�Hidden=�5A      .��5C        $��30��5D      $��30��5E      $ Close=�5F      
�������$��Center=�5H      $��Center=�5I      5K      �� 5L      -   5        	 ��Name$	 textboxSeatch��5L      $��Center=�61   $	��200��6N   
 �� 
CaretBrush

 � ��� w� Text$ Search here��5N      .��5P      5R        5S      $��30��5T      $��30��5U      $ Search=�5V      
��� ���$��Center=�5X      $��Center=�5Y      5[      #  MaterialDesignThemes.Wpf.Card  5\      $��5q�6"   .��5]      �� -   5         ��Name$ textblockItemName��5^      $��Center=�5_      $��Center=�5`      $��Arabic Typesetting)�5a      $��30(�5b      5e      5f      5j      &   System.Windows.Controls.DataGrid  5k   
   -   5          Name$ mainDatagrid��5s      $��1��5l      $��	5,10,5,10q�5m      $
��auto��5n      $
��auto��5o      $
��True��5p      $
��Auto=�5q         ColumnHeaderStyle# �   5r         CanUserAddRows$ False��5t         CanUserDeleteRows$ False��5u         CanUserReorderColumns$ False��5v      $|�False��5w         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5x         	RowHeight$ 50Q�5y      $��Arabic Typesetting)�5z   @   $��30(�6`      	CellStyle 5~      �� 5      "  6   .�5�      ��  �@��TextAlignment$ Center=�6@   �� 5�       � �� 5�      �� 5�       �� 
TargetType"  6.   .R�5�   "   � #��z��6'   .+�5�   &   �� $��Center=�67   5�   #   5�      5�      5�      5�      5�      5�      