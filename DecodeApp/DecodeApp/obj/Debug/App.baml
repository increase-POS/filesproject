   M S B A M L   `   `   `  ????D  @DecodeApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:DecodeApp	DecodeApp  5          DecodeApp.App   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      )localclr-namespace:DecodeApp     5        ?? 	Resources  5         Blue ?? Color  	BigButton ?? 
TargetType ?? Property ?? Value ?? 
TargetType ?Name'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState	   
Storyboard
 g? Duration	 W? To ?? TargetProperty ?? 
TargetName	 ?? To ? RowDefinitions ??Name ?? Stretch ?? RadiusY ?? RadiusX J? Opacity ?? ElementName J? Effect3  -System.Windows.Media.Effects.DropShadowEffect   Color   
BlurRadius   	Direction   RenderingBias   ShadowDepth F?Name ??Name  Font-cairo-bold ?? Triggers P? Property  P? Value! N? EnterActions" N? ExitActions	# t? To  SmallButton$ ?? MergedDictionaries% ?? Source?? 5      $ 5?      ?? 5?   
   $e% _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml??6   ?? 5?   
   $h% bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml??6   ?? 5?   
   $t% npack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.blue.xaml??6   ?? 5?      $s% mpack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.blue.xaml??6%   %l  &	        &	 !     7  &	 ?    7  ?? 5      $ #178DD2??6+   ?? 5      " ??6&   .?5      ??  ? ?? 5      ?? 5      " ??6*   .R?5      ? $
 grid??60   $	??195??6#   ???	#00FFFFFF 5   "     5   &   CommonStates??. 5   *     
Normal??66     5   *   	MouseOver??.	 5   .   ?? .??5   2   W? $
 0:0:0.2D?6B   $
 67.5X?6U   $ Height?6_   $ X??6?   W? 5   2   $
 0:0:0.2D?6B   $
 67.5X?6U   $ Width?6_   $ X??6?   W? 5   2   $
 0D?6B   $
 0.95X?6O   $ Opacity?6Y   $ X??6}   ?? 5   2   $
 0:0:0.3D?6A   $ #35B5FFX?6T   $* $(Shape.Fill).(SolidColorBrush.Color)?6a   $ 	rectangle??6?   ?? 5   2   $
 0:0:0.3D?6A   $ WhiteX?6T   $* $(Shape.Fill).(SolidColorBrush.Color)?6_   $ X??6?   ?? 5   2   $
 0:0:0.3D?6A   $ WhiteX?6T   $" (TextBlock.Foreground).Color?6_   $ TXT_Contain??6?   5   /   5   +     5    *   Pressed??.	 5!   .   ?? .??5%   2   W? $
 0:0:0.6D?6B   $ 66X?6U   $ Height?6]   $ X??6?   W? 5&   2   $
 0:0:0.6D?6B   $ 66X?6U   $ Width?6]   $ X??6   ?? 5'   2   $
 0:0:0.5D?6A   $ #66C6FFX?6T   $* $(Shape.Fill).(SolidColorBrush.Color)?6a   $ 	rectangle??6?   ?? 5(   2   $
 0:0:0.3D?6A   $ WhiteX?6T   $* $(Shape.Fill).(SolidColorBrush.Color)?6_   $ X??6?   ?? 5)   2   $
 0:0:0.3D?6A   $ WhiteX?6T   $" (TextBlock.Foreground).Color?6_   $ TXT_Contain??6?   5*   /   5+   +   5,   '    5.   "   ?? 5/   &   $
??1.5* ?64   ?? 50   &   $??* ?64   .+?52   "   ?? $ 	rectangle??56   P   $??3??52   -   $
 Fill=?6?   $ 30??55      $ 30??6   #??z??56   ,   $ 1Q?57   -   ??53      ?? *ActualWidth+$ Grid1????54      ?? *ActualHeight+$ Grid1?? 5?   &     5@   *   $ #d7d7d7??6;   $ 7Q?6K   $	 -90Q?6Z   $ Quality=?6j   $	 0.1Q?6?   5B   #   F? 5C   "   $ X??5E   (   $
??5,10q?5C   (   ???#67686D$
 Fill=?6G   $??Center=?5D      $??Bottom=?6-   $??65??6H   $??65??6T   ??5E   4   ?? ?? 5F   "   $ TXT_Contain??5G   )   $
??5,10q?5F   3   $??1??6B   $??Center=?6Q   $	??Top=?5G      8??  ???#67686D$??20(?5H   R   $??Content??6m   5L       5M      P? 5N   "    ?@J?IsMouseOver  . . ?5O   &   ??  ?@?Cursor$
 Hand??6?   ! 5P   &   ?? 5Q   *   .??5R   .   ?? .??5S   2   W? $
 0:0:0.2D?6B   $	 200X?6U   $ Height?6^   W? 5T   2   $
 0:0:0.2D?6B   $	 200X?6U   $ Width?6^   W? 5U   2   $
 0:0:0.5D?6B   $ 197.5X?6U   $ Height?6`   W? 5V   2   $
 0:0:0.5D?6B   $ 197.5X?6U   $ Width?6`   5W   /   5X   +   " 5Z   &   ?? 5[   *   .??5\   .   ?? .??5]   2   t? $
 	0:0:0.250D?6E   $# 0X?6Z   $ BorderThickness?6a   W? 5^   2   $
 	0:0:0.150D?6B   $	 195X?6W   $ Height?6`   W? 5_   2   $
 	0:0:0.150D?6B   $	 195X?6W   $ Width?6`   5`   /   5a   +   5c   #   5e      5g      5h      ?? 5i      " ??6(   .?5j      ??  ? ?? 5k      ?? 5l      " ??6*   .R?5m      ? $
 grid??6/   $??75??6#   ???	#00FFFFFF 5n   "     5o   &   CommonStates??. 5p   *     
Normal??66     5q   *   	MouseOver??.	 5r   .   ?? .??5v   2   W? $
 0:0:0.2D?6B   $
 32.5X?6U   $ Height?6_   $ X??6?   W? 5w   2   $
 0:0:0.2D?6B   $
 32.5X?6U   $ Width?6_   $ X??6?   W? 5x   2   $
 0D?6B   $
 0.95X?6O   $ Opacity?6Y   $ X??6}   ?? 5y   2   $
 0:0:0.3D?6A   $ #178DD2X?6T   $* $(Shape.Fill).(SolidColorBrush.Color)?6a   $ 	rectangle??6?   ?? 5z   2   $
 0:0:0.3D?6A   $ WhiteX?6T   $* $(Shape.Fill).(SolidColorBrush.Color)?6_   $ X??6?   ?? 5{   2   $
 0:0:0.3D?6A   $ WhiteX?6T   $" (TextBlock.Foreground).Color?6_   $ TXT_Contain??6?   5|   /   5}   +     5~   *   Pressed??.	 5   .   ?? .??5?   2   W? $
 0:0:0.6D?6B   $ 31X?6U   $ Height?6]   $ X??6?   W? 5?   2   $
 0:0:0.6D?6B   $ 31X?6U   $ Width?6]   $ X??6   ?? 5?   2   $
 0:0:0.5D?6A   $ #66C6FFX?6T   $* $(Shape.Fill).(SolidColorBrush.Color)?6a   $ 	rectangle??6?   ?? 5?   2   $
 0:0:0.3D?6A   $ WhiteX?6T   $* $(Shape.Fill).(SolidColorBrush.Color)?6_   $ X??6?   ?? 5?   2   $
 0:0:0.3D?6A   $ WhiteX?6T   $" (TextBlock.Foreground).Color?6_   $ TXT_Contain??6?   5?   /   5?   +   5?   '    5?   "   ?? 5?   &   $
??1.2* ?64   ?? 5?   &   $??* ?64   .+?5?   "   ?? $ 	rectangle??5?   P   $??3??5?   -   $
 Fill=?6?   $ 10??5?      $ 10??6   #??z??5?   ,   $ 1Q?5?   -   ??5?      ?? *ActualWidth+$ Grid1????5?      ?? *ActualHeight+$ Grid1?? 5?   &     5?   *   $ #d7d7d7??6;   $ 7Q?6K   $	 -90Q?6Z   $ Quality=?6j   $	 0.1Q?6?   5?   #   F? 5?   "   $ X??5?   (   $??2.5,2.5q?5?   (   #??z??6:   $
 Fill=?6`   $??Center=?5?      $??Bottom=?6-   $??30??6H   $??30??6T   ??5?   4   ?? ?? 5?   "   $ TXT_Contain??5?   )   $??2.5,5q?5?   3   $??1??6C   $??Center=?6R   $	??Top=?5?      8??  $??12(?5?   h   $??Content??6?   ??63   ?? *Fill+$ X??6?   5?       5?      P? 5?   "    ?@J?IsMouseOver  . . ?5?   &   ??  ?@?Cursor$
 Hand??6?   ! 5?   &   ?? 5?   *   .??5?   .   ?? .??5?   2   W? $
 0:0:0.2D?6B   $
 77.5X?6U   $ Height?6_   W? 5?   2   $
 0:0:0.2D?6B   $
 77.5X?6U   $ Width?6_   W? 5?   2   $
 0:0:0.5D?6B   $ 76X?6U   $ Height?6]   W? 5?   2   $
 0:0:0.5D?6B   $ 76X?6U   $ Width?6]   5?   /   5?   +   " 5?   &   ?? 5?   *   .??5?   .   ?? .??5?   2   t? $
 	0:0:0.250D?6E   $# 0X?6Z   $ BorderThickness?6a   W? 5?   2   $
 	0:0:0.150D?6B   $ 75X?6W   $ Height?6_   W? 5?   2   $
 	0:0:0.150D?6B   $ 75X?6W   $ Width?6_   5?   /   5?   +   5?   #   5?      5?      5?      5?      5?      