   M S B A M L   `   `   `  ����I  EBanAlwaysThere, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:BanAlwaysThere.PagesBanAlwaysThere.Pages  5      "    BanAlwaysThere.Pages.Profile   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:BanAlwaysThere.Pages     5      -   5        $��	PgProfile��5	        N� Title$  Profile��6   .��5      �  � RowDefinitions 5   
   �� 5      $	��310 �6   �� 5      $	��130 �6   �� 5      $��* �6   .+�5   
   ��    
BrdProfile#��[  6   �� 5   
   -   5        $��
TxtProfile��5        TxtTitle#��[ 6&   $!��Личный кабинет��6H   $��0��6^   $
��Left=�6k   $	��Top=�6�   $��	22 37 0 0q�6�   �� 5   
   -   5        $��StpUerAvatarName��5        StpUserAvaterName#��[ 6-   .+�5      A�   	ImgAvatar#��[ 6   ��5      �� 5       �� ImageSource$ /Resource/Avatar.png��6!   5#      �� 5%        Txt30pt#��[ 6   $��Илон Маск��69   $��1��6J   $��Center=�6W   $	��Top=�6t   $��0 15 0 0q�6�   5'      �� 5*   
   $��2��6   .��5+   
   �� -   5        $��StpUserInfo��5+       �� Orientation$ 
Horizontal=�6(   $��2��6A   $��Center=�6N   $��Center=�6k   $��0 0 0 50q�6�   .+�5.      �� $ Vertical=�6   .+�50      �� #��[ 6   $��Имя��6=   $��21 0 0 0q�6H   �� 51      -   5        $��TxbFirstName��51        TxtProfileBox#��[ 6.   $��Илон��6U   �� 53      #��[ 6   $��Фамилия��6=   $��	21 29 0 0q�6L   �� 54      -   5        $��TxbLastName��54      #��[ 6-   $��Маск��6T   �� 56      #��[ 6   $��Страна��6=   $��	21 29 0 0q�6K   �� 57      -   5        $��
TxbCountry��57      #��[ 6,   $��Grate Britan��6S   5:      �� 5<      -   5        $��StpUserTextInfo��5<      $ Vertical=�60   $��	173 0 0 0q�6G   .+�5>      �� #��[ 6   $��
Логин��6=   $��21 0 0 0q�6J   �� 5?      -	   5        $��TxbUserLogin��5?      #��[ 6.   $��marsisournewhome��6U   �� 5A      #��[ 6   $��
Почта��6=   $��	21 29 0 0q�6J   �� 5B      -
   5        $��TxbUserEmail��5B      #��[ 6.   $��Mask@gmail.com��6U   �� 5D      #��[ 6   $��Телефон��6=   $��	21 29 0 0q�6L   �� 5E      -   5        $��TxbUserTelephone��5E      #��[ 62   $��+7 (999)-873-33-11��6Y   5G      5J      5M      �� 5O   
     BtnEditAvater#��[ 6   .��5Q      �� $��/Resource/ImgCamera.png��6   $
��53px��65   $
��53px��6B   5S      �� 5U   
     ImgEditProfile#��[ 6   5W      5Y      