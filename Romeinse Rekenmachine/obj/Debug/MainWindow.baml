   M S B A M L   `   `   `  ����P  LRomeinse Rekenmachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Romeinse_RekenmachineRomeinse_Rekenmachine  5   	   &     Romeinse_Rekenmachine.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Romeinse_Rekenmachine     5   	     � Title$  Romeinse Rekenmachine��5   	   $	��344��6'   $	��280��64   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ buttonI��5      $��4��6"   $��1��6/   .��6?   I6B   �� 5   
   -   5        $ buttonV��5      $��3��6"   $��0��6/   .��6?   V6B   �� 5   
   -   5        $ buttonX��5      $��3��6"   $��1��6/   .��6?   X6B   �� 5   
   -   5        $ buttonL��5      $��3��6"   $��2��6/   .��6?   L6B   �� 5   
   -   5        $ buttonC��5      $��2��6"   $��0��6/   .��6?   C6B   �� 5   
   -   5        $ buttonD��5      $��2��6"   $��1��6/   .��6?   D6B   �� 5    
   -   5        $ buttonM��5       $��2��6"   $��2��6/   .��6?   M6B   �� 5#   
   -   5        $ 
buttonPlus��5#      $��1��6%   $��3��62   .��6B   +6E   �� 5$   
   -	   5        $ buttonMinus��5$      $��2��6&   $��3��63   .��6C   -6F   �� 5%   
   -
   5        $ buttonTimes��5%      $��3��6&   $��3��63   .��6C   *6F   �� 5&   
   -   5        $ buttonDivide��5&      $��4��6'   $��3��64   .��6D   /6G   �� 5'   
   -   5        $ buttonEquals��5'      $��4��6'   $��2��64   .��6_   =6b   �� 5*   
   -   5        $ buttonClearEntry��5*      $��1��6+   $��0��68   .��6g   CE6k   �� 5+   
   -   5        $ buttonClear��5+      $��1��6&   $��1��63   .��6]   C6`   �� 5,   
   -   5        $ buttonBackspace��5,      $��1��6*   $��2��67   $��<=��6G   6w   �� 51   
   -   5        $ buttonPositiveNegative��51      $��4��61   $��0��6>   .��6s   +-6w   �� 54   
   -   5         ��Name$ textDisplay��54       �� 
IsReadOnly .  �� TextAlignment$ Right=�69   $��Bottom=�6O   $��30(�6q   $��0q�6   $��0��6�   $��0��6�   $��4��6�   $��Times New Roman)�6�   6�   55      56      