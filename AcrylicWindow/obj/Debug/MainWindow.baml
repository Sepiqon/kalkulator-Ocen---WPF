   M S B A M L   `   `   `  ����D  @FluentWPF, Version=0.8.0.6, Culture=neutral, PublicKeyToken=nullP6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPFSourceChord.FluentWPF  5   	   I EKalkulatorOcen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:UserControlTemplateUserControlTemplate 5	         AcrylicWindow.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=3.1.0.948, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   ?fw6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPF  5   	   NameProgram  5   	   4xctk)http://schemas.xceed.com/wpf/xaml/toolkit  6   ;UserControlTemplate!clr-namespace:UserControlTemplate  5	      -   5        )   #SourceChord.FluentWPF.AcrylicWindow    AcrylicWindowStyle$  Normal=�5
         Enabled .  � WindowStartupLocation$ CenterScreen=�6h   $��20(�6�   $	��772��6�   $	��535��6�   ��6�   Z� .��5      � -   5         �Name$ 
WindowCent��5       � RowDefinitions 5   
   �� 5      $��5* �6   �� 5      $	��51* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   � -   5        $ Programcent��5      $��0,11,0,0q�6$   $��1��66   $��2��6C    J� RenderTransformOrigin$	 0,0&�6W   .+�5      �� -   5         ��Name$ ProgramTabControl��5      $��2,2,0,2q�64   $ 0.5,0.5&�6F   $��10q�6h   $��Visible=�6u   ��6�   Z� z�5      V� 5      .~�5      �� �� 5      �� 5      T� 5        T� Y$ 0.992Q�6-   5!      .@�5#      �� -   5        	 ��Name$	 WybierzSemestrTab��5#      $��Wybierz semestr��65   .��5$      � -   5        $ nazwa��5$      $��0q�6*   .+�5%      	� -   5        
 	�Name$
 WybierzSemestrRadio1��5%   &   $��	Semestr 1��6D   $
��Left=�6X   $��	10,10,0,0q�6s   $	��Top=�6�   6�   	� 5&      -   5        $
 WybierzSemestrRadio2��5&   &   $��	Semestr 2��6D   $
��Left=�6X   $��	10,42,0,0q�6s   $	��Top=�6�   6�   �� 5'      -	   5         ��Name$ WybierzSemestrDalej��5'   !   $��Dalej��6>   $��10,74,10,10q�6N   $	��Top=�6c   $	��451��6{   6�   5(      5)      �� 5*      -
   5        $	 WybierzPrzedmiotyTab��5*      $��Wybierz przedmioty��68   .��5+      �  5,      �� 5-      $
��349* �6,   �� 5.      $	��52* �6,   .+�50      �� -   5         ��Name$ WybierzPrzedmiotyList��50   "   $��0,0,0,10q�6A    J� IsManipulationEnabled .   �� IsTextSearchCaseSensitive .  �� SelectionMode$ Multiple=�6�    � ToolTip$$ Możesz pozniej to pozmieniać��6�   52      �� 53      -   5        $ WybierzPrzedmiotDalej��53   !   $��Dalej��6@   $��10q�6P   $��1��6\   $	��Top=�6i   $$ Możesz pozniej to pozmieniać��6�   6�   55      56      �� 57      -   5        $"	 Informacje_o_PrzedmiotachTab��57      $��Informacje o przedmiotach��6@   .��58      �  59      �� 5:      $
��313* �6,   �� 5;      $	��57* �6,   �� 5<      $	��57* �6,    5>      �� 5?      �� 5@      .+�5B      �� -   5         ��Name$$ Informacje_o_PrzedmiotachLista��5B   #   $��0q�6K   $: 4Jeśli masz przedmiot z błedem nie pojdziesz dalej ��6W   $��Stretch=�6�   $ Multiple=�6�   $��3��6�   6�   �� 5C      $��Typ nauczyciela��6#   $��10q�6<   $��1��6H   $F @Podaj typ nauczyciela, a my oszacujemy czy podwszyzszy Ci ocenę��6X   .��5D      � .+�5E   "   �� -   5        $1 +Informacje_o_PrzedmiotachTypNauczycielaList��5E   +   $��0q�6`   $��Stretch=�6l   $ Single=�6�   $��0q�6�   .@�5F   &   �� $��Super nauczyciel��63   �� 5G   &   $��Mniej super nauczyciel��63   �� 5H   &   $��Normalny nauczyciel��63   �� 5I   &   $!��Mniej wymagajacy nauczyciel��63   �� 5J   &   $��Wymagajacy nauczyciel��63   5K   #   5L      5M      �� 5N      -   5        $$ Informacje_o_PrzedmiotachDalej��5N   !   $��Dalej��6I   $��1��6Y   $��10q�6i   $��2��6u   6�   �� 5O      -   5        $- 'Informacje_o_PrzedmiotachButtonPrzypisz��5O   !   $. (Przypisz do przedmiotów typ nauczyciela��6R   $��Przypisz do przedmiotów��6�   $��1��6�   $��10q�6�   $��1��6�   6�   5Q      5R      �� 5S      -   5        $	 OcenaTab��5S      $��Oceny��6,   .��5T      �  5U      �� 5V      $��1.75* �6,   �� 5W      $
��0.5* �6,   �� 5X      $
��0.5* �6,   �� 5Y      $
��0.5* �6,   �� 5Z      $
��0.5* �6,    5]      �� 5^      $��2* �6/   �� 5_      $
��0.8* �6/   �� 5`      $
��1.2* �6/   .+�5b      �� -   5        $ OcenaListaPrzedmiotow��5b   #   $��0q�6B   $3 -Przedmioty z błedem zostaną odrazu usuniete��6N   $��Stretch=�6�   $ Single=�6�   $��10q�6�   5f      �� 5g      $��
Lista ocen��6#   $��10q�67   $0 *Możesz wybrać więcej niż jedną ocenę��6C   $��1��6r   $��4��6   .��5h      � .+�5i   "   �� -   5        $ OcenaListaOcen��5i   +   $��0q�6C   $��Stretch=�6O   $ Multiple=�6t   $��0q�6�   .@�5j   &   �� $��1+ Sprawdzian��63   �� 5k   &   $��2- Kartkówka��63   5l   #   5m      5n      �� 5o      -   5        $ 
OcenaDalej��5o   !   $��Dalej��65   $��1��6E   $��10q�6U   $��4��6a   $��2��6n   6�   �� 5p      $��1��6#   $��1��60   $��Ustaw wagę��6@   $��10q�6T   $��3��6`   .��5q      /  )UserControlTemplate.TemplateNumericUpDown  -   5          Name$ IntegerUpDawn��5q   H      MaxVaule$ 10��6_      NumValue$ 1��6m   5s      �� 5u      $��Wybierz ocenę��6#   $��10q�6:   $��1��6G   .��5v      � $
��Auto��6#   $
��Auto��60   .+�5w   "   �� -   5        $ OcenaListaNazwOcen��5w   +   $��0q�6G   $��Stretch=�6S   $ Single=�6x   $��0q�6�   $
��Auto��6�   $
��Auto��6�   5~   #   5      5�      �� 5�      $��Wybierz typ��6#   $��10q�68   $��2��6D   .��5�      � .+�5�   "   �� -   5        $ OcenaListaTypówOcen��5�   +   $��0q�6H   $��Stretch=�6T   $ Single=�6y   $��0q�6�   .@�5�   &   �� $��
Sprawdzian��63   �� 5�   &   $��Odpowiedź ustna��63   �� 5�   &   $��
Kartkówka��63   �� 5�   &   $��Zadanie domowe��63   �� 5�   &   $��Aktywność��63   5�   #   5�      5�      �� 5�      -   5        $ OcenaButtonAddOcena��5�   !   $��2��6?   $��10q�6O   $��1��6[   $��Stretch=�6h   $��Stretch=�6�   .��5�      � $��1,0,0,0q�6#   .+�5�   "   �� $��Center=�6-    �� Orientation$ 
Horizontal=�6J   $
��Auto��6c   $
��Auto��6p   $��Center=�6~   .+�5�   &   �� $��Dodaj ocenę��60   5�   #   �� 5�   "   $
��Left=�6-   $ 
Horizontal=�6H   $
��Auto��6a   $
��Auto��6n   $��Center=�6|   .+�5�   &   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ AddBox=�6>   $��24��6L   $��24��6W   $
��Left=�6c   $��Center=�6~   5�   #   5�      5�      �� 5�      -   5        $ OcenaButtonRemoveOcena��5�   !   $��2��6B   $��10q�6R   $��3��6^   $��Stretch=�6k   $��Stretch=�6�   .��5�      � .+�5�   "   �� $��Center=�6-   $ 
Horizontal=�6J   $
��Auto��6c   $
��Auto��6p   $��Center=�6~   .+�5�   &   �� $��Usuń oceny��60   5�   #   �� 5�   "   $
��Left=�6-   $ 
Horizontal=�6H   $
��Auto��6a   $
��Auto��6n   $��Center=�6|   .+�5�   &     $ MinusBox=�6>   $��24��6N   $��24��6Y   $
��Left=�6e   $��Center=�6�   5�   #   5�      5�      �� 5�      -   5        $ OcenaButtonEditOcena��5�   !   $��2��6@   $��10q�6P   $��2��6\   $��Stretch=�6i   $��Stretch=�6�   .��5�      � .+�5�   "   �� $��Center=�6-   $ 
Horizontal=�6J   $
��Auto��6c   $
��Auto��6p   $��Center=�6~   .+�5�   &   �� $��Edytuj ocenę��60   5�   #   �� 5�   "   $
��Left=�6-   $ 
Horizontal=�6H   $
��Auto��6a   $
��Auto��6n   $��Center=�6|   .+�5�   &     $
 Edit=�6>   $��24��6J   $��24��6U   $
��Left=�6a   $��Center=�6|   5�   #   5�      5�      5�      5�      �� 5�      -   5        $	 DaneWyjscioweTab��5�      $��Dane wyjsciowe��64   .��5�      � .+�5�      R� -   5         R�Name$ DaneWyjscioweTreeView��5�   #   .@�5�      Q� $��Item1��6+   $��Stretch=�6:   .@�5�   "   �� $��item1��6.   �� 5�   "   $��item2��6.   5�      5�      5�      5�      5�      5�      �� 5�   
   -   5         ��Name$ Header��5�      $��10q�6$   $��
Oznaczono:��61   c� 5�   
   $ 0.479,0.532&�6   $��1��6L   ��66   Z� .@�5�      �� -   5        $ Zapisz��5�      $��Right=�6%   $ Zapisz��6A   $	��Top=�6R   
������ 
������ .��5�        $ ContentSave=�6*   
�������$��0q�6P   $
��Auto��6[   $
��Auto��6h   5�      �� 5�      -    5        $ Wczytaj��5�      $��Right=�6&   $ Wczytaj��6B   $	��Top=�6T   
������ 
������ .��5�        $ Download=�6*   
�������$��0q�6M   $
��Auto��6X   $
��Auto��6e   5�      �� 5�      -!   5        $ WyczyscDane��5�      $��Right=�6*   $ Wyczysc dane��6F   $	��Top=�6]   
������ 
������ .��5�        $ DeleteForever=�6*   
�������$��0q�6R   $
��Auto��6]   $
��Auto��6j   5�      �� 5�      -"   5        $ About��5�      $��Right=�6$   $ O mnie��6@   $	��Top=�6Q   
������ 
������ .��5�        $ About=�6*   
�������$��0q�6J   $
��Auto��6U   $
��Auto��6b   5�      5�      5�      5�      