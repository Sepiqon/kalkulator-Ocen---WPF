   M S B A M L   `   `   `  ���� D  @FluentWPF, Version=0.8.0.6, Culture=neutral, PublicKeyToken=nullP6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPFSourceChord.FluentWPF  C ?Database, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC/clr-namespace:Database.Models;assembly=DatabaseDatabase.Models 5(clr-namespace:Database;assembly=DatabaseDatabase  KalkulatorOcen   KalkuratorOcen.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     U QMaterialDesignThemes.Wpf, Version=3.1.0.981, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  ?fw6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPF  NameProgram  <Local2/clr-namespace:Database.Models;assembly=Database  7localWPF(clr-namespace:Database;assembly=Database  -     � Title$  Kalkulator ocen��)   #SourceChord.FluentWPF.AcrylicWindow   TintOpacity$	 0.3Q�   	TintColor$ Black�� � WindowStartupLocation$ CenterScreen=�   AcrylicWindowStyle$ Normal=�   Enabled . $��20(�$
��1000�� � WindowStyle$
 None=�$	��577��$
��1000��$	��577�� � WindowState$ 	Maximized=�$,��&/KalkulatorOcen;component/#Hairy Beard)���Z�  � 	Resources    K	 �� Source  O  W  N��%x   &	        &	      &	 (     &	 <     �� 	 �� *K+�� 	 �� *O+�� 	 �� *W+�� 	 �� *N+.��]� -   
 ]�Name$
 
WindowCent��.+��� -    ��Name$ Header��$��10q�$��
Oznaczono:��
�������$��14(�$	��Top=�c�  J� RenderTransformOrigin$ 0.479,0.532&�$��1��$	��Top=���Z� .@��� -    ��Name$ 
DodajSesje��.��� .+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ DatabaseAdd=�
�������$��0q�$
��auto��$��40���� $��Dodaj nowy rok szkolny��$��Center=�$��Center=��� -   $ 	UsunSesje��.��� .+�  $ DatabaseRemove=�
�������$��0q�$
��auto��$��40���� $��Usun rok szkolny��$��Center=�$��Center=�� .+�  $ DatabaseEdit=�
�������$��0q�$
��auto��$��40��$��Center=�$��Center=��� $��Nazwi rok szkolny��$��Center=�$��Center=�.���� ����  �� ElementName$ 
WindowCent�� �� Path$( "DataContext.SesjaObecna.NameSesion� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� -   $ About��$��Right=� � ToolTip$ O mnie��$	��Top=�
������ 
������ .��  $ About=�
�������$��0q�$
��auto��$��40���� -    ��Name$
 TabC�� �� SelectedIndex �� $ 
WindowCent��$" DataContext.IndexSesjaObecna�$ TwoWay=�$ PropertyChanged=����� $ 
WindowCent��$ DataContext.Sesje�$ TwoWay=�$ PropertyChanged=����� .R�� 
��� ���.+�  $ EditOutline=�$��0q�$
��auto��$��40��
���   �$��Center=�$��Center=��� $��Rok szkolny��$��Center=�$��Center=�
���   �.���  � Orientation$ Vertical=�.+��� $��Center=�$��Center=����� *
NameSesion+�� $��Center=�$��Center=����� *	Średnia1+ �� StringFormat$  Średnia na semestr 1: {0}���� $��Center=�$��Center=����� *	Średnia2+$  Średnia na semestr 2: {0}���� $��Center=�$��Center=����� *
Średnia+$ Średnia {0}�� �� ContentTemplate �� .R�]� .+�&   System.Windows.Controls.DataGrid  -      FrozenColumnCount$ 3��   AutoGenerateColumns .  $��0q�$��Stretch=�$	��Top=�   SelectionMode$ Single=���Z� ���� *
Przedmioty+$ TwoWay=�$ PropertyChanged=���Z�    	CellStyle ��  �� 
TargetType*  $System.Windows.Controls.DataGridCell"  .���  �� Property � �� �� Value ��   �� EndPoint$  0.5,1&�! �� 
StartPoint$! 0.5,0&�" �� RelativeTransform" V� .~��� # �� CenterY$	# 0.5Q�$ �� CenterX$	$ 0.5Q��� % �� CenterY$	% 0.5Q�& �� CenterX$	& 0.5Q��� ' �� Angle$' 45Q�( �� CenterY$	( 0.5Q�) �� CenterX$	) 0.5Q�T� .��� * � Color$* Green��+ � Offset$+ 0Q�,   ColumnHeaderStyle, �� =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .���  � ��
 ��  �-   Columns- 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn.   Header.   Database.PrawdaFałsz  -	   $ Brany pod uwagę��/   IsCheck/ . $��Center=�$��Center=�0   CellTemplate0 �� .R�  / �� *PrzedmiotIsBranyPodUwage+$ TwoWay=�$ PropertyChanged=�0	  *System.Windows.Controls.DataGridTextColumn	  $. 	Przedmiot��1
  +System.Windows.Controls.DataGridBoundColumn1 
  Binding1 �� *PrzedmiotNazwa+$ TwoWay=�$ PropertyChanged=�  $. 
Nauczyciel��0 �� .R��� ���� *PrzedmiotProg+2   CellEditingTemplate2 �� .R��� 3 �� SelectedItem3 �� *PrzedmiotProg+$ TwoWay=�$ PropertyChanged=����� 4 �� Source#4 [   $. Oceny semestr 1��5   SortMemberPath$5 PrzedmiotOceny.Count��0 �� .R�9� $��24(���]� .+��� $��
Lista ocen���� $��20,0,0,0q����� *PrzedmiotOceny1.Count+���� $  0.5,1&�$! 0.5,0&�.��� $* Black��$+ 0Q�� $	* Red��$+ 1Q�.��  -
    .  6   CanUserAddRows6 . 7   CanUserResizeColumns7 .  8   CanUserResizeRows8 .  $��0q�$��Stretch=�9   CanUserSortColumns9 .  $ Single=�$,��&/KalkulatorOcen;component/#Hairy Beard)�$��24(�$	��Top=�$
��Left=�
: � Tag: �� *PrzedmiotNazwa+���� *PrzedmiotOceny1+$ TwoWay=�$ PropertyChanged=���Z� ��Z�  �� "  .���  � �� �� $  0.5,1&�$! 0.5,0&�" V� .~��� $	# 0.5Q�$	$ 0.5Q��� $	% 0.5Q�$	& 0.5Q��� $' 45Q�$	( 0.5Q�$	) 0.5Q�T� .��� $* Black��$+ 0Q�� $	* Red��$	+ 0.5Q�� $* Yellow��$+ 1Q�-   $. Ocena��0 �� .R��� ���� *
OcenaNazwa+2 �� .R��� ; �� 
IsEditable; . < �� IsTextSearchEnabled< . $
��Left=�$	��Top=�$��50������ #4 [ 3 �� *
OcenaNazwa+$ TwoWay=�$ PropertyChanged=�  $
. Waga��0 �� .R��� ���� *	OcenaWaga+2 �� .R��� ; . < . $
��Left=�$	��Top=�$��50������ #4 [ 3 �� *	OcenaWaga+$ TwoWay=�$ PropertyChanged=�  $. 	Kategoria��0 �� .R��� ���� *OcenaKategoria+2 �� .R��� ; . < . $
��Left=�$	��Top=�$��50��= �� Text$=  ������ #4 [  3 �� *OcenaKategoria+$ TwoWay=�$ PropertyChanged=�  $. Oceny semestr 2��$5 PrzedmiotOceny.Count��0 �� .R�9� $��24(���]� .+��� $��
Lista ocen���� $��20,0,0,0q����� *PrzedmiotOceny2.Count+���� $  0.5,1&�$! 0.5,0&�.��� $* Black��$+ 0Q�� $	* Red��$+ 1Q�.��  -    .  >   AlternatingRowBackground
> �  ��6 . 7 .  8 .  $��0q�$��Stretch=�9 .  $ Single=�$,��&/KalkulatorOcen;component/#Hairy Beard)�$��24(�$	��Top=�$
��Left=�: �� *PrzedmiotNazwa+���� *PrzedmiotOceny2+$ TwoWay=�$ PropertyChanged=���Z� ��Z�  �� "  .���  � �� �� $  0.5,1&�$! 0.5,0&�" V� .~��� $	# 0.5Q�$	$ 0.5Q��� $	% 0.5Q�$	& 0.5Q��� $' 45Q�$	( 0.5Q�$	) 0.5Q�T� .��� $* Black��$+ 0Q�� $	* Red��$	+ 0.5Q�� $* Yellow��$+ 1Q�-   $. Ocena��0 �� .R��� ���� *
OcenaNazwa+2 �� .R��� ; . < . $
��Left=�$	��Top=�$��50��$=  ������ #4 [ 3 �� *
OcenaNazwa+$ TwoWay=�$ PropertyChanged=�  $
. Waga��0 �� .R��� ���� *	OcenaWaga+2 �� .R��� ; . < . $
��Left=�$	��Top=�$��50������ #4 [ 3 �� *	OcenaWaga+$ TwoWay=�$ PropertyChanged=�  $. 	Kategoria��0 �� .R��� ���� *OcenaKategoria+2 �� .R��� ; . < . $
��Left=�$	��Top=�$��50��$=  ������ #4 [  3 �� *OcenaKategoria+$ TwoWay=�$ PropertyChanged=�	  $. Średnia semestr 1��?   
IsReadOnly? . 1 �� *PrzedmiotŚrednia1+$ PropertyChanged=�	  $. Ocena na koniec semestr 1��? . 1 �� *PrzedmiotOcena1+$ PropertyChanged=�	  $. Średnia semestr 2��? . 1 �� *PrzedmiotŚrednia2+$ PropertyChanged=�	  $. Ocena na koniec semestr 2��? . 1 �� *PrzedmiotOcena2+$ PropertyChanged=�	  $". Średnia z dwóch semestrów��? . 1 �� *PrzedmiotŚrednia+$ PropertyChanged=�	  $. Ocena na koniec��? . 1 �� *PrzedmiotOcena+$ PropertyChanged=�