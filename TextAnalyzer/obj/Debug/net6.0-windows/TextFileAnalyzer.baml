   M S B A M L   `   `   `  ????G  CTextAnalyzer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:TextAnalyzer.imagesTextAnalyzer.images  5   	   *    $TextAnalyzer.images.TextFileAnalyzer   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:TextAnalyzer.images     5   	     ? WindowStartupLocation$  CenterScreen=?5   	    ? 
ResizeMode$ CanMinimize=?5	   	    ? Title$ TextFileAnalyzer??5
   	   $	??360??6"   $	??640??6/   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      -   5         ??Name$ cornerColumn??5      $??2* ?65   ?? 5      $	??10* ?6   ?? 5      $??2* ?6    ? RowDefinitions 5   
   ?? 5      -   5         ??Name$ 	cornerRow??5      $??2* ?6/   ?? 5      $??4* ?6   ?? 5      $??2* ?6   ?? 5      $	??10* ?6   .+?5   
   ?? -   5        $
??Back??5      $??Center=?6    $??Center=?6=   $??43??6X   $??92??6d   $
??13px(?6o   6   ?? 5   
   -   5         ??Name$ filePath??5      $??Center=?6$   $
??Left=?6F   $??2??6a   $??1??6n    ?? TextWrapping$ NoWrap=?6~   $?? ??6?   $??2q?6?   $
??18px(?6?   $??Center=?6?   $	??371??6?   $??38??6?   ?? 5   
   -   5        $??1??5      $??Browse a file??6!   $
??Left=?69   $??	369,0,0,0q?6T   $??2??6g   $??Center=?6t   $??2??6?   $??39??6?   $??89??6?   $
??13px(?6?   6?   ?? 5   
   -   5        	 ??Name$	 proceedButton??5      $??Proceed??6(   $??1??6:   $??Center=?6K   $??3??6h   $??Center=?6u   $	??150??6?   $??30??6?   6?   ?? 5   
   -   5        
 ??Name$
 errorMessageSpace??5      $??1??6/   $??Center=?6?   
???  ??$??1??6m   $
??Wrap=?6z   $?? ??6?   $??Center=?6?   ?? 5   
   $??2??6   $??3??6$   $	??9px(?61   $??Bottom=?6@   $??Center=?6[   $??Oblique$?6x   $
??Bold"?6?   Text Analyzer 30006?   5       5!      