   M S B A M L   `   `   `  ����J  FPharmacyHajiawa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:PharmacyHajiawa.Views.Store.BuyPharmacyHajiawa.Views.Store.Buy  5      1    +PharmacyHajiawa.Views.Store.Buy.BuyMainPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:PharmacyHajiawa.Views.Store.Buy     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6C   -   5          N� Title$  کڕین��5	       � 	Resources 5      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Property �� Value   CenterGridHeaderStyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%  '        &	  �     �� 5   
   "  6   �5      �� 5       �@��TextAlignment$ Center=�6<   �� 5       � ��$ Center=�6@   6Q   5      �� 5   
   "  6.   .�5      ��  � ��$ Center=�6;   �� 5       � ��$ Center=�69   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��90 �6   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5    
   �� $��0��6   .+�5!      � $��Center=�6   $��Center=�60    5"      �� 5#      $
��auto �6$   �� 5$      $
��auto �6$   .+�5&      �� $��0��6   $��Center=�6%   $��Center=�6B   .��5'      ��  �� Orientation$ 
Horizontal=�6!   .+�5(      �� -   5         ��Name$ inBuyInvoiceId��5(   /   $��18(�6!   $
��Bold"�6G   .��6Y   16\   �� 5)      $��Arabic Typesetting)�6    $��22(�6@   .��6N   !:کۆدی پسوڵەی کڕین6a   5*      5+      �� 5,      $��1��6   $ 
Horizontal=�6*   $��Center=�6C   .+�5-      #  MaterialDesignThemes.Wpf.Card  $��1��6&   $
��10,0q�63   
�������+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth2=�6Z   $
��10,0q�6�   .��5.      �� $��Center=�6"   $��Center=�6?   $ 
Horizontal=�6Z   .+�5/      �� -   5        $��50��5/      
������ $��0q�6A   .��50      �� '  !MaterialDesignThemes.Wpf.PackIcon  6%   $��30��6=   $��30��6H   	   Kind$	 ClipboardListOutline=�6T   ���#27AEE9$��Center=�6�   $��Center=�6�   6�   51      �� 52      -   5        $ 	inCompany��52   $   $��Arabic Typesetting)�67   $��24(�6W   �� 53      $��Arabic Typesetting)�6   $��24(�6<   .��6J   :کۆمپانیا6U   54      55        56      $��1��6*   $
��10,0q�67   
�������$ Depth2=�6^   .��57      �� $��Center=�6&   $��Center=�6C   $ 
Horizontal=�6^   .+�58      (  "System.Windows.Controls.DatePicker  -   5        
  Name$
 	inBuyDate��58   )   $��Center=�6<   $��Center=�6Y   �� 59      $��Arabic Typesetting)�6$   $��24(�6D   .��6R   :بەرواری کڕین6a   5:      5;      5<      5?      5@      �� 5A   
   $��	10,5,10,5q�6   $��1��6(   .+�5D      �� $��Center=�6   $��Center=�66   .+�5F      �� -   5        $��50��5F      
������ $��0q�6=   .��5G      ��   6!   $��30��69   $��30��6D   $		 Add=�6P   ���#27AEE9$��Center=�6p   $��Center=�6�   6�   5H      5I      5K      &   System.Windows.Controls.DataGrid  5M   
   -   5          Name$ mainDatagrid��5U      $��2��5N      $��	0,10,0,10q�5O      $
��auto��5P      $
��auto��5Q      $
��True��5R      $
��Auto=�5S         ColumnHeaderStyle# �   5T         CanUserAddRows$ False��5V         CanUserDeleteRows$ False��5W         CanUserReorderColumns$ False��5X      $|�False��5Y         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5Z         	RowHeight$ 50Q�5[      $��Arabic Typesetting)�5\   @   $��30(�6`      	CellStyle 5_      �� 5`      "  6   .�5a      ��  �@��TextAlignment$ Center=�6@   �� 5b       � �� 5c      �� 5d       �� 
TargetType"  6.   .R�5e   "   � #��z��6'   .+�5f   &   �� $��Center=�67   5g   #   5h      5j      5k      5m      �� 5n   
   -   5        ���#0078D7
�������$��3��5n   N   $��Center=�6[   $��Bottom=�6x   $	��100��6�   $��36��6�   $��0,0,0,2q�6�   $��Arabic Typesetting)�6�   $��28(�6�   .��6�   
کڕین6�   5p      5r      