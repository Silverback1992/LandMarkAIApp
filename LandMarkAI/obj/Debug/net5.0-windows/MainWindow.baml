   M S B A M L   `   `   `  ����E  ALandMarkAI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LandMarkAI
LandMarkAI  5   	       LandMarkAI.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LandMarkAI     5   	     � Title$  Custom Vision AI��5   	   $	��450��6"   $	��800��6/    � 
ResizeMode$ CanMinimize=�5	   	   .��5
      � $��10q�6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��7* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��5* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ fileBrowserButton��5      $��Center=�5      $��Right=�5      $��5q�5      $��0q�5      
������ 
������ .��5      �� $ ��Images/FileBrowserIcon.jpg��6   5       �� 5"   
   -   5         ��Name$ selectedImagePathTextBox��5"      $��5q�5#      ${�False��5$      $��Center=�5%      $��1��5&      $��2��5'      �� 5)   
   -   5        $ processImageButton��5)      $��3��5+      $��2��5,      $��5q�5-      $��Process Image��5.      $��18(�5/      $��DemiBold"�50      �� 52   
   -   5         ��Name$ selectedImage��52      $��1��53      $��1��54      $��5q�55      �� 57   
   -   5         ��Name$ predictionsListView��57      $��1��58      $��2��59      $��3��5:      $	��Top=�5;       �� View 5<      �� 5=      .P�5>      �� $	��Tag��6%   	 �� Width$		 125��5@   %   
 �� DisplayMemberBinding
 5?   %   �� *	TagName+5@   %   �� 5A      $��Probability��6%   $		 125��5C   %   
 5B   %   �� *Probability+ �� StringFormat$ P2��5C   %   5D      5F      5G      5H      