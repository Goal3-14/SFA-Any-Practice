   M S B A M L   `   `   `  ����I  EK5E Memory Map, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:K5E_Memory_MapK5E_Memory_Map  5   	   A%clr-namespace:K5E_Memory_Map.UIModuleK5E_Memory_Map.UIModule  64       K5E_Memory_Map.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:K5E_Memory_Map     5   	   >userControls%clr-namespace:K5E_Memory_Map.UIModule     64   -   5        $��MMainWindow��5   	     � Title$  Any% Practice��5   	   $	��440��6   $	��468��6,    � WindowState$ Normal=�5	   	    � SizeToContent$ Manual=�5
   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $	��150 �6   �� 5      -   5         �Name$ 
DisplayCol��5   +   $	��150 �6   6+   �� 5      -   5        $ GraphCol��5   *   $��1* �6   6*   .+�5   
   � $��1��6   $��1��6    � RowDefinitions 5      �� 5      $	��290 �6    �� 5      $��1* �6    .+�5      �� 
���   �$	��0.5q�6*    �� Padding$ 0q�6@   �� 5      $��1��6   
���   �$	��0.5q�6;   $ 0q�6Q   (   "K5E_Memory_Map.UIModule.TagButtons  5       -   5          Name$ TTagButtons��5    &   $y�	Collapsed=�6<   � 5#      $��1��6   .+�5$      -   'K5E_Memory_Map.UIModule.SelectedDetails  -   5          Name$ SSelectedDetails��5$   /   $��1��6J   �� 5%      $��1��6   
���   �$	��0.1q�6?   $ 0q�6U   �� 5&      $��1��6   
���   �$��1q�6<   $ 0q�6P   5'      &    K5E_Memory_Map.UIModule.SaveMenu  5(      -   5        	  Name$	 	SSaveMenu��5(   $   $y�Visible=�67   $��1��6L   �� 5)      -   5        $��
GraphCheck��5)      $��Graph��6)   
 d� 	IsChecked$
 FalseY�69   $��15(�6K    K� ZIndex$ 1��6�   $��1��6�   $��0,80,0,0q�6�   5*      � 5-   
   $��0��6   $��2��6    5.      �� 5/      $	��300 �6    �� 50      $��1* �6    .+�52      &    K5E_Memory_Map.UIModule.MainMenu  -   5          Name$ 	MMainMenu��52   $   $��1��67   )   #K5E_Memory_Map.UIModule.DisplayMenu  53      -	   5          Name$ DDisplayMenu��53   '   $��1��6>   $y�Visible=�6N   �� 54      
���   �$	��0.5q�6*   $ 0q�6@   �� 55      $��2��6   
���   �$	��0.5q�6;   $ 0q�6Q   57      � 5:   
   $��0��6   $��3��6   .+�5;      �� 
���   �$	��0.5q�6*   $ 0q�6@   (   "K5E_Memory_Map.UIModule.SmallGraph  5<      -
   5          Name$ SSmallGraph��5<   &   $y�Hidden=�6<   '   !K5E_Memory_Map.UIModule.FullGraph  5=      -   5          Name$ 
FFullGraph��5=   %   $y�Hidden=�6:   &    K5E_Memory_Map.UIModule.Analysis  5?      -   5          Name$ 	AAnalysis��5?   $   $y�Hidden=�67   &	    K5E_Memory_Map.UIModule.Practice	  5@      -   5         	 Name$ 	PPractice��5@   $   $y�Hidden=�67   #
   K5E_Memory_Map.UIModule.Merge
  5A      -   5         
 Name$ MMerge��5A   !   $y�Hidden=�61   5C      � 5F   
   $��1��6   $��0��6    5G      �� 5H      $	��152 �6    �� 5I      $	��140 �6    �� 5J      $��1* �6    .+�5L      )   #K5E_Memory_Map.UIModule.NodeDetails  -   5          Name$ NNodeDetails��5L   '   $��1��6=   -   'K5E_Memory_Map.UIModule.ProcessingState  5M      -   5          Name$ ProcessingState��5M   +   $��0��6D   (   "K5E_Memory_Map.UIModule.MemDisplay  5N      -   5          Name$ MMemDisplay��5N   &   $��2��6;   �� 5O      
���   �$	��0.5q�6*   $ 0q�6@   �� 5P      $��1��6   
���   �$	��0.5q�68   $ 0q�6N   �� 5Q      -   5        $��TB_Hash��5Q      $��1��6(    �� Padding$ 3,72,0,0q�6g   $y�	Collapsed=�6z   ��65   �� *Hash+ �� StringFormat$ 	Heap: {0}��6z   �� 5R      -   5        $��TB_Frame��5R      $��1��6)   $ 3,99,0,0q�6j   $y�	Collapsed=�6}   ��66   �� *Frame+$ 
Frame: {0}��6}   �� 5S      $��2��6   
���   �$	��0.5q�68   $ 0q�6N   �� 5U      -   5        $��PauseButton��5U   -   $y�	Collapsed=�6   $��40��6A   $��Bottom=�6M   $��Right=�6h   $��40��6�   $��0,0,0,0q�6�   $��2��6�   $ 1��6�   .��5V      � .+�5W      �� $��Right=�6    $��8��6<   $��20��6G   $��	-13,0,0,0q�6S   $��2��6f   $ 2��6s   
�������6�   �� 5X      $��Right=�6    $��8��6<   $��20��6G   $��0,0,13,0q�6S   $��2��6e   $ 2��6r   
�������6�   5Y      5Z      �� 5\      -   5        $��
PlayButton��5\   ,   $y�	Collapsed=�6   $��40��6?   $��Bottom=�6K   $��Right=�6f   $��40��6�   $��0,0,0,0q�6�   $��2��6�   $ 1��6�   .��5]      � .+�5_      F� "���� � ��� � ?� -1� � ���	
���   �$��	-8,-8,0,0q�6F   $��Center=�6Z   $��Center=�6w   5`      5a      5c      5e      5f      