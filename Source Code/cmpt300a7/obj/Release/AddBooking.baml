   M S B A M L   `   `   `  ����   	cmpt300a7    cmpt300a7.AddBooking   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  
AddBooking��$	��413��$	��462�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$ 
ToolWindow=�.��� .+��� -    ��Name$ OKBtn��$��OK��$
��Left=�$��350,335,0,0q�$	��Top=�$��75���� -   $ 	cancelBtn��$��Cancel��$
��Left=�$��251,335,0,0q�$	��Top=�$��75���� -    ��Name$ pidComboBox��$
��Left=�$��	26,34,0,0q�$	��Top=�$��86��	� -    	�Name$ singleWayRadio��$��
Single Way��$
��Left=�$��
251,34,0,0q�$	��Top=� J� RenderTransformOrigin$ 1.054,0.385&� d� 	IsChecked$
 TrueY�	� -   $ multiWayRadio��$��MultiWay��$
��Left=�$��
352,34,0,0q�$	��Top=�&   System.Windows.Controls.Calendar  -     Name$ 
leavingCal��$
��Left=�$��
26,144,0,0q�$	��Top=�	   DisplayMode$
	 Year=�  -   $ returningCal��$
��Left=�$��251,144,0,0q�$	��Top=�$y�Hidden=�$
	 Year=��� -   $ leaveFlightComboBox��$
��Left=�$��
26,118,0,0q�$	��Top=�$	��175���� -	   $ returningFlightComboBox��$
��Left=�$��251,118,0,0q�$	��Top=�$	��174��$y�Hidden=��� $��First Flight��$
��Left=�$��	26,62,0,0q�$	��Top=��� -
   
 ��Name$
 returnLabel��$��Second Flight��$
��Left=�$��
251,62,0,0q�$	��Top=�$y�Hidden=��� -   $
 leavingFlightCodeLabel��$��Flight Code��$
��Left=�$��	26,90,0,0q�$	��Top=��� -   $
 returnFlightCodeLabel��$��Flight Code��$
��Left=�$��
251,90,0,0q�$	��Top=�$y�Hidden=��� $��Passenger ID��$
��Left=�$��	26,10,0,0q�$	��Top=��� -   $
 errorMsg��$�� ��$
��Left=�$��
10,357,0,0q�$	��Top=�
�������
���  ��$	��434���� -   $
 returningAirports��$�� ��$
��Left=�$��251,295,0,0q�$	��Top=�$	��175�����	#FF1755FB�� -   $
 leavingAirports��$�� ��$
��Left=�$��
26,295,0,0q�$	��Top=�$	��175�����	#FF1755FB