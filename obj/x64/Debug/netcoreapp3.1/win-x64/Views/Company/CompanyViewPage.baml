   M S B A M L   `   `   `  ����J  FPharmacyHajiawa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:PharmacyHajiawa.Views.CompanyPharmacyHajiawa.Views.Company  5      3    -PharmacyHajiawa.Views.Company.CompanyViewPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:PharmacyHajiawa.Views.Company     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6A   -   5          N� Title$  CompanyViewPage��5	       � 	Resources 5      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Property �� Value   CenterGridHeaderStyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%  '        &	  �     �� 5   
   "  6   �5      �� 5       �@��TextAlignment$ Center=�6<   �� 5       � ��$ Center=�6@   6Q   5      �� 5   
   "  6.   .�5      ��  � ��$ Center=�6;   �� 5       � ��$ Center=�69   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��125 �6   �� 5      $��* �6   .+�5   
   �� $��	10,5,10,5q�6   $��0��6(   .+�5      �� -   5         ��Name$ 	stackTest��5       5#      �� 5%      $��Center=�6   $��Center=�66   .+�5'      ��  �� Orientation$ 
Horizontal=�6   $��Center=�66   .+�5(      �� -   5        $	��150��5(   6   $��35��6B   $
��10,0q�6N   $��Arabic Typesetting)�6\   $��28(�6}   .��6�   ڕەشکراوەکان6�   �� 5)      -   5        $	��150��5)   9   $��35��6E   $
��10,0q�6Q   $��Arabic Typesetting)�6_   $��28(�6�   .��6�   بەردەست6�   5*      �� 5+      -   5        $��50��5,      
������ $��0q�5.      .��51      '  !MaterialDesignThemes.Wpf.PackIcon  $��30��52      $��30��53         Kind$	 Add=�54      ���#27AEE9$��Center=�56      $��Center=�57      59      5:      �� 5;      $ 
Horizontal=�6   $��Center=�62   .+�5<      �� -   5        	 ��Name$	 buttonRemoveSearchText��5<      $��60��5=      
������ $��0q�5?      $y�Hidden=�5A      .��5C        $��30��5D      $��30��5E      $ Close=�5F      
�������$��Center=�5H      $��Center=�5I      5K      �� 5L      -   5        
 ��Name$
 textboxSeatch��5L      $��Center=�61   $	��200��6N    �� 
CaretBrush
 � ��� w� Text$ Search here��5N      .��5P      5R        5S      $��30��5T      $��30��5U      $ Search=�5V      
��� ���$��Center=�5X      $��Center=�5Y      5[      5_      &   System.Windows.Controls.DataGrid  5a   
   -   5          Name$ mainDatagrid��5i      $��1��5b      $��	5,10,5,10q�5c      $
��auto��5d      $
��auto��5e      $
��True��5f      $
��Auto=�5g         ColumnHeaderStyle# �   5h         CanUserAddRows$ False��5j         CanUserDeleteRows$ False��5k         CanUserReorderColumns$ False��5l      $|�False��5m         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5n         	RowHeight$ 50Q�5o      $��Arabic Typesetting)�5p   @   $��30(�6`      	CellStyle 5s      �� 5t      "  6   .�5u      ��  �@��TextAlignment$ Center=�6@   �� 5v       � �� 5w      �� 5x       �� 
TargetType"  6.   .R�5y   "   � #��z��6'   .+�5z   &   �� $��Center=�67   5{   #   5|      5~      5      5�      5�      5�      