   M S B A M L   `   `   `  ���� J  FPharmacyHajiawa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:PharmacyHajiawa.Views.Store.BuyPharmacyHajiawa.Views.Store.Buy  1    +PharmacyHajiawa.Views.Store.Buy.BuyMainPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ?local-clr-namespace:PharmacyHajiawa.Views.Store.Buy     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     N� Title$  کڕین�� � 	Resources *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Property �� Value   CenterGridHeaderStyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�   '        &	  P     �� "  ���  �@��TextAlignment$ Center=���  � ��$ Center=��� "  .���  � ��$ Center=���  � ��$ Center=�.���  � RowDefinitions �� $��90 ��� $��50 ��� $��* ��� $��40 �.+��� $��0��.+�� $��Center=�$��Center=� �� $
��auto ��� $
��auto �.+��� $��0��$��Center=�$��Center=�.����  �� Orientation$ 
Horizontal=�.+��� -    ��Name$ inBuyInvoiceId��$��18(�$
��Bold"�.��1�� $��Arabic Typesetting)�$��22(�.��!:کۆدی پسوڵەی کڕین�� $��1��$ 
Horizontal=�$��Center=�.+�#  MaterialDesignThemes.Wpf.Card  $��1��$
��10,0q�
�������+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth2=�$
��10,0q�.���� $��Center=�$��Center=�$ 
Horizontal=�.+��� -   $��50��
������ $��0q�.���� '  !MaterialDesignThemes.Wpf.PackIcon  $��30��$��30��	   Kind$	 ClipboardListOutline=����#27AEE9$��Center=�$��Center=��� -   $ 	inCompany��$��Arabic Typesetting)�$��24(��� $��Arabic Typesetting)�$��24(�.��:کۆمپانیا  $��1��$
��10,0q�
�������$ Depth2=�.���� $��Center=�$��Center=�$ 
Horizontal=�.+�(  "System.Windows.Controls.DatePicker  -   
  Name$
 	inBuyDate��$��Center=�$��Center=��� $��Arabic Typesetting)�$��24(�.��:بەرواری کڕین�� $��	10,5,10,5q�$��1��.+��� $��Center=�$��Center=�.+��� -   $��50��
������ $��0q�.����   $��30��$��30��$		 Add=����#27AEE9$��Center=�$��Center=�&   System.Windows.Controls.DataGrid  -     Name$ mainDatagrid��$��2��$��	0,10,0,10q�$
��auto��$
��auto��$
��True��$
��Auto=�   ColumnHeaderStyle# �      CanUserAddRows$ False��   CanUserDeleteRows$ False��   CanUserReorderColumns$ False��$|�False��   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ *    	RowHeight$ 50Q�$��Arabic Typesetting)�$��30(�   	CellStyle �� "  .���  �@��TextAlignment$ Center=���  � �� ��  �� 
TargetType"  .R�� #��z��.+��� $��Center=��� -   ���#0078D7
�������$��3��$��Center=�$��Bottom=�$	��100��$��36��$��0,0,0,2q�$��Arabic Typesetting)�$��28(�.��
کڕین