   M S B A M L   `   `   `  ����W  SNotification.Wpf, Version=8.0.0.0, Culture=neutral, PublicKeyToken=1acac493089262b5_Aclr-namespace:Notification.Wpf.Controls;assembly=Notification.WpfNotification.Wpf.Controls  5   	   D @projekat2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:projekat2	projekat2 5   	      projekat2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   X TFontAwesome5.WPF, Version=1.0.5.65, Culture=neutral, PublicKeyToken=9cfaf01297a008f8/fa5%http://schemas.fontawesome.com/icons/  5   	   UnotificationsAclr-namespace:Notification.Wpf.Controls;assembly=Notification.Wpf  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   #localclr-namespace:projekat2  5   	   -   5          � Title$  Greek mythology��5
   	    � AllowsTransparency . 
������  � SizeToContent$ WidthAndHeight=�5       � WindowStyle$
 None=�5      .��5       � -   5          �Name$ 
LoginFrame��5        � JournalOwnership$ OwnsJournal=�5   	   ��5   
   �� 5      $	��450��5      $	��550��5       � 	Resources 5      3  -System.Windows.Media.Effects.DropShadowEffect   MouseOverDropShadowEffect   	Direction   Opacity	   ShadowDepth
   Color��%i   &	          5      $	 320Q�5      $ 80Q�5      $	 10Q�5      $
 
SandyBrown��5      5       .+�5!      0   *Notification.Wpf.Controls.NotificationArea  -   5          Name$ WindowNotificationArea��5"       K� ZIndex$
 1000��5#         MaxItems$ 3��5$         Position$ TopRight=�5%      F� 5&      -   5        $��UIPath��5'      
��� ���
���E��$��2��5*      ��5+      B� 5,      .��5-      E�  E� 
StartPoint$ 160,0&�6)   .��5.   "   ��  �� Point$ 0,280&�6.   �� 5/   "   $ 120,280&�6.   �� 50   "   $ 50,550&�6.   �� 51   "   $ 450,150&�6.   �� 52   "   $ 300,150&�6.   �� 53   "   $ 400,0&�6.   54      55      57      �� 58      -   5         ��Name$ 
TitleLabel��59   
   $��LOGIN��5:   
   $
��Left=�5;   
    �� Left$	 220��5<   	   
 �� Top$ 12��5=   	   $	��Top=�5>   	   $��	Agency FB)�5?   	   $��30(�5@   	   $
��Bold"�5A   	   �� 5C      -   5        $ UsernameLabel��5D   	   $��	USERNAME:��5E   	   $��	Agency FB)�5F   	   $��20(�5G   	   $	 128��5H   	   $ 70��5I   	   �� 5K      -   5         ��Name$ UsernameTextBox��5L   	   $	��180��5M   	   $��30��5N   	   $�� ��5O   	    �� TextWrapping$
 Wrap=�5P   	   $	 111��5Q   	   $	 109��5R   	   $
��Left=�5S   	   $��Center=�5T   	   �� 5V      -   5        $ UsernameErrorLabel��5W   	   $	��180��5X   	   $��30��5Y   	   $�� ��5Z   	   $	 100��5[   	   $	 135��5\   	   $
��Left=�5]   	   $��Center=�5^   	   
���  ��5_   	   �� 5`      -	   5        $ PasswordLabel��5a   	   $��	PASSWORD:��5b   	   $��	Agency FB)�5c   	   $��20(�5d   	   $ 70��5e   	   $	 170��5f   	   G� 5h      -
   5         G�Name$ PasswordTextBox��5i   	   $	��180��5j   	   $��30��5k   	    G� PasswordChar$ *��5l   	   $ 60��5m   	   $	 210��5n   	   $
��Left=�5o   	   $��Center=�5p   	   �� 5r      -   5        $ PasswordErrorLabel��5s   	   $	��180��5t   	   $��30��5u   	   $ 50��5v   	   $	 235��5w   	   $
��Left=�5x   	   $��Center=�5y   	   $�� ��5z   	   
���  ��5{   	   �� 5|      -   5         ��Name$ LoginButton��5}   	   $��70��5~   	   $��30��5   	   
���E�� � Cursor$
 Hand��5�   	    � ToolTip$ Login to your account��5�   	   $	 200��5�   	   $	 275��5�   	   .��5�      ��  �� Orientation$ 
Horizontal=�6!   .+�5�      !  FontAwesome5.WPF.SvgAwesome  $��15��5�      $��Center=�5�      $��Center=�5�         
Foreground
 �E��   Icon$ Solid_DoorOpen=�5�      �� 5�      $��3,0,0,0q�5�      $��Center=�5�      $��LOGIN��5�      $��	Agency FB)�5�      $��15(�5�      $��36��5�      5�      5�      �� 5�      -   5        $ CloseButton��5�   	   $��70��5�   	   $��30��5�   	   
���E��$
 Hand��5�   	   $ Close the application��5�   	   $	 135��5�   	   $	 336��5�   	   $
��Left=�5�   	   $	��Top=�5�   	   .��5�      �� $ 
Horizontal=�6!   .+�5�        $��15��5�      $��Center=�5�      $��Center=�5�      
 �E��$ Solid_WindowClose=�5�      �� 5�      $��3,0,0,0q�5�      $��Center=�5�      $��CLOSE��5�      $��	Agency FB)�5�      $��15(�5�      $��36��5�      5�      5�      5�      5�      5�      