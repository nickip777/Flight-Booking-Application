   M S B A M L   `   `   `  ����  	cmpt300a7    cmpt300a7.AddPassenger   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Add Passenger��5   	   $	��156��6   $	��290��6,    � 
ResizeMode$ NoResize=�68    � WindowStartupLocation$ Manual=�6N    � WindowStyle$ 
ToolWindow=�6m   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5
   
   �� -   5         ��Name$ 	cancelBtn��5
      $��Cancel��6$   $
��Left=�65   $��111,100,0,0q�6P   $	��Top=�6e   $��75��6}   $��20��6�   6�   �� 5   
   -   5        $ OKBtn��5      $��OK��6    $
��Left=�6-   $��194,100,0,0q�6H   $	��Top=�6]   $��75��6u   $��20��6�   6�   �� 5   
   -   5         ��Name$ firstNameTextBox��5      $
��Left=�6,   $��23��6G   $��	12,38,0,0q�6S    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $ lastNameTextBox��5      $
��Left=�6+   $��23��6F   $��
149,38,0,0q�6R   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5   
   $��
First Name��6   $
��Left=�6%   $��	12,10,0,0q�6@   $	��Top=�6S   $��23��6k   $��91��6w   �� 5   
   $��	Last Name��6   $
��Left=�6$   $��
149,10,0,0q�6?   $	��Top=�6S   $��23��6k   $��68��6w   �� 5   
   -   5         ��Name$ 
errorLabel��5      $��Fields must not be empty��6$   $
��Left=�6G   $��
132,77,0,0q�6b   $	��Top=�6v   $	��137��6�   
�������
���  ��$y�Hidden=�6�   5      5      