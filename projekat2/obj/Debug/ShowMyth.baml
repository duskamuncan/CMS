   M S B A M L   `   `   `  ����W  SNotification.Wpf, Version=8.0.0.0, Culture=neutral, PublicKeyToken=1acac493089262b5_Aclr-namespace:Notification.Wpf.Controls;assembly=Notification.WpfNotification.Wpf.Controls  5      D @projekat2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:projekat2	projekat2 5         projekat2.ShowMyth   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      X TFontAwesome5.WPF, Version=1.0.5.65, Culture=neutral, PublicKeyToken=9cfaf01297a008f8/fa5%http://schemas.fontawesome.com/icons/  5      UnotificationsAclr-namespace:Notification.Wpf.Controls;assembly=Notification.Wpf  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      #localclr-namespace:projekat2  5      -   5          N�Name$  ShowMythPage��5       N� Title$ ShowMyth��5
       N� 
Background
 ���� .��5      �� $	��450��5      $	��550��5      .+�5   
   0   *Notification.Wpf.Controls.NotificationArea  -   5          Name$ WindowNotificationArea��5       K� ZIndex$
 1000��5         MaxItems$ 3��5         Position$ TopRight=�5      F� 5   
   -   5        $��PagePath��5      
���`���
���E��$��2��5      ��5      B� 5      .��5      E�  E� 
StartPoint$	 0,0&�6!   .��5      ��  �� Point$ 50,100&�6&   �� 5      $ 50,450&�6&   �� 5       $ 0,550&�6&   �� 5!      $ 450,550&�6&   �� 5"      $ 400,450&�6&   �� 5#      $ 400,100&�6&   �� 5$      $ 450,0&�6&   5%      5&      5(      � 5)   
   $	��450��5*      $	��550��5+      	 � ColumnDefinitions	 5,      �� 5-      $��* �6#   �� 5.      $��* �6#   
 � RowDefinitions
 51      �� 52      $��* �6    �� 53      $��* �6    �� 54      $��* �6    �� 55      $��* �6    �� 56      $��* �6    �� 57      $��* �6    �� 58      $��* �6    .+�5;      �� -   5         ��Name$ 
TitleLabel��5<      $��0��5=      $��0��5>      $��2��5?      $��0,10,0,0q�5@      $��Center=�5A      $��Center=�5B      $��Center=�5C      $��Center=�5D      $
��MYTH��5E      $��40(�5F      $��	Agency FB)�5G      �� 5J      -   5         ��Name$ CloseButton��5K      $��90��5L      $��40��5M      $��6��5N      $��0��5O      $��2��5P      $��Center=�5Q      $��Center=�5R      
���E�� � Cursor$
 Hand��5T       � ToolTip$ Close the application��5V      .��5W      ��  �� Orientation$ 
Horizontal=�5X      .+�5Y      !  FontAwesome5.WPF.SvgAwesome  $��20��5Z      $��Center=�5[      $��Center=�5\         
Foreground
 �E��   Icon$ Solid_WindowClose=�5^      �� 5_      $��3,0,0,0q�5`      $��Center=�5a      $��CLOSE��5b      $��	Agency FB)�5c      $��20(�5d      $��45��5e      5f      5g      �� 5h      -   5        $ GodLabel��5i      $��1��5j      $��0��5k      $
��GOD:��5l      $��	Agency FB)�5m      $��Center=�5n      $
��Left=�5o      $��Center=�5p      $��10q�5q      $��25(�5r      �� 5t      -   5         ��Name$ GodTextBlock��5u      $��1��5v      $��1��5w      $	��140��5y      $��60��5z      $
��Left=�5{      $
��Wrap=�5|      $��25(�5}      $��0,20,0,0q�5~      $��	Agency FB)�5      ��5x      �� *Myths+5      �� 5�      -   5        $ 
PhotoLabel��5�      $��2��5�      $��1��5�      $��PHOTO:��5�      $��	Agency FB)�5�      $
��Left=�5�      $��Center=�5�      $��40,-20,10,20q�5�      $��25(�5�      �� 5�      -	   5         ��Name$ Photo��5�      $	��150��5�      $	��180��5�      $��2��5�      $��3��5�      $��1��5�      $��Bottom=�5�      $
��Left=�5�      $��12,10,10,10q�5�      ��5�      �� *PathToPhoto+5�      �� 5�      -
   5        $ DescriptionLabel��5�      $��2��5�      $��0��5�      $��DESCRIPTION:��5�      $��	Agency FB)�5�      $
��Left=�5�      $��Center=�5�      $��80,-20,10,20q�5�      $��25(�5�      �� 5�      -   5        $��DescriptionRichTextBox��5�      $��	Agency FB)�5�      $��2��5�      $��3��5�      $��0��5�      $	��150��5�      $	��180��5�      $��Bottom=�5�      $��Center=�5�       �� 
IsReadOnly . $��
50,10,0,10q�5�      $��Visible=�5�      . �5�      /� .T�5�      J� .*�6    .*�5�      �� -   5         �Name$ RichTextBoxText��5�      
�������$��15(�6H   5�      5�      5�      �� 5�      -   5        $ RatingLabel��5�      $��5��5�      $��0��5�      $��RATING:��5�      $��	Agency FB)�5�      $��80��5�      $
��Left=�5�      $
��Left=�5�      $��Center=�5�      $��60,10,10,10q�5�      $��25(�5�      �� 5�      -   5        $ RatingTextBlock��5�      $��5��5�      $��0��5�      $��60��5�      $��60��5�      $
��Left=�5�      $
��Wrap=�5�      $��25(�5�      $��
145,20,0,8q�5�      ��5�      �� *Rating+5�      �� 5�      -   5        $ 	DateLabel��5�      $��5��5�      $��1��5�      $��DATE:��5�      $��60��5�      $��	Agency FB)�5�      $
��Left=�5�      $
��Left=�5�      $��Center=�5�      $��10,10,10,10q�5�      $��25(�5�      �� 5�      -   5        $ DateTextBlock��5�      $��5��5�      $��1��5�      $��80��5�      $��40��5�      $��Right=�5�      $
��Wrap=�5�      $��15(�5�      $��0,0,70,0q�5�      ��5�      �� *Date+5�      5�      5�      5�      