   M S B A M L   `   `   `  ����B  >WorkApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WorkApp.ViewsWorkApp.Views  5   	       WorkApp.Views.ShellView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WorkApp.Views     5   	   ^ ZCaliburn.Micro.Platform, Version=3.2.0.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21f(calhttp://www.caliburnproject.org  5   	     � Title$  	ShellView��5	   	   $	��600��6   $
��1100��6(    � WindowStartupLocation$ CenterScreen=�5
   	    � 	Resources 5         MainBorderStyle �� 
TargetType �� Property �� Value��%  &	        �� 5   
   " ��6(   .�5      ��  � ��
 �����6+   �� 5       � ��
 �����6,   �� 5       � ��$ 1q�60   �� 5       �@��CornerRadius$ 5��6-   �� 5       �@J�SnapsToDevicePixels . 64   5      5      .��5      ]� .+�5   
   ]� $	��Top=�6   -  'System.Windows.Input.KeyboardNavigation   TabNavigation$
 None=�6)   .+�5      o� $ Cycle=�6   .@�5      m� $��_File��6   .@�5      m� $��E_xit��6    m� Command 6.   ��  �� Path$ CloseCommand�5      m� 5      $��_Edit��6   m� 5       $��_Options��6   m� 5!      $��_Help��6   5"      5#      � 5%   
   $��4q�6   	 � ColumnDefinitions	 5'      �� 5(      $
��Auto �6#   �� 5)      $��4 �6#   �� 5*      $��* �6#   
 � RowDefinitions
 5-      �� 5.      $
��Auto �6    �� 5/      $��* �6    .+�54      ��  �� Orientation$ Vertical=�6   $��0��60   $��2��6@   $	��170��6Q   .+�55      �� -   5         ��Name$ ShowProjectListView��55      $��Projects��56      $��5,10,5,5q�6/   �� 57      $��Reviews��6   $��5,5,5,5q�6/   �� 58      $��Inspections��6   $��5,5,5,5q�6/   �� 59      $
��Tags��6   $��5,5,5,5q�6/   5:      �� 5>      -   5        $ ShowProjectDiologView��5A      $��10,10q�5>      $��80��6$   $��2��5?      $��0��6%   $
��Left=�5@      .��5A   4   Create Project6D   �� 5C      -   5         ��Name$ Items��5C   6   $��2��6   $��1��6)   ��5D      �� 5E      .R�5F      �� $ 
Horizontal=�6%   .+�5G      �� ��6(   �� $ DisplayName��� 5H      $��X��6%     Caliburn.Micro.Message   Attach$ CloseTab($dataContext)��5I   !    � Cursor$
 Hand��5J   !   |�.  $��Courier)�5L   !   $��9(�5M   !   $
��Bold"�5N   !   $��5,0,0,0q�5O   !   $��0,0,0,1q�5P   !   $��Bottom=�5Q   !   $��16��5R   !   $��16��6,   5T      5U      5X      5Z      5[      5\      