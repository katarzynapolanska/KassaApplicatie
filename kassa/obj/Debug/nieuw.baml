   M S B A M L   `   `   `  ����@  <kassa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:kassakassa  5          kassa.nieuw   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:kassa     5      $	��792��5   7   $	��286��6C   .��5	      � $	��792��6   $	��286��6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5           Name$  	dgKlanten��5
      $
��Left=�6&   $	��266��6A   $��
442,10,0,0q�6N   $	��Top=�6b   $	��298��6z      AutoGenerateColumns .  ��6�   Z�    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Klantnummer��6d   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	klantId+   ClipboardContentBinding 6A   Z� 6d     5      $ Voornaam��6e    6%   �� *
voornaam+ 6B   Z� 6e     5      $ 
Achternaam��6g    6%   �� *
achternaam+ 6D   Z� 6g   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      ��  ��Name$ 	btnWijzig��6%   -   5        $��Wiijzig��5   8   6J   5      5      5      � 5   
   -   5         �Name$ gWijzig��5      $
��Left=�6    $	��286��6;   $��10,0,0,0q�6H   $	��Top=�6Z   $	��379��6r   .+�5      �� $
��Left=�6   $	��266��64   $��	46,10,0,0q�6A   $	��Top=�6T   $	��296��6l   .+�5      �� $
��Wrap=�6   $��Telefoonnummer��60   �� 5      -   5        	 ��Name$	 txtTelefoon��5      $��23��6/   
 �� TextWrapping$

 Wrap=�6;   ���	#A5FFFFFF6O   �� 5      $
��Wrap=�6   $��Voornaam��60   �� 5      -   5        $	 txtVoornaam��5      $��23��6/   $

 Wrap=�6;   ���	#A5FFFFFF6O   �� 5      $
��Wrap=�6   $��
Achternaam��60   �� 5      -   5        $	 txtAchternaam��5      $��23��61   $

 Wrap=�6=   ���	#A5FFFFFF6Q   �� 5       $
��Wrap=�6   $
��Stad��60   �� 5!      -   5        $	 txtStad��5!      $��23��6+   $

 Wrap=�67   ���	#A5FFFFFF6K   �� 5"      -   5        $ 
btnOpslaan��5"      $��OPSLAAN��6-   $��25q�6X   $��35��6d   ���	#A5DDDDDD6p   5#      5$      5&      5'      