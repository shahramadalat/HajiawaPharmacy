   M S B A M L   `   `   `  ���� J  FPharmacyHajiawa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PharmacyHajiawaPharmacyHajiawa       PharmacyHajiawa.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:PharmacyHajiawa     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     � Title$  
MainWindow��$	��450��$	��800�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=�$	��800��$	��500��.��� 
������� � ColumnDefinitions �� $	��200 ��� $��* �.+��� $��0�����#0078D7.���� .+��� .+��� $#��/Hi-Res-icon-noBackground.png��$
��auto��$
��auto���� -    ��Name$ 
buttonItem��$��0q�
������ 
������ $��Normal$�$��Medium"�$��40��.��� $	��120��.+��� $��کاڵاکان��$��Arabic Typesetting)�$��28(��� $��Right=�$��Center=�'  !MaterialDesignThemes.Wpf.PackIcon  $��30��$��30��   Kind$ Devices=��� -   $ 	buttonBuy��$��0q�
������ 
������ $��Normal$�$��Medium"�$��40��.��� $	��120��.+��� $��کۆمپانیاکان��$��Arabic Typesetting)�$��28(��� $��Right=�$��Center=�  $��30��$��30��$ Company=��� -   $ buttonBuyInvoice��$��0q�
������ 
������ $��Normal$�$��Medium"�$��40��.��� $	��120��.+��� $��کڕین��$��Arabic Typesetting)�$��28(��� $��Right=�$��Center=�  $��30��$��30��$ ShoppingCartAdd=��� -   $ buttonOrder��$��0q�
������ 
������ $��Normal$�$��Medium"�$��40��.��� $	��120��.+��� $��کۆگا��$��Arabic Typesetting)�$��28(��� $��Right=�$��Center=�  $��30��$��30��$ ShopOutline=��� -   $ 
buttonSell��$��0q�
������ 
������ $��Normal$�$��Medium"�$��40��.��� $	��120��.+��� $��فرۆشتن��$��Arabic Typesetting)�$��28(��� $��Right=�$��Center=�  $��30��$��30��$ AccountCash=��� -   $ buttonCosts��$��0q�
������ 
������ $��Normal$�$��Medium"�$��40��.��� $	��120��.+��� $��تێچوەکان��$��Arabic Typesetting)�$��28(��� $��Right=�$��Center=�  $��30��$��30��$  ClipboardArrowRightOutline=��� -   $ buttonReport��$��0q�
������ 
������ $��Normal$�$��Medium"�$��40��.��� $	��120��.+��� $��ڕاپۆرت��$��Arabic Typesetting)�$��28(��� $��Right=�$��Center=�  $��30��$��30��$ AchievementOutline=��� -	   $ 	buttonReg��$��0q�
������ 
������ $��Normal$�$��Medium"�$��40��.��� $	��120��.+��� $��چالاک کردن��$��Arabic Typesetting)�$��28(��� $��Right=�$��Center=�  $��30��$��30��$ 	LockCheck=��� -
   $ buttonBackup��$��0q�
������ 
������ $��Normal$�$��Medium"�$��40��.��� $	��120��.+��� $��پاراستن��$��Arabic Typesetting)�$��28(��� $��Right=�$��Center=�  $��30��$��30��$ 	LockCheck=�� $��1�� � RowDefinitions �� $��50 ��� $��* �.+�� -   $��0�����#0078D7$	��Top=�.+���  �� Orientation$ 
Horizontal=�$��Right=�.+��� -   
������ 
������ $��Center=�
�������.���� $��Right=�$��Center=�  $��30��$��30��$ WindowMinimize=��� -   
������ 
������ $��Center=�
�������.���� $��Right=�$��Center=�  $��30��$��30��$ WindowMaximize=��� -   
������ 
������ $��Center=�
�������.���� $��Right=�$��Center=�  $��30��$��30��$ Close=�� -    �Name$ 	gridPages��$��1��.+� � -   	  �Name$	 
framePages��
  � NavigationUIVisibility$
 Hidden=�