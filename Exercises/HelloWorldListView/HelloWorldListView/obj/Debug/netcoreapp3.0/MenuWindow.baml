   M S B A M L   `   `   `  ����M  IHelloWorldListView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:HelloWorldListViewHelloWorldListView  5   	   #    HelloWorldListView.MenuWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:HelloWorldListView     5   	     � Title$  
MenuWindow��5   	   $	��450��6   $	��800��6)    J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$	 New��5
      6E    � ContextMenu 5      �� 5   
   .@�5      m� $��Menu item 1��6   m� 5      $��Menu item 2��6   �� 5      m� 5      $��Menu item 3��6   5      .��5      �� .+�5   
   o� .@�5      m� $��_File��6   .@�5      m� -   5        $
��_New��5       m� Icon 5      �� 5      $��\images\wpf-menus-new.png��6    $��24��5      $��24��6(   5      m� 5      $��_Open��6   �� 5      m� 5       -   5        $��E_xit��5       6*   5!      m� 5"      $��_Edit��6   m� 5#      $��_Help��6   5$      `� 5%   
   .�5&      c� .@�5'      �� -   5        $	��New��5'      $	��New��6'   65   �� 5(      $
��Copy��6   �� 5)      $��Paste��6   5*      c� 5+      .@�5,      �� .��6   
Font size:6$   �� 5-      .@�5.      �� .��6#   106'   �� 5/       �� 
IsSelected$
 True��6#   .��65   1269   �� 50      .��6#   146'   �� 51      .��6#   166'   52      53      c� 54      .@�55      �� -   5        $��Close��55      6)   56      57      �� 59   
   $��Click Me��6    5:      �� 5;      .@�5<      m� $��Menu item 1��6   m� 5=      $��Menu item 2��6   �� 5>      m� 5?      $��Menu item 3��6   5@      5B      5C      5D      