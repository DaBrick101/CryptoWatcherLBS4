   M S B A M L   `   `   `  ????K  GCryptoWatcherWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CryptoWatcherWPF.ViewCryptoWatcherWPF.View  5   	   *    $CryptoWatcherWPF.View.RegisterWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:CryptoWatcherWPF.View     5   	   -   5          ? Title$  LoginWindow??5   	   $	??590??6   $	??800??6*    ? WindowStyle$
 None=?5	   	    ? 
ResizeMode$ NoResize=?5
   	    ? WindowStartupLocation$ CenterScreen=?5   	   
??????  ? AllowsTransparency$
 true??5   	   .??5      ? .+?5   
   ??  ?? CornerRadius$ 7??6   ??5      ?? 5       ?? ImageSource$% /Images/LogInPageBackground.jpg??6    j? Stretch$
 Fill=?5      ._?5      ?? $ 5??6   $??3q?5       J? Opacity$
 0.88Q?5      $??	0,0,0,-28q?6!   ??5      ?? 5      	 ?? 
StartPoint$		 0,0&?6*   
 ?? EndPoint$	
 1,1&?6;   .??5      ?  ? Color$ #495371??6'    ? Offset$ 0Q?67   ? 5      $ #74959A??6'   $
  0.5Q?67   ? 5      $ #98B4AA??6'   $ 1Q?67   5!      ??5%      ?? 5&      $		 0,1&?6*   $	
 1,2&?6;   .??5'      ? $ #495371??6'   $ 0Q?67   ? 5(      $ #74959A??6'   $  0.75Q?67   5)      ._?5-      ?  ? RowDefinitions 5.      ?? 5/      $??30 ?6(   ?? 50      .+?53      ?  ? ColumnDefinitions 54      ?? 55      ?? 56      $??25 ?6/   ?? 57      $??25 ?6/   ?? 58      $??5 ?6/   .+?5<      ?? $??Register??6$   
???????$??10(?5>       $??
Montserrat)?5?       $??0??5@       $??Center=?5A       $??10,0,0,0q?5B       ?? 5E      -   5         ??Name$ btnMinimize??5E   !   $??0q?5F      $??-??5G      
???????$??16(?5I      $??
Montserrat)?5J       ? Cursor$
 Hand??5K      $??1??5L      ??5P      ?? 5Q   "    ?? 
TargetType" ??6(   .?5R   &   ??  ?? Property ? ?? ?? Value ?#4953716C    ?? Triggers 5S   &   P? 5T   *    P? Property ?@J?IsMouseOver P? Value$
 True??6I   . ?5U   .   ??  ? ?? ?#74959A6K   5V   +   5X   #   ??5\      ?? 5]   "    ?? 
TargetType" ??62   .R?5^   &   ?? $??18??6-   $??18??68   $ 9??5_   )   #??z??5`   )   ._?5a   *   ?? $??Center=?6;   $??Center=?5b   7   5c   '   5d   #   5f      ?? 5h      -   5        $ btnClose??5h   !   $??0q?5i      $??X??5j      
???????$??16(?5l      $??
Montserrat)?5m      $
 Hand??5n      $??2??5o      ??5s      ?? 5t   "   " ??6(   .?5u   &   ??  ? ??
 ?  ??6C    5v   &   P? 5w   *    ?@J?IsMouseOver$
 True??6I   . ?5x   .   ??  ? ??
 ?<??6K   5y   +   5{   #   ??5      ?? 5?   "   " ??62   .R?5?   &   ?? $??18??6-   $??18??68   $ 9??5?   )   #??z??5?   )   ._?5?   *   ?? $??Center=?6;   $??Center=?5?   7   5?   '   5?   #   5?      5?      ?? 5?      $	??250??6!   
?????? $??2??5?       ?? Orientation$ Vertical=?5?      $??0,35,0,0q?5?      .+?5?      ?? $#??/Images/logoBlackRemovebg.png??6    $	??200??5?      $	??200??6(   ?? 5?      $??CRYPTO WATCHER??6$   ???#F1E0AC$??25(?5?       $??Medium"?5?       $??
Montserrat)?5?       $??Center=?5?       ?? 5?      $??USERNAME??6$   
???????$??12(?5?       $
??Bold"?5?       $??
Montserrat)?5?       $??0,35,0,0q?5?       $	 100Q?5?       $??70??6.   ?? 5?      -   5         ??Name$ txtUsername??5?   "   $??13(?5?      $??Medium"?5?      $??
Montserrat)?5?      
??????? ?? 
CaretBrush
 ?????
???????$??2,2,2,2q?5?      $??28??5?      $??Center=?5?      $??0,5,0,0q?5?      $??23,0,0,0q?5?      ??5?      ?? *
Username+ ?? UpdateSourceTrigger$ PropertyChanged=?.??5?   1   ??5?      ?? 5?   "   $ /Images/UserIconXs.png??6-   $
 None=?5?   )    j? 
AlignmentX$
 Left=?5?   )   .??5?   2   5?      ?? 5?      $??PASSWORD??6$   
???????$??12(?5?       $
??Bold"?5?       $??
Montserrat)?5?       $??0,15,0,0q?5?       $	 100Q?5?       $??71??6.   G? 5?      -   5         G?Name$ 
tbPassword??5?      $??13(?5?      $??Medium"?5?      $??0,5,0,0q?5?      $??
Montserrat)?5?      
?????? 
??????? G? 
CaretBrush
 ?????
???????$??2,2,2,2q?5?      $??28??67   5?      ?? 5?      $??CHECK PASSWORD??6$   
???????$??12(?5?      $
??Bold"?5?      $??
Montserrat)?5?      $??0,15,0,0q?5?      $	 100Q?5?      $	??111??6+   G? 5?      -   5        $ tbPasswordCheck??5?      $??13(?5?      $??Medium"?5?      $??
Montserrat)?5?      
?????? 
???????
 ?????
???????$??2,2,2,2q?5?      $??28??67   ?? 5?      
???  ??$??12(?5?       $??Normal"?5?       $??
Montserrat)?5?       $??0,0,0,0q?5?       $
??Wrap=?5?       $	 100Q?5?       ??5?   $   ?? *ErrorMessage+5?       ?? 5?      -   5        $ btnRegister??5?   !   $??0q?5?      $??Register??5?      
???????$??16(?5?      $??
Montserrat)?5?      $
 Hand??5?      $??2??5?      $??0,10,0,0q?5?      ??5?      ?? 5?   "   " ??6(   .?5?   &   ??  ? ?? ?#FFD0006C    5?   &   P? 5?   *    ?@J?IsMouseOver$
 True??6I   . ?5?   .   ??  ? ?? ?#FFFFBB6K   5?   +   5?   #   ??5      ?? 5  "   " ??62   .R?5  &   ?? $	??150??6-   $??40??69   $ 20??5  )   #??z??5  )   ._?5  *   ?? $??Center=?6;   $??Center=?5  7   5  '   5  #   5
     ?? 5     $ 
Horizontal=?6%   $??Center=?5  %   .+?5     ?? $??Back to Login???6(   
???????$??11(?5  $   $??Normal"?5  $   $??
Montserrat)?5  $   $	 100Q?5  $   $??16??62   ?? 5     -   5         ??Name$ lblLogin??5  !   $??Login??5  !   
???????$??25??5  !   $??11(?5  !   $??Normal"?5  !   $??
Montserrat)?5  !   69   5     5      5!     5"     5#     5$     5%     