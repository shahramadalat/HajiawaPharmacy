   M S B A M L   `   `   `  ����J  FPharmacyHajiawa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:PharmacyHajiawa.Views.Store.Sell PharmacyHajiawa.Views.Store.Sell  5      3    -PharmacyHajiawa.Views.Store.Sell.MainSellPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:PharmacyHajiawa.Views.Store.Sell     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6D   -   5          N� Title$  فرۆشتن��5	       � 	Resources 5      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Property �� Value   CenterGridHeaderStyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%  '        &	  �     �� 5   
   "  6   �5      �� 5       �@��TextAlignment$ Center=�6<   �� 5       � ��$ Center=�6@   6Q   5      �� 5   
   "  6.   .�5      ��  � ��$ Center=�6;   �� 5       � ��$ Center=�69   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5!   
   #  MaterialDesignThemes.Wpf.Card  $��	10,2,10,2q�6   $��0��61   
�������+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth2=�6V   $��3q�6�   .��5"      �  5#      �� 5$      $
��auto �6$   �� 5%      $
��auto �6$   .+�5'      �� $��0��6    �� Orientation$ 
Horizontal=�6*   $��Center=�6C   $��Center=�6`   .+�5(        $
��10,0q�6*   $
��10,0q�68   
�������$ Depth2=�6_   .��5)      �� $��Center=�6&   $��Center=�6C   $ 
Horizontal=�6^   .+�5*      (  "System.Windows.Controls.DatePicker  -   5          Name$ 
inSellDate��5*   )   $��Center=�6=   $��Center=�6Z   �� 5+      $��Arabic Typesetting)�6$   $��24(�6D   .��6R   :بەرواری فرۆشتن6c   5,      5-      �� 5.      -   5        	 ��Name$	 inSellInvoiceId��5.   +   $��18(�6   $
��Bold"�6D   .��6V   06Y   �� 5/      $��Arabic Typesetting)�6   $��22(�6<   .��6J   %#:کۆدی پسوڵەی فرۆشتن6_   50      51      52        55   
   $��	10,2,10,0q�6   $��1��61   
�������$ Depth2=�6V   $��3q�6�   $��43��6�   $	��Top=�6�   .��56      �� $��Center=�6   $��Center=�68   $ 
Horizontal=�6S   .+�58      �� -   5        $��50��58      
������ $��0q�6=   .��59      �� '  !MaterialDesignThemes.Wpf.PackIcon  6!   $��30��69   $��30��6D   
   Kind$	
 Add=�6P   ���#27AEE9$��Center=�6p   $��Center=�6�   6�   5:      �� 5<      -   5         ��Name$ 	inBarcode��5<      $
��10,0q�6I   $	��180��6W   6e   �� 5=      $��Arabic Typesetting)�6   $��24(�68   .��6F   :بارکۆد ڕیدەر6U   5?      5@      &   System.Windows.Controls.DataGrid  5B   
   -   5          Name$ mainDatagrid��5J      $��2��5C      $��	0,10,0,10q�5D      $
��auto��5E      $
��auto��5F      $
��True��5G      $
��Auto=�5H         ColumnHeaderStyle# �   5I         CanUserAddRows$ False��5K         CanUserDeleteRows$ False��5L         CanUserReorderColumns$ False��5M      $|�False��5N         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5O         	RowHeight$ 50Q�5P      $��Arabic Typesetting)�5Q      $��30(�6/      Columns 5T      4	  .System.Windows.Controls.DataGridTemplateColumn	  5V      ,
  &System.Windows.Controls.DataGridColumn 
  Header$ +��6)    	  CellTemplate 5W      �� 5X      .R�5Y      �� -   5        $��60��5[      $��Center=�5\      
������ $��0q�5^      .��5a   "     $��30��5b      $��30��5c      $
 AddCircleOutline=�5d      ���#27AEE9$��Center=�5f      $��Center=�5g      5i      5j      5l      	  5p      $ -��6)    5q      �� 5r      .R�5s      �� -   5        $��60��5t      $��Center=�5u      
������ $��0q�5w      .��5z   "     $��30��5{      $��30��5|      $
 MinusCircleOutline=�5}      ���#27AEE9$��Center=�5      $��Center=�5�      5�      5�      5�         	CellStyle 5�      �� 5�      "  6   .�5�      ��  �@��TextAlignment$ Center=�6@   �� 5�       � �� 5�      �� 5�       �� 
TargetType"  6.   .R�5�   "   � #��z��6'   .+�5�   &   �� $��Center=�67   5�   #   5�      5�      5�      5�      �� 5�   
   $��3��6   $��Center=�6"   $��Center=�6?   $ 
Horizontal=�6Z   $��0,0,0,12q�6s   .+�5�      �� -	   5        ���#0078D7
�������$��3��5�   R   $	��100��6_   $��36��6k   $	��5,0q�6w   $��Arabic Typesetting)�6�   $��30(�6�   .��6�   فرۆشتن6�   �� 5�      -
   5        $ inTotal��5�      ${�False��6'   $
��Bold"�6\   $��4,0,0,0q�6n   $	��200��6   $��22(�6�    �� TextAlignment$ Center=�6�   6�   �� 5�      $��Arabic Typesetting)�6   $��24(�65   .��6C   :کۆی گشتی6N   �� 5�      -   5        $ 
inDiscount��5�      $��4,0,0,0q�6+   $	��150��6<   $��17(�6o   $ Center=�6}   $��0��6�   6�   �� 5�      $��Arabic Typesetting)�6   $��24(�64   .��6B   	:خاتر6I   5�      5�      5�      