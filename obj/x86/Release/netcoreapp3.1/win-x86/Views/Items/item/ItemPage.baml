   M S B A M L   `   `   `  ���� J  FPharmacyHajiawa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:PharmacyHajiawa.Views.Items.item PharmacyHajiawa.Views.Items.item  /    )PharmacyHajiawa.Views.Items.item.ItemPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     @local.clr-namespace:PharmacyHajiawa.Views.Items.item     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     N� Title$  جۆری کاڵاکان�� � 	Resources *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Property �� Value   CenterGridHeaderStyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�   '        &	  P     �� "  ���  �@��TextAlignment$ Center=���  � ��$ Center=��� "  .���  � ��$ Center=���  � ��$ Center=�.���  � RowDefinitions �� $	��200 ��� $��* �.+��� $��	10,5,10,5q�.+��� -    ��Name$ btnBack��$y�Visible=�$��50��
������ $��0q�$
��Left=�.��'  !MaterialDesignThemes.Wpf.PackIcon  $��30��$��30��   Kind$ ArrowLeftBold=����#27AEE9$��Center=�$��Center=���  �� Orientation$ 
Horizontal=�$��Center=�.+��� -   $	��150��$��35��$
��10,0q�$��Arabic Typesetting)�$��28(�.��ڕەشکراوەکان�� -   $	��150��$��35��$
��10,0q�$��Arabic Typesetting)�$��28(�.��بەردەست�� $��	10,5,10,5q����#27AEE9�� $��Center=�$��Center=�.+��� -   $��50��
������ $��0q�.��  $��30��$��30��$	 Add=����#27AEE9$��Center=�$��Center=��� $ 
Horizontal=�$��Center=�.+��� -   $ buttonRemoveSearchText��$��60��
������ $��0q�$y�Hidden=�.��  $��30��$��30��$ Close=�
�������$��Center=�$��Center=��� -   	 ��Name$	 textboxSeatch��$��Center=�$	��200��
 �� 
CaretBrush

 � ��� w� Text$ Search here��.��  $��30��$��30��$ Search=�
��� ���$��Center=�$��Center=�#  MaterialDesignThemes.Wpf.Card  $��5q�.���� -    ��Name$ textblockItemName��$��Center=�$��Center=�$��Arabic Typesetting)�$��30(�&   System.Windows.Controls.DataGrid  -	     Name$ mainDatagrid��$��1��$��	5,10,5,10q�$
��auto��$
��auto��$
��True��$
��Auto=�   ColumnHeaderStyle# �      CanUserAddRows$ False��   CanUserDeleteRows$ False��   CanUserReorderColumns$ False��$|�False��   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ *    	RowHeight$ 50Q�$��Arabic Typesetting)�$��30(�   	CellStyle �� "  .���  �@��TextAlignment$ Center=���  � �� ��  �� 
TargetType"  .R�� #��z��.+��� $��Center=�