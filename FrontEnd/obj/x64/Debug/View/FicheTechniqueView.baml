   M S B A M L   `   `   `  ????R  NMvvmCross.Platforms.Wpf, Version=8.0.2.0, Culture=neutral, PublicKeyToken=nullnLclr-namespace:MvvmCross.Platforms.Wpf.Views;assembly=MvvmCross.Platforms.WpfMvvmCross.Platforms.Wpf.Views  5      C ?FrontEnd, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FrontEnd.ViewFrontEnd.View 5      7 clr-namespace:FrontEnd.ConverterFrontEnd.Converter 5	      &    FrontEnd.View.FicheTechniqueView   5      UviewLclr-namespace:MvvmCross.Platforms.Wpf.Views;assembly=MvvmCross.Platforms.Wpf  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:FrontEnd.View     5      6	Converter clr-namespace:FrontEnd.Converter     5	      -   5          ? 	Resources  5      :  4FrontEnd.Converter.BooleanToVisibilityValueConverter   	BoolToVis??%   &	          5   
   66   5      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $
??auto ?6   .+?5   
   9?  9? ExpandDirection$ Right=?6   .??5      ?  5      ?? 5      $
??auto ?6$   ?? 5      $
??auto ?6$   ?? 5      ?? 5      $
??auto ?6$   .+?5#      ?? $??1??6    ?? Orientation$ 
Horizontal=?6*   .+?5$      ?? .??6   
Search ...6*   ?? 5%      .??6   
Chercher6'   5&      ?? 5'      -   5        $??2??5'      ??6K   ?? *FicheTechniqueList+ ?? SelectedItem 6v   ?? *SelectedFicheTechnique+ ?? View 5(      ?? 5)      .P?5*      ?? $
??Réf??6-    ?? DisplayMemberBinding 6:   ?? *Produits[0].Ref+?? 5+      $??Désignation??6-    6B   ?? *Produits[0].Name+5-      50      ?? 51      $??3??6   $ 
Horizontal=?6*   .+?52      ?? ??6   ?? *CmdAddFicheTek+.??6@   	Ajouter6I   ?? 53      ??6   ?? *CmdEditFicheTek+.??6A   
Modifier6K   ?? 54      ??6   ?? *CmdDeleteFicheTek+.??6C   	Supprimer6N   55      56      57      ? 58   
   -   5        $	??Frm??58      $??1??6   {?6*   ?? *EnableEditing+ 59      ?? 5:      $??3* ?6    ?? 5;      $
??104* ?6    .+?5=      !  FrontEnd.View.FicheTekPart2  $??2??5>   "   y?5=   #   ?? *Part2Visible+ ?? 	Converter# [  5>   "   !  FrontEnd.View.FicheTekPart1  5?      $??2??5@   "   y?5?   #   ?? *Part1Visible+# [  5@   "   5B      ? 5C   
   $??0??6   $??2??6   $??1??63   
??????? 5D      ?? 5E      ?? 5F      ?? 5G      ?? 5I      ?? 5J      $
??auto ?6#   ?? 5K      .+?5M      ?? $??1??6_   	 ? Cursor$
	 Hand??5N      
????İ?$	??100??6?   $??25??5O      $	??Top=?6!   y?5M      ?? *SaveCancelBtn+# [  ??5N   K   ?? *CmdSaveFicheTek+.??5O   9   Enregistrer5Q      ?? 5R      $??2??6_   $
	 Hand??5S      
????İ?$	??100??6?   $??25??6K   y?5R      ?? *SaveCancelBtn+# [  ??5T      ?? *CmdCancelFicheTek+.??6;   	Annuler5V      ?? 5X      $
	 Hand??5Y      
????İ?$??25??6?   $??3??6K   $	??100??6[   $
??Left=?5Z      ??5X      ?? *
PrintCmd+y?62   ?? *
PrintBtn+# [  .??5Z   0   
Imprimer5\      ?? 5^      $
	 Hand??6   $??Right=?6D   $??3??6`   $
??auto??5_   2   
?????? 
?????? {?5^   #   ?? *
IsPrevPage+??5_      ?? *
PrevPage+.??5`      ?? $??20??6   $??../Asset/ArrowLeft.png??6$   5a      ?? 5b      $??4??6   
???????
???????
 ?? CornerRadius$
 4??6U   $??1q?5c      $??Center=?6)   $??Center=?6F   ._?5e      ?? $??Arial)?68   $??20??6K   ??6   ?? *
PageNumber+6K   5f      ?? 5g      $
	 Hand??66   $
??Left=?6D   $??5??6_   $
??auto??5h   2   
?????? 
?????? {?5g      ?? *
IsNextPage+??5h      ?? *
NextPage+.??5i      ?? $??20??6   $??../Asset/ArrowRight.png??6$   5j      5l      5n      5o      