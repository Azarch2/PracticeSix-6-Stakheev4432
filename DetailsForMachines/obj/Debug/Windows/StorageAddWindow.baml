   M S B A M L   `   `   `  ????M  IDetailsForMachines, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DetailsForMachinesDetailsForMachines  5   	   )    #DetailsForMachines.StorageAddWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:DetailsForMachines     5   	   -   5          ? Title$6  0Окно добавления хранилища??5   	   $	??450??6;   $	??400??6H    ? WindowStartupLocation$ CenterScreen=?6T    ? 
ResizeMode$ NoResize=?6y   
???iii?.??5	      ?  ? RowDefinitions 5
   
   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   .+?5   
   ??    TextBig#??[  6   $??Center=?65   $-??'Добавление хранилища??6R   6p   ?? 5   
     TextStandart#??[ 6   $	??Top=?6:   $??Center=?6R   $??1??6o   $??
Номер??6|   6?   ?? 5   
   -   5        $??Number??5      $??10q?6    
??????  TextBox#??[ 6D   $	??200??6e   $??40??6q   $??Bottom=?6}   $??1??6?   6?   ?? 5   
   #??[ 6   $??Center=?6;   $	??Top=?6X   $??2??6p   $??
Адрес??6}   6?   ?? 5   
   -   5        $??Address??5      $??10q?6!   
??????#??[ 6E   $	??200??6f   $??40??6r   $??Bottom=?6~   $??2??6?   6?   ?? 5   
   $	??Top=?6   #??[ 6,   $??Center=?6R   $??3??6o   $??Площадь??6|   6?   ?? 5   
   -   5        $
??Area??5      $??10q?6   
??????#??[ 6B   $	??200??6c   $??40??6o   $??Bottom=?6{   $??3??6?   6?   ?? 5   
   -   5         
 button#??[ 5   $   $??Добавить??6D   $??4??6W   $	??200??6d   $??60??6p    ? 	Resources 5       ?? 
TargetType ?? Property ?? Value??%d   '??       ?? 5      " ??6   .?5      ??  ?@??CornerRadius$ 35??65   6B   5      5      5      5      5       