   M S B A M L   `   `   `  ���� J  FPharmacyHajiawa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:PharmacyHajiawa.Views.Store.Sell PharmacyHajiawa.Views.Store.Sell  3    -PharmacyHajiawa.Views.Store.Sell.MainSellPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     @local.clr-namespace:PharmacyHajiawa.Views.Store.Sell     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     N� Title$  فرۆشتن�� � 	Resources *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Property �� Value   CenterGridHeaderStyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�   '        &	  P     �� "  ���  �@��TextAlignment$ Center=���  � ��$ Center=��� "  .���  � ��$ Center=���  � ��$ Center=�.���  � RowDefinitions �� $
��auto ��� $
��auto ��� $��* ��� $
��auto �.+�#  MaterialDesignThemes.Wpf.Card  $��	10,2,10,2q�$��0��
�������+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth2=�$��3q�.���  �� $
��auto ��� $
��auto �.+��� $��0�� �� Orientation$ 
Horizontal=�$��Center=�$��Center=�.+�  $
��10,0q�$
��10,0q�
�������$ Depth2=�.���� $��Center=�$��Center=�$ 
Horizontal=�.+�(  "System.Windows.Controls.DatePicker  -     Name$ 
inSellDate��$��Center=�$��Center=��� $��Arabic Typesetting)�$��24(�.��:بەرواری فرۆشتن�� -   	 ��Name$	 inSellInvoiceId��$��18(�$
��Bold"�.��0�� $��Arabic Typesetting)�$��22(�.��%#:کۆدی پسوڵەی فرۆشتن  $��	10,2,10,0q�$��1��
�������$ Depth2=�$��3q�$��43��$	��Top=�.���� $��Center=�$��Center=�$ 
Horizontal=�.+��� -   $��50��
������ $��0q�.���� '  !MaterialDesignThemes.Wpf.PackIcon  $��30��$��30��
   Kind$	
 Add=����#27AEE9$��Center=�$��Center=��� -    ��Name$ 	inBarcode��$
��10,0q�$	��180���� $��Arabic Typesetting)�$��24(�.��:بارکۆد ڕیدەر&   System.Windows.Controls.DataGrid  -     Name$ mainDatagrid��$��2��$��	0,10,0,10q�$
��auto��$
��auto��$
��True��$
��Auto=�   ColumnHeaderStyle# �      CanUserAddRows$ False��   CanUserDeleteRows$ False��   CanUserReorderColumns$ False��$|�False��   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ *    	RowHeight$ 50Q�$��Arabic Typesetting)�$��30(�   Columns 4	  .System.Windows.Controls.DataGridTemplateColumn	  ,
  &System.Windows.Controls.DataGridColumn 
  Header$ +�� 	  CellTemplate �� .R��� -   $��60��$��Center=�
������ $��0q�.��  $��30��$��30��$
 AddCircleOutline=����#27AEE9$��Center=�$��Center=�	  $ -�� �� .R��� -   $��60��$��Center=�
������ $��0q�.��  $��30��$��30��$
 MinusCircleOutline=����#27AEE9$��Center=�$��Center=�   	CellStyle �� "  .���  �@��TextAlignment$ Center=���  � �� ��  �� 
TargetType"  .R�� #��z��.+��� $��Center=��� $��3��$��Center=�$��Center=�$ 
Horizontal=�$��0,0,0,12q�.+��� -	   ���#0078D7
�������$��3��$	��100��$��36��$	��5,0q�$��Arabic Typesetting)�$��30(�.��فرۆشتن�� -
   $ inTotal��${�False��$
��Bold"�$��4,0,0,0q�$	��200��$��22(� �� TextAlignment$ Center=��� $��Arabic Typesetting)�$��24(�.��:کۆی گشتی�� -   $ 
inDiscount��$��4,0,0,0q�$	��150��$��17(�$ Center=�$��0���� $��Arabic Typesetting)�$��24(�.��	:خاتر