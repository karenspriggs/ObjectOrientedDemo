   M S B A M L   `   `   `  ����D  @SportsWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SportsWPF.ViewsSportsWPF.Views  5   	        SportsWPF.Views.EditPlayer   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:SportsWPF.Views     5   	     � Title$!  Hope you like crowded UI :)��5   	   $	��450��6-   $	��800��6:   .��5	      � .+�5
   
   �� $
��Bold"�6?   $
��Left=�6Q   $	��Top=�6l   $��48��6�   $	��302��6�   $��20(�6�   $��	11,10,0,0q�6�   ��6   �� *TeamVM.SelectedPlayer.Name+6�   �� 5   
   $��Name:��6   $
��Left=�6    $
��Bold"�6;   $	��Top=�6M   $��	11,63,0,0q�6e   �� 5   
   $
��Left=�6   $��23��6-   $��	11,89,0,0q�69    �� TextWrapping$
 Wrap=�6L   $	��Top=�6�   $	��120��6�   ��6`   �� *TeamVM.SelectedPlayer.Name+ �� Mode$ TwoWay=�6�   �� 5   
   $	��ID:��6   $
��Left=�6   $
��Bold"�69   $	��Top=�6L   $��
11,124,0,0q�6d   �� 5   
   $
��Left=�6   $��23��6-   $��
11,150,0,0q�69   $
 Wrap=�6M   $	��Top=�6�   $	��120��6�   ��6a   �� *TeamVM.SelectedPlayer.ID+$ TwoWay=�6�   �� 5   
   $
��Bold"�6B   $
��Left=�6U   $	��Top=�6p   $��
11,178,0,0q�6�   $��29��6�   $	��310��6�   ��6   �� *TeamVM.SelectedPlayer.Details+6�   �� 5   
   $��Stats:��6   $
��Left=�6!   $
��Bold"�6<   $	��Top=�6O   $��
11,212,0,0q�6g   �� 5   
   $��Wins:��6   $
��Left=�6    $
��Bold"�6;   $	��Top=�6M   $��
11,244,0,0q�6e   �� 5   
   $
��Left=�6   $��23��6-   $��
11,270,0,0q�69   $
 Wrap=�6M   $	��Top=�6�   $	��120��6�   ��6a   �� *(&TeamVM.SelectedPlayer.PlayerStats.Wins+$ TwoWay=�6�   �� 5   
   $��Losses:��6   $
��Bold"�6"   $
��Left=�64   $	��Top=�6O   $��
11,309,0,0q�6g   �� 5   
   $
��Left=�6   $��23��6-   $��
11,335,0,0q�69   $
 Wrap=�6M   $	��Top=�6�   $	��120��6�   ��6a   �� **(TeamVM.SelectedPlayer.PlayerStats.Losses+$ TwoWay=�6�   �� 5   
   $��Update��6   $
��Left=�6J   $
��Bold"�6e   $��193,335,0,0q�6x   $	��Top=�6�   $��94��6�   $��23��6�   ��6"   �� *TeamVM.UpdatePlayer+6�   �� 5   
   $��Rating:��6   $
��Left=�6"   $
��Bold"�6=   $	��Top=�6O   $��186,244,0,0q�6g   �� 5   
   $
��Bold"�6M   $
��Left=�6`   $	��Top=�6{   $��193,270,0,0q�6�   $��23��6�   $��94��6�   ��6   �� **(TeamVM.SelectedPlayer.PlayerStats.Rating+6�   5      5      