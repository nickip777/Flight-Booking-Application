   M S B A M L   `   `   `  ����  	cmpt300a7    cmpt300a7.AddBooking   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
AddBooking��5   	   $	��413��6   $	��462��6)    � WindowStartupLocation$ CenterScreen=�65    � WindowStyle$ 
ToolWindow=�6Z   .��5      � .+�5   
   �� -   5         ��Name$ OKBtn��5      $��OK��6    $
��Left=�6-   $��350,335,0,0q�6H   $	��Top=�6]   $��75��6u   6�   �� 5   
   -   5        $ 	cancelBtn��5      $��Cancel��6$   $
��Left=�65   $��251,335,0,0q�6P   $	��Top=�6e   $��75��6}   6�   �� 5   
   -   5         ��Name$ pidComboBox��5      $
��Left=�6(   $��	26,34,0,0q�6C   $	��Top=�6V   $��86��6n   	� 5	   
   -   5         	�Name$ singleWayRadio��5	      $��
Single Way��6.   $
��Left=�6C   $��
251,34,0,0q�6^   $	��Top=�6r    J� RenderTransformOrigin$ 1.054,0.385&�6�    d� 	IsChecked$
 TrueY�6�   6�   	� 5
   
   -   5        $ multiWayRadio��5
      $��MultiWay��6-   $
��Left=�6@   $��
352,34,0,0q�6[   $	��Top=�6o   6�   &   System.Windows.Controls.Calendar  5   
   -   5          Name$ 
leavingCal��5      $
��Left=�6'   $��
26,144,0,0q�6B   $	��Top=�6V   	   DisplayMode$
	 Year=�6n     5   
   -   5        $ returningCal��5      $
��Left=�6)   $��251,144,0,0q�6D   $	��Top=�6Y   $y�Hidden=�6q   $
	 Year=�6�   �� 5   
   -   5        $ leaveFlightComboBox��5      $
��Left=�60   $��
26,118,0,0q�6K   $	��Top=�6_   $	��175��6w   6�   �� 5   
   -	   5        $ returningFlightComboBox��5      $
��Left=�64   $��251,118,0,0q�6O   $	��Top=�6d   $	��174��6|   $y�Hidden=�6�   6�   �� 5   
   $��First Flight��6   $
��Left=�6'   $��	26,62,0,0q�6B   $	��Top=�6U   �� 5   
   -
   5        
 ��Name$
 returnLabel��5      $��Second Flight��6%   $
��Left=�6=   $��
251,62,0,0q�6X   $	��Top=�6l   $y�Hidden=�6�   �� 5   
   -   5        $
 leavingFlightCodeLabel��5      $��Flight Code��60   $
��Left=�6F   $��	26,90,0,0q�6a   $	��Top=�6t   �� 5   
   -   5        $
 returnFlightCodeLabel��5      $��Flight Code��6/   $
��Left=�6E   $��
251,90,0,0q�6`   $	��Top=�6t   $y�Hidden=�6�   �� 5   
   $��Passenger ID��6   $
��Left=�6'   $��	26,10,0,0q�6B   $	��Top=�6U   �� 5   
   -   5        $
 errorMsg��5      $�� ��6"   $
��Left=�6-   $��
10,357,0,0q�6H   $	��Top=�6\   
�������
���  ��$	��434��6�   �� 5   
   -   5        $
 returningAirports��5      $�� ��6+   $
��Left=�66   $��251,295,0,0q�6Q   $	��Top=�6f   $	��175��6~   ���	#FF1755FB6�   �� 5   
   -   5        $
 leavingAirports��5      $�� ��6)   $
��Left=�64   $��
26,295,0,0q�6O   $	��Top=�6c   $	��175��6{   ���	#FF1755FB6�   5      5      