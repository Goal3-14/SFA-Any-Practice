   M S B A M L   `   `   `  ���� I  EK5E Memory Map, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:K5E_Memory_MapK5E_Memory_Map  A%clr-namespace:K5E_Memory_Map.UIModuleK5E_Memory_Map.UIModule      K5E_Memory_Map.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:K5E_Memory_Map     >userControls%clr-namespace:K5E_Memory_Map.UIModule     -   $��MMainWindow��  � Title$  Any% Practice��$	��440��$	��468�� � WindowState$ Normal=� � SizeToContent$ Manual=�.���  � ColumnDefinitions �� $	��300 ��� $	��150 ��� -    �Name$ 
DisplayCol��$	��150 ��� -   $ GraphCol��$��1* �.+�� $��1��$��1�� � RowDefinitions �� $	��290 ��� $��1* �.+��� 
���   �$	��0.5q� �� Padding$ 0q��� $��1��
���   �$	��0.5q�$ 0q�(   "K5E_Memory_Map.UIModule.TagButtons  -     Name$ TTagButtons��$y�	Collapsed=�� $��1��.+�-   'K5E_Memory_Map.UIModule.SelectedDetails  -     Name$ SSelectedDetails��$��1���� $��1��
���   �$	��0.1q�$ 0q��� $��1��
���   �$��1q�$ 0q�&    K5E_Memory_Map.UIModule.SaveMenu  -   	  Name$	 	SSaveMenu��$y�Visible=�$��1���� -   $��
GraphCheck��$��Graph��
 d� 	IsChecked$
 FalseY�$��15(� K� ZIndex$ 1��$��1��$��0,80,0,0q�� $��0��$��2�� �� $	��300 ��� $��1* �.+�&    K5E_Memory_Map.UIModule.MainMenu  -     Name$ 	MMainMenu��$��1��)   #K5E_Memory_Map.UIModule.DisplayMenu  -	     Name$ DDisplayMenu��$��1��$y�Visible=��� 
���   �$	��0.5q�$ 0q��� $��2��
���   �$	��0.5q�$ 0q�� $��0��$��3��.+��� 
���   �$	��0.5q�$ 0q�(   "K5E_Memory_Map.UIModule.SmallGraph  -
     Name$ SSmallGraph��$y�Hidden=�'   !K5E_Memory_Map.UIModule.FullGraph  -     Name$ 
FFullGraph��$y�Hidden=�&    K5E_Memory_Map.UIModule.Analysis  -     Name$ 	AAnalysis��$y�Hidden=�&	    K5E_Memory_Map.UIModule.Practice	  -    	 Name$ 	PPractice��$y�Hidden=�#
   K5E_Memory_Map.UIModule.Merge
  -    
 Name$ MMerge��$y�Hidden=�� $��1��$��0�� �� $	��152 ��� $	��140 ��� $��1* �.+�)   #K5E_Memory_Map.UIModule.NodeDetails  -     Name$ NNodeDetails��$��1��-   'K5E_Memory_Map.UIModule.ProcessingState  -     Name$ ProcessingState��$��0��(   "K5E_Memory_Map.UIModule.MemDisplay  -     Name$ MMemDisplay��$��2���� 
���   �$	��0.5q�$ 0q��� $��1��
���   �$	��0.5q�$ 0q��� -   $��TB_Hash��$��1�� �� Padding$ 3,72,0,0q�$y�	Collapsed=����� *Hash+ �� StringFormat$ 	Heap: {0}���� -   $��TB_Frame��$��1��$ 3,99,0,0q�$y�	Collapsed=����� *Frame+$ 
Frame: {0}���� $��2��
���   �$	��0.5q�$ 0q��� -   $��PauseButton��$y�	Collapsed=�$��40��$��Bottom=�$��Right=�$��40��$��0,0,0,0q�$��2��$ 1��.��� .+��� $��Right=�$��8��$��20��$��	-13,0,0,0q�$��2��$ 2��
��������� $��Right=�$��8��$��20��$��0,0,13,0q�$��2��$ 2��
��������� -   $��
PlayButton��$y�	Collapsed=�$��40��$��Bottom=�$��Right=�$��40��$��0,0,0,0q�$��2��$ 1��.��� .+�F� "���� � ��� � ?� -1� � ���	
���   �$��	-8,-8,0,0q�$��Center=�$��Center=�