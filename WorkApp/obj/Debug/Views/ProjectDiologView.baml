   M S B A M L   `   `   `  ����B  >WorkApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WorkApp.ViewsWorkApp.Views  5   	   %    WorkApp.Views.ProjectDiologView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WorkApp.Views     5   	     � Title$  ProjectDiologView��5   	   $	��320��6#   $	��400��60    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��2��6   $��Center=�61   .��6N   	General6W   �� 5   
   $��1��6   $��0��6   $��0,0,0,0q�6-   .��6?   Project Name:6N   �� 5   
   $�� ��6   $��1��5      $��1��6!   $��Center=�61   �� 5    
   $��2��6   $��0��6   $��0,0,0,0q�6-   .��6>   Project Type:6M   �� 5!   
   $��2��5"      $��1��6!   $��Center=�61   ��5!      �� *ListOfProjectTypes+5"   1   �� 5#   
   $��3��6   $��0��6   $��0,0,0,0q�6-   .��6>   Development Type:6Q   �� 5$   
   $��3��5%      $��1��6!   $��Center=�61   ��5$      �� *ListOfDevelopmentTypes+5%   1   �� 5&   
   $��4��6   $��0��6   $��0,0,0,0q�6-   .��6>   Project Status:6O   �� 5'   
   $��4��5(      $��1��6!   $��Center=�61   ��5'      �� *ListOfProjectStatuses+5(   1   �� 5)   
   $��5��6   $��0��6   $��0,0,0,0q�6-   .��6>   	Zoning:6G   �� 5*   
   $��5��5+      $��1��6!   $��Center=�61   ��5*      �� *ListOfZonings+5+   1   �� 5,   
   $��6��6   $��0��6   $��0,0,0,0q�6-   .��6>   Date Created:6M   (  "System.Windows.Controls.DatePicker  5-   
   $��6��5.      $��1��6!   $��Center=�61   �� 50   
    �� Orientation$ 
Horizontal=�6   $��7��6.   $��2��6;   $��Right=�6O   .+�51      �� -   5         ��Name$ OnSave��51   !   $��10q�6   .��61   Create Project6A   �� 52      -   5        $ OnExit��52   !   $��10q�6   .��61   Exit Withot Saving6E   53      55      56      