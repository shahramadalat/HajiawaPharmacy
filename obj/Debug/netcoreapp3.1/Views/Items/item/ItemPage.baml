   M S B A M L   `   `   `  ����J  FPharmacyHajiawa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:PharmacyHajiawa.Views.Items.item PharmacyHajiawa.Views.Items.item  5      /    )PharmacyHajiawa.Views.Items.item.ItemPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:PharmacyHajiawa.Views.Items.item     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6D   -   5          N� Title$  جۆری کاڵاکان��5	       � 	Resources 5      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Property �� Value   CenterGridHeaderStyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%  '        &	  �     �� 5   
   "  6   �5      �� 5       �@��TextAlignment$ Center=�6<   �� 5       � ��$ Center=�6@   6Q   5      �� 5   
   "  6.   .�5      ��  � ��$ Center=�6;   �� 5       � ��$ Center=�69   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   .+�5    
   �� $��	10,5,10,5q�6   .+�5"      �� -   5         ��Name$ btnBack��5#      $y�Visible=�5$      $��50��5%      
������ $��0q�5'      $
��Left=�5)      .��5+      '  !MaterialDesignThemes.Wpf.PackIcon  $��30��5,      $��30��5-         Kind$ ArrowLeftBold=�5.      ���#27AEE9$��Center=�50      $��Center=�51      53      �� 54       �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�55      �� -   5        $	��150��55   2   $��35��6>   $
��10,0q�6J   $��Arabic Typesetting)�6X   $��28(�6y   .��6�   ڕەشکراوەکان6�   �� 56      -   5        $	��150��56   5   $��35��6A   $
��10,0q�6M   $��Arabic Typesetting)�6[   $��28(�6|   .��6�   بەردەست6�   57      �� 58      $��	10,5,10,5q�6   ���#27AEE969   �� 59      $��Center=�6   $��Center=�66   .+�5;      �� -   5        $��50��5<      
������ $��0q�5>      .��5A        $��30��5B      $��30��5C      $	 Add=�5D      ���#27AEE9$��Center=�5F      $��Center=�5G      5I      5J      �� 5K      $ 
Horizontal=�6   $��Center=�62   .+�5L      �� -   5        $ buttonRemoveSearchText��5M      $��60��5N      
������ $��0q�5P      $y�Hidden=�5R      .��5T        $��30��5U      $��30��5V      $ Close=�5W      
�������$��Center=�5Y      $��Center=�5Z      5\      �� 5]      -   5        	 ��Name$	 textboxSeatch��5]      $��Center=�61   $	��200��6N   
 �� 
CaretBrush

 � ��� w� Text$ Search here��5_      .��5a      5c        5d      $��30��5e      $��30��5f      $ Search=�5g      
��� ���$��Center=�5i      $��Center=�5j      5l      #  MaterialDesignThemes.Wpf.Card  5m      $��5q�6"   .��5n      �� -   5         ��Name$ textblockItemName��5o      $��Center=�5p      $��Center=�5q      $��Arabic Typesetting)�5r      $��30(�5s      5v      5w      5{      &   System.Windows.Controls.DataGrid  5|   
   -	   5          Name$ mainDatagrid��5�      $��1��5}      $��	5,10,5,10q�5~      $
��auto��5      $
��auto��5�      $
��True��5�      $
��Auto=�5�         ColumnHeaderStyle# �   5�         CanUserAddRows$ False��5�         CanUserDeleteRows$ False��5�         CanUserReorderColumns$ False��5�      $|�False��5�         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5�         	RowHeight$ 50Q�5�      $��Arabic Typesetting)�5�   @   $��30(�6`      	CellStyle 5�      �� 5�      "  6   .�5�      ��  �@��TextAlignment$ Center=�6@   �� 5�       � �� 5�      �� 5�       �� 
TargetType"  6.   .R�5�   "   � #��z��6'   .+�5�   &   �� $��Center=�67   5�   #   5�      5�      5�      5�      5�      5�      