   M S B A M L   `   `   `  ????G  CTextAnalyzer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TextAnalyzerTextAnalyzer  5   	   $    TextAnalyzer.TextInputAnalyzer   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:TextAnalyzer     5   	     ? WindowStartupLocation$  CenterScreen=?5   	    ? 
ResizeMode$ CanMinimize=?5	   	    ? Title$ TextFileAnalyzer??5
   	   $	??360??6"   $	??640??6/   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      -   5         ??Name$ cornerColumn??5      $??2* ?65   ?? 5      $	??10* ?6   ?? 5      $??2* ?6    ? RowDefinitions 5   
   ?? 5      -   5         ??Name$ 	cornerRow??5      $??2* ?6/   ?? 5      $	??16* ?6   ?? 5      $??2* ?6   .+?5   
   ?? -   5        $
??Back??5      $??Center=?6    $??Center=?6=   $??43??6X   $??92??6d   $
??13px(?6o   6   ?? 5   
   -   5         ??Name$ 	textField??5      $??1q?6%   $??1??69   $??1??6I   $??Visible=?6V    ?? TextWrapping$
 Wrap=?6?   ?? 5   
   -   5        $??1??5      $??Blank the text field??6!   $
??Left=?6@   $??2??6[   $	??Top=?6h   $??228.6??6?   $??36??6?   6?   ?? 5   
   -   5        $??1??5      $??Analyze input??6!   $??Right=?69   $??2??6U   $	??Top=?6b   $??228.6??6z   $??36??6?   6?   ?? 5   
   $??2??6   $??3??6$   $	??9px(?61   $??Bottom=?6@   $??Center=?6[   $??Oblique$?6x   $
??Bold"?6?   Text Analyzer 30006?   5      5      