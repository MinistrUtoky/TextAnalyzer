   M S B A M L   `   `   `  ????G  CTextAnalyzer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TextAnalyzerTextAnalyzer  5   	       TextAnalyzer.TextInfo   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:TextAnalyzer     5   	     ? 
ResizeMode$  CanMinimize=?5   	    ? WindowStartupLocation$ CenterScreen=?5	   	    ? Title$ TextInfo??5
   	   $	??270??6   $	??270??6'   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $??1* ?6   ?? 5      $??1* ?6    ? RowDefinitions 5   
   ?? 5      $??2* ?6   ?? 5      $??2* ?6   ?? 5      $??8* ?6   ?? 5      $??8* ?6   ?? 5      $??8* ?6   .+?5   
   ?? $??0??6   $??0??6!   $
??Wrap=?61   Number of words:6W   ?? 5   
   $??1??6   $??0??6!   $
??Wrap=?61   Unique words:6T   ?? 5   
   $??2??6   $??0??6!   $
??Wrap=?61   Top-10 longest words:6\   ?? 5   
   $??3??6   $??0??6!   $
??Wrap=?61   Top-10 most popular words:6a   ?? 5   
   $??4??6   $??0??6!   $
??Wrap=?61   Character percentile:6\   ?? 5   
   $
??Auto=?6   $??0??6:   $??1??6G   .??5      ?? -   5         ??Name$ wordsNumber??5      $
??Wrap=?6-   5      5       ?? 5!   
   $
??Auto=?6   $??1??6:   $??1??6G   .??5"      ?? -   5        $ uniqueWordsNumber??5"      $
??Wrap=?63   5#      5$      ?? 5%   
   $
??Auto=?6   $??2??6:   $??1??6G   .??5&      ?? -   5        $ longestWords??5&      $
??Wrap=?6.   5'      5(      ?? 5)   
   $
??Auto=?6   $??3??6:   $??1??6G   .??5*      ?? -   5        $ mostPopularWords??5*      $
??Wrap=?62   5+      5,      ?? 5-   
   $
??Auto=?6   $??4??6:   $??1??6G   .??5.      ?? -   5        $ characterPercentile??5.      $
??Wrap=?65   5/      50      51      52      