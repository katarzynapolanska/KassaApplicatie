   M S B A M L   `   `   `  ����@  <kassa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:kassakassa  5          kassa.addProducts   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:kassa     5      $	��792��5   7   $	��286��6C   .��5	      � $	��792��6   $	��286��6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5           Name$  dgProducten��5
      $
��Left=�6(   $	��254��6C   $��
422,10,0,0q�6P   $	��Top=�6d   $	��344��6|      AutoGenerateColumns .  ��6�   Z�    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Product��6h   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *productNaam+   ClipboardContentBinding 6E   Z� 6h     5      $ Prijs��6b    6%   �� *prijs+ 6?   Z� 6b     5      $
 Type��6i    6%   �� *omschrijving+ 6F   Z� 6i   5      �� 5   
   $
��Left=�6   $	��257��60   $��	29,10,0,0q�6=   $	��Top=�6P   $	��338��6h    J� RenderTransformOrigin$ 0.5,0.5&�6t   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.455Q�6&   T� 5      5      .+�5      �� $
��Wrap=�6   $��Product naam��6,   �� 5      -   5         ��Name$ txtNaam��5      $��23��6'   	 �� TextWrapping$
	 Wrap=�63   ���	#A5FFFFFF6G   �� 5      $
��Wrap=�6   $��Prijs��6,   �� 5      -   5        $ txtPrijs��5      $��23��6(   $
	 Wrap=�64   ���	#A5FFFFFF6H   �� 5      $
��Wrap=�6   �� 6-   $
�Type��61   6@   �� 5      -   5        $ txtType��5      $��23��6'   $
	 Wrap=�63   ���	#A5FFFFFF6G   �� 5       -   5        
 ��Name$
 
btnOpslaan��5       $��OPSLAAN��6)   $��25                     q�6T   ���	#A5DDDDDD5!      5"      5$      5%      