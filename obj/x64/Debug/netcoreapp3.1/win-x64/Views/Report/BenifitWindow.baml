   M S B A M L   `   `   `  ����J  FPharmacyHajiawa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:PharmacyHajiawa.Views.ReportPharmacyHajiawa.Views.Report  5   	   0    *PharmacyHajiawa.Views.Report.BenifitWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:PharmacyHajiawa.Views.Report     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6B   -   5          � Title$  قازانج��5   	   $	��550��5	   	   $	��850��5
   	    � WindowStyle$
 None=�6,    � 
ResizeMode$ NoResize=�6?    � WindowStartupLocation$ CenterScreen=�6U    � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � ��$ Arabic Typesetting)�6+   �� 5       � ��$ 30(�6)   5      5      .��5      �� 
�������$��5q�6     �� CornerRadius$ 3��64   ._�5      �� $
��Auto=�6   $
��Auto=�68   .��5   
   �� -   5        	 ��Name$	 
stackPrint��5      
 �� Orientation$
 Vertical=�6)   $��Center=�6@   $��Center=�6]   $	��450��6x   .+�5      �� $
 
Horizontal=�6   $��Center=�62   .+�5      �� -   5        $��2��5      $��60��5      $��30��5      $��Right=�5      
������ $��0q�5      .��5      '  !MaterialDesignThemes.Wpf.PackIcon  $��26��5       $��26��5!         Kind$ PrinterCheck=�5"      ���#27AEE9$��Center=�5$      $��Center=�5%      5'      5(      �� 5+      $
 
Horizontal=�6   $��Center=�62   $��Center=�6O   .+�5,      (  "System.Windows.Controls.DatePicker  -   5          Name$ datePickerSecond��5,      $	��110��67   �� 5-      $
��بۆ��6   $��	10,0,20,0q�6&     5.      -   5        $ datePickerFirst��5.      $	��110��66   �� 5/      $
��لە��6   $��10,0,0,0q�6&   50      �� 53      -   5        $��2��54      $��60��55      $��30��56      $��Center=�57      
������ $��0q�59      .��5<        $��26��5=      $��26��5>      $ ArrowDownBold=�5?      ���#27AEE9$��Center=�5A      $��Center=�5B      5D      �� 5E      $	��Top=�6   $��2��61   6G   � 5G       � RowDefinitions 5H      �� 5I      $
��auto �6$   �� 5J      $
��auto �6%   �� 5K      $
��auto �6$   �� 5L      $
��auto �6$   �� 5M      $
��auto �6$    � ColumnDefinitions 5O      �� 5P      $	��250 �6'   �� 5Q      $	��200 �6'   .+�5T      �� $��:کۆی بڕی تێجوو��6   $��1��62   $��0��6B   �� 5U      -   5         ��Name$ lblCost��5U   )   $��00000��6   $��Center=�6;   $��Center=�6X   �� 5X      $%��:کۆی کاڵای کڕدراو��6   $��1��65   $��1��6E   �� 5Y      -   5        $ lblBuy��5Y   )   $��00000��6   $��1��69   $��Center=�6G   $��Center=�6d   �� 5\      $'��!:کۆی کاڵای فرۆشراو��6   $��1��66   $��2��6F   �� 5]      -	   5        $ lblSold��5]   )   $��00000��6   $��2��6:   $��Center=�6H   $��Center=�6e   �� 5`      $��:قازانج��6   $��1��6+   $��3��6;   �� 5a      -
   5        $ lblSoldBenifit��5a   )   $��00000��6   $��3��6A   $��Center=�6O   $��Center=�6l   5f      �� 5h      -   5        $��2��5i      $��60��5j      $��30��5k      $��Center=�5l      
������ $��0q�5n      .��5q        $��26��5r      $��26��5s      $ ArrowDownBold=�5t      ���#27AEE9$��Center=�5v      $��Center=�5w      5y      5{      5|      5}      5~      