   M S B A M L   `   `   `  ����F  BAplicação, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Aplicação.ViewModelAplicação.ViewModel  5   	   5clr-namespace:Aplicação.ModelAplicação.Model  5   	   3clr-namespace:Aplicação.ViewAplicação.View  5   	   !    Aplicação.View.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   2vm#clr-namespace:Aplicação.ViewModel     5   	   1modelclr-namespace:Aplicação.Model     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Aplicação.View     5   	     � Title$
  Home��5
   	   $	��768��5   	   $
��1024��5   	    � DataContext 5      (   "Aplicação.ViewModel.MainWindowVM  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  $
��16 8q�6      
IsReadOnly$
 True��5         AutoGenerateColumns$ False��5       �� SelectedItem 5      �� *SelectedPerson+��5      �� *	Peoples+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *Id+  5      $
 Nome��6%    5   %   �� *Name+  5      $ 	Sobrenome��6%    5    %   �� *	Surname+  5!      $ Telefone��6%    5"   %   �� *Phone+5$      �� 5%   
   $��1��6   $��Stretch=�5&      $
��16 8q�5'      .@�5(      �� $��Criar��6   ��5)      �� *CreatePersonCommand+�� 5*      $��Editar��6   ��5+      �� *EditPersonCommand+�� 5,      $��Excluír��6   $	��120��5.      ��5-      �� *DeletePersonCommand+5.      5/      50      51      