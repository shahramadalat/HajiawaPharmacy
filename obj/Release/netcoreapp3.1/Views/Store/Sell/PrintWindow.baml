   M S B A M L   `   `   `  ���� J  FPharmacyHajiawa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:PharmacyHajiawa.Views.Store.Sell PharmacyHajiawa.Views.Store.Sell  2    ,PharmacyHajiawa.Views.Store.Sell.PrintWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @local.clr-namespace:PharmacyHajiawa.Views.Store.Sell     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     � WindowStyle$
  None=� � Title$ پرنت�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�$	��850�� � SizeToContent$ WidthAndHeight=� � 	Resources *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Property �� Value   CenterGridHeaderStyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�   '        &	  r     �� "  ���  �@��TextAlignment$ Center=���  � ��$ Center=���  �@ 	IsEditing$
 True���� "  .���  � ��$ Center=���  � ��$ Center=�.���� $
��Auto=�.��� -   	 �Name$	 	gridPrint��.+��� 
�������$��3q�� 
 � RowDefinitions
 �� $��30 ��� $
��auto ��� $
��auto ��� $��30 ��� $��50 �.+�� $��0�� � ColumnDefinitions �� �� �� .+��� $��1��$��Center=�$��Center=�
�������$��14(�$��Tempus Sans ITC)�.��Shahr Pharmacy�� -    ��Name$ btnPrint��$��2��$��60��$��30��$��Right=�
������ $��0q�.��'  !MaterialDesignThemes.Wpf.PackIcon  $��26��$��26��   Kind$ PrinterCheck=����#27AEE9$��Center=�$��Center=��� $��0�� �� Orientation$ 
Horizontal=�.+��� -   $��0��$��40��$��30��$
��Left=�$��Center=�
������ $��0q�.��  $��20��$��20��$ Circle=����#27AEE9$��Center=�$��Center=��� -   $��20��$��30��$
��Left=�$��Center=�
������ $��0q�.��  $��20��$��20��$ Circle=�
��� E��$��Center=�$��Center=�� $��1�� �� �� .+��� $	��Top=�$��2���� $��0��$��Center=�$��Center=�$��Arabic Typesetting)�$��24(��� .��� -    ��Name$ lblInvoiceNumber�� �� .��� .��:ژ.پسوڵە�� $��1��$��Center=�$��Center=��� .�(  "System.Windows.Controls.DatePicker  -     Name$ 
datePicker��${�False��$	��100�� �� .�)  #MaterialDesignThemes.Wpf.TimePicker  -     Name$ 
timePicker��${�False��&   System.Windows.Controls.DataGrid  -	     Name$ mainDatagrid��$��2��$	��550��${�False��$��	5,10,5,10q�   ColumnHeaderStyle# �      CanUserAddRows$ False��   CanUserDeleteRows$ False��   CanUserReorderColumns$ False��$|�False��   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ *    	RowHeight$ 35Q�$��Arabic Typesetting)�$��30(�   SelectionMode$ Single=� � DataContext �� *buyVs+   	CellStyle �� "  .���  �@��TextAlignment$ Center=���  � �� ��  �� 
TargetType"  .R�� #��z��.+��� $��Center=��� $��3��$ 
Horizontal=�$��Center=�$��Center=�.+��� $��0��$��Center=�$��Center=�$��Arabic Typesetting)�$��20(��� .��� -
   $ inTotal�� �� .��� .��:کۆی گشتی�� $��0��$��Center=�$��Center=�$��Arabic Typesetting)�$��20(��� .��� -   $ 
inDiscount�� �� .��� .��:بڕی خاتر� $��4��.+��� .+��� $	��Top=��� $��Center=�$��Center=�$��Arabic Typesetting)�$��20(��� .��� $��Arial)�$��10(�.��%#Designed and developed by Shahr-Dev�� $��Center=�$��Center=�$��Arial)�$��10(��� .��� .��&$Shahr-Dev's phone no.: 0751 126 2122