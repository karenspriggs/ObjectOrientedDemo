   M S B A M L   `   `   `  ����D  @SportsWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SportsWPF	SportsWPF  5   	       WPFSports.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:SportsWPF     5   	     � Title$!  Hope you like crowded UI :)��5   	   $	��450��6-   $	��800��6:   .��5	      � $��3,0,-3,0q�6   .+�5
   
   �� -   5         ��Name$ Title��5
      $��Esports Application��6   $
��Left=�6=   $	��Top=�6X   $��42��6p   $	��250��6|   $
��Bold"�6�   $��20(�6�   $��10,0,0,0q�6�   �� 5   
   $��List of Sports��6   $
��Left=�6)   $��	17,42,0,0q�6D   $	��Top=�6W   $	��179��6o   $
��Bold"�6{   $��16(�6�   �� 5   
   $
��Left=�6   $	��321��6-   $��	17,73,0,0q�6:   $	��Top=�6M   $	��243��6e    �� DisplayMemberPath$
 Name��6�   ��6q   �� *SportsVM.CurrentSports+6�   �� 5   
   -   5         ��Name$ SportNameBox��5      $
��Left=�6(   $��24��6C   $��
280,93,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6�   $	��105��6�   ��6w   �� *SportsVM.NewSportName+ �� Mode$ TwoWay=�6�   �� 5   
   -   5        $ SportSizeBox��5      $
��Left=�6(   $��23��6C   $��280,141,0,0q�6O   $
 Wrap=�6d   $	��Top=�6�   $	��105��6�   ��6x   �� *SportsVM.NewSportSize+$ TwoWay=�6�   �� 5   
   -   5         ��Name$ MakeSportFPSButton��5      $��Add FPS Sport��6-   $
��Left=�6E   $��279,211,0,0q�6`   $	��Top=�6u   $	��106��6�   $��32��6�   $
��Bold"�6�   ��6�   �� *SportsVM.AddFPS+6�   �� 5   
   -   5        $ MakeSportMOBAButton��5      $��Add MOBA Sport��6.   $
��Left=�6G   $��279,174,0,0q�6b   $	��Top=�6w   $	��106��6�   $��32��6�   $
��Bold"�6�   ��6�   �� *SportsVM.AddMOBA+6�   �� 5   
   $��Pages��6   $
��Left=�6    $��
394,45,0,0q�6;   $	��Top=�6O   $��55��6g   $
��Bold"�6r   $��16(�6�   �� 5   
   -   5        $ ScheduleButton��5      $��Schedule��6)   $
��Left=�6<   $��
410,85,0,0q�6W   $	��Top=�6k   $	��100��6�   $��14(�6�   $
��Bold"�6�   $��34��6�   6�   �� 5   
   -   5        $ EditTeamsButton��5      $��
Edit Teams��6*   $
��Left=�6?   $��410,130,0,0q�6Z   $	��Top=�6o   $	��100��6�   $��14(�6�   $
��Bold"�6�   $��34��6�   6�   �� 5   
   -   5        $ SaveSportButton��5      $��Save Sports��6*   $
��Left=�6h   $��410,362,0,0q�6�   $	��Top=�6�   $	��106��6�   $��32��6�   $
��Bold"�6�   $��14(�6�   ��6@   �� *SportsVM.SaveSports+6�   �� 5   
   -	   5        $ LoadSportsButton��5      $��Load Sports��6+   $
��Left=�6i   $��533,362,0,0q�6�   $	��Top=�6�   $	��106��6�   $��32��6�   $
��Bold"�6�   $��14(�6�   ��6A   �� *SportsVM.LoadSports+6�   �� 5   
   $��Sport Name:��6   $
��Left=�6&   $	��Top=�6A   $��
273,67,0,0q�6Y   $
��Bold"�6m   �� 5   
   $��Sport Team Size:��6   $
��Left=�6+   $	��Top=�6F   $��273,115,0,0q�6^   $
��Bold"�6s   �� 5   
   $
��Left=�6   $��280,274,0,0q�6.   $	��Top=�6C   $	��106��6[   $
 Name��6g   $��24��6�   ��6�   �� *SportsVM.CurrentSports+ �� SelectedItem 6�   �� *SportsVM.RemovedSport+$ TwoWay=�6�   �� 5   
   -
   5        $ RemoveSportButton��5      $��Remove Sport��6,   $
��Left=�6C   $��280,303,0,0q�6^   $	��Top=�6s   $	��106��6�   $��32��6�   $
��Bold"�6�   ��6�   �� *SportsVM.RemoveSport+6�   5"      5#      