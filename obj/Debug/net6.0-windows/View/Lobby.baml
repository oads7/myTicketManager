   M S B A M L   `   `   `  ����J  FmyTicketManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:myTicketManager.ViewmyTicketManager.View  5   	   C&clr-namespace:myTicketManager.EntitiesmyTicketManager.Entities  5   	        myTicketManager.View.Lobby   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:myTicketManager.View     5   	   ;Entities&clr-namespace:myTicketManager.Entities     5   	   -   5          � Title$  Lobby��5	   	   $	��450��6   $	��800��6$   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5      $	��318 �6    � RowDefinitions 5   
   �� 5      $��67 �6   �� 5      $
��318* �6   �� 5      $	��49* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ FlightDataGrid��5      $��2��6V      
IsReadOnly$
 True��6j   $��1��6|      SelectionMode$ Single=�6�   �� 5   
   $��Listado de Vuelos��6   $
��Left=�6,   $��	10,29,0,0q�6G   $	��Top=�6Z   $��26��6r   $	��103��6~   �� 5   
   -   5         ��Name$ UserWelcome��5      $�� ��6%   $	��302��60   $��16(�6<   $��	0,16,0,12q�6J   $
��Left=�6]   $��1��6x   �� 5   
   -   5         ��Name$ 	NewFlight��5      $��
New Flight��6$   $
��Left=�69   $��10,0,0,0q�6T   $��2��6f   $��Center=�6s   $��29��6�   $��94��6�   6�   �� 5   
   -   5        $ 
EditFlight��5      $��Edit Flight��6%   $
��Left=�6;   $��	119,0,0,0q�6V   $��2��6i   $��Center=�6v   $��29��6�   $��94��6�   6�   �� 5   
   -   5        $ DeleteFlight��5      $��Delete Flight��6'   $
��Left=�6?   $��	228,0,0,0q�6Z   $��2��6m   $��Center=�6z   $��29��6�   $��94��6�   6�   5      5      