   M S B A M L   `   `   `  ����F  BAplicação, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Aplicação.ViewModelAplicação.ViewModel  5   	   3clr-namespace:Aplicação.ViewAplicação.View  5   	   )    #Aplicação.View.CreatePersonWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   2vm#clr-namespace:Aplicação.ViewModel     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Aplicação.View     5   	   -   5          �Name$  CreatePersonW��5   	    � Title$ Criar novo registro��5
   	   $	��260��5   	   $	��450��5   	    � DataContext 5      *   $Aplicação.ViewModel.CreatePersonVM  5   
   .��5      � $
��16 8q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $
��Nome��6   $��0��5      �� 5   
   $��1��6   ��5      �� *Name+�� 5   
   $��	Sobrenome��6   $��0 16 0 0q�5      $��2��5       �� 5!   
   $��3��6   ��5"      �� *	Surname+�� 5#   
   $��Telefone��6   $��0 16 0 0q�5$      $��4��5%      �� 5&   
   $��5��6   ��5'      �� *Phone+�� 5)   
   $��Salvar��6   $��Bottom=�5,      $��6��5-      ��5*      �� *CreateNewPersonCommand+��5+      ��  �� ElementName$ CreatePersonW��5-      5.      5/      