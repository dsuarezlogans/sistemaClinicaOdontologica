   M S B A M L   `   `   `  ����  CIOETsketch1    CIOETsketch1.LogInWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      T PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;Controls,http://metro.mahapps.com/winfx/xaml/controls  5      -   5        (  "MahApps.Metro.Controls.MetroWindow   Name$  Window��5       � Title$ Ingreso��5      $	��409��5      $��579.5��6      	TitleCaps .   � WindowStartupLocation$ CenterScreen=�64   ���	#FFF5F3C8   EnableDWMDropShadow .    RightWindowCommands 5	      +  %MahApps.Metro.Controls.WindowCommands  5
   
   .@�5      �� -   5         ��Name$ 
ButtonHelp��5      .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��20��6    $��20��6+   ��5      ��  �� RelativeSource �� 	 �� AncestorType$	 ButtonL�
 �� Path$
 
Foreground� J� OpacityMask 5      �� 5       �� ImageSource$  Images/appbar.question.png��6)   5      �� 5      $��4 0 0 0q�6    $��Center=�5      $��Ayuda��5      5      5      5      .��5      � -   5         �Name$ LayoutRoot_Copy��5      $��0,0,0.062,-7q�6$   .+�5   
   �� -   5        $ btLogin��5         AccentedSquareButtonStyle#���   6"    �� 	IsDefault . $��INGRESAR��6g   $��153,388,151.938,131q�6z   $��16(�6�    J� RenderTransformOrigin$ 0.49,0.5&�6�   �� 5    
   $��Usuario��6   $%��154.999,179.197,158.001,338.039q�6"   $ 0.456,-0.085&�6K   $��22(�6p   &   System.Windows.Media.TextOptions   TextHintingMode$ Animated=�6~   �� 5!   
   $��Contraseña��6   $%��136.999,270.667,135.001,246.569q�6%   $ 0.456,-0.085&�6N   $��22(�6s   �� 5"   
   -   5         ��Name$ tbuser��5"      $��23��6"   $��129,222,128.938,309q�6.    �� TextWrapping$
 Wrap=�6K   G� 5#   
   -   5         G�Name$ tbpass��5#      $��129,316,128.938,0q�6&   $	��Top=�6A   6Y   �� 5$   
   -   5         ��Name$ lblog��5$      $�� ��6   $��101,350,29.938,162q�6*   ���	#FFDE0707��6F   Z� 6\   �� 5%   
   $��0,60,-0.062,383q�6   $��Images/logoCOIET.png��6)   �� 5&   
   $��0,508.5,-0.062,0q�6   ���	#FF6A9C52$��42��6A   $	��Top=�6M   .��5'      �� $I��C           © 2015 Todos los derechos reservados | SKYNOFF SOFTWARE��6   $��23��6w   $	��386��6�   ��6a   Z� 6�   5(      )  #MahApps.Metro.Controls.ProgressRing  5)   
   -   5          Name$ progressRingLogin��5)       $
��Left=�6;   $��169,377,0,0q�6V   $	��Top=�6k      IsActive . $y�Hidden=�6�   5*      5+      