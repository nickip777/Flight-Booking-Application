   M S B A M L   `   `   `  ����   	cmpt300a7    cmpt300a7.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  
MainWindow��$	��318��$	��600�� � 
ResizeMode$ NoResize=�.��� $��0,0,2,0q� � ColumnDefinitions �� $	��10* ��� $
��187* ��� $	��86* ��� $
��309* �.+��� -    ��Name$ passengerBtn��$��New Passenger��$
��Left=�$��	10,10,0,0q�$	��Top=�$	��175��$��22��$��2��$��2���� -   $ flightInstanceBtn��$��View Passengers��$��1��$
��Left=�$��	1,228,0,0q�$	��Top=�$	��175��$��22���� -   $ addBookingBtn��$��Add Booking��$��3��$��128,10,10,0q�$	��Top=�$��22���� -    ��Name$ flightInstanceComboBox��$��1��$
��Left=�$��3,34,0,0q�$	��Top=�$	��173��$��21���� $��Flight Instance:��$��1��$
��Left=�$��3,11,0,0q�$	��Top=�$	��166��$��23��&   System.Windows.Controls.DataGrid  -     Name$ passengersDataGrid��$��2��$
��Left=�$��	10,60,0,0q�$	��Top=�$��2��$	��190��$	��375������ &   System.Windows.Controls.Calendar  -     Name$ flightInstanceCal��$��1��$
��Left=�$��1,60,0,0q�$	��Top=�$	��163��$	��175��   DisplayMode$
 Year=��� -    ��Name$ remainingSeatsLabel��$��Remaining Seats:��$��3��$
��Left=�$��185,260,0,0q�$	��Top=�$	��114���� -   $ errorMsg��$�� ��$��1��$
��Left=�$��	3,260,0,0q�$	��Top=�$��3��$	��369��
���  ���� -	   $ pidMsg��$�� ��$��2��$
��Left=�$��	10,37,0,0q�$	��Top=�$��2��$	��375�����	#FF1755FB