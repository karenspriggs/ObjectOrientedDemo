   M S B A M L   `   `   `  ����F  BCurrencyWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CurrencyWPF.ViewCurrencyWPF.View  5      #    CurrencyWPF.View.CurrencyRepo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:CurrencyWPF.View     5        � DataContext$  	ViewModel��5	      .��5      � .+�5   
   �� -   5         ��Name$ CoinsListBox��5      $
��Wrap=�6R   $	��Top=�6f   $��
53,88,55,0q�6~   $	��281��6�   $��20(�6�   ��6*   �� *CurrencyRepo.ListCoins+6�   �� 5   
   $��Amount:��6   $
��Left=�6"   $	��Top=�6=   $��39��6U   $	��112��6a   $��20(�6m   $
��Bold"�6{   $��	53,21,0,0q�6�   �� 5   
   -   5         ��Name$ 	AmountBox��5      $
��Left=�6%   $��39��6A    �� TextWrapping$
 Wrap=�6M   $	��Top=�6�   $	��176��6�   $��
165,21,0,0q�6�   $��20(�6�   ��6a   �� *CurrencyRepo.ChangeAmount+ �� Mode$ TwoWay=�6�   �� 5   
   -   5         ��Name$ MakeChangeButton��5      $��Make Change��6X   $
��Left=�6n   $	��Top=�6�   $	��152��6�   $��
374,21,0,0q�6�   $��39��6�   $��20(�6�   $
��Bold"�6�   ��6+   �� *CurrencyRepo.MakeChange+6�   �� 5   
   -   5        $ 
SaveButton��5      $
��Save��6%   $
��Left=�6Q   $	��Top=�6l   $	��152��6�   $��39��6�   $��
593,21,0,0q�6�   $��20(�6�   $
��Bold"�6�   ��64   �� *
saveRepo+6�   5      5      