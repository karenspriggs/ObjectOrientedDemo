   M S B A M L   `   `   `  ����D  @SportsWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SportsWPF.ViewsSportsWPF.Views  5   	   "    SportsWPF.Views.EditSchedule   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:SportsWPF.Views     5   	     � Title$!  Hope you like crowded UI :)��5   	   $	��450��6-   $	��800��6:   .��5	      � .+�5
   
   �� $��Edit Schedule��6   $
��Bold"�6(   $��18(�6:   $
��Left=�6H   $��	10,10,0,0q�6c   $	��Top=�6v   $��35��6�   $	��160��6�   �� 5   
   $
��Left=�6   $��
120,50,0,0q�6.   $	��Top=�6B   $	��122��6Z    �� DisplayMemberPath$
 Name��6f   $��24��6�   ��6   �� *SportsVM.CurrentSports+ �� SelectedItem 6�   �� *MatchVM.SelectedSport+ �� Mode$ TwoWay=�6�   �� 5   
   $��Choose Sport:��6   $
��Bold"�6(   $��14(�6:   $
��Left=�6H   $��	10,45,0,0q�6c   $	��Top=�6v   $��35��6�   $	��110��6�   �� 5   
   $��Team 1:��6   $
��Bold"�6"   $��14(�64   $
��Left=�6B   $��	10,85,0,0q�6]   $	��Top=�6p   $��35��6�   $��69��6�   �� 5   
   $
��Left=�6   $��
120,85,0,0q�6.   $	��Top=�6B   $	��183��6Z   $
 Name��6f   $��24��6�   ��6   �� *MatchVM.SelectedSport.Teams+ 6�   �� *MatchVM.Team1+$ TwoWay=�6�   �� 5   
   $	��vs.��6   $
��Bold"�6   $��14(�60   $
��Left=�6>   $��
325,85,0,0q�6Y   $	��Top=�6m   $��35��6�   $��69��6�   �� 5   
   $��Team 2:��6   $
��Bold"�6"   $��14(�64   $
��Left=�6B   $��
384,85,0,0q�6]   $	��Top=�6q   $��35��6�   $��69��6�   �� 5   
   $
��Left=�6   $��
490,85,0,0q�6.   $	��Top=�6B   $	��183��6Z   $
 Name��6f   $��24��6�   ��6   �� *MatchVM.SelectedSport.Teams+ 6�   �� *MatchVM.Team2+$ TwoWay=�6�   �� 5   
   $��	Set Sport��6   $
��Bold"�6%   $
��Left=�68   $	��Top=�6x   $��78��6�   $��
266,50,0,0q�6�   $��24��6�   ��6S   �� *MatchVM.SetSport+6�   �� 5   
   $��Team 1 Score:��6   $
��Bold"�6(   $��14(�6:   $
��Left=�6H   $��
10,148,0,0q�6c   $	��Top=�6w   $��35��6�   $	��110��6�   �� 5   
   $��Team 2 Score:��6   $
��Bold"�6(   $��14(�6:   $
��Left=�6H   $��
10,188,0,0q�6c   $	��Top=�6w   $��35��6�   $	��110��6�   �� 5   
   $
��Left=�6   $��23��6-    �� TextWrapping$
 Wrap=�69   $	��Top=�6m   $	��120��6�   $��125,148,0,0q�6�   ��6M   �� *MatchVM.Score1+6�   �� 5   
   $
��Left=�6   $��23��6-   $
 Wrap=�69   $	��Top=�6m   $	��120��6�   $��125,188,0,0q�6�   ��6M   �� *MatchVM.Score2+6�   �� 5   
   $��	Set Teams��6   $
��Bold"�6%   $
��Left=�68   $	��Top=�6x   $��87��6�   $��
10,236,0,0q�6�   $��24��6�   ��6S   �� *MatchVM.SetTeams+6�   �� 5   
   $
��Bold"�64   $��14(�6F   $
��Left=�6T   $��
10,276,0,0q�6o   $	��Top=�6�   $	��114��6�   $	��726��6�   ��6   �� *MatchVM.Results+6�   �� 5   
   $+��%<- Set Sport before you can see teams��6   $
��Bold"�6C   $��14(�6U   $
��Left=�6c   $��
344,47,0,0q�6~   $	��Top=�6�   $��35��6�   $	��279��6�   (  "System.Windows.Controls.DatePicker  5   
   $
��Left=�6   $��297,187,0,0q�60   $	��Top=�6E      SelectedDate 6]   �� *MatchVM.MatchTime+$ TwoWay=��� 5   
   $��Choose Time:��6   $
��Bold"�6'   $��14(�69   $
��Left=�6G   $��293,159,0,0q�6b   $	��Top=�6w   $��35��6�   $	��110��6�   �� 5   
   $��Schedule��6   $
��Bold"�6$   $
��Left=�67   $	��Top=�6v   $��78��6�   $��423,187,0,0q�6�   $��24��6�   ��6R   �� *MatchVM.SetTime+6�   �� 5   
   $��Start Match��6   $
��Bold"�6'   $
��Left=�6:   $	��Top=�6|   $��87��6�   $��120,236,0,0q�6�   $��24��6�   ��6U   �� *MatchVM.StartMatch+6�   5      5       