   M S B A M L   `   `   `  ????M  IDetailsForMachines, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DetailsForMachinesDetailsForMachines  5   	   &     DetailsForMachines.StorageWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:DetailsForMachines     5   	   -   5          ? Title$5  /Окно работы с хранилищами??5   	   $	??450??6;   $	??800??6H    ? WindowStartupLocation$ CenterScreen=?6T    
  Window#??[  6y   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??60 ?6   6*   ?? 5      6   ?? 5      $??60 ?6   6*   .+?5   
   ?? -   5        $??BorderUp??5       
 Border#??[ 6!   6C   ?? 5   
   -   5        $??
BorderDown??5      $??2??6#   #??[ 60   6R   ?? 5   
   -   5        $??
BackButton??5       
 button#??[ 6#   $??
Назад??6\   $??2??6l   $
??Left=?6y   $	??200??6?   $??20,0,0,0q?6?   $??50??6?    ? 	Resources 5       ?? 
TargetType ?? Property ?? Value??%d   '??       ?? 5      " ??6   .?5      ??  ?@??CornerRadius$ 35??65   6B   5      5      5      ?? 5   
   $??35??6     TextBig#??[ 6    $??Center=?6A   $??Center=?6^   $??23(?6y   $`??ZЗдесь вы можете просматривать и добавлять склады??6?   6?   ?? 5   
   -   5        $??	AddButton??5      #??[ 6"   $??Добавить??6Z   $??2??6m   $??Center=?6z   $	??200??6?   $??20,0,0,0q?6?   $??50??6?    5      ??%d   '??       ?? 5      " ??6   .?5      ??  ?@??CornerRadius$ 35??65   6B   5      5      5      ?? 5    
   -   5        $??StorageList??5    s   $??Center=?6   
???   ?$??Comic Sans MS)?6J   $??22(?6e   $??1??6?   
???iii?$??Visible=?6?   ??5!      ?? 5"      " ??6   .?5#      ??  ? ??$ Stretch=?6C   6U   5$       ?? View 5&      ?? 5'      P?5(      ?? 5)      $??ID??6)    ?? Width$ 50??65   	 ?? DisplayMemberBinding	 6@   ?? *Id+6f   ?? 5*      $??
Номер??6)   	 68   ?? *Number+6b   ?? 5+      $??
Адрес??6)   	 68   ?? *	Address+6c   ?? 5,      $??Площадь??6)   	 6:   ?? *Area+
 ?? StringFormat$
 
{0} (м^2)??6|   5.      50      51      52      