   M S B A M L   `   `   `  ????M  IDetailsForMachines, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DetailsForMachinesDetailsForMachines  5   	   1    +DetailsForMachines.DeliveryNoteChangeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:DetailsForMachines     5   	   -   5          ? Title$+  %Изменение накладной??5   	    ? WindowStartupLocation$ CenterScreen=?6%   
???iii?$	??650??6o   $	??800??6|    
  Window#??[  6?   .??5	      ? $	??170??6    ? RowDefinitions 5
   
   ?? 5      $??80??6   6-   ?? 5      $??80??6   6-   ?? 5      $??80??6   6-   ?? 5      $??80??6   6-   ?? 5      $??80??6   6-   ?? 5      $??80??6   6-   ?? 5      $??80??6   $??* ?6+   68   .+?5   
   ??   TextBig#??[ 6   $??Center=?65   $+??%Изменение накладной??6R   6o   ?? 5   
     TextStandart#??[ 6   $	??Top=?6:   $??Center=?6R   $??1??6o   $??Деталь??6|   6?   ?? 5   
   -   5        $??
DetailsBox??5   ,    ?? DisplayMemberPath$
 Name??6   $??10q?6>    	 combo#??[ 6K   $	??200??6j   $??40??6v   $??Bottom=?6?   $??1??6?   6?   ?? 5   
   #??[ 6   $??Center=?6;   $	??Top=?6X   $??2??6p   $??Хранилище??6}   6?   ?? 5   
   -   5        $??StoragesBox??5   /   $ Address??6   $??10q?6B   #??[ 6O   $	??200??6n   $??40??6z   $??Bottom=?6?   $??2??6?   6?   ?? 5   
   $	??Top=?6   #??[ 6,   $??Center=?6R   $??3??6o   $!??Дата получения??6|   6?   ?? 5   
   -   5        $??ReceiveDate??5      $??10q?6%   
??????  TextBox#??[ 6I   $	??200??6j   $??40??6v   $??Bottom=?6?   $??3??6?   6?   ?? 5   
   $	??Top=?6   #??[ 6,   $??Center=?6R   $??4??6o   $??Цена детали??6|   6?   ?? 5   
   -   5        $??DetailPrice??5      $??10q?6%   
??????#??[ 6I   $	??200??6j   $??40??6v   $??Bottom=?6?   $??4??6?   6?   ?? 5   
   $	??Top=?6   #??[ 6,   $??Center=?6R   $??5??6o   $??Работник??6|   6?   ?? 5   
   -   5        $??
WorkersBox??5   2   #??[ 6   $??10q?6D   $	??200??6P   $??40??6\   $??Bottom=?6h   $??5??6?   ??5      ?? 5      .R?5       ?? #??[ 6    ??5!      `? 5"       ?? StringFormat$ {0} {1}??6+   .1?5#   "   ??  ?? Path$
 Name?6*   68   ?? 5$   "   $ Surname?6*   6;   5%      5'      5(      5*      ?? 5+   
   -   5         
 button#??[ 5+   ,   $??Изменить??6L   $??7??6_   $	??200??6l   $??60??6x    ? 	Resources 5,       ?? 
TargetType ?? Property	 ?? Value??%d   '??       ?? 5-      " ??6   .?5.      ??  ?@??CornerRadius$	 35??65   6B   5/      50      51      52      53      