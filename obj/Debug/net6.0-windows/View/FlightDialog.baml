   M S B A M L   `   `   `  ����J  FmyTicketManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:myTicketManager.ViewmyTicketManager.View  5   	   '    !myTicketManager.View.FlightDialog   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:myTicketManager.View     5   	   -   5          � Title$  Flight��5   	   $	��342��6   $	��276��6%   .��5	      � .+�5
   
   �� $��Number of Flight
��6   $
��Left=�65   $��	10,10,0,0q�6P   $	��Top=�6c   $��28��6{   �� 5   
   $��Airline��6   $
��Left=�6"   $��	10,38,0,0q�6=   $	��Top=�6P   $��28��6h   �� 5   
   $��Source��6   $
��Left=�6!   $��	10,66,0,0q�6<   $	��Top=�6O   $��28��6g   �� 5   
   $��Destiny��6   $
��Left=�6"   $��	10,94,0,0q�6=   $	��Top=�6P   $��28��6h   �� 5   
   $��Departure Time��6   $
��Left=�6)   $��
10,122,0,0q�6D   $	��Top=�6X   $��28��6p   �� 5   
   $��Arrive Time��6   $
��Left=�6&   $��
10,169,0,0q�6A   $	��Top=�6U   $��28��6m   �� 5   
   $��State��6   $
��Left=�6    $��
14,221,0,0q�6;   $	��Top=�6O   $��28��6g   �� 5   
   -   5         ��Name$ Flight��5      $
��Left=�6"   $��
116,15,0,0q�6=    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��134��6}   �� 5   
   -   5        $ Airline��5      $
��Left=�6#   $��
116,43,0,0q�6>   $
 Wrap=�6R   $	��Top=�6f   $	��134��6~   �� 5   
   -   5        $ Source��5      $
��Left=�6"   $��
116,71,0,0q�6=   $
 Wrap=�6Q   $	��Top=�6e   $	��134��6}   �� 5   
   -   5        $ Destiny��5      $
��Left=�6#   $��
116,99,0,0q�6>   $
 Wrap=�6R   $	��Top=�6f   $	��134��6~   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ DepartureDate��5      $
��Left=�6,   $��116,124,0,0q�6G   $	��134��6\      SelectedDateFormat$ Short=�6h   $��24��6�   $	��Top=�6�     5   
   -   5        $ 
ArriveDate��5      $��116,171,0,0q�6)   $ Short=�6>   $��24��6Y   $	��Top=�6e   $
��Left=�6}   $	��134��6�   6�   �� 5   
   -   5         ��Name$ State��5      $
��Left=�6"   $��116,224,0,0q�6=   $	��Top=�6R   $	��134��6j   �� 5   
   -	   5         ��Name$ Apply��5      $��Aceptar��6    $��180,266,0,0q�62   $
��Left=�6[   $��70��6v   $��24��6�   $	��Top=�6�   �� 5   
   -
   5        $ DepartureTime��5      $
��Left=�6)   $��180,148,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6m   $��70��6�   6�   �� 5   
   -   5        $ 
ArriveTime��5      $
��Left=�6&   $��180,195,0,0q�6A   $
 Wrap=�6V   $	��Top=�6j   $��70��6�   6�   5      5      