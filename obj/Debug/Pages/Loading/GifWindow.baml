   M S B A M L   `   `   `  ����C  ?Tool Kit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:WPFUIKitProfessional.Pages.Loading"WPFUIKitProfessional.Pages.Loading  5   	   2    ,WPFUIKitProfessional.Pages.Loading.GifWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:WPFUIKitProfessional.Pages.Loading     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5	   	    � WindowState$ Normal=�5   	    � Title$ 
loading...��5   	   $	��200��5   	   $	��450��5   	    � 
ResizeMode$ NoResize=�5   	   ���	#FFD3F9D8 � Icon$# /Assets/Icons/IconToolKit.ico��5        � 	Resources 5         ProgressBarAnimation �� TargetProperty �� 
TargetName	 W� From	
 W� To g� Duration��%�   &	        �� 5   
   $ Value�62   $ MyProgressBar��6I   .��5      W� $	 0X�6   $	
 100X�6'   $ 0:0:8D�60   5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ Window.Loaded��6   .[�5      �� #��[  6   5      .��5      � .+�5   
   �� $#��/Assets/Icons/IconToolKit.ico��6   $��Center=�67   $��Center=�6R   $��59��6o   $��0,0,0,60q�6z   6�   �� 5   
   $��
Loading...��6   $��18(�6%   $��
Montserrat)�63   $��Center=�6K   $��Center=�6h   $��0,20,0,0q�6�   � 5   
   -   5         �Name$ MyProgressBar��5      $��Center=�6-   $��Center=�6J   $	��400��6e   $��10��6q   ���	#FF2B8A3E$��0,80,0,0q�6�   5      5       