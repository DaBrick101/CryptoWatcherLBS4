   M S B A M L   `   `   `  ????K  GCryptoWatcherWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CryptoWatcherWPF.ViewCryptoWatcherWPF.View  5   	   3    -CryptoWatcherWPF.View.CurrencyConverterWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:CryptoWatcherWPF.View     5   	   -   5          ? Title$  	Dashboard??5   	   $	??550??6   $	??800??6(    ? WindowStyle$
 None=?5	   	    ? 
ResizeMode$ NoResize=?5
   	    ? WindowStartupLocation$ CenterScreen=?5   	   
??????  ? AllowsTransparency$
 true??5   	   .??5=      ??  ?? CornerRadius$ 7??6   ??5?   
   ?? 5@       ?? ImageSource$% /Images/LogInPageBackground.jpg??6    j? Stretch$
 Fill=?5A      ._?5C   
   ?? $ 5??6   $??3q?5D       J? Opacity$
 0.88Q?5E      ??5H      ?? 5I      	 ?? 
StartPoint$		 0,0&?6&   
 ?? EndPoint$	
 1,1&?67   .??5J      ?  ? Color$ #495371??6#    ? Offset$ 0Q?63   ? 5K      $ #74959A??6#   $
  0.5Q?63   ? 5L      $ #98B4AA??6#   $ 1Q?63   5N      ??5R      ?? 5S      $		 0,1&?6&   $	
 1,2&?67   .??5T      ? $ #495371??6#   $ 0Q?63   ? 5U      $ #74959A??6#   $  0.75Q?63   5V      ._?5Y      ?  J? RenderTransformOrigin$ 0.442,0.726&?6   $??0,0,0,-3q?67    ? RowDefinitions 5Z      ?? 5[      $??30 ?6$   ?? 5\      .+?5`      ?  ? ColumnDefinitions 5a      ?? 5b      ?? 5c      $??25 ?6+   ?? 5d      $??25 ?6+   ?? 5e      $??5 ?6+   .+?5i      ?? $??Currnecy Converter??6    
???????$??10(?5k       $??
Montserrat)?5l       $??0??5m       $??Center=?5n       $??10,0,0,0q?5o       ?? 5r      -   5         ??Name$ btn_Minimizer??5r      $??0q?5s      $??-??5t      
???????$??16(?5v      $??
Montserrat)?5w       ? Cursor$
 Hand??5x      $??1??5y      ??5}      ?? 5~       ?? 
TargetType" ??6$   .?5   "   ??  ?? Property ? ?? ?? Value ?#4953716?    ?? Triggers 5?   "   P? 5?   &    P? Property ?@J?IsMouseOver P? Value$
 True??6E   . ?5?   *   ??  ? ?? ?#74959A6G   5?   '   5?      ??5?      ?? 5?       ?? 
TargetType" ??6.   .R?5?   "   ?? $??18??6)   $??18??64   $ 9??5?   )   #??z??5?   )   ._?5?   &   ?? $??Center=?67   $??Center=?5?   7   5?   #   5?      5?      ?? 5?      -   5        $ 	btn_Close??5?      $??0q?5?      $??X??5?      
???????$??16(?5?      $??
Montserrat)?5?      $
 Hand??5?      $??2??5?      $??30??5?   4   $	??Top=?6@   ??5?      ?? 5?      " ??6$   .?5?   "   ??  ? ??
 ?  ??6?    5?   "   P? 5?   &    ?@J?IsMouseOver$
 True??6E   . ?5?   *   ??  ? ??
 ?<??6G   5?   '   5?      ??5?      ?? 5?      " ??6.   .R?5?   "   ?? $??18??6)   $??18??64   $ 9??5?   )   #??z??5?   )   ._?5?   &   ?? $??Center=?67   $??Center=?5?   7   5?   #   5?      5?      5?      ?? 5?      -   5         ??Name$ txt_Logo??5?      $
??Left=?6,   
?????? ???#F1E0AC$??53??6u   $??70,0,0,0q?6?   $??1??6?    ?? TextWrapping$
 Wrap=?6?   $??Crypto_Watcher??6?   $	??Top=?6?   $	??420??6?   $??0,0,0,0q?6?   $
 1000Q?6  $??36(?6  $
??Bold"?6%  $|?False??67  ${?False??6I  ?? 5?      -   5         ??Name$ 
Logo_black??5?      $
??Left=?61   $??53??6L   $	??Top=?6X   $??78??6p   $??1??6{   .+?5?      ?? $#??/Images/logoBlackRemovebg.png??6   $??62??5?   (   $??58??63   5?      ?? 5?      -   5        $ btnDashboardWindow??5?      $??0q?5?      $??	Dashboard??5?      
???????$??16(?5?      $??
Montserrat)?5?      $
 Hand??5?      $??219,460,397,0q?5?      $??1??5?      $??47??5?      $	??Top=?5?      ??5?      ?? 5?      " ??6    .?5?      ??  ? ?? ?#F1E0AC6;    5?      P? 5?   "    ?@J?IsMouseOver$
 True??6A   . ?5?   &   ??  ? ?? ?#FFFFBB6C   5?   #   5?      ??5?      ?? 5?      " ??6*   .R?5?      ?? $	??150??6%   $??40??61   $ 20??5?   !   #??z??5?   !   ._?5?   "   ?? $??Center=?63   $??Center=?5?   %   5?      5?      5?      ?? 5?      -   5        $ btnCalc??5?      $??0q?5?      $
??Calc??5?      
???????$??16(?5?      $??
Montserrat)?5?      $
 Hand??5?      $??397,460,219,0q?5?      $??1??5?      $??47??5?      $	??Top=?5?      ??5?      ?? 5?      " ??6    .?5?      ??  ? ?? ?#F1E0AC6;    5?      P? 5?   "    ?@J?IsMouseOver$
 True??6A   . ?5?   &   ??  ? ?? ?#FFFFBB6C   5?   #   5?      ??5      ?? 5     " ??6*   .R?5     ?? $	??150??6%   $??40??61   $ 20??5  !   #??z??5  !   ._?5  "   ?? $??Center=?63   $??Center=?5  %   5     5     5     ?? 5     -   5         ??Name$ cbCurrencyFrom??5      ?? 
IsEditable$
 True??5      ?? 
IsReadOnly$
 True??5      ?? Text$ From:??5       ? ToolTip$  Currency??5     $??250,142,434,350q?5     $??1??68   .@?5     ?? -	   5        ! ??Name$! BitcoinFrom??5  1   $	??BTC??6#   61   ?? 5     -
   5        $! EthereumFrom??5  1   $	??ETH??6#   61   ?? 5     -   5        $! DogeCoinFrom??5  2   $
??DOGE??6#   62   ?? 5     -   5        $! EurFrom??5  1   $	??EUR??6#   61   ?? 5     -   5        $! UsdFrom??5  1   $	??USD??6#   61   5     ?? 5     -   5        $ cbCurrencyTo??5     $
 True??5     $
 True??5     $	 To:??5     $  Currency??5     $??250,218,434,273q?5     $??1??6.   .@?5     ?? -   5        $! 	BitcoinTo??5  1   $	??BTC??6#   61   ?? 5     -   5        $! 
EthereumTo??5  1   $	??ETH??6#   61   ?? 5      -   5        $! 
DogeCoinTo??5   2   $
??DOGE??6#   62   ?? 5!     -   5        $! EurTo??5!  1   $	??EUR??6#   61   ?? 5"     -   5        $! UsdTo??5"  1   $	??USD??6#   61   5#     ?? 5$     -   5        $ txtAmountFrom??5$     $??13(?5%     $??Medium"?5&     $??
Montserrat)?5'     
???????" ?? 
CaretBrush
" ?????
???????$??2,2,2,2q?5+     $	  Eur??5,     $??397,140,219,349q?5-     $??1??6   ?? 5.     -   5        $ txtConvertedPrice??5.     $??13(?5/     $??Medium"?50     $??
Montserrat)?51     
???????
" ?????
???????$??2,2,2,2q?55     $	  Eur??56     $??305,322,311,167q?57     $??1??6.   ?? 58     -   5        # ??Name$# lblPayedEurAmount??58     $??=??59     $??24(?5:     $??271,316,494,161q?5;     $??1??6.   $ 0.534,0.595&?6;   5<     5=     5>     5A     