   M S B A M L   `   `   `  ����W  SNotification.Wpf, Version=8.0.0.0, Culture=neutral, PublicKeyToken=1acac493089262b5_Aclr-namespace:Notification.Wpf.Controls;assembly=Notification.WpfNotification.Wpf.Controls  5      D @projekat2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:projekat2	projekat2 5         projekat2.DataTable   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      X TFontAwesome5.WPF, Version=1.0.5.65, Culture=neutral, PublicKeyToken=9cfaf01297a008f8/fa5%http://schemas.fontawesome.com/icons/  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      UnotificationsAclr-namespace:Notification.Wpf.Controls;assembly=Notification.Wpf  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      #localclr-namespace:projekat2  5      -   5          N�Name$  DataTablePage��5       N� Title$ 	DataTable��5
       N� 
Background
 ���� .��5      �� $	��450��5      $	��550��5      .+�5   
   0   *Notification.Wpf.Controls.NotificationArea  -   5          Name$ WindowNotificationArea��5       K� ZIndex$
 1000��5         MaxItems$ 3��5         Position$ TopRight=�5      F� 5   
   -   5        $��PagePath��5      
���`���
���E��$��2��5      ��5      B� 5      .��5      E�  E� 
StartPoint$	 0,0&�6!   .��5      ��  �� Point$ 50,100&�6&   �� 5       $ 50,450&�6&   �� 5!      $ 0,550&�6&   �� 5"      $ 450,550&�6&   �� 5#      $ 400,450&�6&   �� 5$      $ 400,100&�6&   �� 5%      $ 450,0&�6&   5&      5'      5)      � 5*   
   $	��450��5+      $	��550��5,      	 � ColumnDefinitions	 5-      �� 5.      $��* �6#   �� 5/      $��* �6#   �� 50      $��* �6#   �� 51      $��* �6#   
 � RowDefinitions
 53      �� 54      $��* �6    �� 55      $��4* �6    �� 56      $��* �6    .+�59      �� -   5         ��Name$ 
TitleLabel��5:      $��0��5;      $��1��5<      $��2��5=      $��0,10,0,0q�5>      $��Center=�5?      $��Center=�5@      $��Center=�5A      $��Center=�5B      $��TABLE OF MYTHS��5C      $��40(�5D      $��	Agency FB)�5E      �� 5H      -   5         ��Name$ CloseButton��5I      $��90��5J      $��40��5K      $��2��5L      $��2��5M      $��2��5N      $��Center=�5O      $��Center=�5P      
���E�� � Cursor$
 Hand��5R       � ToolTip$ Close the application��5T      .��5U      ��  �� Orientation$ 
Horizontal=�5V      .+�5W      !  FontAwesome5.WPF.SvgAwesome  $��20��5X   !   $��Center=�5Y   !   $��Center=�5Z   !      
Foreground
 �E��   Icon$ Solid_WindowClose=�5\   !   �� 5]      $��3,0,0,0q�5^   !   $��Center=�5_   !   $��CLOSE��5`   !   $��	Agency FB)�5a   !   $��20(�5b   !   $��45��5c   !   5d      5e      �� 5f      -   5        $ 	AddButton��5g      $��90��5h      $��40��5i      $��2��5j      $��0��5k      $��2��5l      $��Center=�5m      $��Center=�5n      
���E��$
 Hand��5p      $y�Visible=�5r      $ Add new myth��5s      .��5t      �� $ 
Horizontal=�5u   !   .+�5v        $��20��5w   %   $��Center=�5x   %   $��Center=�5y   %   
 �E��$ Solid_PlusSquare=�5{   %   �� 5|      $��4,0,0,0q�5}   %   $��Center=�5~   %   $	��ADD��5   %   $��	Agency FB)�5�   %   $��20(�5�   %   $��45��5�   %   5�      5�      �� 5�      -   5        $ DeleteButton��5�      $��90��5�      $��40��5�      $��2��5�      $��1��5�      $��2��5�      $��Center=�5�      $��Center=�5�      
���E��$
 Hand��5�      $y�Visible=�5�      $ Delete myth��5�      .��5�      �� $ 
Horizontal=�5�      .+�5�        $��20��5�   !   $��Center=�5�   !   $��Center=�5�   !   
 �E��$ Solid_MinusSquare=�5�   !   �� 5�      $��3,0,0,0q�5�   !   $��Center=�5�   !   $��DELETE��5�   !   $��	Agency FB)�5�   !   $��20(�5�   !   $��45��5�   !   5�      5�      &   System.Windows.Controls.DataGrid  5�      -   5          Name$ MythsDataGrid��5�      $��1��5�      $��0��5�      $��4��5�      $��60,10,60,10q�5�         AutoGenerateColumns .  ��. $
��Auto=�5�      $
��Auto=�5�      ��5�      �� *Myths+   Columns 5�      4  .System.Windows.Controls.DataGridCheckBoxColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Select��5�      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5�      �� *
IsSelected+ �� UpdateSourceTrigger$ PropertyChanged=�4  .System.Windows.Controls.DataGridTemplateColumn  5�      $ 	Hyperlink��6-      CellTemplate 5�      �� 5�      .R�5�   "   �� �� 5�   &   -	   5        .�5�   I   .�5�   *   �� ��64   �� *God+5�   '   5�   #   5�      5�        5�      $ Photo��5�       5�      �� 5�      .R�5�   "   �� $	��100��5�   %   $	��100��5�   %   ��5�   %   �� *PathToPhoto+5�   %   5�      5�      0  *System.Windows.Controls.DataGridTextColumn  5�      $
 Date��5�   !    5�   !   �� *Date+5�      5�      5�      5�      