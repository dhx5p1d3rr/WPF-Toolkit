   M S B A M L   `   `   `  ����F  BWPF-Toolkit, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPF_ToolkitWPF_Toolkit  5          WPF_Toolkit.Exit_Button   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:WPF_Toolkit     5        � 	Resources  5	         test �� 
TargetType � 	Resources  Key �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value �� CornerRadius J� Opacity	 ��Name
 � RowDefinitions 
� Center 
� GradientOrigin 
� RadiusX 
� RadiusY � Color � Offset �� EndPoint � MappingMode �� 
StartPoint �� Triggers P� Property P� Value �� 
TargetName �� Property �� Value N� ExitActions ��Name  Storyboard2 N� EnterActions  Storyboard1��%{  &	        7  7  �� 5
   
   " ��6'    5      ���� 5      Storyboard1 .��5      U� $ (UIElement.Opacity)�64   $
 glow��6d   .\�5        $ 0:0:0.3��6/   $ 1Q�6A   5      5      �� 5      Storyboard2 .��5      U� $ (UIElement.Opacity)�64   $
 glow��6d   .\�5        $ 0:0:0.3��6/   $ 0Q�6A   5      5      5      .R�5      �� 
�������$��1q�6)   $��0q�6=   $ 25��6H   $��50��6�   $��50��6�   $	 0.5Q�6�   ._�5      �� $	 border��6   
���   �$��1q�6=   ���	#7F000000$ 25��6h   ._�5      � 
 5      �� 5      �� 5      .+�5      �� $
	 glow��6!   
���   �$��1q�6C   $��2��6W   $ 25��6h   $ 0Q�6z   ��5      
� 5    "   $ 0.5,1&�66   $ 0.5,1&�6E   $ 1Q�6\   $
 1.25Q�6h   .��5!   &   � $ 	#B2797FFA��63   $ 0Q�6E   � 5"   &   $ 	#33797FFA��63   $ 1Q�6E   5#   #   5%      �� 5&      $	 shine��6!   $��1q�60   $��1��6D   $ 	25,25,0,0��6U   ��5'      �� 5(   "   $	 1,1&�66   $ RelativeToBoundingBox=�6E   $	 1,0&�6i   .��5)   &   � $ 	#99FFFFFF��63   � 5*   &   $ 	#33FFFFFF��63   $ 1Q�6E   5+   #   5-      5/      50      51       52      P� 53       � �� . . �54      �� $
 glow��63    � y�$ Hidden=�6E   �� 55      $ shine��60    �@J�Opacity$	 0.4Q�6C   �� 56      $ border��63    � �� �	#590000006G   57      P� 58       �@J�IsMouseOver .  59      �� 5:      $! Storyboard2_BeginStoryboard��6*   8��  6O    5<      �� 5=      8�� 6*   5?      5A      5B      .��5C      � .+�5D   
   �� -   5         ��Name$ button��5D      $��Button��6!   $
��Left=�62   $��0,0,-0.4,-0.4q�6M   $	��Top=�6d   $��50��6|   $��50��6�   #���   6�   5E      5F      